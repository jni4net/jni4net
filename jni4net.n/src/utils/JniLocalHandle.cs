#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.utils
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct JniLocalHandle
    {
        internal IntPtr handle;

        public static JniLocalHandle Zero
        {
            get { return default(JniLocalHandle); }
        }

        public long ToInt64()
        {
            return handle.ToInt64();
        }

        public static bool IsNull(JniHandle handle)
        {
            return handle.handle == IntPtr.Zero;
        }

        public JniHandle DangerousGetHandle()
        {
            return new JniHandle {handle = handle};
        }

        public bool IsInvalid()
        {
            return handle == IntPtr.Zero;
        }
    }
}