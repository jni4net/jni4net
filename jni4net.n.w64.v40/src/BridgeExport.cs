#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using selvin.exportdllattribute;

namespace net.sf.jni4net
{
    internal class BridgeExport
    {
        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.Assertion | SecurityPermissionFlag.Execution)]
        [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        [ExportDll("Java_net_sf_jni4net_Bridge_initDotNet", CallingConvention.StdCall)]
        internal static int initDotNet(IntPtr envi, IntPtr clazz)
        {
            try
            {
                string jni4net = typeof (BridgeExport).Assembly.Location.Replace(".w64.v40", "");
                Assembly assembly = Assembly.LoadFile(jni4net);
                Type type = assembly.GetType("net.sf.jni4net.Bridge");
                MethodInfo method = type.GetMethod("initDotNetImpl", BindingFlags.NonPublic | BindingFlags.Static);
                object res = method.Invoke(null, new object[] { envi, clazz });
                return (int)res;
            }
            catch (NotSupportedException ex)
            {
                if (ex.Message.Contains("loadFromRemoteSources"))
                {
                    Console.Error.WriteLine("Can't init BridgeExport: DLLs are marked as unsafe. Open file properties in windows explorer and click unblock.");
                }
                Console.Error.WriteLine("Can't init BridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init BridgeExport:" + ex);
                return -101;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init BridgeExport:" + ex.Message);
                Console.Error.WriteLine("Can't init BridgeExport:" + ex);
                return -100;
            }
        }
    }
}
