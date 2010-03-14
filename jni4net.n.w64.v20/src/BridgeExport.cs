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
                string jni4net = typeof (BridgeExport).Assembly.Location.Replace(".w64.v20", "");
                string oldDir = Environment.CurrentDirectory;
                try
                {
                    Environment.CurrentDirectory = Path.GetDirectoryName(jni4net);
                    Assembly assembly = Assembly.LoadFile(jni4net);
                    Type type = assembly.GetType("net.sf.jni4net.Bridge");
                    MethodInfo method = type.GetMethod("initDotNetImpl", BindingFlags.NonPublic | BindingFlags.Static);
                    object res = method.Invoke(null, new object[] { envi, clazz });
                    return (int)res;
                }
                finally
                {
                    Environment.CurrentDirectory = oldDir;
                }
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
