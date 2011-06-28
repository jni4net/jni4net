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

import system.ArgumentException;

import java.nio.ByteBuffer;
import java.util.List;
import java.util.ArrayList;

public class JavaCallInstanceMethods {

	final Object o = new Object();

	public Object objectMethod() {
		return o;
	}

	public boolean testObjectMethod(Object data) {
		return (data == o);
	}

	public String stringMethod() {
		return "stringMethod";
	}

	public boolean testStringMethod(String data) {
		return (data.equals("stringMethod"));
	}

	public Integer integerMethod() {
		return 11;
	}

	public boolean testIntegerMethod(Integer data) {
		return (data == 11);
	}

	public ClassLoader classLoaderMethod() {
		return JavaCallInstanceMethods.class.getClassLoader();
	}

	public boolean testClassLoaderMethod(ClassLoader data) {
		return (data == JavaCallInstanceMethods.class.getClassLoader());
	}

	public Object[] objectArray(Object[] input) {
		input[1] = input[0];
		return input;
	}

	public char[] charArray(char[] input) {
		if (input[0] == 'Ž') {
			input[1] = input[0];
		} else {
			throw new ArgumentException("Looking for Ž");
		}
		return input;
	}

	public int[] intArray(int[] input) {
		input[1] = input[0];
		return input;
	}

	public Integer[] integerArray(Integer[] input) {
		input[1] = input[0];
		return input;
	}

	public String[] stringArray(String[] input) {
		input[1] = input[0];
		return input;
	}

	public boolean[] booleanArray(boolean[] input) {
		input[1] = input[0];
		return input;
	}

	public ByteBuffer buffer(ByteBuffer input) {
		final double d = input.getDouble();
		ByteBuffer res = ByteBuffer.allocate(8);
		res.putDouble(d + 1.0);
		return res;
	}

	public List<String> stringList() {
		List<String> res = new ArrayList<String>();
		res.add("Test1");
		res.add("Test2");
		res.add("Test3");
		return res;
	}

}