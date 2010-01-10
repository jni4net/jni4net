using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    // TODO one nice day we get rid of this structure and replace it with JniHandleSafe below
    // http://stackoverflow.com/questions/2035528/how-to-get-getfunctionpointerfordelegate-for-method-with-safehandle-or-workaround
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct JniHandle
    {
        internal IntPtr handle;

        public static bool IsNull(JniHandle handle)
        {
            return handle.handle == IntPtr.Zero;
        }

        public IntPtr DangerousGetHandle()
        {
            return handle;
        }

        public bool IsInvalid()
        {
            return handle == IntPtr.Zero;
        }

        public static implicit operator JniHandle(JniLocalHandle nonsafe)
        {
            return new JniHandle { handle = nonsafe.handle };
        }

        public static implicit operator JniHandle(JniGlobalHandle safe)
        {
            return safe.DangerousGetHandle();
        }

    }
}
