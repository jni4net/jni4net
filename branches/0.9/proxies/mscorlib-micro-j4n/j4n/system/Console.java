// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Console.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Console extends system.Object
// <j4ni-Console>
// put user interfaces here
// </j4ni-Console>
{
    // <j4nb-Console> 
    // put user members here
    // </j4nb-Console>
    
    private Console(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Console(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Console.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    static public native void addCancelKeyPress(system.MulticastDelegate value);
    
    /// <signature>#1 ()V ()V</signature>
    static public native void Beep();
    
    /// <signature>#2 (II)V (II)V</signature>
    static public native void Beep(int frequency, int duration);
    
    /// <signature>#3 ()V ()V</signature>
    static public native void Clear();
    
    /// <signature>#4 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    static public native system.Enum getBackgroundColor();
    
    /// <signature>#5 ()I ()I</signature>
    static public native int getBufferHeight();
    
    /// <signature>#6 ()I ()I</signature>
    static public native int getBufferWidth();
    
    /// <signature>#7 ()Z ()Z</signature>
    static public native boolean getCapsLock();
    
    /// <signature>#8 ()I ()I</signature>
    static public native int getCursorLeft();
    
    /// <signature>#9 ()I ()I</signature>
    static public native int getCursorSize();
    
    /// <signature>#10 ()I ()I</signature>
    static public native int getCursorTop();
    
    /// <signature>#11 ()Z ()Z</signature>
    static public native boolean getCursorVisible();
    
    /// <signature>#12 ()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
    static public native system.io.TextWriter getError();
    
    /// <signature>#13 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    static public native system.Enum getForegroundColor();
    
    /// <signature>#14 ()Lsystem/io/TextReader; ()LSystem/IO/TextReader;</signature>
    static public native system.io.TextReader getIn();
    
    /// <signature>#15 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    static public native system.ICloneable getInputEncoding();
    
    /// <signature>#16 ()Z ()Z</signature>
    static public native boolean getKeyAvailable();
    
    /// <signature>#17 ()I ()I</signature>
    static public native int getLargestWindowHeight();
    
    /// <signature>#18 ()I ()I</signature>
    static public native int getLargestWindowWidth();
    
    /// <signature>#19 ()Z ()Z</signature>
    static public native boolean getNumberLock();
    
    /// <signature>#20 ()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
    static public native system.io.TextWriter getOut();
    
    /// <signature>#21 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    static public native system.ICloneable getOutputEncoding();
    
    /// <signature>#22 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getTitle();
    
    /// <signature>#23 ()Z ()Z</signature>
    static public native boolean getTreatControlCAsInput();
    
    /// <signature>#24 ()I ()I</signature>
    static public native int getWindowHeight();
    
    /// <signature>#25 ()I ()I</signature>
    static public native int getWindowLeft();
    
    /// <signature>#26 ()I ()I</signature>
    static public native int getWindowTop();
    
    /// <signature>#27 ()I ()I</signature>
    static public native int getWindowWidth();
    
    /// <signature>#28 (IIIIII)V (IIIIII)V</signature>
    static public native void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);
    
    /// <signature>#29 (IIIIIICLsystem/Enum;Lsystem/Enum;)V (IIIIIICLSystem/Enum;LSystem/Enum;)V</signature>
    static public native void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, system.Enum sourceForeColor, system.Enum sourceBackColor);
    
    /// <signature>#30 ()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardError();
    
    /// <signature>#31 (I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardError(int bufferSize);
    
    /// <signature>#32 ()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardInput();
    
    /// <signature>#33 (I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardInput(int bufferSize);
    
    /// <signature>#34 ()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardOutput();
    
    /// <signature>#35 (I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
    static public native system.io.Stream OpenStandardOutput(int bufferSize);
    
    /// <signature>#36 ()I ()I</signature>
    static public native int Read();
    
    /// <signature>#37 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    static public native system.ValueType ReadKey();
    
    /// <signature>#38 (Z)Lsystem/ValueType; (Z)LSystem/ValueType;</signature>
    static public native system.ValueType ReadKey(boolean intercept);
    
    /// <signature>#39 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String ReadLine();
    
    /// <signature>#40 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    static public native void removeCancelKeyPress(system.MulticastDelegate value);
    
    /// <signature>#41 ()V ()V</signature>
    static public native void ResetColor();
    
    /// <signature>#42 (Lsystem/Enum;)V (LSystem/Enum;)V</signature>
    static public native void setBackgroundColor(system.Enum value);
    
    /// <signature>#43 (I)V (I)V</signature>
    static public native void setBufferHeight(int value);
    
    /// <signature>#44 (I)V (I)V</signature>
    static public native void setBufferWidth(int value);
    
    /// <signature>#45 (I)V (I)V</signature>
    static public native void setCursorLeft(int value);
    
    /// <signature>#46 (I)V (I)V</signature>
    static public native void setCursorSize(int value);
    
    /// <signature>#47 (I)V (I)V</signature>
    static public native void setCursorTop(int value);
    
    /// <signature>#48 (Z)V (Z)V</signature>
    static public native void setCursorVisible(boolean value);
    
    /// <signature>#49 (Lsystem/Enum;)V (LSystem/Enum;)V</signature>
    static public native void setForegroundColor(system.Enum value);
    
    /// <signature>#50 (Lsystem/ICloneable;)V (LSystem/ICloneable;)V</signature>
    static public native void setInputEncoding(system.ICloneable value);
    
    /// <signature>#51 (Lsystem/ICloneable;)V (LSystem/ICloneable;)V</signature>
    static public native void setOutputEncoding(system.ICloneable value);
    
    /// <signature>#52 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    static public native void setTitle(java.lang.String value);
    
    /// <signature>#53 (Z)V (Z)V</signature>
    static public native void setTreatControlCAsInput(boolean value);
    
    /// <signature>#54 (I)V (I)V</signature>
    static public native void setWindowHeight(int value);
    
    /// <signature>#55 (I)V (I)V</signature>
    static public native void setWindowLeft(int value);
    
    /// <signature>#56 (I)V (I)V</signature>
    static public native void setWindowTop(int value);
    
    /// <signature>#57 (I)V (I)V</signature>
    static public native void setWindowWidth(int value);
    
    /// <signature>#58 (II)V (II)V</signature>
    static public native void SetBufferSize(int width, int height);
    
    /// <signature>#59 (II)V (II)V</signature>
    static public native void SetCursorPosition(int left, int top);
    
    /// <signature>#60 (Lsystem/io/TextWriter;)V (LSystem/IO/TextWriter;)V</signature>
    static public native void SetError(system.io.TextWriter newError);
    
    /// <signature>#61 (Lsystem/io/TextReader;)V (LSystem/IO/TextReader;)V</signature>
    static public native void SetIn(system.io.TextReader newIn);
    
    /// <signature>#62 (Lsystem/io/TextWriter;)V (LSystem/IO/TextWriter;)V</signature>
    static public native void SetOut(system.io.TextWriter newOut);
    
    /// <signature>#63 (II)V (II)V</signature>
    static public native void SetWindowPosition(int left, int top);
    
    /// <signature>#64 (II)V (II)V</signature>
    static public native void SetWindowSize(int width, int height);
    
    /// <signature>#65 ([C)V ([C)V</signature>
    static public native void Write(char[] buffer);
    
    /// <signature>#66 ([CII)V ([CII)V</signature>
    static public native void Write(char[] buffer, int index, int count);
    
    /// <signature>#67 (Z)V (Z)V</signature>
    static public native void Write(boolean value);
    
    /// <signature>#68 (C)V (C)V</signature>
    static public native void Write(char value);
    
    /// <signature>#69 (Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
    static public native void Write(system.Decimal value);
    
    /// <signature>#70 (D)V (D)V</signature>
    static public native void Write(double value);
    
    /// <signature>#71 (I)V (I)V</signature>
    static public native void Write(int value);
    
    /// <signature>#72 (J)V (J)V</signature>
    static public native void Write(long value);
    
    /// <signature>#73 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.Object value);
    
    /// <signature>#74 (F)V (F)V</signature>
    static public native void Write(float value);
    
    /// <signature>#75 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    static public native void Write(java.lang.String value);
    
    /// <signature>#76 (Ljava/lang/String;[Ljava/lang/Object;)V (Ljava/lang/String;[Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.String format, java.lang.Object[] arg);
    
    /// <signature>#77 (Ljava/lang/String;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.String format, java.lang.Object arg0);
    
    /// <signature>#78 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#79 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    /// <signature>#80 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void Write(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2, java.lang.Object arg3);
    
    /// <signature>#83 ()V ()V</signature>
    static public native void WriteLine();
    
    /// <signature>#84 ([C)V ([C)V</signature>
    static public native void WriteLine(char[] buffer);
    
    /// <signature>#85 ([CII)V ([CII)V</signature>
    static public native void WriteLine(char[] buffer, int index, int count);
    
    /// <signature>#86 (Z)V (Z)V</signature>
    static public native void WriteLine(boolean value);
    
    /// <signature>#87 (C)V (C)V</signature>
    static public native void WriteLine(char value);
    
    /// <signature>#88 (Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
    static public native void WriteLine(system.Decimal value);
    
    /// <signature>#89 (D)V (D)V</signature>
    static public native void WriteLine(double value);
    
    /// <signature>#90 (I)V (I)V</signature>
    static public native void WriteLine(int value);
    
    /// <signature>#91 (J)V (J)V</signature>
    static public native void WriteLine(long value);
    
    /// <signature>#92 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.Object value);
    
    /// <signature>#93 (F)V (F)V</signature>
    static public native void WriteLine(float value);
    
    /// <signature>#94 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    static public native void WriteLine(java.lang.String value);
    
    /// <signature>#95 (Ljava/lang/String;[Ljava/lang/Object;)V (Ljava/lang/String;[Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.String format, java.lang.Object[] arg);
    
    /// <signature>#96 (Ljava/lang/String;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.String format, java.lang.Object arg0);
    
    /// <signature>#97 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#98 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    /// <signature>#99 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    static public native void WriteLine(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2, java.lang.Object arg3);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Console_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Console.class, system.Console.class, system.Console.class, new system.Console.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
