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

namespace org.eclipse.jdt.core.compiler.batch
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler))]
    public sealed partial class BatchCompiler : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private BatchCompiler(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new org.eclipse.jdt.core.compiler.batch.BatchCompiler(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static BatchCompiler()
        {
            global::net.sf.jni4net.modules.ecjj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler));
        }
        
        /// <signature>#0 ([Ljava/lang/String;Ljava/io/PrintWriter;Ljava/io/PrintWriter;Lorg/eclipse/jdt/core/compiler/CompilationProgress;)Z ([Lsystem/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
        static public bool compile(string[] par0, global::java.lang.Object par1, global::java.lang.Object par2, global::java.lang.Object par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                return j4n_env.CallStaticBooleanMethod(org.eclipse.jdt.core.compiler.batch.BatchCompiler.j4n_Class, org.eclipse.jdt.core.compiler.batch.BatchCompiler.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.io.PrintWriter"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.io.PrintWriter"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par3, "org.eclipse.jdt.core.compiler.CompilationProgress"));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;Ljava/io/PrintWriter;Ljava/io/PrintWriter;Lorg/eclipse/jdt/core/compiler/CompilationProgress;)Z (Lsystem/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
        static public bool compile(string par0, global::java.lang.Object par1, global::java.lang.Object par2, global::java.lang.Object par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                return j4n_env.CallStaticBooleanMethod(org.eclipse.jdt.core.compiler.batch.BatchCompiler.j4n_Class, org.eclipse.jdt.core.compiler.batch.BatchCompiler.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.io.PrintWriter"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.io.PrintWriter"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par3, "org.eclipse.jdt.core.compiler.CompilationProgress"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::org.eclipse.jdt.core.compiler.batch.BatchCompiler))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "org.eclipse.jdt.core.compiler.batch.BatchCompiler";
                    proxyInfo.JVMStaticApiName = "org.eclipse.jdt.core.compiler.batch.BatchCompiler_";
                    proxyInfo.CLRApi = typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler);
                    proxyInfo.CLRStaticApi = typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler);
                    proxyInfo.CLRProxy = typeof(org.eclipse.jdt.core.compiler.batch.BatchCompiler);
                    proxyInfo.JVMProxyFactory = org.eclipse.jdt.core.compiler.batch.BatchCompiler.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("compile","([Ljava/lang/String;Ljava/io/PrintWriter;Ljava/io/PrintWriter;Lorg/eclipse/jdt/core/compiler/CompilationProgress;)Z", false, true), // #0 ([Lsystem/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("compile","(Ljava/lang/String;Ljava/io/PrintWriter;Ljava/io/PrintWriter;Lorg/eclipse/jdt/core/compiler/CompilationProgress;)Z", false, true), // #1 (Lsystem/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
