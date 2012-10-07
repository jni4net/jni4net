using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IKnownTypes
    {
        IMType SystemObject { get; set; }
        IMType SystemString { get; set; }
        IMType SystemException { get; set; }
        IMType SystemType { get; set; }

        IMType ClrBool { get; set; }
        IMType ClrByte { get; set; }
        IMType ClrChar { get; set; }
        IMType ClrShort { get; set; }
        IMType ClrInt { get; set; }
        IMType ClrLong { get; set; }
        IMType ClrFloat { get; set; }
        IMType ClrDouble { get; set; }

        IMType ClrSByte { get; set; }
        IMType ClrUShort { get; set; }
        IMType ClrUInt { get; set; }
        IMType ClrULong { get; set; }
        IMType ClrVoid { get; set; }
        IMType ClrIntPtr { get; set; }
        IMType ClrUIntPtr { get; set; }

        IMType JavaLangObject { get; set; }
        IMType JavaLangString { get; set; }
        IMType JavaLangThrowable { get; set; }
        IMType JavaLangClass { get; set; }
        IMType JavaLangVoid { get; set; }

        IMType JavaLangBoolean { get; set; }
        IMType JavaLangByte { get; set; }
        IMType JavaLangCharacter { get; set; }
        IMType JavaLangShort { get; set; }
        IMType JavaLangInteger { get; set; }
        IMType JavaLangLong { get; set; }
        IMType JavaLangFloat { get; set; }
        IMType JavaLangDouble { get; set; }

        IMType JvmBool { get; set; }
        IMType JvmByte { get; set; }
        IMType JvmChar { get; set; }
        IMType JvmShort { get; set; }
        IMType JvmInt { get; set; }
        IMType JvmLong { get; set; }
        IMType JvmFloat { get; set; }
        IMType JvmDouble { get; set; }
        IMType JvmVoid { get; set; }
    }
}
