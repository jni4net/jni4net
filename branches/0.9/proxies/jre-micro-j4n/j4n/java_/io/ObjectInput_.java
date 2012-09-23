package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectInput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ObjectInput_
// <j4ni-ObjectInput_>
// put user interfaces here
// </j4ni-ObjectInput_>
{
    // <j4nb-ObjectInput_> 
    // put user members here
    // </j4nb-ObjectInput_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._ObjectInput(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.ObjectInput_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.ObjectInput_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.io.ObjectInput.class, java_.io.ObjectInput_.class, java_.io._ObjectInput.class, new java_.io.ObjectInput_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectInput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ObjectInput extends system.Object implements java.io.ObjectInput
// <j4ni-ObjectInput>
// put user interfaces here
// </j4ni-ObjectInput>
{
    // <j4nb-ObjectInput> 
    // put user members here
    // </j4nb-ObjectInput>
    
    _ObjectInput(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.ObjectInput_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()I ()I</signature>
    public native int available();
    
    /// <signature>#1 ()V ()V</signature>
    public native void close();
    
    /// <signature>#2 ()I ()I</signature>
    public native int read();
    
    /// <signature>#3 ([B)I ([B)I</signature>
    public native int read(byte[] par0);
    
    /// <signature>#4 ([BII)I ([BII)I</signature>
    public native int read(byte[] par0, int par1, int par2);
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean readBoolean();
    
    /// <signature>#6 ()B ()B</signature>
    public native byte readByte();
    
    /// <signature>#7 ()C ()C</signature>
    public native char readChar();
    
    /// <signature>#8 ()D ()D</signature>
    public native double readDouble();
    
    /// <signature>#9 ()F ()F</signature>
    public native float readFloat();
    
    /// <signature>#10 ([B)V ([B)V</signature>
    public native void readFully(byte[] par0);
    
    /// <signature>#11 ([BII)V ([BII)V</signature>
    public native void readFully(byte[] par0, int par1, int par2);
    
    /// <signature>#12 ()I ()I</signature>
    public native int readInt();
    
    /// <signature>#13 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String readLine();
    
    /// <signature>#14 ()J ()J</signature>
    public native long readLong();
    
    /// <signature>#15 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object readObject();
    
    /// <signature>#16 ()S ()S</signature>
    public native short readShort();
    
    /// <signature>#17 ()I ()I</signature>
    public native int readUnsignedByte();
    
    /// <signature>#18 ()I ()I</signature>
    public native int readUnsignedShort();
    
    /// <signature>#19 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String readUTF();
    
    /// <signature>#20 (J)J (J)J</signature>
    public native long skip(long par0);
    
    /// <signature>#21 (I)I (I)I</signature>
    public native int skipBytes(int par0);
}
