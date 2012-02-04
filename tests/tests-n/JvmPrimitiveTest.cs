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
    public class JvmPrimitiveTest : TestBase
    {
        [Test]
        public void BooleanTest()
        {
            var v1 = new Boolean(true);
            var v2 = new Boolean(true);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Boolean.FALSE);
            Assert.AreNotEqual(v1, Boolean.FALSE);
            Assert.AreEqual(v1, v2);
            Assert.IsFalse(Boolean.parseBoolean("false"));
            Assert.IsFalse(Arrays.equals(new[] {false, false, true}, new[] {false, false, false}));
            Assert.IsFalse(dummy.jvm.Arrays.equals(new[] {false, false, true},
                new bool[][] {new[] {false, false, true}, new[] {false, false, true}, new[] {false, false, true}}));

            var boolean11L1 = dummy.jvm.Arrays.boolean11_l1();
            Assert.AreEqual(10, boolean11L1.Length);
            Assert.IsNull(boolean11L1[0]);

            var boolean11_l2 = dummy.jvm.Arrays.boolean11_l2();
            Assert.IsTrue(boolean11_l2[1][0]);
            Assert.IsTrue(boolean11_l2[9][8]);
            Assert.IsFalse(boolean11_l2[2][2]);

            var boolean11_lj = dummy.jvm.Arrays.boolean11_lj();
            Assert.AreEqual(0, boolean11_lj[0].Length);
            Assert.AreEqual(1, boolean11_lj[1].Length);
            Assert.AreEqual(2, boolean11_lj[2].Length);
            Assert.AreEqual(3, boolean11_lj[3].Length);
            Assert.AreEqual(9, boolean11_lj[9].Length);
        }

        [Test]
        public void ByteTest()
        {
            var v1 = new Byte(21);
            var v2 = new Byte(21);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Byte.MAX_VALUE);
            Assert.AreNotEqual(v1, Byte.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new byte[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new byte[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new byte[][] {new byte[] {1, 2, 3}, new byte[] {1, 2, 3}}));

            var byte11L1 = dummy.jvm.Arrays.byte11_l1();
            Assert.AreEqual(10, byte11L1.Length);
            Assert.IsNull(byte11L1[0]);

            var byte11_l2 = dummy.jvm.Arrays.byte11_l2();
            Assert.AreEqual(1, byte11_l2[1][0]);
            Assert.AreEqual(1, byte11_l2[9][8]);
            Assert.AreEqual(0, byte11_l2[2][2]);

            var byte11_lj = dummy.jvm.Arrays.byte11_lj();
            Assert.AreEqual(0, byte11_lj[0].Length);
            Assert.AreEqual(1, byte11_lj[1].Length);
            Assert.AreEqual(2, byte11_lj[2].Length);
            Assert.AreEqual(3, byte11_lj[3].Length);
            Assert.AreEqual(9, byte11_lj[9].Length);
        }

        [Test]
        public void CharTest()
        {
            var v1 = new Character('a');
            var v2 = new Character('a');
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Character.MAX_VALUE);
            Assert.AreNotEqual(v1, Character.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(4, Arrays.binarySearch(new[] {'a', 'b', 'c', 'c', 'd', 'e'}, 'd'));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new char[] {'a', 'b', 'c', 'c', 'd', 'e'},
                new char[][] {new char[] {'a', 'b'}, new char[] {'a', 'b'}}));

            var char11L1 = dummy.jvm.Arrays.char11_l1();
            Assert.AreEqual(10, char11L1.Length);
            Assert.IsNull(char11L1[0]);

            var char11_l2 = dummy.jvm.Arrays.char11_l2();
            Assert.AreEqual('a', char11_l2[1][0]);
            Assert.AreEqual('a', char11_l2[9][8]);
            Assert.AreEqual(0, char11_l2[2][2]);

            var char11_lj = dummy.jvm.Arrays.char11_lj();
            Assert.AreEqual(0, char11_lj[0].Length);
            Assert.AreEqual(1, char11_lj[1].Length);
            Assert.AreEqual(2, char11_lj[2].Length);
            Assert.AreEqual(3, char11_lj[3].Length);
            Assert.AreEqual(9, char11_lj[9].Length);
        }

        [Test]
        public void ShortTest()
        {
            var v1 = new Short(21);
            var v2 = new Short(21);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Short.MAX_VALUE);
            Assert.AreNotEqual(v1, Short.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new short[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new short[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new short[][] {new short[] {1, 2, 3}, new short[] {}, null}));

            var short11L1 = dummy.jvm.Arrays.short11_l1();
            Assert.AreEqual(10, short11L1.Length);
            Assert.IsNull(short11L1[0]);

            var short11_l2 = dummy.jvm.Arrays.short11_l2();
            Assert.AreEqual(1, short11_l2[1][0]);
            Assert.AreEqual(1, short11_l2[9][8]);
            Assert.AreEqual(0, short11_l2[2][2]);

            var short11_lj = dummy.jvm.Arrays.short11_lj();
            Assert.AreEqual(0, short11_lj[0].Length);
            Assert.AreEqual(1, short11_lj[1].Length);
            Assert.AreEqual(2, short11_lj[2].Length);
            Assert.AreEqual(3, short11_lj[3].Length);
            Assert.AreEqual(9, short11_lj[9].Length);
        }

        [Test]
        public void IntegerTest()
        {
            var v1 = new Integer(21);
            var v2 = new Integer(21);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Integer.MAX_VALUE);
            Assert.AreNotEqual(v1, Integer.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new int[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new int[][] {new int[] {1, 2, 3}, new int[] {}, null}));

            var int11L1 = dummy.jvm.Arrays.int11_l1();
            Assert.AreEqual(10, int11L1.Length);
            Assert.IsNull(int11L1[0]);

            var int11_l2 = dummy.jvm.Arrays.int11_l2();
            Assert.AreEqual(1, int11_l2[1][0]);
            Assert.AreEqual(1, int11_l2[9][8]);
            Assert.AreEqual(0, int11_l2[2][2]);

            var int11_lj = dummy.jvm.Arrays.int11_lj();
            Assert.AreEqual(0, int11_lj[0].Length);
            Assert.AreEqual(1, int11_lj[1].Length);
            Assert.AreEqual(2, int11_lj[2].Length);
            Assert.AreEqual(3, int11_lj[3].Length);
            Assert.AreEqual(9, int11_lj[9].Length);
        }

        [Test]
        public void LongTest()
        {
            var v1 = new Long(21);
            var v2 = new Long(21);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Long.MAX_VALUE);
            Assert.AreNotEqual(v1, Long.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new long[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new long[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new long[][] {new long[] {1, 2, 3}, new long[] {}, null}));

            var long11L1 = dummy.jvm.Arrays.long11_l1();
            Assert.AreEqual(10, long11L1.Length);
            Assert.IsNull(long11L1[0]);

            var long11_l2 = dummy.jvm.Arrays.long11_l2();
            Assert.AreEqual(1, long11_l2[1][0]);
            Assert.AreEqual(1, long11_l2[9][8]);
            Assert.AreEqual(0, long11_l2[2][2]);

            var long11_lj = dummy.jvm.Arrays.long11_lj();
            Assert.AreEqual(0, long11_lj[0].Length);
            Assert.AreEqual(1, long11_lj[1].Length);
            Assert.AreEqual(2, long11_lj[2].Length);
            Assert.AreEqual(3, long11_lj[3].Length);
            Assert.AreEqual(9, long11_lj[9].Length);
        }

        [Test]
        public void FloatTest()
        {
            var v1 = new Float(0.021);
            var v2 = new Float(0.021);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Float.MAX_VALUE);
            Assert.AreNotEqual(v1, Float.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new float[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new float[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new float[][] {new float[] {1, 2, 3}, new float[] {}, null}));

            var float11L1 = dummy.jvm.Arrays.float11_l1();
            Assert.AreEqual(10, float11L1.Length);
            Assert.IsNull(float11L1[0]);

            var float11_l2 = dummy.jvm.Arrays.float11_l2();
            Assert.AreEqual(1, float11_l2[1][0]);
            Assert.AreEqual(1, float11_l2[9][8]);
            Assert.AreEqual(0, float11_l2[2][2]);

            var float11_lj = dummy.jvm.Arrays.float11_lj();
            Assert.AreEqual(0, float11_lj[0].Length);
            Assert.AreEqual(1, float11_lj[1].Length);
            Assert.AreEqual(2, float11_lj[2].Length);
            Assert.AreEqual(3, float11_lj[3].Length);
            Assert.AreEqual(9, float11_lj[9].Length);
        }

        [Test]
        public void DoubleTest()
        {
            var v1 = new Double(0.021);
            var v2 = new Double(Double.parseDouble("0.021"));
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.toString());
            Console.WriteLine(Double.MAX_VALUE);
            Assert.AreNotEqual(v1, Double.MAX_VALUE);
            Assert.AreEqual(v1, v2);
            Assert.AreEqual(8, Arrays.binarySearch(new double[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19}, 13));
            Assert.IsFalse(dummy.jvm.Arrays.@equals(new double[] {1, 2, 3, 4, 5, 6, 6, 8, 13, 19},
                new double[][] {new double[] {1, 2, 3}, new double[] {}, null}));

            var double11L1 = dummy.jvm.Arrays.double11_l1();
            Assert.AreEqual(10, double11L1.Length);
            Assert.IsNull(double11L1[0]);

            var double11_l2 = dummy.jvm.Arrays.double11_l2();
            Assert.AreEqual(1, double11_l2[1][0]);
            Assert.AreEqual(1, double11_l2[9][8]);
            Assert.AreEqual(0, double11_l2[2][2]);

            var double11_lj = dummy.jvm.Arrays.double11_lj();
            Assert.AreEqual(0, double11_lj[0].Length);
            Assert.AreEqual(1, double11_lj[1].Length);
            Assert.AreEqual(2, double11_lj[2].Length);
            Assert.AreEqual(3, double11_lj[3].Length);
            Assert.AreEqual(9, double11_lj[9].Length);
        }


    }
}
