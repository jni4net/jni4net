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
    public class jremicroj4n
    {
        
        static private bool isModuleInitialized;
        
        static public void InitModule()
        {
            if(!isModuleInitialized) lock(typeof(jremicroj4n))
            {
                isModuleInitialized = true;
                global::net.sf.jni4net.core.Registry.RegisterModule(typeof(jremicroj4n), "net.sf.jni4net.modules.jremicroj4n", "jre-micro-j4n");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Runnable_), typeof(java.lang.Runnable), "java.lang.Runnable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.Closeable_), typeof(java.io.Closeable), "java.io.Closeable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.Flushable_), typeof(java.io.Flushable), "java.io.Flushable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.Serializable_), typeof(java.io.Serializable), "java.io.Serializable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Map_), typeof(java.util.Map), "java.util.Map");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Iterator_), typeof(java.util.Iterator), "java.util.Iterator");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Enumeration_), typeof(java.util.Enumeration), "java.util.Enumeration");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Comparator_), typeof(java.util.Comparator), "java.util.Comparator");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Iterable_), typeof(java.lang.Iterable), "java.lang.Iterable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Member_), typeof(java.lang.reflect.Member), "java.lang.reflect.Member");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Type_), typeof(java.lang.reflect.Type), "java.lang.reflect.Type");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.TypeVariable_), typeof(java.lang.reflect.TypeVariable), "java.lang.reflect.TypeVariable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.WildcardType_), typeof(java.lang.reflect.WildcardType), "java.lang.reflect.WildcardType");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.ParameterizedType_), typeof(java.lang.reflect.ParameterizedType), "java.lang.reflect.ParameterizedType");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.GenericArrayType_), typeof(java.lang.reflect.GenericArrayType), "java.lang.reflect.GenericArrayType");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.annotation.Annotation_), typeof(java.lang.annotation.Annotation), "java.lang.annotation.Annotation");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.GenericDeclaration_), typeof(java.lang.reflect.GenericDeclaration), "java.lang.reflect.GenericDeclaration");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.AnnotatedElement_), typeof(java.lang.reflect.AnnotatedElement), "java.lang.reflect.AnnotatedElement");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Comparable_), typeof(java.lang.Comparable), "java.lang.Comparable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.CharSequence_), typeof(java.lang.CharSequence), "java.lang.CharSequence");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Appendable_), typeof(java.lang.Appendable), "java.lang.Appendable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.Writer), typeof(java.io.Writer), "java.io.Writer");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.DataInput_), typeof(java.io.DataInput), "java.io.DataInput");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectStreamConstants_), typeof(java.io.ObjectStreamConstants), "java.io.ObjectStreamConstants");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.DataOutput_), typeof(java.io.DataOutput), "java.io.DataOutput");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Cloneable_), typeof(java.lang.Cloneable), "java.lang.Cloneable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.MapNest.Entry_), typeof(java.util.MapNest.Entry), "java.util.Map$Entry");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.AbstractMap), typeof(java.util.AbstractMap), "java.util.AbstractMap");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Dictionary), typeof(java.util.Dictionary), "java.util.Dictionary");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Number), typeof(java.lang.Number), "java.lang.Number");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Boolean), typeof(java.lang.Boolean), "java.lang.Boolean");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Byte), typeof(java.lang.Byte), "java.lang.Byte");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Double), typeof(java.lang.Double), "java.lang.Double");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Float), typeof(java.lang.Float), "java.lang.Float");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Short), typeof(java.lang.Short), "java.lang.Short");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Character), typeof(java.lang.Character), "java.lang.Character");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Class), typeof(java.lang.Class), "java.lang.Class");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.ClassLoader), typeof(java.lang.ClassLoader), "java.lang.ClassLoader");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.net.URL), typeof(java.net.URL), "java.net.URL");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.net.URI), typeof(java.net.URI), "java.net.URI");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.System), typeof(java.lang.System), "java.lang.System");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.String), typeof(java.lang.String), "java.lang.String");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.InputStream), typeof(java.io.InputStream), "java.io.InputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.OutputStream), typeof(java.io.OutputStream), "java.io.OutputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.FileInputStream), typeof(java.io.FileInputStream), "java.io.FileInputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.PrintWriter), typeof(java.io.PrintWriter), "java.io.PrintWriter");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ByteArrayInputStream), typeof(java.io.ByteArrayInputStream), "java.io.ByteArrayInputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ByteArrayOutputStream), typeof(java.io.ByteArrayOutputStream), "java.io.ByteArrayOutputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.zip.ZipEntry), typeof(java.util.zip.ZipEntry), "java.util.zip.ZipEntry");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.File), typeof(java.io.File), "java.io.File");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.HashMap), typeof(java.util.HashMap), "java.util.HashMap");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Collection_), typeof(java.util.Collection), "java.util.Collection");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Arrays), typeof(java.util.Arrays), "java.util.Arrays");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Array), typeof(java.lang.reflect.Array), "java.lang.reflect.Array");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Throwable), typeof(java.lang.Throwable), "java.lang.Throwable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.StackTraceElement), typeof(java.lang.StackTraceElement), "java.lang.StackTraceElement");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Error), typeof(java.lang.Error), "java.lang.Error");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Exception), typeof(java.lang.Exception), "java.lang.Exception");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.LinkageError), typeof(java.lang.LinkageError), "java.lang.LinkageError");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.NoClassDefFoundError), typeof(java.lang.NoClassDefFoundError), "java.lang.NoClassDefFoundError");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.NoSuchFieldException), typeof(java.lang.NoSuchFieldException), "java.lang.NoSuchFieldException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.NoSuchMethodException), typeof(java.lang.NoSuchMethodException), "java.lang.NoSuchMethodException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.RuntimeException), typeof(java.lang.RuntimeException), "java.lang.RuntimeException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.ClassNotFoundException), typeof(java.lang.ClassNotFoundException), "java.lang.ClassNotFoundException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.IllegalArgumentException), typeof(java.lang.IllegalArgumentException), "java.lang.IllegalArgumentException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.IndexOutOfBoundsException), typeof(java.lang.IndexOutOfBoundsException), "java.lang.IndexOutOfBoundsException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.UnsupportedOperationException), typeof(java.lang.UnsupportedOperationException), "java.lang.UnsupportedOperationException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.NullPointerException), typeof(java.lang.NullPointerException), "java.lang.NullPointerException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.InvocationTargetException), typeof(java.lang.reflect.InvocationTargetException), "java.lang.reflect.InvocationTargetException");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Modifier), typeof(java.lang.reflect.Modifier), "java.lang.reflect.Modifier");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.AccessibleObject), typeof(java.lang.reflect.AccessibleObject), "java.lang.reflect.AccessibleObject");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Character.Subset), typeof(java.lang.Character.Subset), "java.lang.Character$Subset");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Character.UnicodeBlock), typeof(java.lang.Character.UnicodeBlock), "java.lang.Character$UnicodeBlock");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.security.SecureClassLoader), typeof(java.security.SecureClassLoader), "java.security.SecureClassLoader");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.FilterOutputStream), typeof(java.io.FilterOutputStream), "java.io.FilterOutputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectInput_), typeof(java.io.ObjectInput), "java.io.ObjectInput");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectOutput_), typeof(java.io.ObjectOutput), "java.io.ObjectOutput");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.FilterInputStream), typeof(java.io.FilterInputStream), "java.io.FilterInputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Hashtable), typeof(java.util.Hashtable), "java.util.Hashtable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Long), typeof(java.lang.Long), "java.lang.Long");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Integer), typeof(java.lang.Integer), "java.lang.Integer");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.net.URLClassLoader), typeof(java.net.URLClassLoader), "java.net.URLClassLoader");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.StringBuffer), typeof(java.lang.StringBuffer), "java.lang.StringBuffer");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.StringBuilder), typeof(java.lang.StringBuilder), "java.lang.StringBuilder");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.PrintStream), typeof(java.io.PrintStream), "java.io.PrintStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectInputStream), typeof(java.io.ObjectInputStream), "java.io.ObjectInputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectOutputStream), typeof(java.io.ObjectOutputStream), "java.io.ObjectOutputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.List_), typeof(java.util.List), "java.util.List");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Set_), typeof(java.util.Set), "java.util.Set");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.Properties), typeof(java.util.Properties), "java.util.Properties");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Constructor), typeof(java.lang.reflect.Constructor), "java.lang.reflect.Constructor");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Field), typeof(java.lang.reflect.Field), "java.lang.reflect.Field");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.reflect.Method), typeof(java.lang.reflect.Method), "java.lang.reflect.Method");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectInputStream.GetField), typeof(java.io.ObjectInputStream.GetField), "java.io.ObjectInputStream$GetField");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.io.ObjectOutputStream.PutField), typeof(java.io.ObjectOutputStream.PutField), "java.io.ObjectOutputStream$PutField");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.zip.InflaterInputStream), typeof(java.util.zip.InflaterInputStream), "java.util.zip.InflaterInputStream");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.util.zip.ZipInputStream), typeof(java.util.zip.ZipInputStream), "java.util.zip.ZipInputStream");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.Runnable_), typeof(java.lang.Runnable), "java.lang.Runnable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.Closeable_), typeof(java.io.Closeable), "java.io.Closeable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.Flushable_), typeof(java.io.Flushable), "java.io.Flushable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.Serializable_), typeof(java.io.Serializable), "java.io.Serializable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Map_), typeof(java.util.Map), "java.util.Map");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Iterator_), typeof(java.util.Iterator), "java.util.Iterator");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Enumeration_), typeof(java.util.Enumeration), "java.util.Enumeration");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Comparator_), typeof(java.util.Comparator), "java.util.Comparator");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.Iterable_), typeof(java.lang.Iterable), "java.lang.Iterable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.Member_), typeof(java.lang.reflect.Member), "java.lang.reflect.Member");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.Type_), typeof(java.lang.reflect.Type), "java.lang.reflect.Type");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.TypeVariable_), typeof(java.lang.reflect.TypeVariable), "java.lang.reflect.TypeVariable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.WildcardType_), typeof(java.lang.reflect.WildcardType), "java.lang.reflect.WildcardType");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.ParameterizedType_), typeof(java.lang.reflect.ParameterizedType), "java.lang.reflect.ParameterizedType");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.GenericArrayType_), typeof(java.lang.reflect.GenericArrayType), "java.lang.reflect.GenericArrayType");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.annotation.Annotation_), typeof(java.lang.annotation.Annotation), "java.lang.annotation.Annotation");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.GenericDeclaration_), typeof(java.lang.reflect.GenericDeclaration), "java.lang.reflect.GenericDeclaration");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.reflect.AnnotatedElement_), typeof(java.lang.reflect.AnnotatedElement), "java.lang.reflect.AnnotatedElement");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.Comparable_), typeof(java.lang.Comparable), "java.lang.Comparable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.CharSequence_), typeof(java.lang.CharSequence), "java.lang.CharSequence");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.Appendable_), typeof(java.lang.Appendable), "java.lang.Appendable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.DataInput_), typeof(java.io.DataInput), "java.io.DataInput");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.ObjectStreamConstants_), typeof(java.io.ObjectStreamConstants), "java.io.ObjectStreamConstants");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.DataOutput_), typeof(java.io.DataOutput), "java.io.DataOutput");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.lang.Cloneable_), typeof(java.lang.Cloneable), "java.lang.Cloneable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.MapNest.Entry_), typeof(java.util.MapNest.Entry), "java.util.Map$Entry");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Collection_), typeof(java.util.Collection), "java.util.Collection");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.ObjectInput_), typeof(java.io.ObjectInput), "java.io.ObjectInput");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.io.ObjectOutput_), typeof(java.io.ObjectOutput), "java.io.ObjectOutput");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.List_), typeof(java.util.List), "java.util.List");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(java.util.Set_), typeof(java.util.Set), "java.util.Set");
            }
        }
    }
}

#endregion Component Designer generated code
