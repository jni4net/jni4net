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
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static JniHandle FullC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
            // ReSharper restore CompareNonConstrainedGenericWithNull
            Type reqType = typeof (TBoth);

            if (reqType.IsPrimitive)
            {
                return PrimC2J(env, obj, reqType);
            }
#if DEBUG
            if (reqType.IsArray)
            {
                throw new InvalidOperationException("Call ArrayFullJ2C<TRes, TElem> instead");
            }
#endif

            var proxy = obj as IJvmProxy;
            if (proxy != null)
            {
                if (!reqType.IsInterface && !typeof(IJvmProxy).IsAssignableFrom(reqType))
                {
                    //now we do double wrap
                    RegistryRecord recordW = Registry.GetCLRRecord(typeof(IJvmProxy));
                    return recordW.CreateJVMProxy(env, obj);
                }
                if (Bridge.Setup.Debug)
                {
                    Class clazzT = env.GetObjectClass(proxy.JvmHandle);
                    RegistryRecord recordT = Registry.GetCLRRecord(reqType);
                    if (!recordT.JVMInterface.isAssignableFrom(clazzT))
                    {
                        throw new InvalidCastException("Can't cast JVM instance " + clazzT + " to " + reqType);
                    }
                }
                return proxy.JvmHandle;
            }

            Type realType = obj.GetType();
            if (reqType == typeof (String) && realType == typeof (string))
            {
                return StrongC2JString(env, (string) (object) obj);
            }

            //Now we deal only with CLR instances
            RegistryRecord record = Registry.GetCLRRecord(realType);
            if (reqType.IsAssignableFrom(record.CLRInterface))
            {
                return record.CreateJVMProxy(env, obj);
            }
            record = Registry.GetCLRRecord(reqType);
            if (Bridge.Setup.Debug)
            {
                if (!record.CLRInterface.IsAssignableFrom(realType))
                {
                    throw new InvalidCastException("Can't cast JVM instance" + realType + " to " + reqType);
                }
            }
            return record.CreateJVMProxy(env, obj);
        }

        private static JniLocalHandle PrimC2J(JNIEnv env, object obj, Type type)
        {
            if (type == typeof (int) || type == typeof (uint))
            {
                Value value = ParPrimC2J((int) obj);
                return env.CallStaticObjectMethodPtr(Integer.staticClass, intObject, value);
            }
            if (type == typeof (long) || type == typeof (ulong))
            {
                Value value = ParPrimC2J((long) obj);
                return env.CallStaticObjectMethodPtr(Long.staticClass, longObject, value);
            }
            if (type == typeof (bool))
            {
                Value value = ParPrimC2J((bool) obj);
                return env.CallStaticObjectMethodPtr(Boolean.staticClass, boolObject, value);
            }
            if (type == typeof (double))
            {
                Value value = ParPrimC2J((double) obj);
                return env.CallStaticObjectMethodPtr(Double.staticClass, doubleObject, value);
            }
            if (type == typeof (byte) || type == typeof (sbyte))
            {
                Value value = ParPrimC2J((byte) obj);
                return env.CallStaticObjectMethodPtr(Byte.staticClass, byteObject, value);
            }
            if (type == typeof (char))
            {
                Value value = ParPrimC2J((char) obj);
                return env.CallStaticObjectMethodPtr(Character.staticClass, charObject, value);
            }
            if (type == typeof (short) || type == typeof (ushort))
            {
                Value value = ParPrimC2J((short) obj);
                return env.CallStaticObjectMethodPtr(Short.staticClass, shortObject, value);
            }
            if (type == typeof (float))
            {
                Value value = ParPrimC2J((float) obj);
                return env.CallStaticObjectMethodPtr(Float.staticClass, floatObject, value);
            }
            throw new InvalidOperationException("Unknown simple type" + type);
        }

        //TODO, too bad. Conversion doesn''t work, because args are CLR object
        internal static Value[] ConverArgs(JNIEnv env, object[] args)
        {
            if (args.Length == 0)
            {
                return null;
            }
            var jargs = new Value[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                var sarg = args[i] as string;
                if (sarg != null)
                {
                    jargs[i] = new Value { _object = env.NewStringPtr(sarg).DangerousGetHandle() };
                }
                else
                {
                    jargs[i] = new Value { _object = FullC2J(env, args[i]) };
                }
            }
            return jargs;
        }
    }
}