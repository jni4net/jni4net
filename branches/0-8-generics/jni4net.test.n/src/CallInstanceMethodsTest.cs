#region Copyright (C) 2009 by Pavel Savara
/*
This file is part of tools for jni4net - bridge between Java and .NET
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
#endregion

using System;
using java.lang;
using java.util;
using net.sf.jni4net.tested;
using NUnit.Framework;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class CallInstanceMethodsTest : TestBase
    {
        private JavaCallInstanceMethods testInstance;

        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
            testInstance = new JavaCallInstanceMethods();
        }

        [Test]
        public void clMethod()
        {
            var data = testInstance.classLoaderMethod();
            bool res = testInstance.testClassLoaderMethod(data);
            Assert.IsTrue(res);
        }

        [Test]
        public void integerMethod()
        {
            var data = testInstance.integerMethod();
            bool res = testInstance.testIntegerMethod(data);
            Assert.IsTrue(res);
            Assert.IsTrue(data.equals((Integer) 11));
        }

        [Test]
        public void objectMethod()
        {
            var data = testInstance.objectMethod();
            bool res = testInstance.testObjectMethod(data);
            Assert.IsTrue(res);
        }

        [Test]
        public void stringMethod()
        {
            var data = testInstance.stringMethod();
            bool res = testInstance.testStringMethod(data);
            Assert.IsTrue(res);
        }

        [Test]
        public void objectArray()
        {
            Object[] objects=new Object[3];
            objects[0] = (String)"test6857";
            Object[] res = testInstance.objectArray(objects);
            Assert.AreEqual((String)"test6857", res[1]);
        }

        [Test]
        public void stringArray()
        {
            String[] objects = new String[3];
            objects[0] = "test6857";
            String[] res = testInstance.stringArray(objects);
            Assert.AreEqual((String)"test6857", res[1]);
        }

        
        [Test]
        public void charArray()
        {
            char[] arr = new char[3];
            arr[0] = 'Ž';
            char[] res = testInstance.charArray(arr);
            Assert.IsTrue('Ž'.Equals(res[1]));
        }

        [Test]
        public void intArray()
        {
            int[] objects = new int[3];
            objects[0] = 6857;
            int[] res = testInstance.intArray(objects);
            Assert.AreEqual(6857, res[1]);
        }

        [Test]
        public void integerArray()
        {
            Integer[] objects = new Integer[3];
            objects[0] = 6857;
            Integer[] res = testInstance.integerArray(objects);
            int i = (int)res[1];
            Assert.IsTrue(i.Equals(6857));
        }

        [Test]
        public void boolArray()
        {
            bool[] objects = new bool[3];
            objects[0] = true;
            bool[] res = testInstance.booleanArray(objects);
            Assert.AreEqual(true, res[1]);
        }

        /*[Test]
        public void byteBuffer()
        {
            ByteBuffer bb = ByteBuffer.allocate(8);
            objects[0] = 6857;
            int[] res = testInstance.intArray(objects);
            Assert.AreEqual(6857, res[1]);
        }*/

        /*
        [Test]
        public void iterrator()
        {
            int c = 0;
            List list = testInstance.stringList();
            foreach (Object items in list)
            {
                //Console.WriteLine(items);
                c++;
            }
            Assert.AreEqual(3,c);
        }*/
    }
}