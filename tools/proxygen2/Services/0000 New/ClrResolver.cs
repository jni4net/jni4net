using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using IKVM.Reflection;
using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Assembly = IKVM.Reflection.Assembly;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    public class ClrResolver : IClrResolver
    {
        class Record
        {
            public bool CantLoad;
            public string PlainName;
            public string ReflectionName;
            public Type Type;
            public IMType Model;
        }

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public ITypeRepository TypeRepository { get; set; }

        readonly Dictionary<string, List<Record>> ams = new Dictionary<string, List<Record>>();
        readonly Dictionary<string, Record> byLowName = new Dictionary<string, Record>();
        readonly Dictionary<string, Record> byName = new Dictionary<string, Record>();
        readonly Dictionary<Type, Record> byType = new Dictionary<Type, Record>();
        Dictionary<string, Assembly> names = new Dictionary<string, Assembly>();
        Dictionary<string, Assembly> files = new Dictionary<string, Assembly>();

        private readonly Universe universe = new Universe();

        public void AddName(string fullName)
        {
            try
            {
                Assembly assembly = universe.Load(fullName);
                ams.Add(fullName,new List<Record>());
                names.Add(fullName, assembly);
            }
            catch(Exception ex)
            {
                string message = "ClrResolver: can't load " + fullName;
                Logger.LogError(message, ex);
                throw new ProxygenConfigException(message);
            }
        }

        public void AddPath(string filename)
        {
            if(!File.Exists(filename))
            {
                string message = "ClrResolver: file doesn't exist " + filename;
                Logger.LogError(message);
                throw new ProxygenConfigException(message);
            }
            Assembly assembly = universe.LoadFile(filename);
            ams.Add(filename, new List<Record>());
            files.Add(filename, assembly);
        }

        public void Init()
        {
            foreach (var file in files)
            {
                var records = new List<Record>();
                foreach (var type in file.Value.GetTypes())
                {
                    Record record = RegisterType(type);
                    records.Add(record);
                }
                ams[file.Key] = records;
            }

            foreach (var name in names)
            {
                var records = new List<Record>();
                foreach (var type in name.Value.GetTypes())
                {
                    Record record = RegisterType(type);
                    records.Add(record);
                }
                ams[name.Key] = records;
            }

            files = null;
            names = null;

            var knownParent = new MType(null) { Registration = new TypeRegistration { Parent = new ProjectRegistration() { ProjectName = "Knowntypes stub" }, Name = "Knowntypes stub", Generate = false,Exclude = true} };
            knownParent.Parent = knownParent;

            TypeRepository.SystemObject = ResolveModel(universe.GetType("System.Object"), knownParent);
            TypeRepository.SystemException = ResolveModel(universe.GetType("System.Exception"), knownParent);
            TypeRepository.SystemType = ResolveModel(universe.GetType("System.Type"), knownParent);

        }

        public List<IMType> GenerateAs(string asm, IMType parent, string regex = null)
        {
            var res = new List<IMType>();
            var rx = regex == null ? null : new Regex(regex.Contains("*") ? regex : "^"+regex+"$");
            foreach (var record in ams[asm].Where(record => rx == null || rx.IsMatch(record.PlainName)))
            {
                LoadType(record, parent);
                if (record.Model != null)
                {
                    res.Add(record.Model);
                }
            }
            return res;
        }

        private void LoadType(Record record, IMType parent, bool forceModel = false)
        {
            if (record.Type == null && !record.CantLoad)
            {
                try
                {
                    string loadName = record.ReflectionName;
                    record.Type = universe.GetType(loadName);
                    byType[record.Type] = record;
                }
                catch (Exception)
                {
                    record.CantLoad = true;
                    Logger.LogVerbose("Can't load " + record.ReflectionName);
                }
            }
            if (record.Type != null && record.Model == null && (forceModel || record.Type.IsPublic))
            {
                record.Model = new MType(parent) { ClrReflection = record.Type };
            }
            if (record.Type != null)
            {
                byType[record.Type] = record;
            }
            byLowName[record.PlainName] = record;
            byName[record.PlainName.ToLowerInvariant()] = record;
        }

        public IMType ResolveModel(Type type, IMType parent)
        {
            Record res;
            if (byType.TryGetValue(type, out res))
            {
                LoadType(res, parent, true);
                return res.Model;
            }

            var plainName = type.FullName.Replace('+', '.');
            res = new Record { Type = type, ReflectionName = type.AssemblyQualifiedName, PlainName = plainName };
            LoadType(res, parent, true);
            return res.Model;
        
        }

        public IMType ResolveModel(string fullname, IMType parent)
        {
            Record res;
            if (byName.TryGetValue(fullname, out res))
            {
                LoadType(res, parent, true);
                return res.Model;
            }
            if (byLowName.TryGetValue(fullname.ToLowerInvariant(), out res))
            {
                LoadType(res, parent, true);
                return res.Model;
            }
            return null;
        }

        public void UpdateModel(IMType model)
        {
            byType[model.ClrReflection].Model = model;
        }

        public Type FindPlainType(Type clr)
        {
            while (clr.IsArray || clr.IsPointer || clr.IsByRef)
            {
                clr = clr.GetElementType();
            }
            if (clr.IsGenericParameter)
            {
                clr = TypeRepository.SystemObject.ClrReflection;
            }
            while (clr.IsGenericType)
            {
                clr = clr.BaseType ?? TypeRepository.SystemObject.ClrReflection;
            }
            return clr;
            
        }

        private Record RegisterType(Type type)
        {
            var plainName = type.FullName.Replace('+', '.');
            var record = new Record { Type = type, PlainName = plainName, ReflectionName = type.AssemblyQualifiedName };
            byLowName.Add(type.FullName.ToLowerInvariant(), record);
            byName.Add(type.FullName, record);
            byType.Add(type,record);
            return record;
        }
    }
}
