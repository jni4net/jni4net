using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static Class J2CClass(JNIEnv env, IntPtr obj)
        {
            Class res = new Class(env);
            ((IJavaProxy)res).Init(env, obj, Class._class);
            return res;
        }

        public static String J2CString(JNIEnv env, IntPtr obj)
        {
            String res = new String(env);
            ((IJavaProxy)res).Init(env, obj, String._class);
            return res;
        }

        public static Object J2CObject(JNIEnv env, IntPtr obj)
        {
            Object res = new Object(env);
            ((IJavaProxy)res).Init(env, obj, Object._class);
            return res;
        }

        public static TRes J2C<TInput, TRes>(JNIEnv env, IntPtr obj)
        {
            return J2C<TRes>(env, obj);
        }

        public static TRes J2C<TRes>(JNIEnv env, IntPtr obj)
        {
            Class clazz;
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            Type clrType = typeof(TRes);
            if (typeof(IJavaProxy).IsAssignableFrom(clrType))
            {
                //TODO all sealed ?
                if (clrType == typeof(Class))
                {
                    return (TRes)(object)J2CClass(env, obj);
                }
                clazz = env.GetObjectClass(obj);
                if (clrType == typeof(String))
                {
                    if (clazz == String._class)
                    {
                        return (TRes)(object)J2CString(env, obj);
                    }
                    return (TRes) (object) env.NewString((string) OptiJP2C(env, obj));
                }
                //This should not happen
                /*if (IClrProxy_._class.isAssignableFrom(clazz))
                {
                    return (TRes)OptiJP2C(env, obj);
                }*/
                return (TRes)OptiJ2CP(env, obj, clazz);
            }
            if (clrType.IsArray)
            {
                return (TRes)(object)J2CArray(env, obj, typeof(TRes).GetElementType());
            }

            //TODO all sealed ?
            clazz = env.GetObjectClass(obj);
            if (clrType == typeof(string) && clazz==String._class)
            {
                return (TRes)(object)env.ConvertToString(obj);
            }
            
            return (TRes)J2C(env, obj, clazz, clrType);
        }

        private static object J2C(JNIEnv env, IntPtr obj, Class clazz, Type type)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            if (IClrProxy_._class.isAssignableFrom(clazz))
            {
                return OptiJP2C(env, obj);
            }
            if (clazz.isArray())
            {
                return J2CArray(env, obj, clazz);
            }
            if (type.IsPrimitive)
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
            } 
            IJavaProxy proxy = OptiJ2CP(env, obj, clazz);
            return proxy;
        }

        private static Array J2CArray(JNIEnv env, IntPtr array, Class arrayClazz)
        {
            Class elementClass = arrayClazz.getComponentType();
            Type elementType = Registry.Default.GetJVMRecord(elementClass).CLRInterface;
            return J2CArray(env, array, elementType);
        }

        private static Array J2CArray(JNIEnv env, IntPtr array, Type elementType)
        {
            int length = env.GetArrayLength(array);
            Array res = Array.CreateInstance(elementType, length);
            if (!elementType.IsPrimitive)
            {
                for (int i = 0; i < length; i++)
                {
                    IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                    Class elementClazz = env.GetObjectClass(elementPtr);
                    object element = J2C(env, elementPtr, elementClazz, elementType);
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

        private static IJavaProxy OptiJ2CP(JNIEnv env, IntPtr obj, Class clazz)
        {
            RegistryRecord record = Registry.Default.GetRecord(env, obj, clazz);
            return record.CreateCLRProxy(env, obj, clazz);
        }

        private static object OptiJP2C(JNIEnv env, IntPtr obj)
        {
            object res = __IClrProxy.GetObject(env, obj);
            return res;
        }

    }
}
