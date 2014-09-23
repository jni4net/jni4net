#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net
{
    partial class Out
    {
        internal static void Init()
        {
            fieldID = JNIEnv.ThreadEnv.GetFieldID(_class, "value", "Ljava/lang/Object;");
        }

        private static FieldId fieldID;

        public static void SetValue<TRef>(JNIEnv env, JniLocalHandle container, TRef value)
        {
            JniHandle val = Convertor.FullC2J(env, value);
            env.SetObjectFieldPtr(container, fieldID, val);
        }
    }

    // warning: different class
    public class Out<TRef>
    {
    }
}
