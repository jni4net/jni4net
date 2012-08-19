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
    public class AttachedJVM : IDisposable
    {
        public AttachedThread AttachedThread { get; private set; }
        internal bool IsAttached { get; private set; }
        internal JVMInstance JVMInstance { get; private set; }

        private readonly StackTrace stackTrace;
        private bool isDisposed;

        private static int counter;
        private readonly int id;

        internal AttachedJVM(JVMInstance jvmInstance, bool attached, JNIEnv env)
        {
            id = Interlocked.Increment(ref counter);
            if (J4NBridge.currentJVM!=null)
            {
                throw new J4NException();
            }
            J4NBridge.currentJVM = this;
            IsAttached = attached;
            JVMInstance = jvmInstance;
            if (J4NBridge.currentSetup == null || J4NBridge.currentSetup.EnforceThreadDetach)
            {
                stackTrace = new StackTrace();
            }
            AttachedThread = new AttachedThread(env, stackTrace);
        }

        internal AttachedJVM(JVMInstance jvmInstance, bool attached)
        {
            id = Interlocked.Increment(ref counter);
            if (J4NBridge.currentJVM != null)
            {
                throw new J4NException();
            }
            J4NBridge.currentJVM = this;
            IsAttached = attached;
            JVMInstance = jvmInstance;
            if (J4NBridge.currentSetup == null || J4NBridge.currentSetup.EnforceThreadDetach)
            {
                stackTrace = new StackTrace();
            }
            AttachedThread = new AttachedThread(stackTrace);
        }

        public void Dispose()
        {
            isDisposed = true;

            Logger.LogWarn("JVM disposal is not implemented yet");
            return;
            /* TODO !!!
#if DEBUG
            JNIGlobalHandle.ResolveHandles();
#endif
            Registry.Unload1();

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();

            J4NBridge.isInitialized = false;
            J4NBridge.currentSetup.DefaultClassLoader = null;

            Registry.Unload2();
            MethodWrapper.Unload();

            AttachedThread.Dispose();

            J4NBridge.currentJVM = null;
            JNIEnv.gcthreadJNIEnv = null;

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();

#if DEBUG
            JNIGlobalHandle.DumpHandles();
            LongClrHandle.DumpHandles();
#endif

            //Thread.Sleep(int.MaxValue);
            //JVMInstance.DestroyJavaVM();

            //TODO unload DLL
             */
        }

        ~AttachedJVM()
        {
            if (!isDisposed && J4NBridge.currentSetup.EnforceThreadDetach)
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
                Logger.LogWarn("AttachedJVM "+id+" was not disposed properly. Please call AttachedJVM.Dispose() or use using pattern.\n" + sb);
            }
        }
    }
}