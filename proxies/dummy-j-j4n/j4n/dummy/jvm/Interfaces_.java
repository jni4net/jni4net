package dummy.jvm;

@net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Interfaces_
// <j4ni-Interfaces_>
// put user interfaces here
// </j4ni-Interfaces_>
{
    // <j4nb-Interfaces_> 
    // put user members here
    // </j4nb-Interfaces_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Bar_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Bar_
    // <j4ni-Bar_>
    // put user interfaces here
    // </j4ni-Bar_>
    {
        // <j4nb-Bar_> 
        // put user members here
        // </j4nb-Bar_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.jvm.Interfaces_._Bar(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.jvm.Interfaces_.Bar_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.jvm.Interfaces+Bar_, " + net.sf.jni4net.modules.dummyjj4n.assemblyName, dummy.jvm.Interfaces.Bar.class, dummy.jvm.Interfaces_.Bar_.class, dummy.jvm.Interfaces_._Bar.class, new dummy.jvm.Interfaces_.Bar_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Bar_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Bar extends system.Object implements dummy.jvm.Interfaces.Bar
    // <j4ni-Bar>
    // put user interfaces here
    // </j4ni-Bar>
    {
        // <j4nb-Bar> 
        // put user members here
        // </j4nb-Bar>
        
        _Bar(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.jvm.Interfaces_.Bar_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public native void bar();
        
        /// <signature>#1 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Foob(java.lang.Object par0);
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Foo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Foo_
    // <j4ni-Foo_>
    // put user interfaces here
    // </j4ni-Foo_>
    {
        // <j4nb-Foo_> 
        // put user members here
        // </j4nb-Foo_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.jvm.Interfaces_._Foo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.jvm.Interfaces_.Foo_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.jvm.Interfaces+Foo_, " + net.sf.jni4net.modules.dummyjj4n.assemblyName, dummy.jvm.Interfaces.Foo.class, dummy.jvm.Interfaces_.Foo_.class, dummy.jvm.Interfaces_._Foo.class, new dummy.jvm.Interfaces_.Foo_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Foo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Foo extends system.Object implements dummy.jvm.Interfaces.Foo
    // <j4ni-Foo>
    // put user interfaces here
    // </j4ni-Foo>
    {
        // <j4nb-Foo> 
        // put user members here
        // </j4nb-Foo>
        
        _Foo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.jvm.Interfaces_.Foo_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public native void foo();
        
        /// <signature>#1 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Foob(java.lang.Object par0);
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Goo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Goo_
    // <j4ni-Goo_>
    // put user interfaces here
    // </j4ni-Goo_>
    {
        // <j4nb-Goo_> 
        // put user members here
        // </j4nb-Goo_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.jvm.Interfaces_._Goo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.jvm.Interfaces_.Goo_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.jvm.Interfaces+Goo_, " + net.sf.jni4net.modules.dummyjj4n.assemblyName, dummy.jvm.Interfaces.Goo.class, dummy.jvm.Interfaces_.Goo_.class, dummy.jvm.Interfaces_._Goo.class, new dummy.jvm.Interfaces_.Goo_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Goo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Goo extends system.Object implements dummy.jvm.Interfaces.Goo
    // <j4ni-Goo>
    // put user interfaces here
    // </j4ni-Goo>
    {
        // <j4nb-Goo> 
        // put user members here
        // </j4nb-Goo>
        
        _Goo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.jvm.Interfaces_.Goo_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public native void foo();
        
        /// <signature>#1 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Foob(java.lang.Object par0);
        
        /// <signature>#2 ()V ()V</signature>
        public native void goo();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.MyPublicY_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class MyPublicY_
    // <j4ni-MyPublicY_>
    // put user interfaces here
    // </j4ni-MyPublicY_>
    {
        // <j4nb-MyPublicY_> 
        // put user members here
        // </j4nb-MyPublicY_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.MyPublicZ_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class MyPublicZ_
    // <j4ni-MyPublicZ_>
    // put user interfaces here
    // </j4ni-MyPublicZ_>
    {
        // <j4nb-MyPublicZ_> 
        // put user members here
        // </j4nb-MyPublicZ_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Zoo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Zoo_
    // <j4ni-Zoo_>
    // put user interfaces here
    // </j4ni-Zoo_>
    {
        // <j4nb-Zoo_> 
        // put user members here
        // </j4nb-Zoo_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.jvm.Interfaces_._Zoo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.jvm.Interfaces_.Zoo_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.jvm.Interfaces+Zoo_, " + net.sf.jni4net.modules.dummyjj4n.assemblyName, dummy.jvm.Interfaces.Zoo.class, dummy.jvm.Interfaces_.Zoo_.class, dummy.jvm.Interfaces_._Zoo.class, new dummy.jvm.Interfaces_.Zoo_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Interfaces_.Zoo_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Zoo extends system.Object implements dummy.jvm.Interfaces.Zoo
    // <j4ni-Zoo>
    // put user interfaces here
    // </j4ni-Zoo>
    {
        // <j4nb-Zoo> 
        // put user members here
        // </j4nb-Zoo>
        
        _Zoo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.jvm.Interfaces_.Zoo_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public native void foo();
        
        /// <signature>#1 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Foob(java.lang.Object par0);
        
        /// <signature>#2 ()V ()V</signature>
        public native void zoo();
    }
}
