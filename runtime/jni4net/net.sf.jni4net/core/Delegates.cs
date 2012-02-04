#region Copyright (C) 2012 by Pavel Savara

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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public delegate object CreateJvmProxy(JNIEnv env, IntPtr localHandle, JvmInstanceInfo proxyInfo);
    public delegate IntPtr CreateClrProxy(JNIEnv env, object value, Type instanceType);

    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
    [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
    internal static class Delegates
    {
        static readonly FieldInfo field_methodPtr = typeof(Delegate).GetField("_methodPtr", BindingFlags.NonPublic | BindingFlags.Instance);
        static readonly FieldInfo field_methodPtrAux = typeof(Delegate).GetField("_methodPtrAux", BindingFlags.NonPublic|BindingFlags.Instance);

        public static T CastDelegate<T>(Delegate source)
            where T : class
        {
            if (source == null)
                return null;

            Delegate[] delegates = source.GetInvocationList();
            if (delegates.Length == 1)
            {
                var resDel = Delegate.CreateDelegate(typeof(T), delegates[0].Target, delegates[0].Method) as T;
                field_methodPtr.SetValue(resDel, field_methodPtr.GetValue(delegates[0]));
                field_methodPtrAux.SetValue(resDel, field_methodPtrAux.GetValue(delegates[0]));
                return resDel;
            }

            for (int i = 0; i < delegates.Length; i++)
            {
                Delegate src = delegates[i];
                delegates[i] = Delegate.CreateDelegate(typeof(T), src.Target, src.Method);
                field_methodPtr.SetValue(delegates[i], field_methodPtr.GetValue(src));
                field_methodPtrAux.SetValue(delegates[i], field_methodPtrAux.GetValue(src));
            }

            return Delegate.Combine(delegates) as T;
        }

        public static void GetDelegateForFunctionPointer<TCDecl, TStdCall>(IntPtr ptr, ref TCDecl res, bool stdCall)
            where TCDecl : class
            where TStdCall : class
        {
            res = (TCDecl)(object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TCDecl));
            if (stdCall)
            {
                Delegate stdc = Marshal.GetDelegateForFunctionPointer(ptr, typeof(TStdCall));
                var aex1 = field_methodPtr.GetValue(stdc);
                var bex1 = field_methodPtrAux.GetValue(stdc);
                var aex2 = field_methodPtr.GetValue(res);
                var bex2 = field_methodPtrAux.GetValue(res);

                field_methodPtr.SetValue(res, aex1);
                field_methodPtrAux.SetValue(res, bex1);
                field_methodPtr.SetValue(stdc, aex2);
                field_methodPtrAux.SetValue(stdc, bex2);
            }
        }

        public static CreateJvmProxy MakeGenericDelegate(CreateJvmProxy inp, Type[] gargs)
        {
            MethodInfo methodInfo = inp.Method;
            Type declaringType = methodInfo.DeclaringType;
            Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
            Type outDeclaringType = genericTypeDefinition.MakeGenericType(gargs);
            MethodInfo method = outDeclaringType.GetMethod(methodInfo.Name, BindingFlags.Static | BindingFlags.NonPublic);

            var res = (CreateJvmProxy)Delegate.CreateDelegate(typeof(CreateJvmProxy), method);
            return res;
        }

        public static void GetDelegateForFunctionPointer<T>(IntPtr ptr, ref T res)
        {
            res = (T)(object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(T));
        }


    }
}
