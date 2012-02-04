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
using net.sf.jni4net.jni.utils;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public JNIGlobalHandle NewGlobalRef(IntPtr lobj)
        {
            if (IntPtr.Zero == lobj)
            {
                throw new ArgumentNullException("lobj");
            }
            return new JNIGlobalHandle(Functions.newGlobalRef(envPtr, lobj));
        }

        public IntPtr NewLocalRef(IntPtr gobj)
        {
            if (IntPtr.Zero == gobj)
            {
                throw new ArgumentNullException("gobj");
            }
            return Functions.newLocalRef(envPtr, gobj);
        }

        public void DeleteGlobalRef(IntPtr lobj)
        {
            if (IntPtr.Zero == lobj)
            {
                throw new ArgumentNullException("lobj");
            }
            Functions.deleteGlobalRef(envPtr, lobj);
        }

        public void DeleteLocalRef(IntPtr gobj)
        {
            if (IntPtr.Zero == gobj)
            {
                throw new ArgumentNullException("gobj");
            }
            Functions.deleteLocalRef(envPtr, gobj);
        }

        public IntPtr PopLocalFrame(IntPtr result)
        {
            IntPtr res = Functions.popLocalFrame(envPtr, result);
            ExceptionTest();
            return res;
        }

        public IntPtr PopLocalFrameNoTest(IntPtr result)
        {
            IntPtr res = Functions.popLocalFrame(envPtr, result);
            return res;
        }

        public void PushLocalFrame(int capacity)
        {
            int res = Functions.pushLocalFrame(envPtr, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new J4NException("Can't allocate local frame" + res);
            }
        }
    }
}
