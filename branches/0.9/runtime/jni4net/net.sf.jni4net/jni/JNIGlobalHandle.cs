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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using java.lang;
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    public class JNIGlobalHandle : JNIHandle, IDisposable
    {
#if DEBUG
        private static readonly Hashtable knownHandles = new Hashtable();
#endif

        public JNIGlobalHandle(IntPtr handle)
            : base(handle)
        {
#if DEBUG
            lock (knownHandles)
            {
#if DEBUG_LEAKS_STACK
                knownHandles.Add(handle, new StackTrace());
#else
                knownHandles.Add(handle, "");
#endif
            }
#endif
        }

#if DEBUG
        public static void ResolveHandles()
        {
            JNIEnv env = JNIEnv.ThreadEnv;

            using (new LocalFrame(env, knownHandles.Count*2))
            {
                var handles = new ArrayList(knownHandles.Keys);
#if DEBUG_LEAKS_STACK
                var stacks = new ArrayList(knownHandles.Values);
#endif
                knownHandles.Clear();
                for (int i = 0; i < handles.Count; i++)
                {
                    var handle = (IntPtr)handles[i];
                    var clsLocal = env.GetObjectClass(handle);
                    IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);
                    var name = clazz.getName();
                    var toString = env.CallStringMethod(handle, Registry.javaLangObject.Members[6]);
#if DEBUG_LEAKS_STACK
                    knownHandles.Add(handle, name + " " + toString + "\r\n" + stacks[i]);
#else
                    knownHandles.Add(handle, name + " " + toString);
#endif
                }
            }
        }

        public static void DumpHandles()
        {
            if (knownHandles.Count>0)
            {
                Logger.LogWarn("There are " + knownHandles.Count+ " leaking JVM handles");
            }
            foreach (var value in knownHandles.Values)
            {
                Logger.LogDebug(value.ToString());
            }
            knownHandles.Clear();
        }

#endif

        
        public void Dispose()
        {
            try
            {
                IntPtr cpy = Handle;
                if (cpy != IntPtr.Zero)
                {
#if DEBUG
                    lock (knownHandles)
                    {
                        knownHandles.Remove(handle);
                    }
#endif
                    handle = IntPtr.Zero;
                    JNIEnv env = JNIEnv.ThreadEnvGC;
                    if (env != null)
                    {
#if SYNCGC
                        lock (J4NBridge.syncRoot)
#endif
                        {
                            env.DeleteGlobalRef(cpy);
                        }
                    }
                }
            }
            finally
            {
                GC.SuppressFinalize(this);
            }
        }

        ~JNIGlobalHandle()
        {
            Dispose();
        }

        public override string ToString()
        {
            return Handle.ToString();
        }
    }
}
