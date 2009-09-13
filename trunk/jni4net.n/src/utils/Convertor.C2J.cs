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
        public static IntPtr FullC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J(env, obj);
        }

        public static IntPtr ArrayFullC2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            Type elementType = typeof(TBoth).GetElementType();
            return ArrayC2J(env, (Array)(object)obj, elementType);
        }

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
            return record.CreateCLRProxy(env, ptr, IClrProxy_._class);
        }

        private static IntPtr C2J(JNIEnv env, object obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            var proxy = obj as IJavaProxy;
            if (proxy != null)
            {
                return proxy.Native;
            }
            Type type = obj.GetType();
            if (type.IsPrimitive)
            {
                return PrimC2J(env, obj, type);
            }
            var array = obj as Array;
            if (array != null)
            {
                Type elementType = array.GetType().GetElementType();
                return ArrayC2J(env, array, elementType);
            }

            RegistryRecord record = Registry.Default.GetCLRRecord(type);
            return record.CreateJVMProxy(env, obj);
        }

        private static IntPtr PrimC2J(JNIEnv env, object obj, Type type)
        {
            if (type == typeof(int) || type == typeof(uint))
            {
                Value value = ParPrimC2J((int)obj);
                return env.CallStaticObjectMethodPtr(Integer.staticClass, intObject, value);
            }
            if (type == typeof(long) || type == typeof(ulong))
            {
                Value value = ParPrimC2J((long)obj);
                return env.CallStaticObjectMethodPtr(Long.staticClass, longObject, value);
            }
            if (type == typeof(bool))
            {
                Value value = ParPrimC2J((bool)obj);
                return env.CallStaticObjectMethodPtr(Boolean.staticClass, boolObject, value);
            }
            if (type == typeof(double))
            {
                Value value = ParPrimC2J((double)obj);
                return env.CallStaticObjectMethodPtr(Double.staticClass, doubleObject, value);
            }
            if (type == typeof(byte) || type == typeof(sbyte))
            {
                Value value = ParPrimC2J((byte)obj);
                return env.CallStaticObjectMethodPtr(Byte.staticClass, byteObject, value);
            }
            if (type == typeof(char))
            {
                Value value = ParPrimC2J((char)obj);
                return env.CallStaticObjectMethodPtr(Character.staticClass, charObject, value);
            }
            if (type == typeof(short) || type == typeof(ushort))
            {
                Value value = ParPrimC2J((short)obj);
                return env.CallStaticObjectMethodPtr(Short.staticClass, shortObject, value);
            }
            if (type == typeof(float))
            {
                Value value = ParPrimC2J((float)obj);
                return env.CallStaticObjectMethodPtr(Float.staticClass, floatObject, value);
            }
            throw new InvalidOperationException("Unknown simple type" + type);
        }

        private static IntPtr ArrayC2J(JNIEnv env, Array array, Type elementType)
        {
            Class elemClazz = Registry.Default.GetCLRRecord(elementType).JVMInterface;
            int length = array.Length;
            IntPtr res;
            if (typeof (int) == elementType)
            {
                res = env.NewIntArrayPtr(length);
                env.SetIntArrayRegion(res, 0, length, (int[]) array);
            }
            else if (typeof(long) == elementType)
            {
                res = env.NewLongArrayPtr(length);
                env.SetLongArrayRegion(res, 0, length, (long[])array);
            }
            else if (typeof(bool) == elementType)
            {
                res = env.NewBooleanArrayPtr(length);
                env.SetBooleanArrayRegion(res, 0, length, (bool[]) array);
            }
            else if (typeof (double) == elementType)
            {
                res = env.NewDoubleArrayPtr(length);
                env.SetDoubleArrayRegion(res, 0, length, (double[]) array);
            }
            else if (typeof (byte) == elementType)
            {
                res = env.NewByteArrayPtr(length);
                env.SetByteArrayRegion(res, 0, length, (byte[]) array);
            }
            else if (typeof (short) == elementType)
            {
                res = env.NewShortArrayPtr(length);
                env.SetShortArrayRegion(res, 0, length, (short[]) array);
            }
            else if (typeof (float) == elementType)
            {
                res = env.NewFloatArrayPtr(length);
                env.SetFloatArrayRegion(res, 0, length, (float[]) array);
            }
            else if (typeof (char) == elementType)
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
                    jargs[i] = new Value { _object = env.NewStringPtr(sarg) };
                }
                else
                {
                    jargs[i] = new Value { _object = C2J(env, args[i]) };
                }
            }
            return jargs;
        }
    }
}
