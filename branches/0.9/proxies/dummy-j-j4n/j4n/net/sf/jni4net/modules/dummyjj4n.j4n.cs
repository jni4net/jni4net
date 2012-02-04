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
    public class dummyjj4n
    {
        
        static private bool isModuleInitialized;
        
        static public void InitModule()
        {
            if(!isModuleInitialized) lock(typeof(dummyjj4n))
            {
                isModuleInitialized = true;
                global::net.sf.jni4net.core.Registry.RegisterModule(typeof(dummyjj4n), "net.sf.jni4net.modules.dummyjj4n", "dummy-j-j4n");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Foobararable_), typeof(dummy.jvm.Foobararable), "dummy.jvm.Foobararable");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Arrays), typeof(dummy.jvm.Arrays), "dummy.jvm.Arrays");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces), typeof(dummy.jvm.Interfaces), "dummy.jvm.Interfaces");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.Bar_), typeof(dummy.jvm.Interfaces.Bar), "dummy.jvm.Interfaces$Bar");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.Foo_), typeof(dummy.jvm.Interfaces.Foo), "dummy.jvm.Interfaces$Foo");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.Goo_), typeof(dummy.jvm.Interfaces.Goo), "dummy.jvm.Interfaces$Goo");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.MyPublicY), typeof(dummy.jvm.Interfaces.MyPublicY), "dummy.jvm.Interfaces$MyPublicY");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.MyPublicZ), typeof(dummy.jvm.Interfaces.MyPublicZ), "dummy.jvm.Interfaces$MyPublicZ");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(dummy.jvm.Interfaces.Zoo_), typeof(dummy.jvm.Interfaces.Zoo), "dummy.jvm.Interfaces$Zoo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(dummy.jvm.Foobararable_), typeof(dummy.jvm.Foobararable), "dummy.jvm.Foobararable");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(dummy.jvm.Interfaces.Bar_), typeof(dummy.jvm.Interfaces.Bar), "dummy.jvm.Interfaces$Bar");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(dummy.jvm.Interfaces.Foo_), typeof(dummy.jvm.Interfaces.Foo), "dummy.jvm.Interfaces$Foo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(dummy.jvm.Interfaces.Goo_), typeof(dummy.jvm.Interfaces.Goo), "dummy.jvm.Interfaces$Goo");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(dummy.jvm.Interfaces.Zoo_), typeof(dummy.jvm.Interfaces.Zoo), "dummy.jvm.Interfaces$Zoo");
            }
        }
    }
}

#endregion Component Designer generated code
