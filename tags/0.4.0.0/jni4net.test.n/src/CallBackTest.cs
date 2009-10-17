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
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.tested;
using NUnit.Framework;
using Exception = java.lang.Exception;
using Object = java.lang.Object;
using String = java.lang.String;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class CallBackTest : TestBase
    {
        [Test]
        public void CallMeFromJava()
        {
            Class testClass = env.FindClass("net/sf/jni4net/tested/JavaToClrReflection");
            Object test = testClass.newInstance();
            test.getClass().Invoke("reflect", "()V");
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException), ExpectedMessage = "clr")]
        public void CallBackExceptionPropagate()
        {
            JavaCallBack.callBackExceptionPropagate();
        }

        [Test]
        public void CallMeFromJavaException()
        {
            JavaCallBack.callBackException();
        }

        [Test]
        public void CallMeFromJavaComparison()
        {
            int res = JavaCallBack.callBackComparison();
            Assert.AreEqual(1, res);
        }

        [Test]
        public void CallMeFromJavaComparison2()
        {
            int res = JavaCallBack.callBackComparison2();
            Assert.AreEqual(1,res);
        }

        [Test]
        public void CallBackRun()
        {
            int res = JavaCallBack.callBackRun();
            Assert.AreEqual(3, res);
        }

        
        [Test]
        [Explicit]
        public void HeavyCallMeFromJava()
        {
            var start = DateTime.Now;
            Class testClass = env.FindClass("net/sf/jni4net/tested/JavaToClrReflection");
            Object test = testClass.newInstance();
            MethodId methodId = env.GetStaticMethodID(test.getClass(), "reflect", "()V");
            for (int i = 0; i < 100000; i++)
            {
                env.CallVoidMethod(test,methodId);
            }
            var end = DateTime.Now;

            Console.WriteLine(end - start);
        }
    
    }
}
