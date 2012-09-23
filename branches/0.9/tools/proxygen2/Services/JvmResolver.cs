using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.io;
using java.lang;
using java.util.zip;
using net.sf.jni4net;
using Exception = System.Exception;
using File = System.IO.File;
using JType = java.lang.reflect.Type;
using Object = java.lang.Object;

namespace com.jni4net.proxygen.Services
{
    public class JvmResolver : IJvmResolver,IDisposable
    {
        class Record
        {
            public bool CantLoad;
            public string PlainName;
            public string ReflectionName;
            public Class Clazz;
            public IMType Model;
        }

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public ITypeRepository TypeRepository { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        private readonly BridgeSetup bridgeSetup = new BridgeSetup();
        Dictionary<string, List<Record>> cps = new Dictionary<string, List<Record>>();
        List<string> jars = new List<string>();
        List<string> dirs = new List<string>();
        readonly Dictionary<string, Record> byLowName = new Dictionary<string, Record>();
        readonly Dictionary<string, Record> byName = new Dictionary<string, Record>();
        readonly Dictionary<Class, Record> byClass = new Dictionary<Class, Record>();
        private AttachedJVM jvm;

        public void AddDir(string cp)
        {
            if (!Directory.Exists(cp))
            {
                string message = "JvmResolver: file doesn't exist " + Path.GetFullPath(cp);
                Logger.LogMessage(message);
                throw new ProxygenConfigException(message);
            }
            Logger.LogVerbose("Adding classPath " + cp);

            bridgeSetup.AddClassPath(cp);
            dirs.Add(cp);
        }

        public void AddJar(string cp)
        {
            if (!File.Exists(cp))
            {
                string message = "JvmResolver: file doesn't exist " + Path.GetFullPath(cp);
                Logger.LogError(message);
                throw new ProxygenConfigException(message);
            }
            Logger.LogVerbose("Adding classPath " + cp);

            bridgeSetup.AddClassPath(cp);
            jars.Add(cp);
        }

        public void Init()
        {
            if(Configurator.Verbose)
            {
                bridgeSetup.LogLevel = LogLevel.Info;
            }
            if (Configurator.Debug)
            {
                bridgeSetup.LogLevel = LogLevel.Debug;
            }
            jvm = J4NBridge.CreateJVM(bridgeSetup);

            foreach (var jar in jars)
            {
                IEnumerable<string> classesInJar = EnumerateClassesInJar(jar);
                var records = new List<Record>();
                foreach (var clazzName in classesInJar)
                {
                    string plainName = clazzName.Replace('$', '.');
                    var record = new Record { ReflectionName = clazzName, PlainName = plainName };
                    byName.Add(plainName, record);
                    byLowName.Add(plainName.ToLowerInvariant(), record);
                    records.Add(record);
                }
                cps[jar] = records;
            }

            foreach (var dir in dirs)
            {
                IEnumerable<string> classesInDir = EnumerateClassesInDir(dir);
                var records = new List<Record>();
                foreach (var clazzName in classesInDir)
                {
                    string plainName = clazzName.Replace('$', '.');
                    var record = new Record { ReflectionName = clazzName, PlainName = plainName };
                    byName.Add(plainName, record);
                    byLowName.Add(plainName.ToLowerInvariant(), record);
                    records.Add(record);
                }
                cps[dir] = records;
            }

            jars = null;
            dirs = null;

            TypeRepository.JavaLangClass = ResolveType((Class)Class._class);
            TypeRepository.JavaLangObject = ResolveType((Class)Object._class);
            TypeRepository.JavaLangThrowable = ResolveType((Class)Throwable._class);
        }

        public List<IMType> GenerateCp(string cp, string regex)
        {
            var res = new List<IMType>();
            var rx = regex == null ? null : new Regex(regex.Contains("*") ? regex : "^" + regex + "$");
            foreach (var record in cps[cp].Where(record => rx == null || rx.IsMatch(record.PlainName)))
            {
                LoadClass(record);
                if(record.Model!=null)
                {
                    res.Add(record.Model);
                }
            }
            return res;
        }

        private void LoadClass(Record record,bool forceModel=false)
        {
            if (record.Clazz == null && !record.CantLoad)
            {
                try
                {
                    string loadName = record.ReflectionName.Replace('/', '.');
                    record.Clazz = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass(loadName);
                    byClass[record.Clazz] = record;
                }
                catch (Exception)
                {
                    record.CantLoad = true;
                    Logger.LogVerbose("Can't load " + record.ReflectionName);
                }
            }
            if (record.Clazz != null && record.Model == null && (forceModel || record.Clazz.IsPublic()))
            {
                record.Model = new MType {JvmType = record.Clazz};
            }
        }

        public IMType ResolveType(Class clazz)
        {
            Record res;
            if(byClass.TryGetValue(clazz, out res))
            {
                LoadClass(res,true);
                return res.Model;
            }
            string reflectionName = clazz.getName();
            string plainName = reflectionName.Replace('$', '.');

            res = new Record {Clazz = clazz, ReflectionName = reflectionName, PlainName = plainName};
            LoadClass(res, true);
            return res.Model;
        }

        private IEnumerable<string> EnumerateClassesInDir(string dir)
        {
            var classes = new List<string>();
            string[] files = Directory.GetFiles(dir, "*.class", SearchOption.AllDirectories);
            int prefix = dir.Length;
            foreach (var ename in files)
            {
                int dcl = ename.LastIndexOf(".class", StringComparison.Ordinal);
                if (dcl != -1)
                {
                    string urlName = ename.Substring(prefix + 1, dcl - prefix - 1).Replace('\\', '/');
                    classes.Add(urlName);
                }
            }
            return classes;
        }

        private IEnumerable<string> EnumerateClassesInJar(string jar)
        {
            var classes = new List<string>();

            try
            {
                var zis = new ZipInputStream(new FileInputStream(jar));
                ZipEntry entry = zis.getNextEntry();
                while (entry != null)
                {
                    string ename = entry.getName();
                    int dcl = ename.LastIndexOf(".class", StringComparison.Ordinal);
                    if (dcl != -1)
                    {
                        string urlName = ename.Substring(0, dcl);
                        classes.Add(urlName);
                    }
                    entry = zis.getNextEntry();
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage("JvmResolver: Can't open " + jar + "\n" + ex);
            }
            return classes;
        }

        public void Dispose()
        {
            if (jvm!=null)
            {
                jvm.Dispose();
                jvm = null;
            }
        }
    }
}
