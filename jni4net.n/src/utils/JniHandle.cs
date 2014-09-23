#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
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

        public static JniHandle Zero;
    }
}
