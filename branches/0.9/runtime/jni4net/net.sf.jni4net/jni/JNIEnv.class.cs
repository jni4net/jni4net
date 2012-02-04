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
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        /*public IntPtr FindClassG(string className)
        {
            return NewGlobalRef(FindClass(className));
        }

        public IntPtr FindClassGNoThrow(string className)
        {
            var ptr = FindClassNoThrow(className);
            if (ptr == IntPtr.Zero)
            {
                return IntPtr.Zero;
            }
            return NewGlobalRef(ptr);
        }*/

        public IntPtr FindClass(string className)
        {
            string name = className.Replace(".", "/");
            IntPtr clazz = Functions.findClass(envPtr, name);
            try
            {
                ExceptionTest();
            }
            catch (J4NException ex)
            {
                if (ex.Message == J4NException.cantThrowAlreadyPending)
                {
                    throw J4NException.ExceptionAlreadyPending(className, ex);
                }
            }
            return clazz;
        }

        public IntPtr FindClassNoThrow(string className)
        {
            string name = className.Replace(".", "/");
            IntPtr clazz = Functions.findClass(envPtr, name);
            if (ExceptionCheck())
            {
#if DEBUG
                ExceptionDescribe();
#endif
                ExceptionClear();
                Logger.LogDebug("Can't find class for " + className);
                return IntPtr.Zero;
            }
            return clazz;
        }
        
        public IntPtr GetObjectClass(IJvmProxy obj)
        {
            return GetObjectClass(obj.JvmHandle);
        }

        public IntPtr GetObjectClass(IntPtr obj)
        {
            IntPtr res = Functions.getObjectClass(envPtr, obj);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectClassNoCheck(IntPtr obj)
        {
            return Functions.getObjectClass(envPtr, obj);
        }
    }
}
