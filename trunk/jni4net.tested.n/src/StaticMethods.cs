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
using System.Reflection;
using String = java.lang.String;

namespace net.sf.jni4net.tested
{
    public class StaticMethods
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        #region REF+OUT

        public static void TestOutParamS(out String text)
        {
            text = "Ahoj";
        }

        public static void TestRefParamS(ref String text)
        {
            text = text + "Ahoj";
        }

        public static void TestRefParamSa(ref String[] text)
        {
        }

        public static void TestRefParamPa(ref char[] text)
        {
        }

        public static void TestRefParamBa(out byte[] text, int a, char f)
        {
            text = null;
        }

        public static void TestOutParam(out int num)
        {
            num = 1;
        }

        public static int TestRefParam(ref int num)
        {
            num = num - 1;
            return -1;
        }

        #endregion

        #region delegate + event

        //implementation
        object TestDelegateImpl(int i, String s)
        {
            return s + i;
        }

        public TestDelegate fcePtr;

        TestDelegate fcePtrProp { get; set; }

        public event TestDelegate EnvDispatcher;

        public event TestDelegate EnvDispatcherProp
        {
            add { EnvDispatcher += value; }
            remove { EnvDispatcher -= value; }
        }

        //type
        private interface JDdd
        {
            object Ddd(int i, string s);
        }

        private class CWrapper
        {
            public CWrapper(JDdd jproxy)
            {
                this.jproxy = jproxy;
            }

            private JDdd jproxy;

            public object DddFwd(int i, string s)
            {
                return jproxy.Ddd(i, s);
            }
        }

        private class JWrapper : JDdd
        {
            public JWrapper(TestDelegate del)
            {
                this.del = del;
            }

            private TestDelegate del;

            public object Ddd(int i, string s)
            {
                return del.Invoke(i, s);
            }

            public static implicit operator JWrapper(TestDelegate str)
            {
                return new JWrapper(str);
            }
        }

        TestDelegate J2C(JDdd i)
        {
            CWrapper w=new CWrapper(i);
            return w.DddFwd;
        }

        JDdd C2J(TestDelegate d)
        {
            JWrapper jWrapper=d;
            return jWrapper;
        }


        #endregion
    }


}
