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
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;

namespace net.sf.jni4net
{
    public static partial class J4NBridge
    {
        private static readonly object syncRoot=new object();
        internal static bool isInitialized;
        internal static AttachedJVM currentJVM;
        internal static CurrentBridgeSetup currentSetup;

        public static CurrentBridgeSetup Setup
        {
            get
            {
                if(!isInitialized)
                {
                    throw J4NException.InitBridgeFirst();
                }
                return currentSetup;
            }
        }

        internal static AttachedJVM CurrentJVM
        {
            get
            {
                return currentJVM;
            }
        }

        /// <summary>
        /// Into default classLoader. Assuming URLClassLoader.
        /// </summary>
        public static void AddClassPath(string classPath)
        {
            string fullPath = Path.GetFullPath(classPath);
            if (!File.Exists(fullPath))
            {
                if(!Directory.Exists(fullPath))
                {
                    Logger.LogWarn("Can't find classPath " + fullPath);
                }
                else
                {
                    fullPath += "\\";
                }
            }
            lock (syncRoot)
            {
                if (!isInitialized)
                {
                    throw J4NException.InitBridgeFirst();
                }
                Logger.LogInfo("Adding to classPath " + fullPath);
                Registry.JvmCoreHooks.AddURL(currentSetup.DefaultClassLoader, fullPath);
            }
        }

        public static JNIResult AttachCurrentThreadAsDaemon()
        {
            if (!isInitialized)
            {
                throw J4NException.InitBridgeFirst();
            }
            JNIEnv env;
            return CurrentJVM.JVMInstance.AttachCurrentThreadAsDaemon(out env);
        }

        public static JNIResult DetachCurrentThread()
        {
            if (!isInitialized)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CurrentJVM.JVMInstance.DetachCurrentThread();
        }

        [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void DumpRuntimeInfoCLR()
        {
            Logger.LogInfo("clr.version         :" + RuntimeEnvironment.GetSystemVersion());
            Logger.LogInfo ("clr.arch            :" + ((IntPtr.Size == 8) ? "64bit" : "32bit"));
            Logger.LogInfo ("java.home           :" + currentSetup.JavaHome);
            Logger.LogInfo ("current.dir         :" + Directory.GetCurrentDirectory());
            Logger.LogInfo ("appdomain.base      :" + AppDomain.CurrentDomain.BaseDirectory);
            Logger.LogDebug("env.PATH            :" + Environment.GetEnvironmentVariable("PATH"));
        }

        [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void DumpRuntimeInfoJVM()
        {
            if (!isInitialized)
            {
                throw J4NException.InitBridgeFirst();
            }
            Logger.LogInfo("java.version        :" + Registry.JvmCoreHooks.systemGetProperty("java.version"));
            Logger.LogInfo("sun.arch.data.model :" + Registry.JvmCoreHooks.systemGetProperty("sun.arch.data.model")+"bit");
            Logger.LogDebug("java.class.path     :" + Registry.JvmCoreHooks.systemGetProperty("java.class.path"));
        }

    }
}
