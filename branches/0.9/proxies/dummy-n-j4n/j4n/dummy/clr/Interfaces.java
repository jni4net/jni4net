// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package dummy.clr;

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Interfaces extends system.Object
// <j4ni-Interfaces>
// put user interfaces here
// </j4ni-Interfaces>
{
    // <j4nb-Interfaces> 
    // put user members here
    // </j4nb-Interfaces>
    
    protected Interfaces(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.clr.Interfaces(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        dummy.clr.Interfaces.j4n_ProxyInit(null);
    }
    
    public Interfaces() {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    /// <signature>#1 ()Ldummy/clr/Interfaces$Buufararable; ()Ldummy/clr/Interfaces+Buufararable;</signature>
    static public native dummy.clr.Interfaces.Buufararable getBuufararableA();
    
    /// <signature>#2 ()Ldummy/clr/Interfaces$Buufararable; ()Ldummy/clr/Interfaces+Buufararable;</signature>
    static public native dummy.clr.Interfaces.Buufararable getBuufararableAG();
    
    /// <signature>#3 ()Ldummy/clr/Interfaces$Buufararable; ()Ldummy/clr/Interfaces+Buufararable;</signature>
    static public native dummy.clr.Interfaces.Buufararable getBuufararableB();
    
    /// <signature>#4 ()Ldummy/clr/Interfaces$Buufararable; ()Ldummy/clr/Interfaces+Buufararable;</signature>
    static public native dummy.clr.Interfaces.Buufararable getBuufararableBG();
    
    /// <signature>#5 ()Ldummy/clr/Interfaces$Fuu; ()Ldummy/clr/Interfaces+Fuu;</signature>
    static public native dummy.clr.Interfaces.Fuu getFuu();
    
    /// <signature>#6 ()Lsystem/collections/IList; ()LSystem/Collections/IList;</signature>
    static public native system.collections.IList getListOfintNG();
    
    /// <signature>#7 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    static public native system.ICloneable getRunnable();
    
    /// <signature>#8 ()Ldummy/clr/Interfaces$YourPublicZ; ()Ldummy/clr/Interfaces+YourPublicZ;</signature>
    static public native dummy.clr.Interfaces.YourPublicZ getYourPublicA();
    
    /// <signature>#9 ()Ldummy/clr/Interfaces$YourPublicZ; ()Ldummy/clr/Interfaces+YourPublicZ;</signature>
    static public native dummy.clr.Interfaces.YourPublicZ getYourPublicB();
    
    /// <signature>#10 ()Ldummy/clr/Interfaces$YourPublicY; ()Ldummy/clr/Interfaces+YourPublicY;</signature>
    static public native dummy.clr.Interfaces.YourPublicY getYourPublicYA();
    
    /// <signature>#11 ()Ldummy/clr/Interfaces$YourPublicY; ()Ldummy/clr/Interfaces+YourPublicY;</signature>
    static public native dummy.clr.Interfaces.YourPublicY getYourPublicYB();
    
    /// <signature>#12 ()Ldummy/clr/Interfaces$YourPublicY; ()Ldummy/clr/Interfaces+YourPublicY;</signature>
    static public native dummy.clr.Interfaces.YourPublicY getYourPublicYZ();
    
    /// <signature>#13 ()Ldummy/clr/Interfaces$YourPublicZ; ()Ldummy/clr/Interfaces+YourPublicZ;</signature>
    static public native dummy.clr.Interfaces.YourPublicZ getYourPublicZ();
    
    /// <signature>#14 (Lsystem/collections/IList;)I (LSystem/Collections/IList;)I</signature>
    static public native int setListOfintNG(system.collections.IList value);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.class, dummy.clr.Interfaces.class, dummy.clr.Interfaces.class, new dummy.clr.Interfaces.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Buufararable_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public interface Buufararable
    // <j4ni-Buufararable>
    // put user interfaces here
    // </j4ni-Buufararable>
    {
        // <j4nb-Buufararable> 
        // put user members here
        // </j4nb-Buufararable>
        
        /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        int Buuf(java.lang.Object bar);
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Buufararable_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Buufararable_
    // <j4ni-Buufararable_>
    // put user interfaces here
    // </j4ni-Buufararable_>
    {
        // <j4nb-Buufararable_> 
        // put user members here
        // </j4nb-Buufararable_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces._Buufararable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.clr.Interfaces.Buufararable_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+Buufararable_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.Buufararable.class, dummy.clr.Interfaces.Buufararable_.class, dummy.clr.Interfaces._Buufararable.class, new dummy.clr.Interfaces.Buufararable_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Buufararable_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Buufararable extends system.Object implements dummy.clr.Interfaces.Buufararable
    // <j4ni-Buufararable>
    // put user interfaces here
    // </j4ni-Buufararable>
    {
        // <j4nb-Buufararable> 
        // put user members here
        // </j4nb-Buufararable>
        
        _Buufararable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.clr.Interfaces.Buufararable_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Buuf(java.lang.Object bar);
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Fuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public interface Fuu extends dummy.clr.Interfaces.Buufararable
    // <j4ni-Fuu>
    // put user interfaces here
    // </j4ni-Fuu>
    {
        // <j4nb-Fuu> 
        // put user members here
        // </j4nb-Fuu>
        
        /// <signature>#0 ()V ()V</signature>
        void fuu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Fuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Fuu_
    // <j4ni-Fuu_>
    // put user interfaces here
    // </j4ni-Fuu_>
    {
        // <j4nb-Fuu_> 
        // put user members here
        // </j4nb-Fuu_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces._Fuu(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.clr.Interfaces.Fuu_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+Fuu_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.Fuu.class, dummy.clr.Interfaces.Fuu_.class, dummy.clr.Interfaces._Fuu.class, new dummy.clr.Interfaces.Fuu_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Fuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Fuu extends system.Object implements dummy.clr.Interfaces.Fuu
    // <j4ni-Fuu>
    // put user interfaces here
    // </j4ni-Fuu>
    {
        // <j4nb-Fuu> 
        // put user members here
        // </j4nb-Fuu>
        
        _Fuu(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.clr.Interfaces.Fuu_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Buuf(java.lang.Object bar);
        
        /// <signature>#1 ()V ()V</signature>
        public native void fuu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Guu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public interface Guu extends dummy.clr.Interfaces.Fuu
    // <j4ni-Guu>
    // put user interfaces here
    // </j4ni-Guu>
    {
        // <j4nb-Guu> 
        // put user members here
        // </j4nb-Guu>
        
        /// <signature>#0 ()V ()V</signature>
        void guu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Guu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Guu_
    // <j4ni-Guu_>
    // put user interfaces here
    // </j4ni-Guu_>
    {
        // <j4nb-Guu_> 
        // put user members here
        // </j4nb-Guu_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces._Guu(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.clr.Interfaces.Guu_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+Guu_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.Guu.class, dummy.clr.Interfaces.Guu_.class, dummy.clr.Interfaces._Guu.class, new dummy.clr.Interfaces.Guu_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Guu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Guu extends system.Object implements dummy.clr.Interfaces.Guu
    // <j4ni-Guu>
    // put user interfaces here
    // </j4ni-Guu>
    {
        // <j4nb-Guu> 
        // put user members here
        // </j4nb-Guu>
        
        _Guu(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.clr.Interfaces.Guu_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Buuf(java.lang.Object bar);
        
        /// <signature>#1 ()V ()V</signature>
        public native void fuu();
        
        /// <signature>#2 ()V ()V</signature>
        public native void guu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Zuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public interface Zuu extends dummy.clr.Interfaces.Fuu
    // <j4ni-Zuu>
    // put user interfaces here
    // </j4ni-Zuu>
    {
        // <j4nb-Zuu> 
        // put user members here
        // </j4nb-Zuu>
        
        /// <signature>#0 ()V ()V</signature>
        void zuu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Zuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Zuu_
    // <j4ni-Zuu_>
    // put user interfaces here
    // </j4ni-Zuu_>
    {
        // <j4nb-Zuu_> 
        // put user members here
        // </j4nb-Zuu_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces._Zuu(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.clr.Interfaces.Zuu_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+Zuu_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.Zuu.class, dummy.clr.Interfaces.Zuu_.class, dummy.clr.Interfaces._Zuu.class, new dummy.clr.Interfaces.Zuu_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Zuu_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Zuu extends system.Object implements dummy.clr.Interfaces.Zuu
    // <j4ni-Zuu>
    // put user interfaces here
    // </j4ni-Zuu>
    {
        // <j4nb-Zuu> 
        // put user members here
        // </j4nb-Zuu>
        
        _Zuu(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.clr.Interfaces.Zuu_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Buuf(java.lang.Object bar);
        
        /// <signature>#1 ()V ()V</signature>
        public native void fuu();
        
        /// <signature>#2 ()V ()V</signature>
        public native void zuu();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Rab_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public interface Rab extends dummy.clr.Interfaces.Buufararable
    // <j4ni-Rab>
    // put user interfaces here
    // </j4ni-Rab>
    {
        // <j4nb-Rab> 
        // put user members here
        // </j4nb-Rab>
        
        /// <signature>#0 ()V ()V</signature>
        void bar();
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Rab_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Rab_
    // <j4ni-Rab_>
    // put user interfaces here
    // </j4ni-Rab_>
    {
        // <j4nb-Rab_> 
        // put user members here
        // </j4nb-Rab_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces._Rab(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            dummy.clr.Interfaces.Rab_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+Rab_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.Rab.class, dummy.clr.Interfaces.Rab_.class, dummy.clr.Interfaces._Rab.class, new dummy.clr.Interfaces.Rab_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.Rab_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Rab extends system.Object implements dummy.clr.Interfaces.Rab
    // <j4ni-Rab>
    // put user interfaces here
    // </j4ni-Rab>
    {
        // <j4nb-Rab> 
        // put user members here
        // </j4nb-Rab>
        
        _Rab(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            dummy.clr.Interfaces.Rab_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public native void bar();
        
        /// <signature>#1 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
        public native int Buuf(java.lang.Object bar);
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.YourPublicY.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class YourPublicY extends system.Object
    // <j4ni-YourPublicY>
    // put user interfaces here
    // </j4ni-YourPublicY>
    {
        // <j4nb-YourPublicY> 
        // put user members here
        // </j4nb-YourPublicY>
        
        protected YourPublicY(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces.YourPublicY(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static  {
            dummy.clr.Interfaces.YourPublicY.j4n_ProxyInit(null);
        }
        
        public YourPublicY() {
            super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
            j4n_clrHandle = j4n_constructor();
        }
        
        /// <signature>#0 ()V ()V</signature>
        private native long j4n_constructor();
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+YourPublicY_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.YourPublicY.class, dummy.clr.Interfaces.YourPublicY.class, dummy.clr.Interfaces.YourPublicY.class, new dummy.clr.Interfaces.YourPublicY.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(dummy.clr.Interfaces.YourPublicZ.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class YourPublicZ extends dummy.clr.Interfaces.YourPublicY
    // <j4ni-YourPublicZ>
    // put user interfaces here
    // </j4ni-YourPublicZ>
    {
        // <j4nb-YourPublicZ> 
        // put user members here
        // </j4nb-YourPublicZ>
        
        protected YourPublicZ(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new dummy.clr.Interfaces.YourPublicZ(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static  {
            dummy.clr.Interfaces.YourPublicZ.j4n_ProxyInit(null);
        }
        
        public YourPublicZ() {
            super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
            j4n_clrHandle = j4n_constructor();
        }
        
        /// <signature>#0 ()V ()V</signature>
        private native long j4n_constructor();
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Interfaces_+YourPublicZ_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Interfaces.YourPublicZ.class, dummy.clr.Interfaces.YourPublicZ.class, dummy.clr.Interfaces.YourPublicZ.class, new dummy.clr.Interfaces.YourPublicZ.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
}
