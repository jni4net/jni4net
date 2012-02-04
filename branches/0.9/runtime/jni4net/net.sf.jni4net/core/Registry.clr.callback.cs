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

// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local

using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class Registry
    {
        private static void disposeClrHandle(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            LongClrHandle.Free(clrHandle);
        }

        private static long createBoxedBool(IntPtr penv, IntPtr myClazz, bool value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedByte(IntPtr penv, IntPtr myClazz, byte value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedChar(IntPtr penv, IntPtr myClazz, char value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedShort(IntPtr penv, IntPtr myClazz, short value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedInteger(IntPtr penv, IntPtr myClazz, int value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedLong(IntPtr penv, IntPtr myClazz, long value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedFloat(IntPtr penv, IntPtr myClazz, float value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedDouble(IntPtr penv, IntPtr myClazz, double value)
        {
            return LongClrHandle.Alloc(value);
        }

        private static long createBoxedString(IntPtr penv, IntPtr myClazz, IntPtr value)
        {
            var env = new JNIEnv(penv);
            var str = env.GetString(value);
            return LongClrHandle.Alloc(str);
        }

        private static bool unboxBool(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (bool)LongClrHandle.ToObject(clrHandle);
        }
        private static byte unboxByte(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (byte)LongClrHandle.ToObject(clrHandle);
        }
        private static char unboxChar(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (char)LongClrHandle.ToObject(clrHandle);
        }
        private static short unboxShort(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (short)LongClrHandle.ToObject(clrHandle);
        }
        private static int unboxInteger(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (int)LongClrHandle.ToObject(clrHandle);
        }
        private static long unboxLong(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (long)LongClrHandle.ToObject(clrHandle);
        }
        private static float unboxFloat(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (float)LongClrHandle.ToObject(clrHandle);
        }
        private static double unboxDouble(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            return (double)LongClrHandle.ToObject(clrHandle);
        }

        private static IntPtr unboxString(IntPtr penv, IntPtr myClazz, long clrHandle)
        {
            var str = (string) LongClrHandle.ToObject(clrHandle);
            var env=new JNIEnv(penv);
            return ConvertString.ToPtr(env,str);
        }

        private static int registerNative(IntPtr penv, IntPtr myClazz, IntPtr pbackingFullName)
        {
            string backingFullName = "";
            var env = new JNIEnv(penv);
            using (new LocalFrame(env))
            {
                try
                {
                    backingFullName = env.GetString(pbackingFullName);
                    Logger.LogDebug("Registry.RegisterNative() " + backingFullName);
                    var clrBacking = Type.GetType(backingFullName, true);
                    return InitClrProxy(clrBacking, env) != null ? 0 : -1;
                }
                catch (Exception ex)
                {
                    Logger.LogError("registerNative failed on " + backingFullName, ex);
                    env.ThrowExisting(ex);
                    return default(int);
                }
            }
        }
    }
}
