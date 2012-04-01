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
using System.Configuration;
using System.Diagnostics;

namespace dummy.clr
{
    public class Tested : ITested
    {
        public Tested()
        {
            intField = 123;
            intFieldRO = 123;
        }

        public readonly int intFieldRO;
        public static readonly int intStaticFieldRo=456;

        public int intField;
        public static int intStaticField = 456;

        public int test1(int value, string s, IList l)
        {
            int res;
            string value1 = ConfigurationManager.AppSettings["testAppConfig"];
            Console.WriteLine(value1);
            Int32.TryParse(value1, out res);
            return res;
        }

        public int test2(int value, string s, IList l)
        {
            return 2;
        }

        public int test3(int[] value, string[] s, IList[] l)
        {
            throw new System.NotImplementedException();
        }

        public void testSkip()
        {
            throw new System.NotImplementedException();
        }

        public void testOut(out int[] value, out object[] value2, out string[] srt, out IEnumerable[] enumerable, out BitArray[] array)
        {
            value = new Int32[2];
            value2 = new Object[2];
            value2[0] = new object();
            srt = new String[2];
            srt[0] = "sfdfsdf";
            enumerable = null;
            array = null;
        }

        public void testRef(ref int[] value, ref object[] value2, ref string[] srt, ref IEnumerable[] enumerable, ref BitArray[] array)
        {
            value = new Int32[2];
            value2 = new Object[2];
            value2[0] = new object();
            srt = new String[2];
            srt[0] = "sfdfsdf";
            enumerable = null;
            array = null;
        }

        public void testRef11(ref int[][] value, ref object[][] value2, ref string[][] srt, ref IEnumerable[][] enumerable, ref BitArray[][] array)
        {
            value = new[] { new int[] { 1 } };
            value2 = new[] { new object[] { 2 } };
            srt = new[] { new[] { "a" } };
            enumerable = new[] { new IEnumerable[] { new List<string>() } };
            array = new[] { new[] { new BitArray(1) } };
        }

        public int testOutint(out int value, out object value2, out string srt, out IEnumerable enumerable, out BitArray array)
        {
            throw new System.NotImplementedException();
        }

        public int testRefint(ref int value, ref object value2, ref string srt, ref IEnumerable enumerable, ref BitArray array)
        {
            throw new System.NotImplementedException();
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

        public int testGetSet { get; set; }

        public string this[int a]
        {
            get { return "a"; }
            set { throw new System.NotImplementedException(); }
        }

        string ITested.this[long a]
        {
            set { throw new System.NotImplementedException(); }
        }

        public int testGet { get { return 0; } }
        
        public int testSet { set{} }

        public int testGetPrivateSet { get; private set; }

        public int testSetPrivateGet { private get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}