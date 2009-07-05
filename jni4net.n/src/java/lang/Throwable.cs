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
using net.sf.jni4net.jni;

namespace java.lang
{
    unsafe partial class Throwable : global::System.Exception, IJavaProxy, IDisposable
    {
        internal Class clazz;
        private JavaVM javaVM;
        internal Object.JavaPtr* native;

        protected internal Throwable(JNIEnv env)
        {
        }

        protected JNIEnv Env
        {
            get { return JNIEnv.GetEnv(javaVM); }
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

        #region IJavaProxy Members

        Object.JavaPtr* IJavaProxy.Native
        {
            get { return native; }
            set { native = value; }
        }

        void IJavaProxy.Init(JNIEnv env, Object.JavaPtr* obj, Class clazz)
        {
            this.clazz = clazz;
            native = env.NewGlobalRef(obj);
            env.DeleteLocalRef(obj);
            javaVM = env.GetJavaVM();
        }

        Class IJavaProxy.GetClass()
        {
            if (clazz == null)
            {
                FieldInfo field = GetType().GetField("staticClass", BindingFlags.Static | BindingFlags.NonPublic);
                return (Class) field.GetValue(null);
            }
            return clazz;
        }

        public void Dispose()
        {
            if (native != null)
            {
                JNIEnv env;
                JNIResult result = javaVM.AttachCurrentThreadAsDaemon(out env, null);
                if (result == JNIResult.JNI_OK)
                {
                    env.DeleteGlobalRef(this);
                }
                // we don't crash if JVM is gone already
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
            var other = obj as Object;
            if (other == null)
            {
                return false;
            }
            return Env.CallBooleanMethod(this, "equals", "(Ljava/lang/Object;)Z", (Object) obj);
        }

        public override int GetHashCode()
        {
            return Env.CallIntMethod(this, "hashCode", "()I");
        }

        ~Throwable()
        {
            Dispose();
        }

        public static bool operator ==(Throwable a, IJavaProxy b)
        {
            if ((object) a == null && (object) b == null)
                return true;
            if ((object) a == null || (object) b == null)
                return false;
            return a.Env.IsSameObject(a, b);
            //return a.native == b.native;
        }

        public static bool operator !=(Throwable a, IJavaProxy b)
        {
            if ((object) a == null && (object) b == null)
                return false;
            if ((object) a == null || (object) b == null)
                return true;
            return !a.Env.IsSameObject(a, b);
            //return a.native != b.native;
        }

        public override string ToString()
        {
            JNIEnv env = Env;
            if ((_toString7 == null))
            {
                _toString7 = env.GetMethodID(((IJavaProxy)this).GetClass(), "toString", "()Ljava/lang/String;");
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