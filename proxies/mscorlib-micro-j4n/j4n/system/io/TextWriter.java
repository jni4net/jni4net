// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.io;

@net.sf.jni4net.attributes.J4NProxy(system.io.TextWriter.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class TextWriter extends system.MarshalByRefObject implements system.IDisposable
// <j4ni-TextWriter>
// put user interfaces here
// </j4ni-TextWriter>
{
    // <j4nb-TextWriter> 
    // put user members here
    // </j4nb-TextWriter>
    
    protected TextWriter(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.io.TextWriter(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.io.TextWriter.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
    static public native system.io.TextWriter Null();
    
    /// <signature>#1 (Lsystem/io/TextWriter;)Lsystem/io/TextWriter; (LSystem/IO/TextWriter;)LSystem/IO/TextWriter;</signature>
    static public native system.io.TextWriter Synchronized(system.io.TextWriter writer);
    
    /// <signature>#2 ()V ()V</signature>
    public native void Close();
    
    /// <signature>#3 ()V ()V</signature>
    public native void Dispose();
    
    /// <signature>#4 ()V ()V</signature>
    public native void Flush();
    
    /// <signature>#5 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    public native system.ICloneable getEncoding();
    
    /// <signature>#6 ()Lsystem/IFormatProvider; ()LSystem/IFormatProvider;</signature>
    public native system.IFormatProvider getFormatProvider();
    
    /// <signature>#7 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getNewLine();
    
    /// <signature>#8 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void setNewLine(java.lang.String value);
    
    /// <signature>#9 ([C)V ([C)V</signature>
    public native void Write(char[] buffer);
    
    /// <signature>#10 ([CII)V ([CII)V</signature>
    public native void Write(char[] buffer, int index, int count);
    
    /// <signature>#11 (Z)V (Z)V</signature>
    public native void Write(boolean value);
    
    /// <signature>#12 (C)V (C)V</signature>
    public native void Write(char value);
    
    /// <signature>#13 (Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
    public native void Write(system.Decimal value);
    
    /// <signature>#14 (D)V (D)V</signature>
    public native void Write(double value);
    
    /// <signature>#15 (I)V (I)V</signature>
    public native void Write(int value);
    
    /// <signature>#16 (J)V (J)V</signature>
    public native void Write(long value);
    
    /// <signature>#17 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void Write(java.lang.Object value);
    
    /// <signature>#18 (F)V (F)V</signature>
    public native void Write(float value);
    
    /// <signature>#19 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void Write(java.lang.String value);
    
    /// <signature>#20 (Ljava/lang/String;[Ljava/lang/Object;)V (Ljava/lang/String;[Ljava/lang/Object;)V</signature>
    public native void Write(java.lang.String format, java.lang.Object[] arg);
    
    /// <signature>#21 (Ljava/lang/String;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;)V</signature>
    public native void Write(java.lang.String format, java.lang.Object arg0);
    
    /// <signature>#22 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void Write(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#23 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void Write(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    /// <signature>#26 ()V ()V</signature>
    public native void WriteLine();
    
    /// <signature>#27 ([C)V ([C)V</signature>
    public native void WriteLine(char[] buffer);
    
    /// <signature>#28 ([CII)V ([CII)V</signature>
    public native void WriteLine(char[] buffer, int index, int count);
    
    /// <signature>#29 (Z)V (Z)V</signature>
    public native void WriteLine(boolean value);
    
    /// <signature>#30 (C)V (C)V</signature>
    public native void WriteLine(char value);
    
    /// <signature>#31 (Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
    public native void WriteLine(system.Decimal value);
    
    /// <signature>#32 (D)V (D)V</signature>
    public native void WriteLine(double value);
    
    /// <signature>#33 (I)V (I)V</signature>
    public native void WriteLine(int value);
    
    /// <signature>#34 (J)V (J)V</signature>
    public native void WriteLine(long value);
    
    /// <signature>#35 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void WriteLine(java.lang.Object value);
    
    /// <signature>#36 (F)V (F)V</signature>
    public native void WriteLine(float value);
    
    /// <signature>#37 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void WriteLine(java.lang.String value);
    
    /// <signature>#38 (Ljava/lang/String;[Ljava/lang/Object;)V (Ljava/lang/String;[Ljava/lang/Object;)V</signature>
    public native void WriteLine(java.lang.String format, java.lang.Object[] arg);
    
    /// <signature>#39 (Ljava/lang/String;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;)V</signature>
    public native void WriteLine(java.lang.String format, java.lang.Object arg0);
    
    /// <signature>#40 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void WriteLine(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#41 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void WriteLine(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IO.TextWriter_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.io.TextWriter.class, system.io.TextWriter.class, system.io.TextWriter.class, new system.io.TextWriter.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
