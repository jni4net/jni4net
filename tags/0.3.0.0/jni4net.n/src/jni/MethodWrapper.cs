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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.jni
{
    internal class MethodWrapper
    {
        //just to prevent collection
        private static readonly List<Delegate> knownDelegates = new List<Delegate>();
        private static readonly Dictionary<Signature, Type> knownSignatures = new Dictionary<Signature, Type>();
        public static AssemblyBuilder assemblyBuilder;
        private static ModuleBuilder moduleBuilder;

        public static IntPtr CreateMethodPtr(MethodInfo method)
        {
            lock (knownDelegates)
            {
                Delegate res;
                Type delegateType;
                Type[] parameters = GetParameters(method.GetParameters());

                bool isStatic = method.IsStatic;
                var signature = new Signature(parameters, method.ReturnType, isStatic);
                bool newDelegate = !knownSignatures.TryGetValue(signature, out delegateType);
                if (newDelegate)
                {
                    delegateType = CreateDelegateType(method.ReturnType, parameters);
                    knownSignatures.Add(signature, delegateType);
                }
                if (isStatic)
                {
                    res = Delegate.CreateDelegate(delegateType, method);
                }
                else
                {
                    res = Delegate.CreateDelegate(delegateType, null, method);
                }
                knownDelegates.Add(res);
                return Marshal.GetFunctionPointerForDelegate(res);
            }
        }

        private static Type CreateDelegateType(Type returnType, Type[] paramTypes)
        {
            ModuleBuilder moduleBuilder = InitModuleBuilder();
            TypeBuilder typeBuilder = moduleBuilder.DefineType("DelegateSignature" + knownSignatures.Count,
                                                               TypeAttributes.Public | TypeAttributes.Class |
                                                               TypeAttributes.Sealed | TypeAttributes.AnsiClass |
                                                               TypeAttributes.AutoClass, typeof (MulticastDelegate));
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("Invoke",
                                                                   MethodAttributes.Public | MethodAttributes.HideBySig |
                                                                   MethodAttributes.NewSlot |
                                                                   MethodAttributes.Virtual, CallingConventions.Standard,
                                                                   returnType, paramTypes);
            methodBuilder.SetImplementationFlags(MethodImplAttributes.Runtime | MethodImplAttributes.Managed);

            ConstructorBuilder constructorBuilder =
                typeBuilder.DefineConstructor(
                    MethodAttributes.RTSpecialName | MethodAttributes.HideBySig | MethodAttributes.Public,
                    CallingConventions.Standard, new[] {typeof (object), typeof (IntPtr)});

            constructorBuilder.SetImplementationFlags(MethodImplAttributes.Runtime | MethodImplAttributes.Managed);

            typeBuilder.SetCustomAttribute(
                new CustomAttributeBuilder(
                    typeof (UnmanagedFunctionPointerAttribute).GetConstructor(new[] {typeof (CallingConvention)}),
                    new object[] {CallingConvention.StdCall}));
            Type delegateType = typeBuilder.CreateType();
            return delegateType;
        }

        private static Type[] GetParameters(ParameterInfo[] paramInfo)
        {
            var paramTypes = new Type[paramInfo.Length];
            for (int i = 0; i < paramInfo.Length; i++)
            {
                ParameterInfo parameter = paramInfo[i];
                if (parameter.IsOut || parameter.IsRetval)
                {
                    throw new JNIException("Can't bind method with out or ref params");
                }
                paramTypes[i] = parameter.ParameterType;
            }
            return paramTypes;
        }

        public static ModuleBuilder InitModuleBuilder()
        {
            if (moduleBuilder == null)
            {
                assemblyBuilder =
                    AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("net.sf.jni4net.jni.dynammic"),
                                                                  AssemblyBuilderAccess.RunAndSave); //TODO RUN only
                moduleBuilder = assemblyBuilder.DefineDynamicModule("net.sf.jni4net.jni.dynammic",
                                                                    "net.sf.jni4net.jni.dynammic.dll");
            }
            return moduleBuilder;
        }


        public static void GetDelegateForFunctionPointer<T>(IntPtr ptr, ref T res)
        {
            res = (T) (object) Marshal.GetDelegateForFunctionPointer(ptr, typeof (T));
        }

        #region Nested type: Signature

        private class Signature
        {
            private readonly Type[] types;
            private int hash;
            private bool isStatic;

            public Signature(IEnumerable<Type> parameters, Type returnType, bool isStatic)
            {
                var lsignature = new List<Type>(parameters);
                lsignature.Add(returnType);
                types = lsignature.ToArray();
                this.isStatic = isStatic;
            }

            public override int GetHashCode()
            {
                if (hash == 0)
                {
                    foreach (Type type in types)
                    {
                        hash ^= type.GetHashCode();
                    }
                    hash ^= (isStatic ? 0 : 1);
                }
                return hash;
            }

            public override bool Equals(object obj)
            {
                var other = obj as Signature;
                if (other == null)
                {
                    return false;
                }
                if (other.types.Length != types.Length)
                {
                    return false;
                }
                if (GetHashCode() != other.GetHashCode())
                {
                    return false;
                }
                if (isStatic != other.isStatic)
                {
                    return false;
                }
                for (int i = 0; i < types.Length; i++)
                {
                    if (types[i] != other.types[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        #endregion
    }
}