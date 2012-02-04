#region Copyright (C) 2012 by Pavel Savara

/*
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

#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace dummy.clr
{
    public class InterfacesFactory
    {
        private class MyITested : ITested
        {
            public int test1(int value, string s, IList c)
            {
                return value + 1;
            }

            public int test2(int value, string s, IList c)
            {
                return value + 2;
            }

            public int test3(int[] value, string[] s, IList[] l)
            {
                throw new NotImplementedException();
            }

            public void testSkip()
            {
                throw new NotImplementedException();
            }

            public void testOut(out int[] value, out object[] value2, out string[] srt, out IEnumerable[] enumerable, out BitArray[] array)
            {
                value = new []{1};
                value2 = new object[]{2};
                srt = new [] { "a" };
                enumerable = new IEnumerable[] { new List<string>() };
                array = new [] { new BitArray(1) };
            }

            public void testRef(ref int[] value, ref object[] value2, ref string[] srt, ref IEnumerable[] enumerable, ref BitArray[] array)
            {
                value = new [] { 1 };
                value2 = new object[] { 2 };
                srt = new [] { "a" };
                enumerable = new IEnumerable[] { new List<string>() };
                array = new [] { new BitArray(1) };
            }

            public void testRef11(ref int[][] value, ref object[][] value2, ref string[][] srt, ref IEnumerable[][] enumerable, ref BitArray[][] array)
            {
                value = new []{new int[]{1}};
                value2 = new []{new object[] { 2 }};
                srt = new []{new[] { "a" }};
                enumerable = new []{new IEnumerable[] { new List<string>() }};
                array = new []{new[] { new BitArray(1) }};
            }

            public int testOutint(out int value, out object value2, out string srt, out IEnumerable enumerable, out BitArray array)
            {
                value = 1;
                value2 = 2;
                srt = "a";
                enumerable = new List<string>();
                array = new BitArray(1);
                return 1;
            }

            public int testRefint(ref int value, ref object value2, ref string srt, ref IEnumerable enumerable, ref BitArray array)
            {
                value = 1;
                value2 = 2;
                srt = "a";
                enumerable = new List<string>();
                array = new BitArray(1);
                return 2;
            }

            public void testOutCallback(ITested callback, out int[] value, out object[] value2, out string[] srt, out IEnumerable[] enumerable, out BitArray[] array)
            {
                callback.testOut(out value, out value2, out srt, out enumerable, out array);
            }

            public void testRefCallback(ITested callback, ref int[] value, ref object[] value2, ref string[] srt, ref IEnumerable[] enumerable, ref BitArray[] array)
            {
                callback.testRef(ref value, ref value2, ref srt, ref enumerable, ref array);
            }

            public void testRefCallback11(ITested callback, ref int[][] value, ref object[][] value2, ref string[][] srt, ref IEnumerable[][] enumerable, ref BitArray[][] array)
            {
                callback.testRef11(ref value, ref value2, ref srt, ref enumerable, ref array);
            }

            public int testGetSet
            {
                get; set; }

            public string this[int a]
            {
                get { return "a"; }
                set { }
            }

            string ITested.this[long a]
            {
                set { }
            }

            public int testGet
            {
                get { return 1; }
            }

            public int testSet
            {
                set { }
            }

            public int testGetPrivateSet
            {
                get { return 1; }
            }

            public int testSetPrivateGet
            {
                set {  }
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public static ITested createITested()
        {
            return new MyITested();
        }

        public static Tested createTested()
        {
            return new Tested();
        }
    }
}
