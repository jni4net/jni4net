// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.runtime.serialization;

@net.sf.jni4net.attributes.J4NProxy(system.runtime.serialization.SerializationInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class SerializationInfo extends system.Object
// <j4ni-SerializationInfo>
// put user interfaces here
// </j4ni-SerializationInfo>
{
    // <j4nb-SerializationInfo> 
    // put user members here
    // </j4nb-SerializationInfo>
    
    private SerializationInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.runtime.serialization.SerializationInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.runtime.serialization.SerializationInfo.j4n_ProxyInit(null);
    }
    
    public SerializationInfo(system.Type type, system.Object converter) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(type, converter);
    }
    
    /// <signature>#0 (Lsystem/Type;Lsystem/Object;)V (LSystem/Type;Lsystem/Object;)V</signature>
    private native long j4n_constructor(system.Type type, system.Object converter);
    
    public SerializationInfo(system.Type type, system.Object converter, boolean requireSameTokenInPartialTrust) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(type, converter, requireSameTokenInPartialTrust);
    }
    
    /// <signature>#1 (Lsystem/Type;Lsystem/Object;Z)V (LSystem/Type;Lsystem/Object;Z)V</signature>
    private native long j4n_constructor(system.Type type, system.Object converter, boolean requireSameTokenInPartialTrust);
    
    /// <signature>#2 (Ljava/lang/String;Z)V (Ljava/lang/String;Z)V</signature>
    public final native void AddValue(java.lang.String name, boolean value);
    
    /// <signature>#3 (Ljava/lang/String;B)V (Ljava/lang/String;B)V</signature>
    public final native void AddValue(java.lang.String name, byte value);
    
    /// <signature>#4 (Ljava/lang/String;C)V (Ljava/lang/String;C)V</signature>
    public final native void AddValue(java.lang.String name, char value);
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/DateTime;)V (Ljava/lang/String;LSystem/DateTime;)V</signature>
    public final native void AddValue(java.lang.String name, system.DateTime value);
    
    /// <signature>#6 (Ljava/lang/String;Lsystem/Decimal;)V (Ljava/lang/String;LSystem/Decimal;)V</signature>
    public final native void AddValue(java.lang.String name, system.Decimal value);
    
    /// <signature>#7 (Ljava/lang/String;D)V (Ljava/lang/String;D)V</signature>
    public final native void AddValue(java.lang.String name, double value);
    
    /// <signature>#8 (Ljava/lang/String;S)V (Ljava/lang/String;S)V</signature>
    public final native void AddValue(java.lang.String name, short value);
    
    /// <signature>#9 (Ljava/lang/String;I)V (Ljava/lang/String;I)V</signature>
    public final native void AddValue(java.lang.String name, int value);
    
    /// <signature>#10 (Ljava/lang/String;J)V (Ljava/lang/String;J)V</signature>
    public final native void AddValue(java.lang.String name, long value);
    
    /// <signature>#11 (Ljava/lang/String;Ljava/lang/Object;)V (Ljava/lang/String;Ljava/lang/Object;)V</signature>
    public final native void AddValue(java.lang.String name, java.lang.Object value);
    
    /// <signature>#12 (Ljava/lang/String;Ljava/lang/Object;Lsystem/Type;)V (Ljava/lang/String;Ljava/lang/Object;LSystem/Type;)V</signature>
    public final native void AddValue(java.lang.String name, java.lang.Object value, system.Type type);
    
    /// <signature>#14 (Ljava/lang/String;F)V (Ljava/lang/String;F)V</signature>
    public final native void AddValue(java.lang.String name, float value);
    
    /// <signature>#18 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getAssemblyName();
    
    /// <signature>#19 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getFullTypeName();
    
    /// <signature>#20 ()I ()I</signature>
    public final native int getMemberCount();
    
    /// <signature>#21 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    public final native boolean GetBoolean(java.lang.String name);
    
    /// <signature>#22 (Ljava/lang/String;)B (Ljava/lang/String;)B</signature>
    public final native byte GetByte(java.lang.String name);
    
    /// <signature>#23 (Ljava/lang/String;)C (Ljava/lang/String;)C</signature>
    public final native char GetChar(java.lang.String name);
    
    /// <signature>#24 (Ljava/lang/String;)Lsystem/DateTime; (Ljava/lang/String;)LSystem/DateTime;</signature>
    public final native system.DateTime GetDateTime(java.lang.String name);
    
    /// <signature>#25 (Ljava/lang/String;)Lsystem/Decimal; (Ljava/lang/String;)LSystem/Decimal;</signature>
    public final native system.Decimal GetDecimal(java.lang.String name);
    
    /// <signature>#26 (Ljava/lang/String;)D (Ljava/lang/String;)D</signature>
    public final native double GetDouble(java.lang.String name);
    
    /// <signature>#27 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public final native system.collections.IEnumerator GetEnumerator();
    
    /// <signature>#28 (Ljava/lang/String;)S (Ljava/lang/String;)S</signature>
    public final native short GetInt16(java.lang.String name);
    
    /// <signature>#29 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    public final native int GetInt32(java.lang.String name);
    
    /// <signature>#30 (Ljava/lang/String;)J (Ljava/lang/String;)J</signature>
    public final native long GetInt64(java.lang.String name);
    
    /// <signature>#31 (Ljava/lang/String;)B (Ljava/lang/String;)B</signature>
    public final native byte GetSByte(java.lang.String name);
    
    /// <signature>#32 (Ljava/lang/String;)F (Ljava/lang/String;)F</signature>
    public final native float GetSingle(java.lang.String name);
    
    /// <signature>#33 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String GetString(java.lang.String name);
    
    /// <signature>#34 (Ljava/lang/String;)S (Ljava/lang/String;)S</signature>
    public final native short GetUInt16(java.lang.String name);
    
    /// <signature>#35 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    public final native int GetUInt32(java.lang.String name);
    
    /// <signature>#36 (Ljava/lang/String;)J (Ljava/lang/String;)J</signature>
    public final native long GetUInt64(java.lang.String name);
    
    /// <signature>#37 (Ljava/lang/String;Lsystem/Type;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Type;)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(java.lang.String name, system.Type type);
    
    /// <signature>#38 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public final native void setAssemblyName(java.lang.String value);
    
    /// <signature>#39 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public final native void setFullTypeName(java.lang.String value);
    
    /// <signature>#40 (Lsystem/Type;)V (LSystem/Type;)V</signature>
    public final native void SetType(system.Type type);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Runtime.Serialization.SerializationInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.runtime.serialization.SerializationInfo.class, system.runtime.serialization.SerializationInfo.class, system.runtime.serialization.SerializationInfo.class, new system.runtime.serialization.SerializationInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
