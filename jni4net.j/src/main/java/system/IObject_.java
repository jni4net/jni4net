/* Copyright (C) 2009 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

package system;

/**
 * @author Pavel Savara (original)
 */
@net.sf.jni4net.attributes.ClrTypeInfo
public final class IObject_ {
    
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.IObject_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.IObject_.staticType = staticType;
    }
}

/**
 * @author Pavel Savara (original)
 */
@net.sf.jni4net.attributes.ClrProxy
class __IObject extends system.Object implements system.IObject {
	protected __IObject(net.sf.jni4net.inj.INJEnv __env, long __handle) {
			super(__env, __handle);
	}
}
