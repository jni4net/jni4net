/* Copyright (C) 2009 by Pavel Savara
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

package system;

import net.sf.jni4net.inj.IClrProxy;

@net.sf.jni4net.attributes.ClrType
public class Object implements IClrProxy, system.IObject {
    
	private long clrHandle;

	public long getClrHandle() {
		return clrHandle;
	}

	public void initProxy(long handle) {
		clrHandle = handle;
	}

	protected Object(net.sf.jni4net.inj.INJEnv env, long handle) {
		clrHandle = handle;
	}

    @Override
    public java.lang.String toString() {
        return ToString();
    }

    @Override
    public boolean equals(java.lang.Object o){
        return o instanceof Object && Equals((Object) o);
    }

    @Override
    public int hashCode(){
        return GetHashCode();
    }

	@Override
	protected void finalize() throws Throwable {
		try {
			if (clrHandle != 0) {
				net.sf.jni4net.Bridge.DisposeClrHandle(clrHandle);
				clrHandle = 0;
			}
		} finally {
			super.finalize();
		}
	}


    //<generated-proxy>
    private static system.Type staticType;
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public Object() {
        system.Object.__ctorObject0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorObject0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String ToString();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    public native boolean Equals(system.Object obj);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;)Z")
    public native static boolean Equals(system.Object objA, system.Object objB);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Object;)Z")
    public native static boolean ReferenceEquals(system.Object objA, system.Object objB);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int GetHashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Type;")
    public native system.Type GetType();
    
    public static system.Type typeof() {
        return system.Object.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.Object.staticType = staticType;
    }
    //</generated-proxy>
}
