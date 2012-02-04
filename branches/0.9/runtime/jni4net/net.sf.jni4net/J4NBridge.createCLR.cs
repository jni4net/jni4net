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
using net.sf.jni4net.jni;

namespace net.sf.jni4net
{
    partial class J4NBridge
    {
        internal static int initDotNetImpl(IntPtr penv, IntPtr pclazz, IntPtr initialJavaSetup)
        {
            JNIEnv env = null;
            try
            {
                try
                {
                    env = new JNIEnv(penv);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Can't bind env:\n" + ex.Message);
                    Console.Error.WriteLine("Can't bind env:\n" + ex);
                    return -3;
                }
                using (new LocalFrame(env, 1000))
                {
                    var initialSetup = new BridgeSetup();
                    initialSetup.BindClrProxies = true;
                    initialSetup.EnforceThreadDetach = false;
                    initialSetup.AllowJVMJoin = true;
                    if (initialJavaSetup != IntPtr.Zero)
                    {
                        initialSetup.JVMCoreLib = env.GetStringField(initialJavaSetup, "jvmCoreLib");
                        initialSetup.CLRCoreLib = env.GetStringField(initialJavaSetup, "clrCoreLib");
                        initialSetup.JavaHome = env.GetStringField(initialJavaSetup, "javaHome");
                        initialSetup.LogLevel = (LogLevel)env.GetIntField(initialJavaSetup, "logLevel");
                        //TODO log redirect
                    }
                    CreateBridge(initialSetup, false, null);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Console.Error.WriteLine("Can't bind bridge:" + ex.Message);
                    Console.Error.WriteLine("Can't bind bridge:" + ex);
                    if (env != null)
                    {
                        var exClazz = env.FindClass("net/sf/jni4net/J4NException");
                        env.ThrowNew(exClazz, ex.Message);
                    }
                    else
                    {
                        return -6;
                    }
                    return -4;
                }
                catch (Exception)
                {
                    return -5;
                }
            }
            return 0;
        }
    }
}
