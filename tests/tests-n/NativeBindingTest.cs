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
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using NUnit.Framework;
using dummy.clr;
using java.lang;
using java.lang.reflect;
using net.sf.jni4net;

#if JNI4NETPRO
namespace tests.n.pro
#else
namespace tests.n
#endif
{
    [TestFixture]
    class NativeBindingTest : TestBase
    {
        [Test]
        public void Stupid()
        {
            int res;
            string value1 = ConfigurationManager.AppSettings["testAppConfig"];
            Int32.TryParse(value1, out res);
        }

        [Test]
        public void BindingTest()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy.clr.InterfacesFactory");
            Method method = ifact.getMethod("createITested", new Class[]{});
            method.invoke(null, new object[] { });

            Method method2 = ifact.getMethod("createTested", new Class[] { });
            object tested = method2.invoke(null, new object[] {});
        }


        [Test]
        public void OutTest()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory) ifact.newInstance();
            var jtested = factory.createJTested();

            int v;
            object v2;
            string s;
            IEnumerable e;
            BitArray be;
            jtested.testOutint(out v, out v2, out s, out e, out be);
            Assert.AreEqual(2, v);
            var vl2 = (java.util.List)v2;
            Assert.AreEqual(2, vl2.size());
            vl2.add(new Integer(1));
            Assert.AreEqual(3, vl2.size());
            Assert.AreEqual("test", s);
        }


        [Test]
        public void OutTest2()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            int[] v;
            object[] v2;
            string[] s;
            IEnumerable[] e;
            BitArray[] be;
            jtested.testOut(out v, out v2, out s, out e, out be);
            Assert.AreEqual(new []{0,0}, v);
            Assert.AreEqual(2, v2.Length);
            Assert.AreEqual(new[] { "sfdfsdf",null}, s);
        }

        [Test]
        public void OutTest3()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            int[] v;
            object[] v2;
            string[] s;
            IEnumerable[] e;
            BitArray[] be;
            jtested.testOutCallback(new Tested(), out v, out v2, out s, out e, out be);
            Assert.AreEqual(new []{0,0}, v);
            Assert.AreEqual(2, v2.Length);
            Assert.AreEqual(new[] { "sfdfsdf",null}, s);
        }

        [Test]
        public void RefTest()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            int v=5;
            object v2="aaa";
            string s="sss";
            IEnumerable e=new ArrayList();
            var be=new BitArray(1,true);
            jtested.testRefint(ref v, ref v2, ref s, ref e, ref be);
            Assert.AreEqual(6, v);
            var vl2 = (java.util.List)v2;
            Assert.AreEqual(2, vl2.size());
            vl2.add(new Integer(1));
            Assert.AreEqual(3, vl2.size());
            Assert.AreEqual("testsss", s);
        }

        [Test]
        public void RefTest2()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            var v=new int[1];
            var v2=new object[1];
            var s=new string[3];
            var e=new IEnumerable[6];
            var be=new BitArray[1];
            jtested.testRef(ref v, ref v2, ref s, ref e, ref be);
            Assert.AreEqual(new[] { 0, 0 }, v);
            Assert.AreEqual(2, v2.Length);
            Assert.AreEqual(new[] { "sfdfsdf", null }, s);
        }

        [Test]
        public void RefTest3()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            var v=new int[1];
            var v2=new object[1];
            var s=new string[3];
            var e=new IEnumerable[6];
            var be=new BitArray[1];
            jtested.testRefCallback(new Tested(), ref v, ref v2, ref s, ref e, ref be);
            Assert.AreEqual(new[] { 0, 0 }, v);
            Assert.AreEqual(2, v2.Length);
            Assert.AreEqual(new[] { "sfdfsdf", null }, s);
        }

        [Test]
        public void RefTest4()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy2.jvm.JTestedFactory");
            var factory = (ITestedFactory)ifact.newInstance();
            var jtested = factory.createJTested();

            var v=new []{new int[1]};
            var v2 = new[] { new object[1] };
            var s=new []{new string[3]};
            var e=new []{new IEnumerable[6]};
            var be=new []{new BitArray[1]};
            jtested.testRefCallback11(new Tested(), ref v, ref v2, ref s, ref e, ref be);
            Assert.AreEqual(new []{new[] { 1 }}, v);
            Assert.AreEqual(1, v2.Length);
            Assert.AreEqual(new []{new[] { "a" }}, s);
        }

        [Test, Explicit]
        public void AllocationTest()
        {
            var ifact = (Class)J4NBridge.Setup.DefaultClassLoader.loadClass("dummy.clr.InterfacesFactory");
            Method method = ifact.getMethod("createITested", new Class[] { });
            Method method2 = ifact.getMethod("createTested", new Class[] { });

            for (int i = 0; i < 1000; i++)
            {
                method.invoke(null, new object[] { });
                object tested = method2.invoke(null, new object[] { });
            }
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            Thread.Sleep(1000);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();

        }
    }
}
