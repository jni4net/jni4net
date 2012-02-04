#region Copyright (C) 2012 by Pavel Savara

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
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using java.io;
using java.lang;
using net.sf.jni4net;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;
using net.sf.jni4net.jni.utils;

namespace java.lang
{
    [Serializable]
    partial class Throwable : global::System.Exception, IThrowable
    {
        // ReSharper disable InconsistentNaming
        internal JNIHandle j4n_handle;
        internal JvmInstanceInfo j4n_instanceInfo;

        protected Throwable(SerializationInfo info, StreamingContext context) 
        {
            byte[] data = (byte[])info.GetValue("exception", typeof(byte[]));
            using (var bai = Adapt.Closeable(new ByteArrayInputStream(data)))
            {
                using (var ois = Adapt.Closeable(new ObjectInputStream(bai.Real)))
                {
                    var exception = (_IJvmProxy)ois.Real.readObject();
                    ((_IJvmProxy)this).SetJvmHandle(JNIEnv.ThreadEnv.NewGlobalRef(exception.JvmHandle));
                }
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            using (var bao = Adapt.Closeable(new ByteArrayOutputStream()))
            {
                using (var oos = Adapt.Closeable(new ObjectOutputStream(bao.Real)))
                {
                    oos.Real.writeObject(this);
                    byte[] data = bao.Real.toByteArray();
                    info.AddValue("exception", data);
                }
            }
        }

        protected internal Throwable(JNIEnv env, JNIHandle handle, JvmInstanceInfo instanceInfo)
        {
            j4n_handle = handle;
            j4n_instanceInfo = instanceInfo;
            /* TODO
            global::System.Exception inner = getCause();
            if (inner != null && Registry._innerException != null)
            {
                Registry._innerException.SetValue(this, inner);
            }*/
        }

        static private IJvmProxy j4n_ProxyFactory(JNIEnv j4n_env, IntPtr j4n_handle, JvmInstanceInfo instanceInfo)
        {
            return new Throwable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), instanceInfo);
        }

        internal string NetStackTrace
        {
            get { return base.StackTrace; }
        }

        public override string StackTrace
        {
            get
            {
                var sb = new global::System.Text.StringBuilder();
                StackTraceElement[] objects = getStackTrace();
                foreach (StackTraceElement element in objects)
                {
                    string className = element.getClassName();
                    if (!J4NBridge.Setup.HideJNIFromStackTrace ||  !className.Contains("j4n_ProxyFactory"))
                    {
                        sb.Append("    at ");
                        sb.Append(className);
                        sb.Append('.');
                        sb.Append(element.getMethodName());
                        sb.Append("() in ");
                        sb.Append(element.getFileName());
                        sb.Append(": line ");
                        sb.Append(element.getLineNumber());
                        sb.Append('\n');
                    }
                }
                if (base.StackTrace != null)
                {
                    if (J4NBridge.currentSetup.HideJNIFromStackTrace)
                    {
                        var netTrace = new List<string>();
                        netTrace.AddRange(base.StackTrace.Split(new[] {Environment.NewLine}, StringSplitOptions.None));
                        foreach (var line in netTrace)
                        {
                            if (!line.StartsWith("   at net.sf.jni4net.jni.JNIEnv"))
                            {
                                sb.AppendLine(line);
                            }
                        }
                    }
                    else
                    {
                        sb.Append(base.StackTrace);
                    }
                }
                return sb.ToString();
            }
        }

        public override string Message
        {
            get { return getMessage(); }
        }

        #region IJvmProxy Members

        IntPtr IJvmProxy.JvmHandle
        {
            get { return j4n_handle.Handle; }
        }

        JvmInstanceInfo IJvmProxy.InstanceInfo
        {
            get { return j4n_instanceInfo; }
        }

        void _IJvmProxy.SetJvmHandle(JNIHandle handle)
        {
            var disposable = j4n_handle as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
            j4n_handle = handle;
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            var other = obj as Throwable;
            if (other == null)
            {
                return false;
            }
            if (JNIEnv.ThreadEnv.IsSameObjectnoCheck(this, other))
            {
                return true;
            }
            return equals(other);
        }

        IClass IObject.getClass()
        {
            return j4n_instanceInfo.JVMInstance;
        }

        public Class getClass()
        {
            return (Class)j4n_instanceInfo.JVMInstance;
        }

        public override int GetHashCode()
        {
            return hashCode();
        }

        public static bool operator ==(Throwable a, IJvmProxy b)
        {
            return JNIEnv.ThreadEnv.IsSameObjectnoCheck(a, b);
        }

        public static bool operator !=(Throwable a, IJvmProxy b)
        {
            return !JNIEnv.ThreadEnv.IsSameObjectnoCheck(a, b);
        }

        public override string ToString()
        {
            return toString();
        }

        void IThrowable.SetStackTrace(StackTrace trace)
        {
            try
            {
                StackTraceElement[] current = getStackTrace();
                var st = new List<StackTraceElement>();
                for (int i = 0; i < current.Length; i++)
                {
                    st.Add(current[i]);
                }
                for (int i = 0; i < trace.FrameCount; i++)
                {
                    StackFrame frame = trace.GetFrame(i);
                    string type = frame.GetMethod().DeclaringType.FullName;
                    string method = frame.GetMethod().Name + "()";
                    string file = frame.GetFileName();
                    int number = frame.GetFileLineNumber();
                    st.Add(new StackTraceElement(type, method, file ?? "", number));
                }
                setStackTrace(st.ToArray());
            }
            catch (Exception ex)
            {
                Logger.LogError("Can't handle stack trace properly",ex);
            }
        }
    }
}