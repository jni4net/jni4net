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
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes FullJ2C<TRes>(JNIEnv env, JniLocalHandle obj)
        {
            if (JniLocalHandle.IsNull(obj))
            {
                return default(TRes);
            }
            Type reqType = typeof (TRes);
            if (reqType.IsPrimitive)
            {
                return (TRes) PrimJ2C(obj, env, reqType);
            }
#if DEBUG
            if (reqType.IsArray)
            {
                throw new InvalidOperationException("Call ArrayFullJ2C<TRes, TElem> instead");
            }
#endif
            Class clazz = env.GetObjectClass(obj);
            if (reqType == typeof (string) && clazz == String._class)
            {
                return (TRes) (object) StrongJp2CString(env, obj);
            }

            if (IClrProxy_._class.isAssignableFrom(clazz))
            {
                if (!reqType.IsInterface && typeof(IJvmProxy).IsAssignableFrom(reqType))
                {
                    //now we double wrap
                    return (TRes)__IClrProxy.CreateProxy(env, obj);
                }
                object res = __IClrProxy.GetObject(env, obj);
                if (Bridge.Setup.Debug)
                {
                    Type realType = res.GetType();
                    if (!reqType.IsAssignableFrom(realType))
                    {
                        throw new InvalidCastException("Can't cast CLR instance" + realType + " to " + reqType);
                    }
                }
                return (TRes) res;
            }

            //now we deal only with JVM instances
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            if (reqType.IsAssignableFrom(record.CLRInterface))
            {
                return (TRes) record.CreateCLRProxy(env, obj);
            }
            record = Registry.GetCLRRecord(reqType);
            if (Bridge.Setup.Debug)
            {
                if (!record.JVMInterface.isAssignableFrom(clazz))
                {
                    throw new InvalidCastException("Can't cast JVM instance" + clazz + " to " + reqType);
                }
            }
            return (TRes) record.CreateCLRProxy(env, obj);
        }

        private static object PrimJ2C(JniLocalHandle obj, JNIEnv env, Type type)
        {
            if (type == typeof (bool))
            {
                return env.CallBooleanMethod(obj, boolValue);
            }
            if (type == typeof (char))
            {
                return env.CallCharMethod(obj, charValue);
            }
            if (type == typeof (byte))
            {
                return env.CallByteMethod(obj, byteValue);
            }
            if (type == typeof (short))
            {
                return env.CallShortMethod(obj, shortValue);
            }
            if (type == typeof (int))
            {
                return env.CallIntMethod(obj, intValue);
            }
            if (type == typeof (long))
            {
                return env.CallLongMethod(obj, longValue);
            }
            if (type == typeof (double))
            {
                return env.CallDoubleMethod(obj, doubleValue);
            }
            if (type == typeof (float))
            {
                return env.CallFloatMethod(obj, floatValue);
            }
            throw new InvalidProgramException("Unnknown primitive type" + type);
        }
    }
}