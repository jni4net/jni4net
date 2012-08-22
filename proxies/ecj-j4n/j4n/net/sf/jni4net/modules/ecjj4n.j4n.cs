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
    public class ecjj4n
    {
        
        static private bool isModuleInitialized;
        
        static public void InitModule()
        {
            if(!isModuleInitialized) lock(typeof(ecjj4n))
            {
                isModuleInitialized = true;
                global::net.sf.jni4net.core.Registry.RegisterModule(typeof(ecjj4n), "net.sf.jni4net.modules.ecjj4n", "ecj-j4n");
                global::net.sf.jni4net.core.Registry.RegisterJvmProxy(typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler), typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler), "org.eclipse.jdt.core.compiler.batch.BatchCompiler");
            }
        }
    }
}

#endregion Component Designer generated code
