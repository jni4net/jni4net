// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.io;

@net.sf.jni4net.attributes.J4NProxy(system.io.TextReader.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class TextReader extends system.MarshalByRefObject implements system.IDisposable
// <j4ni-TextReader>
// put user interfaces here
// </j4ni-TextReader>
{
    // <j4nb-TextReader> 
    // put user members here
    // </j4nb-TextReader>
    
    protected TextReader(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.io.TextReader(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.io.TextReader.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/io/TextReader; ()LSystem/IO/TextReader;</signature>
    static public native system.io.TextReader Null();
    
    /// <signature>#1 (Lsystem/io/TextReader;)Lsystem/io/TextReader; (LSystem/IO/TextReader;)LSystem/IO/TextReader;</signature>
    static public native system.io.TextReader Synchronized(system.io.TextReader reader);
    
    /// <signature>#2 ()V ()V</signature>
    public native void Close();
    
    /// <signature>#3 ()V ()V</signature>
    public native void Dispose();
    
    /// <signature>#4 ()I ()I</signature>
    public native int Peek();
    
    /// <signature>#5 ()I ()I</signature>
    public native int Read();
    
    /// <signature>#6 ([CII)I ([CII)I</signature>
    public native int Read(char[] buffer, int index, int count);
    
    /// <signature>#7 ([CII)I ([CII)I</signature>
    public native int ReadBlock(char[] buffer, int index, int count);
    
    /// <signature>#8 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String ReadLine();
    
    /// <signature>#9 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String ReadToEnd();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IO.TextReader_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.io.TextReader.class, system.io.TextReader.class, system.io.TextReader.class, new system.io.TextReader.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
