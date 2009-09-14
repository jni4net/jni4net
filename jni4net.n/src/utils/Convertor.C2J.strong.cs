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
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr StrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            // ReSharper restore CompareNonConstrainedGenericWithNull
            RegistryRecord record = Registry.GetCLRRecord(obj.GetType());
            return record.CreateJVMProxy(env, obj);
        }

        public static IntPtr StrongCp2J(ICJvmProxy obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            return obj.Native;
        }

        public static IntPtr StrongC2JString(JNIEnv env, string obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            return env.NewStringPtr(obj);
        }
    }
}