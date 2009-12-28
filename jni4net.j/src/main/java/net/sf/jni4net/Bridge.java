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
package net.sf.jni4net;

import net.sf.jni4net.inj.IClrProxy_;
import net.sf.jni4net.inj.INJException;
import net.sf.jni4net.inj.IClrProxy;
import net.sf.jni4net.jni.IJvmProxy;
import net.sf.jni4net.jni.IJvmProxy_;

import java.lang.String;
import java.io.IOException;

import system.IObject;

@net.sf.jni4net.attributes.ClrType
public class Bridge extends system.Object {

	static boolean isRegistered;

	static boolean verbose;
	static boolean debug;

	public static void init() throws java.io.IOException {
		init(CLRLoader.findDefaultDll());
	}

	public static void init(String fileOrDirectory) throws IOException {
		CLRLoader.init(fileOrDirectory);
	}

	public static void setDebug(boolean value){
		debug=value;
		if (isRegistered){
			getSetup().setDebug(value);
		}
	}

	public static void setVerbose(boolean value){
		verbose=value;
		if (isRegistered){
			getSetup().setVerbose(value);
		}
	}

	public static synchronized String getVersion() {
		return CLRLoader.getVersion();
	}

	public static synchronized boolean isRegistered() {
		return isRegistered;
	}

	public static boolean isCLRInstance(Object obj){
		return !isJVMInstance(obj);
	}
	
	public static boolean isJVMInstance(Object obj){
		if (IObject.class.isAssignableFrom(obj.getClass())){
			IObject o=(IObject)obj;
			return IClrProxy_.typeof().IsAssignableFrom(o.GetType());
		}
		return true;
	}


	public static system.Object wrapJVM(Object obj){
		if (IObject.class.isAssignableFrom(obj.getClass())){
			if (IJvmProxy.class.isAssignableFrom(obj.getClass())){
				return (system.Object)obj; 
			}
			throw new INJException("Can't wrap CLR instance");
		}
		final long clrHandle = WrapJVM(obj);
		return IJvmProxy_.createProxy(clrHandle);
	}

	@SuppressWarnings("unchecked")
	public static <TRes> TRes unwrapJVM(system.Object obj){
		if (!IJvmProxy.class.isAssignableFrom(obj.getClass())){
			throw new INJException("Can't unwrap JVM instance");
		}
		long clrHandle=obj.getClrHandle();
		return (TRes)UnwrapJVM(clrHandle);
	}

	public static system.String convert(String obj){
		return new system.String(obj);
	}

	public static String convert(system.String obj){
		return obj.toString();
	}

	@SuppressWarnings("unchecked")
	public static <TRes> TRes cast(Object obj, Class<TRes> expectedInterface){
		if (!IClrProxy.class.isAssignableFrom(obj.getClass())){
			throw new INJException("Can't cast JVM instance");
		}
		if (IJvmProxy.class.isAssignableFrom(obj.getClass())){
			throw new INJException("Can't cast JVM instance");
		}
		return (TRes)Cast(obj, expectedInterface);
	}

	// this is registered by convention to Java_net_sf_jni4net_Bridge_initDotNet
	static native int initDotNet();

	//these are conversion helpers
	native static long WrapJVM(java.lang.Object obj);
	native static java.lang.Object UnwrapJVM(long obj);
	public native static long Convert(String obj);
    public native static void DisposeClrHandle(long clrHandle);
	native static net.sf.jni4net.inj.IClrProxy Cast(Object obj, java.lang.Class expectedInterface);

	//<generated-proxy>
    private static system.Type staticType;
    
    protected Bridge(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected Bridge() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Lnet/sf/jni4net/BridgeSetup;")
    public native static net.sf.jni4net.BridgeSetup getSetup();
    
    @net.sf.jni4net.attributes.ClrMethod("()[[LSystem/Collections/Generic/IList`1;")
    public native static system.collections.IList getKnownAssemblies();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/jni4net/BridgeSetup;)Lnet/sf/jni4net/jni/JNIEnv;")
    public native static system.Object CreateJVM(net.sf.jni4net.BridgeSetup setup);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native static void LoadAndRegisterAssembly(java.lang.String assemblyPath);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/Assembly;)V")
    public native static void RegisterAssembly(system.reflection.Assembly assembly);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/ClassLoader;)V")
    public native static void SetSystemClassLoader(java.lang.ClassLoader classLoader);
    
    public static system.Type typeof() {
        return net.sf.jni4net.Bridge.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.jni4net.Bridge.staticType = staticType;
    }
    //</generated-proxy>
}
