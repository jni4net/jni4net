/* Copyright (C) 2012 by Pavel Savara
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

package dummy2.jvm;

import dummy.clr.ITested;
import net.sf.jni4net.Out;
import net.sf.jni4net.Ref;
import system.Int32;
import system.MulticastDelegate;
import system.collections.ICollection;
import system.collections.IEnumerable;
import system.collections.IList;

import java.util.ArrayList;

public class JTested implements ITested {
    public void addPropertyChanged(MulticastDelegate value) {
    }

    public String getItem(int a) {
        return null;
    }

    public int gettestGet() {
        return 0;
    }

    public int gettestGetPrivateSet() {
        return 0;
    }

    public int gettestGetSet() {
        return 0;
    }

    public void removePropertyChanged(MulticastDelegate value) {
    }

    public void setItem(int a, String value) {
    }

    public void setItem(long a, String value) {
    }

    public void settestGetSet(int value) {
    }

    public void settestSet(int value) {
    }

    public void settestSetPrivateGet(int value) {
    }

    public int test1(int value, String s, IList l) {
        return 0;
    }

    public int test2(int value, String s, IList l) {
        return 0;
    }

    public int test3(int[] value, String[] s, IList[] l) {
        return 0;
    }

    public void testOut(Out<Int32[]> value, Out<Object[]> value2, Out<String[]> srt, Out<IEnumerable[]> enumerable, Out<ICollection[]> array) {
        ArrayList list = new ArrayList();
        list.add(new Integer(1));
        list.add(new Integer(2));
        Int32[] newValue = new Int32[2];
        value.setValue(newValue);
        Object[] newValue2 = new Object[2];
        newValue2[0]=list;
        value2.setValue(newValue2);
        String[] strs = new String[2];
        strs[0]="sfdfsdf";
        srt.setValue(strs);
        enumerable.setValue(null);
        array.setValue(null);
    }

    public void testOutCallback(ITested callback, Out<Int32[]> value, Out<Object[]> value2, Out<String[]> srt, Out<IEnumerable[]> enumerable, Out<ICollection[]> array) {
        callback.testOut(value, value2, srt, enumerable, array);
    }

    public void testRefCallback(ITested callback, Ref<Int32[]> value, Ref<Object[]> value2, Ref<String[]> srt, Ref<IEnumerable[]> enumerable, Ref<ICollection[]> array) {
        callback.testRef(value, value2, srt, enumerable, array);
    }

    public void testRefCallback11(ITested callback, Ref<Int32[][]> value, Ref<Object[][]> value2, Ref<String[][]> srt, Ref<IEnumerable[][]> enumerable, Ref<ICollection[][]> array) {
        callback.testRef11(value, value2, srt, enumerable, array);
    }

    public int testOutint(Out<Int32> value, Out<Object> value2, Out<String> srt, Out<IEnumerable> enumerable, Out<ICollection> array) {
        ArrayList list = new ArrayList();
        list.add(new Integer(1));
        list.add(new Integer(2));
        value2.setValue(list);
        value.setValue(new Int32(list.size()));
        srt.setValue("test");
        enumerable.setValue(null);
        array.setValue(null);
        return 0;
    }

    public void testRef(Ref<Int32[]> value, Ref<Object[]> value2, Ref<String[]> srt, Ref<IEnumerable[]> enumerable, Ref<ICollection[]> array) {
        ArrayList list = new ArrayList();
        list.add(new Integer(1));
        list.add(new Integer(2));
        Int32[] newValue = new Int32[2];
        value.setValue(newValue);
        Object[] newValue2 = new Object[2];
        newValue2[0]=list;
        value2.setValue(newValue2);
        String[] strs = new String[2];
        strs[0]="sfdfsdf";
        srt.setValue(strs);
        enumerable.setValue(null);
        array.setValue(null);
    }

    public void testRef11(Ref<Int32[][]> value, Ref<Object[][]> value2, Ref<String[][]> srt, Ref<IEnumerable[][]> enumerable, Ref<ICollection[][]> array) {
        ArrayList list = new ArrayList();
        list.add(new Integer(1));
        list.add(new Integer(2));
        Int32[][] newValue = new Int32[2][];
        value.setValue(newValue);
        Object[][] newValue2 = new Object[2][];
        newValue2[0]=new Object[2];
        newValue2[0][0]=list;
        value2.setValue(newValue2);
        String[][] strs = new String[2][];
        strs[0]=new String[2];
        strs[0][0]="sfdfsdf";
        srt.setValue(strs);
        enumerable.setValue(null);
        array.setValue(null);
    }

    public int testRefint(Ref<Int32> value, Ref<Object> value2, Ref<String> srt, Ref<IEnumerable> enumerable, Ref<ICollection> array) {
        ArrayList list = new ArrayList();
        list.add(new Integer(1));
        list.add(new Integer(2));
        value2.setValue(list);
        value.setValue(new Int32(value.getValue().value()+1));
        srt.setValue("test"+srt.getValue());
        enumerable.setValue(null);
        array.setValue(null);
        return 0;
    }
}
