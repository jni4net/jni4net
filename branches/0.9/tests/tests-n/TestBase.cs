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
using NUnit.Framework;
using net.sf.jni4net;

#if JNI4NETPRO
namespace tests.n.pro
#else
namespace tests.n
#endif
{
    public abstract class TestBase
    {
        private AttachedJVM jvm;
        
        [TestFixtureSetUp]
        public void Setup()
        {
            var j4NSetup = new BridgeSetup
                               {
                                   LogLevel = LogLevel.Debug,
                                   //EnforceThreadDetach = true,
                                   AllowJVMJoin = true,
                                   EnforceImmediateBinding = true,
                                   JavaVersion = "1.5",
                                   //JavaHome = @"c:\Program Files (x86)\Java\jdk1.7.0" ,
                               };
            //j4NSetup.AddJVMOption("-verbose");
            //j4NSetup.AddJVMOption("-verbose:jni");
            //j4NSetup.AddJVMOption("-Xcheck:jni");
            AddClassPath(j4NSetup);
            jvm = J4NBridge.CreateJVM(j4NSetup);
        }

        protected virtual void AddClassPath(BridgeSetup j4NSetup)
        {
            //j4NSetup.AddClassPath("dummy-j.jar");
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            jvm.Dispose();
        }
    }
}