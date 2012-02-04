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
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;

namespace net.sf.jni4net
{
    public class AttachedThread : IDisposable
    {
        private LocalFrame frame;
        private JNIEnv env;
        private readonly StackTrace stackTrace;

        private static int counter;
        private readonly int id;

        public JNIEnv JNIEnv
        {
            get { return env; }
            internal set { env = value; }
        }

        internal AttachedThread(JNIEnv env, StackTrace stackTrace)
        {
            id = Interlocked.Increment(ref counter);
            this.env = env;
            JNIEnv.threadJNIEnv = env;
            this.stackTrace = stackTrace;
            if (J4NBridge.currentSetup == null || J4NBridge.currentSetup.AutoCreateLocalFrame)
            {
                frame=new LocalFrame(env, 1000);
            }
        }

        internal AttachedThread(StackTrace stackTrace)
        {
            id = Interlocked.Increment(ref counter);
            if (JNIEnv.threadJNIEnv == null)
            {
                J4NBridge.CurrentJVM.JVMInstance.AttachCurrentThreadAsDaemon(out env);
            }
            else
            {
                env = JNIEnv.threadJNIEnv;
            }
            if (J4NBridge.currentSetup == null || J4NBridge.currentSetup.AutoCreateLocalFrame)
            {
                frame = new LocalFrame(env, 1000);
            }
            this.stackTrace = stackTrace;
        }

        public void Dispose()
        {
            env = null;
            if (frame != null)
            {
                frame.Dispose();
                frame = null;
            }
            J4NBridge.CurrentJVM.JVMInstance.DetachCurrentThread();
        }

        ~AttachedThread()
        {
            if (env != null)
            {
                if (frame != null)
                {
                    frame.Dispose();
                    frame = null;
                }
                if (J4NBridge.currentSetup != null && J4NBridge.currentSetup.EnforceThreadDetach)
                {
                    var sb = new StringBuilder();
                    if (stackTrace != null)
                    {
                        foreach (StackFrame stackFrame in stackTrace.GetFrames())
                        {
                            MethodBase method = stackFrame.GetMethod();
                            if (method.DeclaringType != null)
                            {
                                sb.AppendLine(method.DeclaringType.FullName + "." + method.Name + " at " +
                                              stackFrame.GetFileLineNumber());
                            }
                            else
                            {
                                sb.AppendLine(method.Name + " at " + stackFrame.GetFileLineNumber());
                            }
                        }
                    }
                    Logger.LogWarn(
                        "AttachedThread " + id + " was not disposed properly. Please call AttachedThread.Dispose() or use using pattern.\n" +
                        sb);
                }
            }
        }
    }
}
