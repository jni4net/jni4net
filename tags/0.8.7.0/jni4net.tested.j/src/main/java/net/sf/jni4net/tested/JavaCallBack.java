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

import net.sf.jni4net.Out;
import net.sf.jni4net.Ref;
import net.sf.jni4net.inj.INJException;
import net.sf.jni4net.Bridge;
import system.*;
import system.Object;

/**
 * @author Pavel Savara (original)
 */
public class JavaCallBack {
	public static void callBackException() {
		boolean found = false;
		try {
			ClrException.ThrowBack();
		} catch (NullReferenceException th) {
			found = true;
		}
		if (!found) {
			throw new INJException("wrong!");
		}
	}

	public static void callBackExceptionPropagate() {
		ClrException.ThrowBack();
	}

	public static int callBackStatic(int a, int b) {
        Out<Integer> cont0=new Out<Integer>();
        StaticMethods.TestOutParam(cont0);

        Ref<Integer> cont1=new Ref<Integer>(a+cont0.getValue());
        final int i = StaticMethods.TestRefParam(cont1);
        if (i!=-1){
            throw new Error("but "+i);
        }

        Out<java.lang.String> cont2=new Out<java.lang.String>();
        StaticMethods.TestOutParamS(cont2);

        Ref<java.lang.String> cont3=new Ref<java.lang.String>("Cosi"+cont2.getValue());
        StaticMethods.TestRefParamS(cont3);
        if (!cont3.getValue().equals("CosiAhojAhoj")){
            throw new Error(cont3.getValue());
        }

		return StaticMethods.add(cont1.getValue(),b);
	}

	public static int callBackComparison() {
		CWithJavaInterface c1=new CWithJavaInterface (1);
		CWithJavaInterface c2=new CWithJavaInterface (2);
		return c1.compareTo(c2);
	}

	public static int callBackComparison2() {
		JWithClrInterface c1=new JWithClrInterface(1);
		JWithClrInterface c2=new JWithClrInterface(2);
		final system.Object other = Bridge.wrapJVM(c2);
		return c1.CompareTo(other);
	}

	public static int callBackComparison3() {
		JWithClrInterfaceUnreg c1=new JWithClrInterfaceUnreg(1);
		JWithClrInterfaceUnreg c2=new JWithClrInterfaceUnreg(2);
		final system.Object other = Bridge.wrapJVM(c2);
		return c1.CompareTo(other);
	}

	public static int callBackRun() {
		CWithJavaInterface c1=new CWithJavaInterface (2);
		c1.run();
		return c1.getValue();
	}

}
