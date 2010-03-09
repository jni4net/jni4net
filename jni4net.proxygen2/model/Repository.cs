using System;
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class Repository
    {
        private readonly Dictionary<MAssembly, MAssembly> Assemblies = new Dictionary<MAssembly, MAssembly>();
        private readonly Dictionary<string, MType> AllTypes = new Dictionary<string, MType>();
        private readonly Dictionary<Type, MType> Types = new Dictionary<Type, MType>();
        private readonly Dictionary<Class, MType> Classes = new Dictionary<Class, MType>();

        private Queue<IModel> work=new Queue<IModel>();

        public Config Config { get; private set;}

        public Repository(Config config)
        {
            Config = config;
        }

        public void Tour(IModelVisitor visitor)
        {
            foreach (MAssembly assembly in Assemblies.Values)
            {
                work.Enqueue(assembly);
            }

            // prefer to process base types first
            Dictionary<string, MType> known = new Dictionary<string, MType>();
            foreach (MType type in AllTypes.Values)
            {
                EnQBase(known, type);
            }

            //processing
            while (work.Count > 0)
            {
                IModel current = work.Dequeue();
                current.Accept(visitor, this);
            }
        }

        private void EnQBase(Dictionary<string, MType> known, MType toAdd)
        {
            if (known.ContainsKey(toAdd.Key))
            {
                return;
            }
            if (toAdd.Base != null)
            {
                EnQBase(known, toAdd.Base);
            }
            foreach (MType ifc in toAdd.Interfaces)
            {
                EnQBase(known, ifc);
            }
            if (toAdd.Enclosing != null)
            {
                EnQBase(known, toAdd.Enclosing);
            }
            if (toAdd.Subst != null && toAdd.Subst != toAdd)
            {
                EnQBase(known, toAdd.Subst);
            }
            work.Enqueue(toAdd);
            known.Add(toAdd.Key, toAdd);
        }

        public MType AddOrResolve(Type type)
        {
            return AddOrResolve(new MType(type));
        }

        public MType AddOrResolve(Class clazz)
        {
            return AddOrResolve(new MType(clazz));
        }
        
        public void AddOrResolve(IModel model)
        {
            work.Enqueue(model);
        }

        public MType AddOrResolve(MType type)
        {
            string typeKey = type.Key; 
            if (AllTypes.ContainsKey(typeKey))
            {
                MType res = AllTypes[typeKey];
                if (type.Clr != null && res.Clr==null)
                {
                    res.Clr = type.Clr;
                    Types.Add(type.Clr, res);
                }
                if (type.Jvm != null && res.Jvm == null)
                {
                    res.Jvm = type.Jvm;
                    Classes.Add(type.Jvm, res);
                }
                return res;
            }
            AllTypes.Add(typeKey,type);
            if (type.Clr!=null)
            {
                Types.Add(type.Clr, type);
            }
            if (type.Jvm != null)
            {
                Classes.Add(type.Jvm, type);
            }
            work.Enqueue(type);
            return type;
        }

        public MAssembly AddOrResolve(MAssembly assembly)
        {
            if (Assemblies.ContainsKey(assembly))
            {
                return Assemblies[assembly];
            }
            Assemblies.Add(assembly, assembly);
            work.Enqueue(assembly);
            return assembly;
        }
    
    }
}
