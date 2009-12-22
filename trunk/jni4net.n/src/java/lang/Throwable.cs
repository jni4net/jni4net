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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using java.io;
using net.sf.jni4net;
using net.sf.jni4net.adaptors;
using net.sf.jni4net.jni;

namespace java.lang
{
    [Serializable]
    partial class Throwable : global::System.Exception, IJvmProxy
    {
        internal Class clazz;
        private JavaVM javaVM;
        internal IntPtr jvmHandle;

        protected Throwable(SerializationInfo info, StreamingContext context) 
            //: base(info, context)
        {

            //int len = info.GetInt32("lenght");
            byte[] data = (byte[])info.GetValue("exception", typeof(byte[]));
            using (var bai = Adapt.Disposable(new ByteArrayInputStream(data)))
            {
                using (var ois = Adapt.Disposable(new ObjectInputStream(bai.Real)))
                {
                    Object exception = ois.Real.readObject();
                    ((IJvmProxy)this).Copy(JNIEnv.ThreadEnv, ((IJvmProxy)exception).JvmHandle, exception.getClass());
                }
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            using (var bao = Adapt.Disposable(new ByteArrayOutputStream()))
            {
                using (var oos = Adapt.Disposable(new ObjectOutputStream(bao.Real)))
                {
                    oos.Real.writeObject(Bridge.Cast<Object>(this));
                    byte[] data = bao.Real.toByteArray();
                    //info.AddValue("length", data.Length);
                    info.AddValue("exception", data);
                }
            }
        }
        
        protected internal Throwable(JNIEnv env)
        {
        }

        protected JNIEnv Env
        {
            get { return JNIEnv.GetEnvForVm(javaVM); }
        }

        internal string NetStackTrace
        {
            get { return base.StackTrace; }
        }

#if !JNI4NET_MINI
        public override string StackTrace
        {
            get
            {
                var sb = new global::System.Text.StringBuilder();
                StackTraceElement[] objects = getStackTrace();
                foreach (StackTraceElement element in objects)
                {
                    sb.Append(' ');
                    sb.Append(' ');
                    sb.Append(' ');
                    sb.Append(' ');
                    sb.Append(element.getClassName());
                    sb.Append('.');
                    sb.Append(element.getMethodName());
                    sb.Append("() ");
                    sb.Append(element.getFileName());
                    sb.Append(':');
                    sb.Append(element.getLineNumber());
                    sb.Append('\n');
                }
                sb.Append(base.StackTrace);
                return sb.ToString();
            }
        }
#else
        //TODO
#endif

        public override string Message
        {
            get { return getMessage(); }
        }

        #region IJvmProxy Members

        IntPtr IJvmProxy.JvmHandle
        {
            get { return jvmHandle; }
            set { jvmHandle = value; }
        }

        void IJvmProxy.Init(JNIEnv env, IntPtr obj, Class clazs)
        {
            clazz = clazs;
            jvmHandle = env.NewGlobalRef(obj);
            env.DeleteLocalRef(obj);
            javaVM = env.GetJavaVM();
        }

        void IJvmProxy.Copy(JNIEnv env, IntPtr obj, Class clazs)
        {
            clazz = clazs;
            jvmHandle = env.NewGlobalRef(obj);
            javaVM = env.GetJavaVM();
        }

        void IJvmProxy.Copy(JNIEnv env, IJvmProxy src)
        {
            var srco = ((Throwable)src);
            jvmHandle = env.NewGlobalRef(srco.jvmHandle);
            clazz = srco.clazz;
            javaVM = srco.javaVM;
        }

        Class IJvmProxy.GetClass()
        {
            if (clazz == null)
            {
                FieldInfo field = GetType().GetField("staticClass", BindingFlags.Static | BindingFlags.NonPublic);
                return (Class) field.GetValue(null);
            }
            return clazz;
        }

        void IJvmProxy.Dispose()
        {
            if (jvmHandle != IntPtr.Zero)
            {
                JNIEnv env;
                JNIResult result = javaVM.AttachCurrentThreadAsDaemon(out env, null);
                if (result == JNIResult.JNI_OK)
                {
                    env.DeleteGlobalRef(this);
                }
                // we don't crash if JVM is gone already
                jvmHandle = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
        }

        #endregion

        public void Invoke(string method, string signature, params object[] args)
        {
            Env.CallVoidMethod(this, method, signature, args);
        }

        public TRes Invoke<TRes>(string method, string signature, params object[] args)
        {
            return Env.CallMethod<TRes>(this, method, signature, args);
        }

        public TRes InvokeGet<TRes>(string method, string signature, params object[] args)
        {
            return Env.GetField<TRes>(this, method, signature);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Throwable;
            if (other == null)
            {
                return false;
            }
            var value = new Value {_object = ((IJvmProxy) other).JvmHandle};
            //TODO optimizie
            return Env.CallBooleanMethod(this, "equals", "(Ljava/lang/Object;)Z", value);
        }

        public override int GetHashCode()
        {
            //TODO optimizie
            return Env.CallIntMethod(this, "hashCode", "()I");
        }

        ~Throwable()
        {
            ((IJvmProxy)this).Dispose();
        }

        public static bool operator ==(Throwable a, IJvmProxy b)
        {
            if ((object) a == null && b == null)
                return true;
            if ((object) a == null || b == null)
                return false;
            return a.Env.IsSameObject(a, b);
            //return a.jvmHandle == b.jvmHandle;
        }

        public static bool operator !=(Throwable a, IJvmProxy b)
        {
            if ((object) a == null && b == null)
                return false;
            if ((object) a == null || b == null)
                return true;
            return !a.Env.IsSameObject(a, b);
            //return a.jvmHandle != b.jvmHandle;
        }

        public override string ToString()
        {
            JNIEnv env = Env;
            if ((_toString4 == null))
            {
                _toString4 = env.GetMethodID(((IJvmProxy)this).GetClass(), "toString", "()Ljava/lang/String;");
            }
            return toString();
        }


#if !JNI4NET_MINI
        public void SetStackTrace(StackTrace trace)
        {
            try
            {
                StackTraceElement[] current = getStackTrace();
                var st = new StackTraceElement[current.Length + trace.FrameCount];
                for (int i = 0; i < current.Length; i++)
                {
                    st[i] = current[i];
                }
                for (int i = 0; i < trace.FrameCount; i++)
                {
                    StackFrame frame = trace.GetFrame(i);
                    string type = frame.GetMethod().DeclaringType.FullName;
                    string method = frame.GetMethod().Name + "()";
                    string file = frame.GetFileName();
                    int number = frame.GetFileLineNumber();
                    st[i + current.Length] = new StackTraceElement(type, method, file == null ? "" : file, number);
                }
                setStackTrace(st);
            }
            catch (Exception)
            {
                //ignore
            }
        }
#else
        //TODO
#endif
    }
}