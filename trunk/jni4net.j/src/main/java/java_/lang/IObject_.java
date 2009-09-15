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

package java_.lang;

import system.InvalidOperationException;

/**
 * @author Pavel Savara (original)
 */
@net.sf.jni4net.attributes.ClrTypeInfo
public final class IObject_ {
    
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.IObject_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.IObject_.staticType = staticType;
    }
}

/**
 * @author Pavel Savara (original)
 */
@net.sf.jni4net.attributes.ClrProxy
class __IObject implements IObject {
	protected __IObject(net.sf.jni4net.inj.INJEnv __env, long __handle) {
			throw new InvalidOperationException("Unexpected call");
	}
}
