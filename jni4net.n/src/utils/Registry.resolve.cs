#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using java.lang;
using Object=java.lang.Object;

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        private static RegistryRecord ResolveNew(Class clazz)
        {
            var fill = new List<Class> {clazz};
            Class current = clazz.getSuperclass();
            RegistryRecord res;
            while (!knownJVM.TryGetValue(current, out res))
            {
                fill.Add(current);
                current = current.getSuperclass();
            }

            if (current == Object._class)
            {
                RegistryRecord resi = null;
                // any interface is better than system.Object
                current = clazz;
                while (current != Object._class)
                {
                    foreach (Class ifc in current.getInterfaces())
                    {
                        if (knownJVM.TryGetValue(ifc, out resi))
                        {
                            res = resi;
                            fill = new List<Class> {clazz};
                            if (current != clazz)
                            {
                                fill.Add(current);
                            }
                            break;
                        }
                        foreach (Class ifcin in ifc.getInterfaces())
                        {
                            if (knownJVM.TryGetValue(ifcin, out resi))
                            {
                                res = resi;
                                fill = new List<Class> {clazz};
                                fill.Add(ifc);
                                if (current != clazz)
                                {
                                    fill.Add(current);
                                }
                                break;
                            }
                        }
                        if (resi != null)
                        {
                            break;
                        }
                    }
                    if (resi != null)
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

        private static RegistryRecord ResolveNew(Type type)
        {
            var fill = new List<Type> {type};
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