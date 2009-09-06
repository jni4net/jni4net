using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public static partial class Convertor
    {
        #region JVM -> CLR

        public static Array J2CArray(JNIEnv env, IntPtr array, Class clazz)
        {
            Class elementClass = clazz.getComponentType();
            Type elementType = Registry.Default.GetJVMRecord(elementClass).CLRInterface;
            return J2CArray(env, array, elementType);
        }

        public static Array J2CArray(JNIEnv env, IntPtr array, Type elementType)
        {
            int length = env.GetArrayLength(array);
            Array res = Array.CreateInstance(elementType, length);
            if (!elementType.IsPrimitive)
            {
                for (int i = 0; i < length; i++)
                {
                    IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                    object element = J2C(env, elementPtr);
                    res.SetValue(element, i);
                }
            }
            else if (elementType == typeof(int))
            {
                env.GetIntArrayRegion(array, 0, length, (int[])res);
            }
            else if (elementType == typeof(char))
            {
                env.GetCharArrayRegion(array, 0, length, (char[])res);
            }
            else if (elementType == typeof(byte))
            {
                env.GetByteArrayRegion(array, 0, length, (byte[])res);
            }
            else if (elementType == typeof(long))
            {
                env.GetLongArrayRegion(array, 0, length, (long[])res);
            }
            else if (elementType == typeof(short))
            {
                env.GetShortArrayRegion(array, 0, length, (short[])res);
            }
            else if (elementType == typeof(double))
            {
                env.GetDoubleArrayRegion(array, 0, length, (double[])res);
            }
            else if (elementType == typeof(float))
            {
                env.GetFloatArrayRegion(array, 0, length, (float[])res);
            }
            else if (elementType == typeof(bool))
            {
                env.GetBooleanArrayRegion(array, 0, length, (bool[])res);
            }
            else
            {
                throw new NotImplementedException();
            }
            return res;
        }

        private static object J2C(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            Class clazz = env.GetObjectClass(obj);
            if (IClrProxy_._class.isAssignableFrom(clazz))
            {
                return OptiJP2C(env, obj);
            }
            if (clazz.isArray())
            {
                return J2CArray(env, obj, clazz);
            }
            return OptiJ2CP(env, obj, clazz);
        }

        public static object OptiJP2C(JNIEnv env, IntPtr obj)
        {
            int handle = __IClrProxy.getClrHandle(env, obj);
            return IntHandle.ToObject(handle);
        }

        public static IJavaProxy OptiJ2CP(JNIEnv env, IntPtr obj)
        {
            return OptiJ2CP(env, obj, env.GetObjectClass(obj));
        }

        private static IJavaProxy OptiJ2CP(JNIEnv env, IntPtr obj, Class clazz)
        {
            RegistryRecord record = Registry.Default.GetRecord(env, obj, clazz);
            IJavaProxy proxy = record.CLRConstructor.CreateProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }

        #endregion

        #region CLR -> JVM

        public static IClrProxy C2JObject(JNIEnv env, object obj)
        {
            IntPtr ptr = C2J(env, obj);

            RegistryRecord record = Registry.Default.GetCLRRecord(typeof (IClrProxy));
            IJavaProxy proxy = record.CLRConstructor.CreateProxy(env);
            proxy.Init(env, ptr, IClrProxy_._class);
            return proxy as IClrProxy;
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

        public static IntPtr OptiC2JP(JNIEnv env, object obj)
        {
            var array = obj as Array;
            if (array != null)
            {
                return C2J(env, array);
            }
            int handle = IntHandle.Alloc(obj);
            RegistryRecord record = Registry.Default.GetRecord(obj);
            return env.NewObjectPtr(record.JVMProxy.native, record.JVMConstructor, new Value(), new Value { _int = handle });
        }

        public static IntPtr C2J(JNIEnv env, Array array)
        {
            Type type = array.GetType().GetElementType();
            Class elemClazz = Registry.Default.GetCLRRecord(type).JVMInterface;
            int length = array.Length;
            IntPtr res;
            if (typeof(IJavaProxy).IsAssignableFrom(type))
            {
                res = env.NewObjectArrayPtr(length, elemClazz.native, null);
                for (int i = 0; i < length; i++)
                {
                    IntPtr item = C2J(env, array.GetValue(i));
                    env.SetObjectArrayElement(res, i, item);
                }
            }
            else if (typeof(int).IsAssignableFrom(type))
            {
                res = env.NewIntArrayPtr(length);
                env.SetIntArrayRegion(res, 0, length, (int[])array);
            }
            else if (typeof(bool).IsAssignableFrom(type))
            {
                res = env.NewBooleanArrayPtr(length);
                env.SetBooleanArrayRegion(res, 0, length, (bool[])array);
            }
            else if (typeof(long).IsAssignableFrom(type))
            {
                res = env.NewLongArrayPtr(length);
                env.SetLongArrayRegion(res, 0, length, (long[])array);
            }
            else if (typeof(double).IsAssignableFrom(type))
            {
                res = env.NewDoubleArrayPtr(length);
                env.SetDoubleArrayRegion(res, 0, length, (double[])array);
            }
            else if (typeof(byte).IsAssignableFrom(type))
            {
                res = env.NewByteArrayPtr(length);
                env.SetByteArrayRegion(res, 0, length, (byte[])array);
            }
            else if (typeof(short).IsAssignableFrom(type))
            {
                res = env.NewShortArrayPtr(length);
                env.SetShortArrayRegion(res, 0, length, (short[])array);
            }
            else if (typeof(float).IsAssignableFrom(type))
            {
                res = env.NewFloatArrayPtr(length);
                env.SetFloatArrayRegion(res, 0, length, (float[])array);
            }
            else if (typeof(char).IsAssignableFrom(type))
            {
                res = env.NewCharArrayPtr(length);
                env.SetCharArrayRegion(res, 0, length, (char[])array);
            }
            else
            {
                throw new NotImplementedException();
            }
            return res;
        }

        public static IntPtr OptiCP2J(IJavaProxy obj)
        {
            return obj.Native;
        }

        #endregion
    }
}
