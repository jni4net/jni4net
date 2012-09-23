// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Guid.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Guid extends system.ValueType implements system.IFormattable, system.nongeneric.IComparable
// <j4ni-Guid>
// put user interfaces here
// </j4ni-Guid>
{
    // <j4nb-Guid> 
    // put user members here
    // </j4nb-Guid>
    
    private Guid(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Guid(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Guid.j4n_ProxyInit(null);
    }
    
    public Guid(byte[] b) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(b);
    }
    
    /// <signature>#0 ([B)V ([B)V</signature>
    private native long j4n_constructor(byte[] b);
    
    public Guid(int a, short b, short c, byte[] d) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(a, b, c, d);
    }
    
    /// <signature>#1 (ISS[B)V (ISS[B)V</signature>
    private native long j4n_constructor(int a, short b, short c, byte[] d);
    
    public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(a, b, c, d, e, f, g, h, i, j, k);
    }
    
    /// <signature>#2 (ISSBBBBBBBB)V (ISSBBBBBBBB)V</signature>
    private native long j4n_constructor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
    
    public Guid(java.lang.String g) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(g);
    }
    
    /// <signature>#3 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    private native long j4n_constructor(java.lang.String g);
    
    /// <signature>#5 ()Lsystem/Guid; ()LSystem/Guid;</signature>
    static public native system.Guid Empty();
    
    /// <signature>#6 ()Lsystem/Guid; ()LSystem/Guid;</signature>
    static public native system.Guid NewGuid();
    
    /// <signature>#7 (Lsystem/Guid;)I (LSystem/Guid;)I</signature>
    public native int CompareTo(system.Guid value);
    
    /// <signature>#8 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#9 (Lsystem/Guid;)Z (LSystem/Guid;)Z</signature>
    public native boolean Equals(system.Guid g);
    
    /// <signature>#10 ()[B ()[B</signature>
    public final native byte[] ToByteArray();
    
    /// <signature>#11 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#12 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Guid_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Guid.class, system.Guid.class, system.Guid.class, new system.Guid.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
