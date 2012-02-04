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
    public class jni4net
    {
        
        static private bool isModuleInitialized;
        
        static public void InitModule()
        {
            if(!isModuleInitialized) lock(typeof(jni4net))
            {
                isModuleInitialized = true;
                global::net.sf.jni4net.core.Registry.RegisterModule(typeof(jni4net), "net.sf.jni4net.modules.jni4net", "jni4net");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(java.lang.Object), typeof(java.lang.Object), "java.lang.Object");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(net.sf.jni4net.Out), typeof(net.sf.jni4net.Out), "net.sf.jni4net.Out");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(net.sf.jni4net.Ref), typeof(net.sf.jni4net.Ref), "net.sf.jni4net.Ref");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(System.Object_), typeof(object), "system.Object");
                global::net.sf.jni4net.core.Registry.RegisterClrProxy(typeof(net.sf.jni4net.CurrentBridgeSetup_), typeof(net.sf.jni4net.CurrentBridgeSetup), "net.sf.jni4net.CurrentBridgeSetup");
            }
        }
    }
}

#endregion Component Designer generated code
