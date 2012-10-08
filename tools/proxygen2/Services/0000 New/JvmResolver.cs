using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.io;
using java.lang;
using java.util.zip;
using net.sf.jni4net;
using Directory = System.IO.Directory;
using Exception = System.Exception;
using File = System.IO.File;
using JType = java.lang.reflect.Type;
using Object = java.lang.Object;

namespace com.jni4net.proxygen.Services
{
    public class JvmResolver : IJvmResolver,IDisposable
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ICommonResolver CommonResolver { get; set; }

        private IWorkQueue workQueue;
        public IWorkQueue WorkQueue
        {
            get { return workQueue ?? (workQueue = Container.Resolve<IWorkQueue>()); }
        }

        [Dependency]
        public IContainer Container { get; set; }

        private readonly BridgeSetup bridgeSetup = new BridgeSetup();
        readonly Dictionary<string, List<ResolverRecord>> cps = new Dictionary<string, List<ResolverRecord>>();
        List<string> jars = new List<string>();
        List<string> dirs = new List<string>();
        readonly Dictionary<Class, ResolverRecord> byClass = new Dictionary<Class, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byLowName = new Dictionary<string, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byName = new Dictionary<string, ResolverRecord>();
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
                var records = new List<ResolverRecord>();
                foreach (var clazzName in classesInJar)
                {
                    var record = RegisterClass(clazzName);
                    records.Add(record);
                }
                cps[jar] = records;
            }

            foreach (var dir in dirs)
            {
                IEnumerable<string> classesInDir = EnumerateClassesInDir(dir);
                var records = new List<ResolverRecord>();
                foreach (var clazzName in classesInDir)
                {
                    var record = RegisterClass(clazzName);
                    records.Add(record);
                }
                cps[dir] = records;
            }

            jars = null;
            dirs = null;

            var knownParent = new MType(null) { Registration = new TypeRegistration { Parent = new ProjectRegistration() { ProjectName = "Knowntypes stub" }, Name = "Knowntypes stub", Generate = false, Exclude = true } };
            knownParent.Parent = knownParent;

            KnownTypes.JavaLangObject = ResolveModel("java.lang.Object", knownParent);
            KnownTypes.JavaLangClass = ResolveModel("java.lang.Class", knownParent);
            KnownTypes.JavaLangThrowable = ResolveModel("java.lang.Throwable", knownParent);
            KnownTypes.JavaLangString = ResolveModel("java.lang.String", knownParent);
            KnownTypes.JavaLangVoid = ResolveModel("java.lang.Void", knownParent);

            KnownTypes.JavaLangBoolean = ResolveModel("java.lang.Boolean", knownParent);
            KnownTypes.JavaLangByte = ResolveModel("java.lang.Byte", knownParent);
            KnownTypes.JavaLangCharacter = ResolveModel("java.lang.Character", knownParent);
            KnownTypes.JavaLangShort = ResolveModel("java.lang.Short", knownParent);
            KnownTypes.JavaLangInteger = ResolveModel("java.lang.Integer", knownParent);
            KnownTypes.JavaLangLong = ResolveModel("java.lang.Long", knownParent);
            KnownTypes.JavaLangFloat = ResolveModel("java.lang.Float", knownParent);
            KnownTypes.JavaLangDouble = ResolveModel("java.lang.Double", knownParent);

            KnownTypes.JvmVoid = ResolveModel(ReflectionUtils.getPrimitiveClass("void"), knownParent);
            KnownTypes.JvmBool = ResolveModel(ReflectionUtils.getPrimitiveClass("boolean"), knownParent);
            KnownTypes.JvmByte = ResolveModel(ReflectionUtils.getPrimitiveClass("byte"), knownParent);
            KnownTypes.JvmChar = ResolveModel(ReflectionUtils.getPrimitiveClass("char"), knownParent);
            KnownTypes.JvmShort = ResolveModel(ReflectionUtils.getPrimitiveClass("short"), knownParent);
            KnownTypes.JvmInt = ResolveModel(ReflectionUtils.getPrimitiveClass("int"), knownParent);
            KnownTypes.JvmLong = ResolveModel(ReflectionUtils.getPrimitiveClass("long"), knownParent);
            KnownTypes.JvmFloat = ResolveModel(ReflectionUtils.getPrimitiveClass("float"), knownParent);
            KnownTypes.JvmDouble = ResolveModel(ReflectionUtils.getPrimitiveClass("double"), knownParent);
        }

        private ResolverRecord RegisterClass(string clazzName)
        {
            string plainName = clazzName.Replace('$', '.').Replace('/', '.');
            var lowName = plainName.ToLowerInvariant();
            ResolverRecord record;
            if (!CommonResolver.ByName.TryGetValue(plainName, out record))
            {
                if (!CommonResolver.ByLowName.TryGetValue(lowName, out record))
                {
                    record = new ResolverRecord { JvmReflectionName = clazzName, JvmPlainName = plainName };
                }
            }
            CommonResolver.ByName.Add(plainName, record);
            CommonResolver.ByLowName.Add(lowName, record);
            byName.Add(plainName, record);
            byLowName.Add(lowName, record);
            return record;
        }

        public List<IMType> GenerateCp(string cp, IMType father, string regex)
        {
            var res = new List<IMType>();
            var rx = regex == null ? null : new Regex(regex.Contains("*") ? regex : "^" + regex + "$");
            foreach (var record in cps[cp].Where(record => rx == null || rx.IsMatch(record.JvmPlainName)))
            {
                LoadClass(record, father);
                if(record.Model!=null)
                {
                    res.Add(record.Model);
                }
            }
            return res;
        }

        private void LoadClass(ResolverRecord record, IMType father, bool forceModel = false)
        {
            if (record.Clazz == null && !record.JvmCantLoad && record.JvmReflectionName!=null)
            {
                try
                {
                    string loadName = record.JvmReflectionName.Replace('/', '.');
                    record.Clazz = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass(loadName);
                }
                catch (Exception)
                {
                    record.JvmCantLoad = true;
                    Logger.LogVerbose("Can't load " + record.JvmReflectionName);
                }
            }
            if (record.Clazz != null && record.Model == null && (forceModel || record.Clazz.IsPublic()))
            {
                record.Model = new MType(father) { JvmReflection = record.Clazz };
            }
            if (record.Clazz != null)
            {
                byClass[record.Clazz] = record;
                if(record.JvmReflectionName==null)
                {
                    var name = record.Clazz.getName();
                    record.JvmReflectionName = name.Replace('.', '/');
                    record.JvmPlainName = name.Replace('$', '.');
                }
            }
            if (record.JvmPlainName!=null)
            {
                var lowName = record.JvmPlainName.ToLowerInvariant();

                CommonResolver.ByLowName[record.JvmPlainName] = record;
                CommonResolver.ByName[lowName] = record;
                byLowName[record.JvmPlainName] = record;
                byName[lowName] = record;
            }
        }

        public IMType ResolveModel(Class clazz, IMType father)
        {
            ResolverRecord res;
            if(byClass.TryGetValue(clazz, out res))
            {
                LoadClass(res, father, true);
                return res.Model;
            }
            string reflectionName = clazz.getName();
            string plainName = reflectionName.Replace('$', '.');
            if (CommonResolver.ByName.TryGetValue(plainName, out res))
            {
                res.Clazz = clazz;
                res.JvmReflectionName = reflectionName;
                res.JvmPlainName = plainName;
                LoadClass(res, father, true);
                return res.Model;
            }
            if (CommonResolver.ByLowName.TryGetValue(plainName.ToLowerInvariant(), out res))
            {
                res.Clazz = clazz;
                res.JvmReflectionName = reflectionName;
                res.JvmPlainName = plainName;
                LoadClass(res, father, true);
                return res.Model;
            }

            res = new ResolverRecord {Clazz = clazz, JvmReflectionName = reflectionName, JvmPlainName = plainName};
            LoadClass(res, father, true);
            return res.Model;
        }

        public IMType ResolveModel(string fullname, IMType father)
        {
            ResolverRecord res;
            if (byName.TryGetValue(fullname, out res))
            {
                LoadClass(res, father, true);
                return res.Model;
            }
            if (byLowName.TryGetValue(fullname.ToLowerInvariant(), out res))
            {
                LoadClass(res, father, true);
                return res.Model;
            }
            return null;
        }

        public void UpdateModel(IMType model)
        {
            byClass[model.JvmReflection].Model = model;
        }

        public Class FindPlainType(Class clazz)
        {
            while (clazz.isArray())
            {
                clazz = clazz.getComponentType();
            }
            return clazz;
        }

        public UTypeUsage CreateUsage(Class type, IMTypeView father)
        {
            var parModel = ResolveModel(FindPlainType(type), father);
            WorkQueue.Enqueue(parModel, false, father.IsExplore);
            //TODO modifiers
            return new UTypeUsage(parModel.IsClr ? parModel.HomeView : parModel.ForeignView, father);
        }

        public UTypeUsage CreateUsage(Class type, string paramName, IMTypeView father)
        {
            var parModel = ResolveModel(FindPlainType(type), father);
            WorkQueue.Enqueue(parModel, false, father.IsExplore);
            //TODO modifiers
            var usage = new UTypeUsage(parModel.IsClr ? parModel.HomeView : parModel.ForeignView, father);
            usage.MethodParameterName = paramName;
            return usage;
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
