/* Copyright (C) 2009 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/
package system;

/**
 * @author Pavel Savara (original)
 */
public interface IObject {

	java.lang.String ToString();

	boolean Equals(system.Object objPar0);

	int GetHashCode();

	system.Type GetType();

}
