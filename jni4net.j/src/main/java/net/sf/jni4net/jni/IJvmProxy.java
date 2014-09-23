/* Copyright (C) 2009 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/
package net.sf.jni4net.jni;

import net.sf.jni4net.inj.IClrProxy;

/**
 * @author Pavel Savara (original)
 */
public interface IJvmProxy extends IClrProxy {

	long getJvmHandle();

	void Init(system.Object env, long obj);
}
