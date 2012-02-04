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

namespace dummy.clr
{
    public class Interfaces
    {
        public interface Buufararable
        {
            int Buuf(object bar);
        }

        public interface Fuu : Buufararable
        {
            void fuu();
        }

        public interface Guu : Fuu
        {
            void guu();
        }

        public interface Zuu : Fuu
        {
            void zuu();
        }

        public interface Rab : Buufararable
        {
            void bar();
        }

        public class YourPublicY
        {
        }

        public class YourPublicZ : YourPublicY
        {
        }

        private class YourPrivateA : YourPublicZ, Buufararable
        {
            public int Buuf(object o)
            {
                return 0;
            }
        }

        private class YourPrivateB : YourPrivateA, ICloneable, Rab, Zuu
        {
            public void fuu()
            {
            }

            public void bar()
            {
            }

            public void zuu()
            {
            }

            public object Clone()
            {
                return new object();
            }
        }


        public static ICloneable getRunnable()
        {
            return new YourPrivateB();
        }

        public static Buufararable getBuufararableB()
        {
            return new YourPrivateB();
        }

        public static Buufararable getBuufararableA()
        {
            return new YourPrivateA();
        }

        public static Buufararable getBuufararableBG()
        {
            return new YourPrivateB();
        }

        public static Buufararable getBuufararableAG()
        {
            return new YourPrivateA();
        }

        public static Fuu getFuu()
        {
            return new YourPrivateB();
        }

        public static YourPublicZ getYourPublicZ()
        {
            return new YourPublicZ();
        }

        public static YourPublicZ getYourPublicA()
        {
            return new YourPrivateA();
        }

        public static YourPublicZ getYourPublicB()
        {
            return new YourPrivateB();
        }

        public static YourPublicY getYourPublicYZ()
        {
            return new YourPublicZ();
        }

        public static YourPublicY getYourPublicYA()
        {
            return new YourPrivateA();
        }

        public static YourPublicY getYourPublicYB()
        {
            return new YourPrivateB();
        }

        public static List<int> getListOfint()
        {
            return new List<int>();
        }

        public static IList getListOfintNG()
        {
            return new List<int>();
        }

        public static List<IList> getListOfList()
        {
            return new List<IList>();
        }

        public static List<List<Type>> getListOfListOfType()
        {
            return new List<List<Type>>();
        }

        public static int setListOfint(List<int> value)
        {
            return value.Count;
        }

        public static int setListOfintNG(IList value)
        {
            return value.Count;
        }

        public static int setListOfintAG<T>(List<T> value)
        {
            return value.Count;
        }

        public static int setListOfList(List<IList> value)
        {
            return value.Count;
        }

        public static int setListOfListOfType(List<List<Type>> value)
        {
            return value.Count;
        }
    }
}
