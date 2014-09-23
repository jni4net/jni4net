/* Copyright (C) 2009 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

package net.sf.jni4net.inj;

/**
 * @author Pavel Savara (original)
 */
public class INJException extends RuntimeException {
	public INJException(String message) {
		super(message);
	}

	public INJException(String message, Throwable cause) {
		super(message, cause);
	}
}
