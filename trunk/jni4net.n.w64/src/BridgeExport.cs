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
                string jni4net = typeof (BridgeExport).Assembly.Location.Replace(".w64", "");
                string oldDir = Environment.CurrentDirectory;
                Environment.CurrentDirectory = Path.GetDirectoryName(jni4net);
                Assembly assembly = Assembly.LoadFile(jni4net);
                Type type = assembly.GetType("net.sf.jni4net.Bridge");
                MethodInfo method = type.GetMethod("initDotNetImpl", BindingFlags.NonPublic | BindingFlags.Static);
                object res = method.Invoke(null, new object[] { envi, clazz });
                Environment.CurrentDirectory = oldDir;
                return (int)res;
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
