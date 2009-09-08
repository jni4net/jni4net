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

package net.sf.jni4net.test;

import net.sf.jni4net.Bridge;
import net.sf.jni4net.tested.*;
import org.junit.BeforeClass;
import org.junit.Test;
import org.junit.Assert;
import system.NullReferenceException;
import system.Type;
import system.reflection.Assembly;

import java.io.File;
import java.io.IOException;
import static org.hamcrest.CoreMatchers.*;

public class TestClr {

	@BeforeClass
	public static void setup() throws IOException {
		Bridge.verbose = true;
		Bridge.init(new File("../jni4net.tested.n/target").getCanonicalPath());
		Bridge.LoadAndRegisterAssembly(new File("../jni4net.tested.n/target/jni4net.tested.n-" + Bridge.getNVersion() + ".dll").getAbsolutePath());
	}


	@Test
	public void testClrReflection() throws IOException {
		JavaToClrReflection.reflect();
	}

	@Test()
	public void testNoException() {
		ClrException.NoException();
	}

	@Test(expected = NullReferenceException.class)
	public void testException() {
		ClrException.ThrowBack();
	}

	@Test()
	public void testPrimitiveTypes() {
		JavaCallBack.callBackException();
	}

	@Test()
	public void testExceptionType() {
		JavaCallBack.callBackException();
	}

	@Test()
	public void testCtor() {
		StaticMethods sm=new StaticMethods(); 
	}

	@Test()
	public void testCWithJavaInterface() {
		int res= JavaCallBack.callBackComparison();
		Assert.assertThat(res, is(1));
	}

	@Test()
	public void testJWithClrInterface() {
		int res= JavaCallBack.callBackComparison2();
		Assert.assertThat(res, is(1));
	}

	//SLOW @Test()
	public void testGarbage() {
		long[] longs;
		for(int i=0;i<100;i++){
			inner();
			System.gc();
			System.gc();
			System.gc();
			System.gc();
		}
	}

	private void inner() {
		Type type = system.Console.typeof();
		Assembly assembly = type.getAssembly();
		//system.Console.WriteLine(assembly.getFullName());
		type=null;
		assembly=null;
	}

}