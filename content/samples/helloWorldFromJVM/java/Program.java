/* Copyright (C) 2009 by Pavel Savara
This file is part of of jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

import net.sf.jni4net.Bridge;

import java.io.IOException;
import java.lang.String;

import system.*;
import system.Object;
import system.io.TextWriter;
import system.collections.IDictionary;
import system.collections.IEnumerator;

/**
 * @author Pavel Savara (original)
 */
public class Program {
	public static void main(String[] args) throws IOException {
		// create bridge, with default setup
		// it will lookup jni4net.n.dll next to jni4net.j.jar 
		Bridge.setVerbose(true);
		
		Bridge.init();

		// here you go!
		Console.WriteLine("Hello .NET world!\n");

		// OK, simple hello is boring, let's play with System.Environment
		// they are Hashtable realy
		final IDictionary variables = system.Environment.GetEnvironmentVariables();

		// let's enumerate all keys
		final IEnumerator keys = variables.getKeys().GetEnumerator();
		while (keys.MoveNext()) {
			// there hash table is not generic and returns system.Object
			// but we know is should be system.String, so we could cast
			final system.String key = (system.String) keys.getCurrent();
			Console.Write(key);

			// this is automatic conversion of JVM string to system.String
			Console.Write(" : ");

			// we use the hashtable
			Object value = variables.getItem(key);

			// and this is JVM toString() redirected to CLR ToString() method
			String valueToString = value.toString();
			Console.WriteLine(valueToString);
		}

		// Console output is really TextWriter on stream
		final TextWriter writer = Console.getOut();
		writer.Flush();
	}
}
