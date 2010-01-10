using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct JniLocalHandle
    {
        internal IntPtr handle;

        public static JniLocalHandle Zero
        {
            get
            {
                return default(JniLocalHandle);
            }
        }

        public long ToInt64()
        {
            return handle.ToInt64();
        }

        public static bool IsNull(JniHandle handle)
        {
            return handle.handle == IntPtr.Zero;
        }

        public JniHandle DangerousGetHandle()
        {
            return new JniHandle { handle = this.handle };
        }

        public bool IsInvalid()
        {
            return handle == IntPtr.Zero;
        }
    }
}