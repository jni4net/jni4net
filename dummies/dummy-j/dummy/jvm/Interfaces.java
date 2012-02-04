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

package dummy.jvm;

import java.util.ArrayList;
import java.util.List;

public class Interfaces {

    //TODO Foobararable<MyPublicZ>
    public static interface Foo extends Foobararable<Object> {
        void foo();
    }

    public static interface Goo extends Foo {
        void goo();
    }

    public static interface Zoo extends Foo {
        void zoo();
    }

    //TODO Foobararable<MyPublicZ>
    public static interface Bar extends Foobararable<Object> {
        void bar();
    }

    public static class MyPublicY {
    }

    public static class MyPublicZ extends MyPublicY {
    }

    //TODO Foobararable<MyPublicZ>
    static class MyPrivateA extends MyPublicZ implements Foobararable<Object>{
        public int Foob
                (Object o) {
            return 0;
        }
    }

    static class MyPrivateB extends MyPrivateA implements Runnable, Foo, Bar, Zoo{
        public void run() {
        }

        public void foo() {
        }

        public void bar() {
        }

        public void zoo() {
        }
    }


    public static Runnable getRunnable(){
        return new MyPrivateB();
    }

    public static Foobararable getFoobararableB(){
        return new MyPrivateB();
    }

    public static Foobararable getFoobararableA(){
        return new MyPrivateA();
    }

    //TODO Foobararable<MyPublicZ>
    public static Foobararable<Object> getFoobararableBG(){
        return new MyPrivateB();
    }

    //TODO Foobararable<MyPublicZ>
    public static Foobararable<Object> getFoobararableAG(){
        return new MyPrivateA();
    }

    public static Foo getFoo(){
        return new MyPrivateB();
    }

    public static MyPublicZ getMyPublicZ(){
        return new MyPublicZ();
    }

    public static MyPublicZ getMyPublicA(){
        return new MyPrivateA();
    }

    public static MyPublicZ getMyPublicB(){
        return new MyPrivateB();
    }

    public static MyPublicY getMyPublicYZ(){
        return new MyPublicZ();
    }

    public static MyPublicY getMyPublicYA(){
        return new MyPrivateA();
    }

    public static MyPublicY getMyPublicYB(){
        return new MyPrivateB();
    }

    public static List<Integer> getListOfInteger(){
        return new ArrayList<Integer>();
    }

    public static List getListOfIntegerNG(){
        return new ArrayList<Integer>();
    }

    public static List<List> getListOfList(){
        return new ArrayList<List>();
    }

    public static List<List<Class>> getListOfListOfClass(){
        return new ArrayList<List<Class>>();
    }

    public static int setListOfInteger(List<Integer> value){
        return value.size();
    }

    public static int setListOfIntegerNG(List value){
        return value.size();
    }

    public static int setListOfIntegerAG(List<?> value){
        return value.size();
    }

    public static int setListOfList(List<List> value){
        return value.size();
    }

    public static int setListOfListOfClass(List<List<Class>> value){
        return value.size();
    }

}
