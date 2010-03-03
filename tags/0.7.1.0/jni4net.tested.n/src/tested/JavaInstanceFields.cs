using System;
using System.Runtime.Serialization;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.tested
{
    [Serializable]
    partial class JavaInstanceFields : ISerializable
    {
        #region ISerializable

        protected JavaInstanceFields(SerializationInfo info, StreamingContext context)
        {
            var handle = (JniHandle)info.GetValue("handle", typeof(JniHandle));

            JNIEnv env = JNIEnv.ThreadEnv;
            ((IJvmProxy)this).Copy(env, env.NewGlobalRef(handle));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("handle", ((IJvmProxy) this).JvmHandle.DangerousGetHandle());
        }

        #endregion
    }
}
