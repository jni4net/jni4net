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

using net.sf.jni4net.tested;
using NUnit.Framework;
using String = java.lang.String;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class CallInstanceFieldsTest : TestBase
    {
        private JavaInstanceFields testInstance;

        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
            testInstance = new JavaInstanceFields();
        }

        [Test]
        public void byteField()
        {
            byte data = testInstance.byteField;
            Assert.AreEqual(6, data);
        }

        [Test]
        public void charField()
        {
            char data = testInstance.charField;
            Assert.IsTrue('x'.Equals(data));
        }

        [Test]
        public void intField()
        {
            int data = testInstance.intField;
            Assert.AreEqual(1033, data);
        }

        [Test]
        public void stringField()
        {
            var data = testInstance.stringField;
            Assert.IsTrue(data.equals((String) "ManicMiner"));
        }
    }
}