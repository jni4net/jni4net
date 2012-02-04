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
using java.lang;
using net.sf.jni4net.jni.utils;

namespace net.sf.jni4net.jni
{
    public partial class JNIEnv
    {
        public IntPtr NewObject(IntPtr clazz, IntPtr methodID, JNIValue[] args)
        {
            IntPtr res = Functions.newObject(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }
        
        public IntPtr NewObject(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return NewObject(clazz.JvmHandle, methodID, args);
        }

        public JNIGlobalHandle NewObjectG(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if(methodID==IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = NewObject(clazz.JvmHandle, methodID, args);
            return NewGlobalRef(lh);
        }
    }
}
