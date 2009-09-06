using System;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static Value ParamCP2J(IJavaProxy obj)
        {
            var res = new Value {_object = OptiCP2J(obj)};
            return res;
        }

        public static Value ParamC2JP(JNIEnv env, object obj)
        {
            var res = new Value {_object = OptiC2JP(env, obj)};
            return res;
        }

        //TODO generic
        public static Value ParamC2J(JNIEnv env, object obj)
        {
            var res = new Value { _object = C2J(env, obj) };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, IJavaProxy obj)
        {
            var res = new Value { _object = obj.Native };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, int value)
        {
            var res = new Value { _int = value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, bool value)
        {
            var res = new Value { _bool = value ? (byte)1 : (byte)0 };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, byte value)
        {
            var res = new Value { _byte = value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, char value)
        {
            var res = new Value { _char = (short)value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, short value)
        {
            var res = new Value { _short = value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, long value)
        {
            var res = new Value { _long = value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, float value)
        {
            var res = new Value { _float = value };
            return res;
        }

        public static Value ParamC2J(JNIEnv env, double value)
        {
            var res = new Value { _double = value };
            return res;
        }

        public static Value ParamCJPString(JNIEnv env, string str)
        {
            var res = new Value {_object = env.NewStringPtr(str) };
            return res;
        }

        public static string J2CString(JNIEnv env, IntPtr javaString)
        {
            return env.ConvertToString(javaString);
        }

        public static void InitProxy(JNIEnv env, IntPtr obj, object real)
        {
            int handle = IntHandle.Alloc(real);
            env.CallVoidMethod(obj, __IClrProxy._initProxy1, new Value { _int = handle });
        }

        public static Value[] ConverArgs(JNIEnv env, object[] args)
        {
            if (args.Length == 0)
            {
                return null;
            }
            var jargs = new Value[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                string sarg = args[i] as string;
                if (sarg != null)
                {
                    jargs[i] = new Value {_object = env.NewStringPtr(sarg)};
                }
                else
                {
                    jargs[i] = ParamC2J(env, args[i]);
                }
            }
            return jargs;
        }


    }
}
