using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using java.lang;
using java_.lang;
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public IObject NewObject(Class clazz, string method, string sig, params object[] args)
        {
            MethodId idNative = GetMethodID(clazz, method, sig);
            if (idNative != null)
            {
                return NewObject(clazz, idNative, Convertor.ConverArgs(this, args));
            }
            throw new ArgumentException();
        }

        public TRes CallStaticMethod<TRes>(Class clazz, string method, string sig, params object[] args)
        {
            return CallStaticMethod<TRes>(clazz, method, sig, Convertor.ConverArgs(this, args));
        }

        public void CallVoidMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            CallVoidMethod(obj, method, signature, Convertor.ConverArgs(this, args));
        }

        public object CallObjectMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            return CallObjectMethod(obj, method, signature, Convertor.ConverArgs(this, args));
        }

        public bool CallBooleanMethod(IJavaProxy obj, string method, string sig, params object[] args)
        {
            return CallBooleanMethod(obj, method, sig, Convertor.ConverArgs(this, args));
        }

        public int CallIntMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            return CallIntMethod(obj, method, signature, Convertor.ConverArgs(this, args));
        }

        public TRes CallMethod<TRes>(IJavaProxy obj, string method, string sig, params object[] args)
        {
            return CallMethod<TRes>(obj, method, sig, Convertor.ConverArgs(this, args));
        }



    }
}
