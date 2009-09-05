using System;
using System.Collections.Generic;
using java.lang;

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        private RegistryRecord ResolveNew(Class clazz)
        {
            var fill = new List<Class>(){clazz};
            Class current = clazz.getSuperclass();
            RegistryRecord res;
            while (!knownJVM.TryGetValue(current, out res))
            {
                fill.Add(current);
                current = current.getSuperclass();
            }

            if (current == Object_._class)
            {
                // any interface is better than system.Object
                bool ifcfound = false;
                current = clazz;
                while (current != Object_._class)
                {
                    foreach (Class ifc in current.getInterfaces())
                    {
                        if (knownJVM.TryGetValue(ifc, out res))
                        {
                            ifcfound = true;
                            break;
                        }
                    }
                    if (ifcfound)
                    {
                        break;
                    }
                    current = current.getSuperclass();
                }
            }

            foreach (Class newType in fill)
            {
                knownJVM.Add(newType, res);
            }
            return res;
        }

        private RegistryRecord ResolveNew(Type type)
        {
            var fill = new List<Type>() { type };
            Type current = type.BaseType;
            RegistryRecord res;
            while (!knownCLR.TryGetValue(current, out res))
            {
                fill.Add(current);
                current = current.BaseType;
            }

            if (current == typeof (object))
            {
                // any interface is better than system.Object
                bool ifcfound = false;
                current = type;
                while (current != typeof (object))
                {
                    foreach (Type ifc in current.GetInterfaces())
                    {
                        if (knownCLR.TryGetValue(ifc, out res))
                        {
                            ifcfound = true;
                            break;
                        }
                    }
                    if (ifcfound)
                    {
                        break;
                    }
                    current = current.BaseType;
                }
            }

            foreach (Type newType in fill)
            {
                knownCLR.Add(newType, res);
            }
            return res;
        }
    }
}
