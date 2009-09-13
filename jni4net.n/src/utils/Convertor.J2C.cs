using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes FullJ2C<TRes>(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            Type reqType = typeof(TRes);
            if (reqType.IsPrimitive)
            {
                return (TRes)PrimJ2C(obj, env, reqType);
            }
#if DEBUG
            if (reqType.IsArray)
            {
                throw new InvalidOperationException("Call ArrayFullJ2C<TRes, TElem> instead");
            }
#endif
            Class clazz = env.GetObjectClass(obj);
            if (reqType == typeof(string) && clazz == String._class)
            {
                return (TRes)(object)StrongJp2CString(env, obj);
            }

            if (!typeof(IJavaProxy).IsAssignableFrom(reqType) 
                && IClrProxy_._class.isAssignableFrom(clazz))
            {
                object res = __IClrProxy.GetObject(env, obj);
                if (Bridge.Debug)
                {
                    Type realType = res.GetType();
                    if (!reqType.IsAssignableFrom(realType))
                    {
                        throw new InvalidCastException("Can't cast CLR instance" + realType + " to " + reqType);
                    }
                }
                return (TRes)res;
            }
            
            //now we deal only with JVM instances, 
            // or with wrapped CLR instances, which should stay wrapped
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            if (reqType.IsAssignableFrom(record.CLRInterface))
            {
                return (TRes) record.CreateCLRProxy(env, obj, clazz);
            }
            record = Registry.GetCLRRecord(reqType);
            if (Bridge.Debug)
            {
                if (!record.JVMInterface.isAssignableFrom(clazz))
                {
                    throw new InvalidCastException("Can't cast JVM instance" + clazz + " to " + reqType);
                }
            }
            return (TRes)record.CreateCLRProxy(env, obj, clazz);
        }

        private static object PrimJ2C(IntPtr obj, JNIEnv env, Type type)
        {
            if (type == typeof(bool))
            {
                return env.CallBooleanMethod(obj, boolValue);
            }
            if (type == typeof(char))
            {
                return env.CallCharMethod(obj, charValue);
            }
            if (type == typeof(byte))
            {
                return env.CallByteMethod(obj, byteValue);
            }
            if (type == typeof(short))
            {
                return env.CallShortMethod(obj, shortValue);
            }
            if (type == typeof(int))
            {
                return env.CallIntMethod(obj, intValue);
            }
            if (type == typeof(long))
            {
                return env.CallLongMethod(obj, longValue);
            }
            if (type == typeof(double))
            {
                return env.CallDoubleMethod(obj, doubleValue);
            }
            if (type == typeof(float))
            {
                return env.CallFloatMethod(obj, floatValue);
            }
            throw new InvalidProgramException("Unnknown primitive type" + type);
        }

    }
}
