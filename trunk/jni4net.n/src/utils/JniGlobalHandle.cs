#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct JniGlobalHandleNs
    {
        internal IntPtr handle;
    }

    [Serializable]
    public sealed class JniGlobalHandle : SafeHandle
    {
        public static bool IsNull(JniGlobalHandle handle)
        {
            return handle == null || handle.IsInvalid;
        }

        internal JavaVM javaVM;

        private static readonly JniGlobalHandle zero = new JniGlobalHandle(IntPtr.Zero, null);

        public new JniHandle DangerousGetHandle()
        {
            return new JniHandle { handle = base.DangerousGetHandle() };
        }

        public static JniGlobalHandle Zero
        {
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            get { return zero; }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public JniGlobalHandle(IntPtr handleValue, JavaVM javaVM)
            : base(IntPtr.Zero, true)
        {
            this.javaVM = javaVM;
            SetHandle(handleValue);
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public JniGlobalHandle(JniGlobalHandleNs handleValue, JavaVM javaVM)
            : base(IntPtr.Zero, true)
        {
            this.javaVM = javaVM;
            SetHandle(handleValue.handle);
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        private JniGlobalHandle()
            : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid
        {
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            get { return handle == IntPtr.Zero; }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            try
            {
                if (handle != IntPtr.Zero)
                {
                    JNIEnv env = JNIEnv.GetEnvNoThrow(javaVM);
                    if (env == null)
                    {
                        return false;
                    }
                    env.DeleteGlobalRef(this);
                }
                return true;
            }
            finally
            {
                handle = IntPtr.Zero;
            }
        }

        /// <summary>
        /// empty operation
        /// trick to retain JVM handle till this point, protect from gc
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void HoldThisHandle()
        {
            //empty operation
        }
    }
}