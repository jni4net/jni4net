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

import net.sf.jni4net.inj.IClrProxy;
import system.*;

import java.lang.String;

@net.sf.jni4net.attributes.ClrType
public class Bridge extends system.Object {

	private static boolean isRegistered;

	public static boolean verbose;

	public static void init() throws java.io.IOException {
		init(findDefaultDll());
	}

	public static String getVersion() {
		return VersionReader.getVersion();
	}

	public static String getNVersion() {
		return VersionReader.getNVersion();
	}

	public static void init(String fileOrDirectory) {
		if (!isRegistered) {
			if (new java.io.File(fileOrDirectory).isDirectory()) {
				init(fileOrDirectory + "/jni4net.n-" + getNVersion() + ".dll");
				return;
			}
			try {
				System.load(fileOrDirectory);
				final int res = initDotNet(verbose);
				if (res != 0) {
					System.err.println("Can't initialize jni4net Bridge");
					throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge");
				}
				isRegistered = true;
			} catch (Throwable th) {
				System.err.println("Can't initialize jni4net Bridge" + th.getMessage());
				throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge", th);
			}
		}
	}

	public static synchronized boolean isRegistered() {
		return isRegistered;
	}

	private static String findDefaultDll() throws java.io.IOException {
		final java.security.CodeSource source = Bridge.class.getProtectionDomain().getCodeSource();
		final String file = source.getLocation().getFile();

		java.io.File path;
		if (file.endsWith("classes/")) {
			final String base = file.substring(0, file.length() - 8).replaceAll("jni4net.j", "jni4net.n") + "jni4net.n";
			path = new java.io.File(base + "-" + getNVersion() + ".dll");
			if (!path.exists()) {
				throw new Error("Can't find " + path);
			}
		} else if (file.endsWith(".jar")) {
			final String base = file.substring(0, file.length() - 4).replaceAll("jni4net\\.j", "jni4net.n");
			path = new java.io.File(base + ".dll");
		} else {
			throw new Error("Can't find " + file);
		}
		return path.getCanonicalPath();
	}

	@SuppressWarnings("unchecked")
	public static <TRes,TInput> TRes wrapJVM(TInput obj, Class<TRes> requestedClass){
		return (TRes)WrapJVM(obj, requestedClass);
	}

	@SuppressWarnings("unchecked")
	public static <TRes> TRes unwrapJVM(system.Object obj, Class<TRes> requestedClass){
		return (TRes)UnwrapJVM(obj, requestedClass);
	}

	@SuppressWarnings("unchecked")
	public static <TRes> TRes unwrapJVM(system.Exception obj, Class<TRes> requestedClass){
		return (TRes)UnwrapJVM(obj, requestedClass);
	}

	// this is registered by convention to Java_net_sf_jni4net_Bridge_initDotNet
	@net.sf.jni4net.attributes.ClrMethod("()V")
	private static native int initDotNet(boolean verbose);

	//<generated-proxy>
    private static system.Type staticType;
    
    protected Bridge(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    protected Bridge() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/jni4net/jni/IJavaProxy;Ljava/lang/Class;)LSystem/Object;")
    public native static system.Object WrapJVM(java.lang.Object obj, java.lang.Class interfaceClass);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;Ljava/lang/Class;)Lnet/sf/jni4net/jni/IJavaProxy;")
    public native static java.lang.Object UnwrapJVM(system.Object obj, java.lang.Class interfaceClass);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Exception;Ljava/lang/Class;)Lnet/sf/jni4net/jni/IJavaProxy;")
    public native static java.lang.Object UnwrapJVM(system.Exception obj, java.lang.Class interfaceClass);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native static boolean getVerbose();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native static void setVerbose(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native static boolean getDebug();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native static void setDebug(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native static boolean getBindNative();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native static void setBindNative(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)V")
    public native static void LoadAndRegisterAssembly(java.lang.String assemblyPath);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/Assembly;)V")
    public native static void RegisterAssembly(system.reflection.Assembly assembly);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native static void disposeClrHandle(int clrHandle);
    
    public static system.Type typeof() {
        return net.sf.jni4net.Bridge.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.jni4net.Bridge.staticType = staticType;
    }
    //</generated-proxy>
}
