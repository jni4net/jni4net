#region Copyright (C) 2012 by Pavel Savara

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
using NUnit.Framework;
using java.lang;
using java.util;
using Boolean = java.lang.Boolean;
using Byte = java.lang.Byte;
using Double = java.lang.Double;
using String = java.lang.String;

#if JNI4NETPRO
namespace tests.n.pro
#else
namespace tests.n
#endif 
{
    [TestFixture]
    public class JvmClassTest : TestBase
    {
        private class MyComparator : Comparator
        {
            public int compare(object par0, object par1)
            {
                int a = ((Integer)par0).intValue();
                int b = ((Integer)par1).intValue();
                return a.CompareTo(b);
            }

            public bool equals(object par0)
            {
                return false;
            }
        }

        [Test]
        public void LateBinding()
        {
            Assert.IsTrue(new Boolean(true).@equals(true));
            Assert.IsTrue(new Byte(1).@equals((byte)1));
            Assert.IsTrue(new Character('a').@equals('a'));
            Assert.IsTrue(new Short(1).@equals((short)1));
            Assert.IsTrue(new Integer(1).@equals(1));
            Assert.IsTrue(new Long(1).@equals((long)1));
            Assert.IsTrue(new Float(1).@equals((float)1));
            Assert.IsTrue(new Double(1).@equals((double)1));
            Assert.IsTrue(new String("a").@equals("a"));

            var hm = new HashMap();
            hm.put(1, 1);
        }

        [Test]
        public void StringTest()
        {
            var v1 = new String("ahoj");
            var v2 = (String)"ahoj";
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Assert.AreEqual(String.copyValueOf(new[] { 'ž', 'ů' }), "žů");
            Assert.AreEqual(new String("žů"), String.copyValueOf(new[] { 'ž', 'ů' }));
            Assert.AreEqual(v1, v2);
            var caseInsensitiveOrder = String.CASE_INSENSITIVE_ORDER;
            var x = new String("xxx");
            var y = new String("yyy");
            Console.WriteLine(caseInsensitiveOrder.compare(x, y));

            Assert.IsFalse(dummy.jvm.Arrays.@equals(new string[] { "a", "b", "c", "c", "d", "e" },
                new string[][] { new string[] { "a", "b" }, new string[] { "a", "b" } }));

            var string11L1 = dummy.jvm.Arrays.string11_l1();
            Assert.AreEqual(10, string11L1.Length);
            Assert.IsNull(string11L1[0]);

            var string11_l2 = dummy.jvm.Arrays.string11_l2();
            Assert.AreEqual("1", string11_l2[1][0]);
            Assert.AreEqual("1", string11_l2[9][8]);
            Assert.AreEqual(null, string11_l2[2][2]);

            var string11_lj = dummy.jvm.Arrays.string11_lj();
            Assert.AreEqual(0, string11_lj[0].Length);
            Assert.AreEqual(1, string11_lj[1].Length);
            Assert.AreEqual(2, string11_lj[2].Length);
            Assert.AreEqual(3, string11_lj[3].Length);
            Assert.AreEqual(9, string11_lj[9].Length);
        }

        [Test]
        public void ClassTest()
        {
            Class[] classes = ((Class)HashMap._class).getInterfaces();
            Assert.Greater(classes.Length, 1);

            var class11L1 = dummy.jvm.Arrays.class11_l1();
            Assert.AreEqual(10, class11L1.Length);
            Assert.IsNull(class11L1[0]);

            var class11L2 = dummy.jvm.Arrays.class11_l2();
            Assert.AreEqual(Class._class, class11L2[1][0]);
            Assert.AreEqual(Class._class, class11L2[9][8]);
            Assert.AreEqual(Class._class, class11L2[1][0].getClass());
            Assert.AreEqual(null, class11L2[2][2]);

            var class11Lj = dummy.jvm.Arrays.class11_lj();
            Assert.AreEqual(0, class11Lj[0].Length);
            Assert.AreEqual(1, class11Lj[1].Length);
            Assert.AreEqual(2, class11Lj[2].Length);
            Assert.AreEqual(3, class11Lj[3].Length);
            Assert.AreEqual(9, class11Lj[9].Length);
        }

        [Test]
        public void InterfaceTest()
        {
            var interface1 = dummy.jvm.Arrays.interface1();
            Assert.AreEqual(10, interface1.Length);
            Assert.AreEqual(String.CASE_INSENSITIVE_ORDER, interface1[0]);

            var interface11L1 = dummy.jvm.Arrays.interface11_l1();
            Assert.AreEqual(10, interface11L1.Length);
            Assert.IsNull(interface11L1[0]);

            var interface11L2 = dummy.jvm.Arrays.interface11_l2();
            Assert.AreEqual(String.CASE_INSENSITIVE_ORDER, interface11L2[1][0]);
            Assert.AreEqual(String.CASE_INSENSITIVE_ORDER, interface11L2[9][8]);
            Assert.AreEqual(null, interface11L2[2][2]);

            var interface11Lj = dummy.jvm.Arrays.interface11_lj();
            Assert.AreEqual(0, interface11Lj[0].Length);
            Assert.AreEqual(1, interface11Lj[1].Length);
            Assert.AreEqual(2, interface11Lj[2].Length);
            Assert.AreEqual(3, interface11Lj[3].Length);
            Assert.AreEqual(9, interface11Lj[9].Length);
        }

        [Test]
        public void ClrInstance()
        {
            Arrays.binarySearch(new object[] { 5, 89, 2, 48, 51, 74, 51, 66 }, 2, new JvmClassTest.MyComparator());
        }

    }
}
