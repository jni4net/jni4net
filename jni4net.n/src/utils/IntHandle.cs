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
    public static class IntHandle
    {
        public static void Free(long ptr)
        {
            GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(ptr));
            tgt.Free();
        }

        public static object ToObject(long ptr)
        {
            GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(ptr));
            return tgt.Target;
        }

        public static long Alloc(object real)
        {
            GCHandle handle = GCHandle.Alloc(real);
            return GCHandle.ToIntPtr(handle).ToInt64();
        }
    }
}