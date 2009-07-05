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
using System.Runtime.InteropServices;

namespace net.sf.jni4net.utils
{
    public class IntHandle
    {
        public static void Free(int ptr)
        {
            GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(ptr));
            tgt.Free();
        }

        public static object ToObject(int ptr)
        {
            GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(ptr));
            return tgt.Target;
        }

        public static int Alloc(object real)
        {
            GCHandle handle = GCHandle.Alloc(real);
            return GCHandle.ToIntPtr(handle).ToInt32();
        }
    }
}