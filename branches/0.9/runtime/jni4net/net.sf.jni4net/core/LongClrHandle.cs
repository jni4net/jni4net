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
using System.Collections;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.core
{
    internal static class LongClrHandle
    {
#if DEBUG
        private static readonly Hashtable knownHandles=new Hashtable();

        public static void DumpHandles()
        {
            if (knownHandles.Count > 0)
            {
                Logger.LogWarn("There are " + knownHandles.Count + " leaking CLR handles");
            }
            foreach (var value in knownHandles.Values)
            {
                Logger.LogDebug(value.ToString());
            }
            knownHandles.Clear();
        }

#endif

        public static void Free(long clrHandle)
        {
            try
            {
                GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(clrHandle));
#if DEBUG
                lock (knownHandles)
                {
                    knownHandles.Remove(clrHandle);
                }
#endif
                tgt.Free();
            }
            catch (Exception ex)
            {
                Logger.LogError("LongClrHandle " + clrHandle + " conversion failed in " + AppDomain.CurrentDomain.FriendlyName, ex);
                throw;
            }
        }

        public static object ToObject(long ptr)
        {
            try
            {
                GCHandle tgt = GCHandle.FromIntPtr(new IntPtr(ptr));
                return tgt.Target;
            }
            catch (Exception ex)
            {
                Logger.LogError("LongClrHandle " + ptr + " conversion failed in " + AppDomain.CurrentDomain.FriendlyName, ex);
                throw;
            }
        }

        public static long Alloc(object real)
        {
            GCHandle handle = GCHandle.Alloc(real);
            long clrHandle = GCHandle.ToIntPtr(handle).ToInt64();
            //Logger.LogDebug(real.GetType().FullName + " -> " + int64 + " in " + AppDomain.CurrentDomain.FriendlyName);

#if DEBUG
            lock (knownHandles)
            {
                knownHandles.Add(clrHandle, real);
            }
#endif
            
            return clrHandle;
        }
    }
}
