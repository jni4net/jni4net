using System;
using System.Runtime.Serialization;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.tested
{
    [Serializable]
    partial class JavaInstanceFields : ISerializable
    {
        #region ISerializable

        protected JavaInstanceFields(SerializationInfo info, StreamingContext context)
        {
            var handle = (IntPtr) info.GetValue("handle", typeof (IntPtr));
            ((IJvmProxy) this).Copy(JNIEnv.ThreadEnv, handle, null);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("handle", ((IJvmProxy) this).JvmHandle);
        }

        #endregion
    }
}
