using System;
using java.lang;
using net.sf.jni4net.jni;
using String = java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr FinalC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            RegistryRecord record = Registry.Default.GetCLRRecord(typeof(TBoth));
            return record.CreateJVMProxy(env, obj);
        }

        public static IntPtr ArrayC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J(env, obj);
        }

        public static IntPtr FinalC2J(JNIEnv env, string obj)
        {
            RegistryRecord record = Registry.Default.GetCLRRecord(typeof(string));
            return record.CreateJVMProxy(env, obj);
        }

        public static IntPtr FinalCp2J(IJavaProxy obj)
        {
            return obj.Native;
        }

        public static IntPtr SameC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J<TBoth>(env, obj);
        }

        public static IntPtr ConvC2J<TRes, TIn>(JNIEnv env, TIn obj)
        {
            return C2J<TRes, TIn>(env, obj);
        }


        ////////////////////////////////////////////////////////

        public static Value ParFinalCp2J(IJavaProxy obj)
        {
            var res = new Value { _object = FinalCp2J(obj) };
            return res;
        }

        public static Value ParFinalC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = FinalC2Jp<TBoth>(env, obj) };
            return res;
        }

        public static Value ParArrayC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = ArrayC2J<TBoth>(env, obj) };
            return res;
        }
        
        public static Value ParSameC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = SameC2J<TBoth>(env, obj) };
            return res;
        }

        public static Value ParFinalC2J(JNIEnv env, string obj)
        {
            var res = new Value { _object = FinalC2J(env, obj) };
            return res;
        }

        public static Value ParPrimC2J(int value)
        {
            var res = new Value { _int = value };
            return res;
        }

        public static Value ParPrimC2J(bool value)
        {
            var res = new Value { _bool = value ? (byte)1 : (byte)0 };
            return res;
        }

        public static Value ParPrimC2J(byte value)
        {
            var res = new Value { _byte = value };
            return res;
        }

        public static Value ParPrimC2J(char value)
        {
            var res = new Value { _char = (short)value };
            return res;
        }

        public static Value ParPrimC2J(short value)
        {
            var res = new Value { _short = value };
            return res;
        }

        public static Value ParPrimC2J(long value)
        {
            var res = new Value { _long = value };
            return res;
        }

        public static Value ParPrimC2J(float value)
        {
            var res = new Value { _float = value };
            return res;
        }

        public static Value ParPrimC2J(double value)
        {
            var res = new Value { _double = value };
            return res;
        }
    
    
    }
}
