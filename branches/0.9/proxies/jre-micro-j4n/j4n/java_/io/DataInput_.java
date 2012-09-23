package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.DataInput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class DataInput_
// <j4ni-DataInput_>
// put user interfaces here
// </j4ni-DataInput_>
{
    // <j4nb-DataInput_> 
    // put user members here
    // </j4nb-DataInput_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._DataInput(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.DataInput_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.DataInput_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.io.DataInput.class, java_.io.DataInput_.class, java_.io._DataInput.class, new java_.io.DataInput_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.DataInput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _DataInput extends system.Object implements java.io.DataInput
// <j4ni-DataInput>
// put user interfaces here
// </j4ni-DataInput>
{
    // <j4nb-DataInput> 
    // put user members here
    // </j4nb-DataInput>
    
    _DataInput(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.DataInput_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Z ()Z</signature>
    public native boolean readBoolean();
    
    /// <signature>#1 ()B ()B</signature>
    public native byte readByte();
    
    /// <signature>#2 ()C ()C</signature>
    public native char readChar();
    
    /// <signature>#3 ()D ()D</signature>
    public native double readDouble();
    
    /// <signature>#4 ()F ()F</signature>
    public native float readFloat();
    
    /// <signature>#5 ([B)V ([B)V</signature>
    public native void readFully(byte[] par0);
    
    /// <signature>#6 ([BII)V ([BII)V</signature>
    public native void readFully(byte[] par0, int par1, int par2);
    
    /// <signature>#7 ()I ()I</signature>
    public native int readInt();
    
    /// <signature>#8 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String readLine();
    
    /// <signature>#9 ()J ()J</signature>
    public native long readLong();
    
    /// <signature>#10 ()S ()S</signature>
    public native short readShort();
    
    /// <signature>#11 ()I ()I</signature>
    public native int readUnsignedByte();
    
    /// <signature>#12 ()I ()I</signature>
    public native int readUnsignedShort();
    
    /// <signature>#13 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String readUTF();
    
    /// <signature>#14 (I)I (I)I</signature>
    public native int skipBytes(int par0);
}
