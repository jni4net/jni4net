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