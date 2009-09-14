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

	import net.sf.jni4net.inj.ICClrProxy;

	@net.sf.jni4net.attributes.ClrType
public class Exception extends java.lang.RuntimeException implements ICClrProxy, system.IObject {

	private int clrHandle;

	@Override
	public java.lang.String toString() {
		return ToString();
	}

	public int getClrHandle() {
		return clrHandle;
	}

	public void initProxy(int handle) {
		clrHandle = handle;
	}

	protected Exception(net.sf.jni4net.inj.INJEnv env, int handle) {
		clrHandle = handle;
	}

    //<generated-proxy>
    private static system.Type staticType;
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public Exception() {
        system.Exception.__ctorException0(this);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;)V")
    public Exception(java.lang.String message) {
        system.Exception.__ctorException1(this, message);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/Exception;)V")
    public Exception(java.lang.String message, system.Exception innerException) {
        system.Exception.__ctorException2(this, message, innerException);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorException0(net.sf.jni4net.inj.ICClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)V")
    private native static void __ctorException1(net.sf.jni4net.inj.ICClrProxy thiz, java.lang.String message);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Exception;)V")
    private native static void __ctorException2(net.sf.jni4net.inj.ICClrProxy thiz, java.lang.String message, system.Exception innerException);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V")
    public native void GetObjectData(system.Object info, system.ValueType context);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getMessage();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IDictionary;")
    public native system.collections.IDictionary getData();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Exception;")
    public native system.Exception GetBaseException();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Exception;")
    public native system.Exception getInnerException();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodBase;")
    public native system.reflection.MethodBase getTargetSite();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getStackTraceNet();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getHelpLink();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native void setHelpLink(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getSource();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native void setSource(java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String ToString();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Type;")
    public native system.Type GetType();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    public native boolean Equals(system.Object obj);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int GetHashCode();
    
    public static system.Type typeof() {
        return system.Exception.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.Exception.staticType = staticType;
    }
    //</generated-proxy>
}
