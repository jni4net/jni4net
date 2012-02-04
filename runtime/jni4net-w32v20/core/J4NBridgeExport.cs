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
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using net.sf.jni4net.jniexport;
using selvin.exportdllattribute;

namespace net.sf.jni4net.core
{
    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.Assertion | SecurityPermissionFlag.Execution)]
    [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
    [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
    [EnvironmentPermission(SecurityAction.Assert, Read = "PATH")]
    [EnvironmentPermission(SecurityAction.Assert, Write = "PATH")]
    internal static class J4NBridgeExport
    {
        private static int counter = -1;

        [ExportDll("Java_net_sf_jni4net_core_J4NBridgeExport_initDotNet", CallingConvention.StdCall)]
        public static int initDotNet(IntPtr penv, IntPtr clazz, IntPtr currentJavaSetup, IntPtr pApplicationBase, byte useNewAppdomain)
        {
            try
            {
                counter++;
                if(counter!=0)
                {
                    return -102;
                }
                JNIEnvMini env;
                string applicationBase;
                try
                {
                    env = new JNIEnvMini(penv);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Can't bind env:\n" + ex.Message);
                    Console.Error.WriteLine("Can't bind env:\n" + ex);
                    return -103;
                }
                try
                {
                    applicationBase = env.GetString(pApplicationBase);
                    Console.Error.WriteLine(applicationBase);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Can't read applicationBase:\n" + ex.Message);
                    Console.Error.WriteLine("Can't read applicationBase:\n" + ex);
                    return -104;
                }
                if(useNewAppdomain!=0)
                {
                    var domaininfo = new AppDomainSetup();
                    domaininfo.ApplicationBase = applicationBase;
                    domaininfo.ConfigurationFile = Path.Combine(applicationBase, "jni4net-n.dll.config");
                    AppDomain domain = AppDomain.CreateDomain("jni4net" + counter, null, domaininfo);

                    domain.SetData("penv", penv);
                    domain.SetData("clazz", clazz);
                    domain.SetData("currentJavaSetup", currentJavaSetup);

                    domain.DoCallBack(AppDomainDirectReference);
                    return (int)domain.GetData("result");
                }
                else
                {
                    return SameDomain(penv, clazz, currentJavaSetup);
                }

            }
            catch (NotSupportedException ex)
            {
                if (ex.Message.Contains("loadFromRemoteSources"))
                {
                    Console.Error.WriteLine("Can't init J4NBridgeExport: DLLs are marked as unsafe. Open file properties in windows explorer and click unblock.");
                }
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                return -101;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                return -100;
            }
        }

        private static void AppDomainDirectReference()
        {
            int result;
            try
            {
                var penv = (IntPtr) AppDomain.CurrentDomain.GetData("penv");
                var clazz = (IntPtr) AppDomain.CurrentDomain.GetData("clazz");
                var currentJavaSetup = (IntPtr)AppDomain.CurrentDomain.GetData("currentJavaSetup");
                result = J4NBridge.initDotNetImpl(penv, clazz, currentJavaSetup);
            }
            catch (NotSupportedException ex)
            {
                if (ex.Message.Contains("loadFromRemoteSources"))
                {
                    Console.Error.WriteLine("Can't init J4NBridgeExport: DLLs are marked as unsafe. Open file properties in windows explorer and click unblock.");
                }
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                result = -201;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                result = -200;
            }
            AppDomain.CurrentDomain.SetData("result", result);
        }

        private static int SameDomain(IntPtr penv, IntPtr clazz, IntPtr currentJavaSetup)
        {
            try
            {
                return J4NBridge.initDotNetImpl(penv, clazz, currentJavaSetup);
            }
            catch (NotSupportedException ex)
            {
                if (ex.Message.Contains("loadFromRemoteSources"))
                {
                    Console.Error.WriteLine("Can't init J4NBridgeExport: DLLs are marked as unsafe. Open file properties in windows explorer and click unblock.");
                }
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                return -301;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init J4NBridgeExport:" + ex);
                return -300;
            }
        }
    
    }
}
