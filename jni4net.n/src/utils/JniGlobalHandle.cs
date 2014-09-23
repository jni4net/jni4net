#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
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