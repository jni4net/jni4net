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
using System.Globalization;
using System.Threading;
using net.sf.jni4net.jni;
using net.sf.jni4net.tested;
using NUnit.Framework;

namespace net.sf.jni4net.test
{
    public abstract class TestBase
    {
        protected JavaVM vm;
        protected JNIEnv env;

        [TestFixtureSetUp]
        public virtual void Setup()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Bridge.Verbose = true;
            Bridge.Debug = true;
            if (Environment.CurrentDirectory.EndsWith("target"))
            {
                Bridge.CreateJVM(out vm, out env,
                                 "-Djava.class.path=../../jni4net.j/target/classes;../../jni4net.tested.j/target/classes;../../jni4net.test.j/target/test-classes");
            }
            else
            {
                Console.WriteLine("Current Directory "+Environment.CurrentDirectory);
                Bridge.CreateJVM(out vm, out env,
                                 "-Djava.class.path=../../../jni4net.j/target/classes;../../../jni4net.tested.j/target/classes;../../../jni4net.test.j/target/test-classes");
            }
            Bridge.RegisterAssembly(typeof(TestBase).Assembly);
            Bridge.RegisterAssembly(typeof(JavaInstanceFields).Assembly);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            //Assert.AreEqual(JNIResult.JNI_OK, vm.DestroyJavaVM());
        }
    }
}