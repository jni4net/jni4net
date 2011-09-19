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

package net.sf.jni4net.tested;

import net.sf.jni4net.Bridge;
import system.Type;
import system.reflection.MethodInfo;

import java.io.IOException;

/**
 * @author Pavel Savara (original)
 */
public class JavaToClrReflection {
	public static void reflect() throws IOException {
		System.out.println("Hello from Java");
		Bridge.init();
		System.out.println("init done");

		system.Console.WriteLine("Hello from Clr");
		system.DateTime today = system.DateTime.getToday();
		system.Console.WriteLine(system.DateTime.getToday().toString());
		final Type type = system.DateTime.typeof();
		system.Console.WriteLine(type.toString());
		final MethodInfo[] methodInfos = type.GetMethods();
		for (MethodInfo mi : methodInfos) {
			final String mName = mi.getName();
			if (mName.contains("ToString") && mi.GetParameters().length == 0) {
				system.Console.WriteLine(mi.toString());
				final system.Object object = mi.Invoke(today, new system.Object[]{});
				system.String text = (system.String) object;
				system.Console.WriteLine(text);
			}
		}

        Type retype = Type.GetType("System.Runtime.InteropServices.RuntimeEnvironment");
        MethodInfo methodInfo = retype.GetMethod("GetSystemVersion");
        Object invoke = methodInfo.Invoke(null, null);
        System.out.println("CLR Version " + invoke.toString());

    }
}
