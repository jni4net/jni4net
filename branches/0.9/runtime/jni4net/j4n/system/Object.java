// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Object.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Object
// <j4ni-Object>
implements net.sf.jni4net.IClrProxy, system.IObject
// </j4ni-Object>
{
    // <j4nb-Object> 

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
    //protected net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo;

    public long _getClrHandle() {
        return j4n_clrHandle;
    }

    public void _initProxy(long handle) {
        j4n_clrHandle = handle;
    }

    protected Object(long handle, net.sf.jni4net.core.ClrInstanceInfo instanceInfo) {
        j4n_clrHandle = handle;
        //j4n_instanceInfo = instanceInfo;
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

    // </j4nb-Object>
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Object(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Object.j4n_ProxyInit(null);
    }
    
    public Object() {
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    /// <signature>#1 (Ljava/lang/Object;Ljava/lang/Object;)Z (Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
    static public native boolean Equals(java.lang.Object objA, java.lang.Object objB);
    
    /// <signature>#2 (Ljava/lang/Object;Ljava/lang/Object;)Z (Ljava/lang/Object;Ljava/lang/Object;)Z</signature>
    static public native boolean ReferenceEquals(java.lang.Object objA, java.lang.Object objB);
    
    /// <signature>#3 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean Equals(java.lang.Object obj);
    
    /// <signature>#4 ()I ()I</signature>
    public native int GetHashCode();
    
    /// <signature>#5 ()Lsystem/IType; ()Lsystem/IType;</signature>
    public final native system.IType GetType();
    
    /// <signature>#6 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String ToString();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Object_, " + net.sf.jni4net.modules.jni4net.assemblyName, system.Object.class, system.Object.class, system.Object.class, new system.Object.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
