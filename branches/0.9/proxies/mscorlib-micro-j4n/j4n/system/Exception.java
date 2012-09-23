// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Exception.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Exception extends java.lang.RuntimeException implements system.runtime.serialization.ISerializable
// <j4ni-Exception>
        ,net.sf.jni4net.IClrProxy, system.IObject
// </j4ni-Exception>
{
    // <j4nb-Exception> 

    /* Copyright (C) 2012 by Pavel Savara
    This file is part of jni4net library - bridge between Java and .NET
    http://jni4net.sourceforge.net/

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as
    published by the Free Software Foundation, either version 3
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    */

    protected long j4n_clrHandle;
    protected net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo;

    public long _getClrHandle() {
        return j4n_clrHandle;
    }

    public void _initProxy(long handle) {
        j4n_clrHandle = handle;
    }

    protected Exception(long handle, net.sf.jni4net.core.ClrInstanceInfo instanceInfo) {
        j4n_clrHandle = handle;
        j4n_instanceInfo = instanceInfo;
    }

    @Override
    public java.lang.String toString() {
        return ToString();
    }

    @Override
    public boolean equals(java.lang.Object o) {
        return o instanceof java.lang.Object && Equals(o);
    }

    @Override
    public int hashCode() {
        return GetHashCode();
    }

    @Override
    protected void finalize() throws Throwable {
        try {
            if (j4n_clrHandle != 0) {
                net.sf.jni4net.core.Registry.disposeClrHandle(j4n_clrHandle);
                j4n_clrHandle = 0;
            }
        } catch (Throwable ignore) {
        } finally {
            super.finalize();
        }
    }

    public Type GetType() {
        return (Type)j4n_instanceInfo.CLRInstance;
    }

    /* TODO
    @Override
    public java.lang.Throwable getCause(){
        return getInnerException();
    }
    */
    // </j4nb-Exception>
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Exception(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Exception.j4n_ProxyInit(null);
    }
    
    public Exception() {
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    public Exception(java.lang.String message) {
        j4n_clrHandle = j4n_constructor(message);
    }
    
    /// <signature>#1 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    private native long j4n_constructor(java.lang.String message);
    
    public Exception(java.lang.String message, java.lang.Throwable innerException) {
        j4n_clrHandle = j4n_constructor(message, innerException);
    }
    
    /// <signature>#2 (Ljava/lang/String;Ljava/lang/Throwable;)V (Ljava/lang/String;Ljava/lang/Throwable;)V</signature>
    private native long j4n_constructor(java.lang.String message, java.lang.Throwable innerException);
    
    /// <signature>#3 ()Lsystem/collections/IDictionary; ()LSystem/Collections/IDictionary;</signature>
    public native system.collections.IDictionary getData();
    
    /// <signature>#4 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getHelpLink();
    
    /// <signature>#5 ()Ljava/lang/Throwable; ()Ljava/lang/Throwable;</signature>
    public native java.lang.Throwable getInnerException();
    
    /// <signature>#6 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getMessage();
    
    /// <signature>#7 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getSource();
    
    /// <signature>#8 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getClrStackTrace();
    
    /// <signature>#9 ()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
    public native system.reflection.MethodBase getTargetSite();
    
    /// <signature>#10 ()Ljava/lang/Throwable; ()Ljava/lang/Throwable;</signature>
    public native java.lang.Throwable GetBaseException();
    
    /// <signature>#11 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    /// <signature>#12 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type GetType_26();
    
    /// <signature>#13 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void setHelpLink(java.lang.String value);
    
    /// <signature>#14 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void setSource(java.lang.String value);
    
    /// <signature>#15 (Ljava/lang/Object;Ljava/lang/Object;)Z (Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
    static public native boolean Equals(java.lang.Object objA, java.lang.Object objB);
    
    /// <signature>#16 (Ljava/lang/Object;Ljava/lang/Object;)Z (Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
    static public native boolean ReferenceEquals(java.lang.Object objA, java.lang.Object objB);
    
    /// <signature>#17 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean Equals(java.lang.Object obj);
    
    /// <signature>#18 ()I ()I</signature>
    public native int GetHashCode();
    
    /// <signature>#19 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String ToString();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Exception_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Exception.class, system.Exception.class, system.Exception.class, new system.Exception.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
