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
using Exception = System.Exception;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    public class ClrResolver : IClrResolver
    {

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public ICommonResolver CommonResolver { get; set; }

        private IWorkQueue workQueue;
        public IWorkQueue WorkQueue
        {
            get { return workQueue ?? (workQueue = Container.Resolve<IWorkQueue>()); }
        }

        [Dependency]
        public IContainer Container { get; set; }
        readonly Dictionary<string, List<ResolverRecord>> ams = new Dictionary<string, List<ResolverRecord>>();
        readonly Dictionary<Type, ResolverRecord> byType = new Dictionary<Type, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byLowName = new Dictionary<string, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byName = new Dictionary<string, ResolverRecord>();
        Dictionary<string, Assembly> names = new Dictionary<string, Assembly>();
        Dictionary<string, Assembly> files = new Dictionary<string, Assembly>();

        private readonly Universe universe = new Universe();

        public void AddName(string fullName)
        {
            try
            {
                Assembly assembly = universe.Load(fullName);
                ams.Add(fullName,new List<ResolverRecord>());
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
            ams.Add(filename, new List<ResolverRecord>());
            files.Add(filename, assembly);
        }

        public void Init()
        {
            foreach (var file in files)
            {
                var records = new List<ResolverRecord>();
                foreach (var type in file.Value.GetTypes())
                {
                    ResolverRecord record = RegisterType(type);
                    records.Add(record);
                }
                ams[file.Key] = records;
            }

            foreach (var name in names)
            {
                var records = new List<ResolverRecord>();
                foreach (var type in name.Value.GetTypes())
                {
                    ResolverRecord record = RegisterType(type);
                    records.Add(record);
                }
                ams[name.Key] = records;
            }

            files = null;
            names = null;

            var knownParent = new MType(null) { Registration = new TypeRegistration { Parent = new ProjectRegistration() { ProjectName = "Knowntypes stub" }, Name = "Knowntypes stub", Generate = false,Exclude = true} };
            knownParent.Parent = knownParent;

            KnownTypes.SystemObject = ResolveModel(universe.GetType("System.Object"), knownParent);
            KnownTypes.SystemException = ResolveModel(universe.GetType("System.Exception"), knownParent);
            KnownTypes.SystemType = ResolveModel(universe.GetType("System.Type"), knownParent);
            KnownTypes.ClrVoid = ResolveModel(universe.GetType("System.Void"), knownParent);

            KnownTypes.ClrBool = ResolveModel(universe.GetType("System.Boolean"), knownParent);
            KnownTypes.ClrByte = ResolveModel(universe.GetType("System.Byte"), knownParent);
            KnownTypes.ClrChar = ResolveModel(universe.GetType("System.Char"), knownParent);
            KnownTypes.ClrShort = ResolveModel(universe.GetType("System.Int16"), knownParent);
            KnownTypes.ClrInt = ResolveModel(universe.GetType("System.Int32"), knownParent);
            KnownTypes.ClrLong = ResolveModel(universe.GetType("System.Int64"), knownParent);
            KnownTypes.ClrFloat = ResolveModel(universe.GetType("System.Single"), knownParent);
            KnownTypes.ClrDouble = ResolveModel(universe.GetType("System.Double"), knownParent);
            KnownTypes.ClrSByte = ResolveModel(universe.GetType("System.SByte"), knownParent);
            KnownTypes.ClrUShort = ResolveModel(universe.GetType("System.UInt16"), knownParent);
            KnownTypes.ClrUInt = ResolveModel(universe.GetType("System.UInt32"), knownParent);
            KnownTypes.ClrULong = ResolveModel(universe.GetType("System.UInt64"), knownParent);
            KnownTypes.ClrIntPtr = ResolveModel(universe.GetType("System.IntPtr"), knownParent);
            KnownTypes.ClrUIntPtr = ResolveModel(universe.GetType("System.UIntPtr"), knownParent);
        }

        private ResolverRecord RegisterType(Type type)
        {
            var plainName = type.FullName.Replace('+', '.');
            var lowName = plainName.ToLowerInvariant();

            ResolverRecord record;
            if (!CommonResolver.ByName.TryGetValue(plainName, out record))
            {
                if (!CommonResolver.ByLowName.TryGetValue(lowName, out record))
                {
                    record = new ResolverRecord { Type = type, ClrPlainName = plainName, ClrReflectionName = type.AssemblyQualifiedName };
                }
            }
            CommonResolver.ByName.Add(plainName, record);
            CommonResolver.ByLowName.Add(lowName, record);
            byLowName.Add(lowName, record);
            byName.Add(plainName, record);
            byType.Add(type, record);
            return record;
        }

        public List<IMType> GenerateAs(string asm, IMType father, string regex = null)
        {
            var res = new List<IMType>();
            var rx = regex == null ? null : new Regex(regex.Contains("*") ? regex : "^"+regex+"$");
            foreach (var record in ams[asm].Where(record => rx == null || rx.IsMatch(record.ClrPlainName)))
            {
                LoadType(record, father);
                if (record.Model != null)
                {
                    res.Add(record.Model);
                }
            }
            return res;
        }

        private void LoadType(ResolverRecord record, IMType father, bool forceModel = false)
        {
            if (record.Type == null && !record.ClrCantLoad && record.ClrReflectionName!=null)
            {
                try
                {
                    string loadName = record.ClrReflectionName;
                    record.Type = universe.GetType(loadName);
                    byType[record.Type] = record;
                }
                catch (Exception)
                {
                    record.ClrCantLoad = true;
                    Logger.LogVerbose("Can't load " + record.ClrReflectionName);
                }
            }
            if (record.Type != null && record.Model == null && (forceModel || record.Type.IsPublic))
            {
                record.Model = new MType(father) { ClrReflection = record.Type };
            }
            if (record.Type != null)
            {
                byType[record.Type] = record;
                if (record.ClrReflectionName==null)
                {
                    record.ClrReflectionName = record.Type.AssemblyQualifiedName;
                    record.ClrPlainName = record.Type.FullName.Replace('+', '.');
                }
            }
            if (record.ClrPlainName!=null)
            {
                var lowName = record.ClrPlainName.ToLowerInvariant();

                CommonResolver.ByLowName[record.ClrPlainName] = record;
                CommonResolver.ByName[lowName] = record;
                byLowName[record.ClrPlainName] = record;
                byName[lowName] = record;
            }
        }

        public IMType ResolveModel(Type type, IMType father)
        {
            ResolverRecord res;
            if (byType.TryGetValue(type, out res))
            {
                LoadType(res, father, true);
                return res.Model;
            }
            var plainName = type.FullName.Replace('+', '.');
            if (CommonResolver.ByName.TryGetValue(plainName, out res))
            {
                res.Type = type;
                res.ClrReflectionName = type.AssemblyQualifiedName;
                res.ClrPlainName = plainName;
                LoadType(res, father, true);
                return res.Model;
            }
            if (CommonResolver.ByLowName.TryGetValue(plainName.ToLowerInvariant(), out res))
            {
                res.Type = type;
                res.ClrReflectionName = type.AssemblyQualifiedName;
                res.ClrPlainName = plainName;
                LoadType(res, father, true);
                return res.Model;
            }

            res = new ResolverRecord { Type = type, ClrReflectionName = type.AssemblyQualifiedName, ClrPlainName = plainName };
            LoadType(res, father, true);
            return res.Model;
        
        }

        public IMType ResolveModel(string fullname, IMType father)
        {
            ResolverRecord res;
            if (byName.TryGetValue(fullname, out res))
            {
                LoadType(res, father, true);
                return res.Model;
            }
            if (byLowName.TryGetValue(fullname.ToLowerInvariant(), out res))
            {
                LoadType(res, father, true);
                return res.Model;
            }
            return null;
        }

        public void UpdateModel(IMType model)
        {
            byType[model.ClrReflection].Model = model;
        }

        public Type FindPlainType(Type type)
        {
            while (type.IsArray || type.IsPointer || type.IsByRef)
            {
                type = type.GetElementType();
            }
            return type;
        }

        public Type LoadType(string fullname)
        {
            return universe.GetType(fullname);
        }

        public IUTypeUsage CreateUsage(ParameterInfo clr, IMTypeView father)
        {
            var parModel = ResolveModel(FindPlainType(clr.ParameterType), father);
            WorkQueue.Enqueue(parModel, false, father.IsExplore);
            //TODO modifiers
            return new UTypeUsage(parModel.IsClr ? parModel.HomeView : parModel.ForeignView, father);
        }

        public IUTypeUsage CreateUsage(Type clr, IMTypeView father)
        {
            var parModel = ResolveModel(FindPlainType(clr), father);
            WorkQueue.Enqueue(parModel, false, father.IsExplore);
            //TODO modifiers
            return new UTypeUsage(parModel.IsClr ? parModel.HomeView : parModel.ForeignView, father);
        }
    }
}
