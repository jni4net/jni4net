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

/**
 * @author Pavel Savara (original)
 */
public class Program {
	public static void main(String[] args) throws IOException {

    if (args.length>0){
			Bridge.setClrVersion(args[0]);
		}
		Bridge.init();

    system.Type re = system.Type.GetType("System.Runtime.InteropServices.RuntimeEnvironment");
    system.reflection.MethodInfo mi = re.GetMethod("GetSystemVersion");
		System.out.println("clr.version         :" + mi.Invoke(null,null).toString());
		System.out.println("java.version        :" + System.getProperty("java.version"));
		System.out.println("sun.arch.data.model :" + System.getProperty("sun.arch.data.model"));
		System.out.println("");
	}
}
