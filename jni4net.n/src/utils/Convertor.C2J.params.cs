using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
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

        #region Primitive

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

        #endregion

        public static Value[] ConverArgs(JNIEnv env, object[] args)
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
                    jargs[i] = new Value {_object = env.NewStringPtr(sarg)};
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
