// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace net.sf.jni4net.modules
{
    public class mscorlibmicroj4n
    {
        
        static private bool isModuleInitialized;
        
        static public void InitModule()
        {
            if(!isModuleInitialized) lock(typeof(mscorlibmicroj4n))
            {
                isModuleInitialized = true;
                global::net.sf.jni4net.core.Registry.RegisterModule(typeof(mscorlibmicroj4n), "net.sf.jni4net.modules.mscorlibmicroj4n", "mscorlib-micro-j4n");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IComparable_), typeof(System.IComparable), "system.nongeneric.IComparable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.IEnumerator_), typeof(System.Collections.IEnumerator), "system.collections.IEnumerator");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.IDictionaryEnumerator_), typeof(System.Collections.IDictionaryEnumerator), "system.collections.IDictionaryEnumerator");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.IEnumerable_), typeof(System.Collections.IEnumerable), "system.collections.IEnumerable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Runtime.Serialization.ISerializable_), typeof(System.Runtime.Serialization.ISerializable), "system.runtime.serialization.ISerializable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Security.IEvidenceFactory_), typeof(System.Security.IEvidenceFactory), "system.security.IEvidenceFactory");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IConvertible_), typeof(System.IConvertible), "system.IConvertible");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IDisposable_), typeof(System.IDisposable), "system.IDisposable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IFormattable_), typeof(System.IFormattable), "system.IFormattable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IFormatProvider_), typeof(System.IFormatProvider), "system.IFormatProvider");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.ICloneable_), typeof(System.ICloneable), "system.ICloneable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.IAsyncResult_), typeof(System.IAsyncResult), "system.IAsyncResult");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Reflection.ICustomAttributeProvider_), typeof(System.Reflection.ICustomAttributeProvider), "system.reflection.ICustomAttributeProvider");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Reflection.IReflect_), typeof(System.Reflection.IReflect), "system.reflection.IReflect");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.ICollection_), typeof(System.Collections.ICollection), "system.collections.ICollection");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.IDictionary_), typeof(System.Collections.IDictionary), "system.collections.IDictionary");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(System.Collections.IList_), typeof(System.Collections.IList), "system.collections.IList");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IComparable_), typeof(System.IComparable), "system.nongeneric.IComparable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.IEnumerator_), typeof(System.Collections.IEnumerator), "system.collections.IEnumerator");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.IDictionaryEnumerator_), typeof(System.Collections.IDictionaryEnumerator), "system.collections.IDictionaryEnumerator");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.IEnumerable_), typeof(System.Collections.IEnumerable), "system.collections.IEnumerable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Runtime.Serialization.ISerializable_), typeof(System.Runtime.Serialization.ISerializable), "system.runtime.serialization.ISerializable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Security.IEvidenceFactory_), typeof(System.Security.IEvidenceFactory), "system.security.IEvidenceFactory");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IConvertible_), typeof(System.IConvertible), "system.IConvertible");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IDisposable_), typeof(System.IDisposable), "system.IDisposable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IFormattable_), typeof(System.IFormattable), "system.IFormattable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IFormatProvider_), typeof(System.IFormatProvider), "system.IFormatProvider");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.ICloneable_), typeof(System.ICloneable), "system.ICloneable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IAsyncResult_), typeof(System.IAsyncResult), "system.IAsyncResult");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.ICustomAttributeProvider_), typeof(System.Reflection.ICustomAttributeProvider), "system.reflection.ICustomAttributeProvider");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.IReflect_), typeof(System.Reflection.IReflect), "system.reflection.IReflect");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Nullable_), typeof(System.Nullable), "system.nongeneric.Nullable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.String_), typeof(string), "system.String");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.ValueType_), typeof(System.ValueType), "system.ValueType");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.MarshalByRefObject_), typeof(System.MarshalByRefObject), "system.MarshalByRefObject");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.DateTime_), typeof(System.DateTime), "system.DateTime");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Decimal_), typeof(System.Decimal), "system.Decimal");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Guid_), typeof(System.Guid), "system.Guid");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Enum_), typeof(System.Enum), "system.Enum");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Boolean_), typeof(bool), "system.Boolean");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Byte_), typeof(byte), "system.Byte");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Double_), typeof(double), "system.Double");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Single_), typeof(float), "system.Single");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Int32_), typeof(int), "system.Int32");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Int64_), typeof(long), "system.Int64");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Int16_), typeof(short), "system.Int16");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Char_), typeof(char), "system.Char");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.UInt32_), typeof(uint), "system.UInt32");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.UInt64_), typeof(ulong), "system.UInt64");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.UInt16_), typeof(ushort), "system.UInt16");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.SByte_), typeof(sbyte), "system.SByte");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IntPtr_), typeof(System.IntPtr), "system.IntPtr");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.UIntPtr_), typeof(System.UIntPtr), "system.UIntPtr");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Exception_), typeof(System.Exception), "system.Exception");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.SystemException_), typeof(System.SystemException), "system.SystemException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.NullReferenceException_), typeof(System.NullReferenceException), "system.NullReferenceException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.ArgumentException_), typeof(System.ArgumentException), "system.ArgumentException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IO.IOException_), typeof(System.IO.IOException), "system.io.IOException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.NotImplementedException_), typeof(System.NotImplementedException), "system.NotImplementedException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.NotSupportedException_), typeof(System.NotSupportedException), "system.NotSupportedException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.InvalidOperationException_), typeof(System.InvalidOperationException), "system.InvalidOperationException");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IO.Stream_), typeof(System.IO.Stream), "system.io.Stream");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Console_), typeof(System.Console), "system.Console");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Environment_), typeof(System.Environment), "system.Environment");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IO.TextWriter_), typeof(System.IO.TextWriter), "system.io.TextWriter");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IO.TextReader_), typeof(System.IO.TextReader), "system.io.TextReader");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.ICollection_), typeof(System.Collections.ICollection), "system.collections.ICollection");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.CharEnumerator_), typeof(System.CharEnumerator), "system.CharEnumerator");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Runtime.Serialization.SerializationInfo_), typeof(System.Runtime.Serialization.SerializationInfo), "system.runtime.serialization.SerializationInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Runtime.Serialization.StreamingContext_), typeof(System.Runtime.Serialization.StreamingContext), "system.runtime.serialization.StreamingContext");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Delegate_), typeof(System.Delegate), "system.Delegate");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.MulticastDelegate_), typeof(System.MulticastDelegate), "system.MulticastDelegate");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.AsyncCallback_), typeof(System.AsyncCallback), "system.AsyncCallback");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.MemberInfo_), typeof(System.Reflection.MemberInfo), "system.reflection.MemberInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.Assembly_), typeof(System.Reflection.Assembly), "system.reflection.Assembly");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.PropertyInfo_), typeof(System.Reflection.PropertyInfo), "system.reflection.PropertyInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.FieldInfo_), typeof(System.Reflection.FieldInfo), "system.reflection.FieldInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.ParameterInfo_), typeof(System.Reflection.ParameterInfo), "system.reflection.ParameterInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.BindingFlags_), typeof(System.Reflection.BindingFlags), "system.reflection.BindingFlags");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.MethodBase_), typeof(System.Reflection.MethodBase), "system.reflection.MethodBase");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Environment_.SpecialFolder_), typeof(System.Environment.SpecialFolder), "system.Environment$SpecialFolder");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.IDictionary_), typeof(System.Collections.IDictionary), "system.collections.IDictionary");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Type_), typeof(System.Type), "system.Type");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.IO.FileStream_), typeof(System.IO.FileStream), "system.io.FileStream");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Collections.IList_), typeof(System.Collections.IList), "system.collections.IList");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.ConstructorInfo_), typeof(System.Reflection.ConstructorInfo), "system.reflection.ConstructorInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Reflection.MethodInfo_), typeof(System.Reflection.MethodInfo), "system.reflection.MethodInfo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Array_), typeof(System.Array), "system.Array");
            }
        }
    }
}

#endregion Component Designer generated code
