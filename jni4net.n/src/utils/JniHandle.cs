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
    // TODO one nice day we get rid of this structure and replace it with JniHandleSafe below
    // http://stackoverflow.com/questions/2035528/how-to-get-getfunctionpointerfordelegate-for-method-with-safehandle-or-workaround
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct JniHandle
    {
        internal IntPtr handle;

        public static bool IsNull(JniHandle handle)
        {
            return handle.handle == IntPtr.Zero;
        }

        public IntPtr DangerousGetHandle()
        {
            return handle;
        }

        public bool IsInvalid()
        {
            return handle == IntPtr.Zero;
        }

        public static implicit operator JniHandle(JniLocalHandle nonsafe)
        {
            return new JniHandle {handle = nonsafe.handle};
        }

        public static implicit operator JniHandle(JniGlobalHandle safe)
        {
            return safe.DangerousGetHandle();
        }
    }
}
