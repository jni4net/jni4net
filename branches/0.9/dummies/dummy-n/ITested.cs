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

using System.Collections;
using System.ComponentModel;

namespace dummy.clr
{
    public interface ITestedFactory
    {
        ITested createJTested();
    }

    public interface ITested
    {
        int test1(int value, string s, IList l);
        int test2(int value, string s, IList l);
        int test3(int[] value, string[] s, IList[] l);
        void testSkip();
        void testOut(out int[] value, out object[] value2, out string[] srt, out IEnumerable[] enumerable, out BitArray[] array);
        void testRef(ref int[] value, ref object[] value2, ref string[] srt, ref IEnumerable[] enumerable, ref BitArray[] array);
        void testRef11(ref int[][] value, ref object[][] value2, ref string[][] srt, ref IEnumerable[][] enumerable, ref BitArray[][] array);

        int testOutint(out int value, out object value2, out string srt, out IEnumerable enumerable, out BitArray array);
        int testRefint(ref int value, ref object value2, ref string srt, ref IEnumerable enumerable, ref BitArray array);

        void testOutCallback(ITested callback, out int[] value, out object[] value2, out string[] srt, out IEnumerable[] enumerable, out BitArray[] array);
        void testRefCallback(ITested callback, ref int[] value, ref object[] value2, ref string[] srt, ref IEnumerable[] enumerable, ref BitArray[] array);
        void testRefCallback11(ITested callback, ref int[][] value, ref object[][] value2, ref string[][] srt, ref IEnumerable[][] enumerable, ref BitArray[][] array);
        
        int testGetSet { get; set; }
        
        string this[int a] { get; set; }

        string this[long a] { set; }

        int testGet { get; }

        int testSet { set; }

        int testGetPrivateSet { get; }

        int testSetPrivateGet { set; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
