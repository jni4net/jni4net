using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        internal static IJavaProxy C2JWrapper(JNIEnv env, object obj)
        {
            Type type = obj.GetType();
            if (typeof(IJavaProxy).IsAssignableFrom(type))
            {
                return (IJavaProxy)obj;
            }
            IntPtr ptr = C2J(env, obj);
            RegistryRecord record;
            if (type.IsPrimitive)
            {
                record = Registry.Default.GetRecord(env, ptr, env.GetObjectClass(ptr));
            }
            else
            {
                record = Registry.Default.GetCLRRecord(typeof(IClrProxy));
            }
            IJavaProxy proxy = record.CLRConstructor.CreateProxy(env);
            proxy.Init(env, ptr, IClrProxy_._class);
            return proxy;
        }

        public static IntPtr C2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J(env, (object) obj);
        }

        public static IntPtr C2J<TRes, TInput>(JNIEnv env, TInput obj)
        {
            return C2J(env, obj);
        }

        public static IntPtr C2J(JNIEnv env, object obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            var proxy = obj as IJavaProxy;
            if (proxy != null)
            {
                return OptiCP2J(proxy);
            }
            return OptiC2JP(env, obj);
        }

        private static IntPtr OptiC2JP(JNIEnv env, object obj)
        {
            var array = obj as Array;
            if (array != null)
            {
                return C2J(env, array);
            }
            Type type = obj.GetType();
            if (type.IsPrimitive)
            {
                if (type == typeof (bool))
                {
                    Value value = ParamC2J(env, (bool) obj);
                    return env.CallStaticObjectMethodPtr(Boolean.staticClass, boolObject, value);
                }
                if (type == typeof (byte))
                {
                    Value value = ParamC2J(env, (byte) obj);
                    return env.CallStaticObjectMethodPtr(Byte.staticClass, byteObject, value);
                }
                if (type == typeof (char))
                {
                    Value value = ParamC2J(env, (char) obj);
                    return env.CallStaticObjectMethodPtr(Character.staticClass, charObject, value);
                }
                if (type == typeof (short))
                {
                    Value value = ParamC2J(env, (short) obj);
                    return env.CallStaticObjectMethodPtr(Short.staticClass, shortObject, value);
                }
                if (type == typeof (int))
                {
                    Value value = ParamC2J(env, (int) obj);
                    return env.CallStaticObjectMethodPtr(Integer.staticClass, intObject, value);
                }
                if (type == typeof (long))
                {
                    Value value = ParamC2J(env, (long) obj);
                    return env.CallStaticObjectMethodPtr(Long.staticClass, longObject, value);
                }
                if (type == typeof (double))
                {
                    Value value = ParamC2J(env, (double) obj);
                    return env.CallStaticObjectMethodPtr(Double.staticClass, doubleObject, value);
                }
                if (type == typeof (float))
                {
                    Value value = ParamC2J(env, (float) obj);
                    return env.CallStaticObjectMethodPtr(Float.staticClass, floatObject, value);
                }
            }

            RegistryRecord record = Registry.Default.GetCLRRecord(type);
            int handle = IntHandle.Alloc(obj);
            return env.NewObjectPtr(record.JVMProxy.native, record.JVMConstructor, new Value(),
                                    new Value {_int = handle});
        }

        public static IntPtr C2J(JNIEnv env, Array array)
        {
            Type type = array.GetType().GetElementType();
            Class elemClazz = Registry.Default.GetCLRRecord(type).JVMInterface;
            int length = array.Length;
            IntPtr res;
            if (typeof (int).IsAssignableFrom(type))
            {
                res = env.NewIntArrayPtr(length);
                env.SetIntArrayRegion(res, 0, length, (int[]) array);
            }
            else if (typeof (bool).IsAssignableFrom(type))
            {
                res = env.NewBooleanArrayPtr(length);
                env.SetBooleanArrayRegion(res, 0, length, (bool[]) array);
            }
            else if (typeof (long).IsAssignableFrom(type))
            {
                res = env.NewLongArrayPtr(length);
                env.SetLongArrayRegion(res, 0, length, (long[]) array);
            }
            else if (typeof (double).IsAssignableFrom(type))
            {
                res = env.NewDoubleArrayPtr(length);
                env.SetDoubleArrayRegion(res, 0, length, (double[]) array);
            }
            else if (typeof (byte).IsAssignableFrom(type))
            {
                res = env.NewByteArrayPtr(length);
                env.SetByteArrayRegion(res, 0, length, (byte[]) array);
            }
            else if (typeof (short).IsAssignableFrom(type))
            {
                res = env.NewShortArrayPtr(length);
                env.SetShortArrayRegion(res, 0, length, (short[]) array);
            }
            else if (typeof (float).IsAssignableFrom(type))
            {
                res = env.NewFloatArrayPtr(length);
                env.SetFloatArrayRegion(res, 0, length, (float[]) array);
            }
            else if (typeof (char).IsAssignableFrom(type))
            {
                res = env.NewCharArrayPtr(length);
                env.SetCharArrayRegion(res, 0, length, (char[]) array);
            }
            else
            {
                res = env.NewObjectArrayPtr(length, elemClazz.native, null);
                for (int i = 0; i < length; i++)
                {
                    IntPtr item = C2J(env, array.GetValue(i));
                    env.SetObjectArrayElement(res, i, item);
                }
            }
            return res;
        }

        public static IntPtr OptiCP2J(IJavaProxy obj)
        {
            return obj.Native;
        }
    }
}
