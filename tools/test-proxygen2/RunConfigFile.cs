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

using NUnit.Framework;

namespace test.proxygen
{
    [Explicit]
    public class RunConfigFile:TestBase
    {
        [SetUp]
        public void Reset()
        {
            Init();
        }

        [Test, Explicit]
        public void Generate_Objects()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\runtime\jni4net\jni4net-j4n.xml","--verbose" });
        }

        [Test, Explicit]
        public void Generate_Micro_Jre15()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\proxies\jre-micro-j4n\jre-micro-j4n.xml" });
        }

        [Test, Explicit]
        public void Generate_Micro_MsCorLib()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\proxies\mscorlib-micro-j4n\mscorlib-micro-j4n.xml" });
        }

        [Test, Explicit]
        public void Generate_Dummy_Jvm()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\proxies\dummy-j-j4n\dummy-j-j4n.xml" });
        }

        [Test, Explicit]
        public void Generate_Dummy_Clr()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\proxies\dummy-n-j4n\dummy-n-j4n.xml" });
        }

        [Test, Explicit]
        public void Generate_Ecj()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\proxies\ecj-j4n\ecj-j4n.xml", "--compile" });
        }

        /*
        [Test, Explicit]
        public void Generate_Core_Jre15()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\jre15-core-j4n\jre15-core-j4n.xml" });
        }

        [Test, Explicit]
        public void Generate_MsCorLib_20()
        {
            com.jni4net.proxygen.Proxygen.Run(new[] { @"..\..\..\mscorlib-20-j4n\mscorlib-20-j4n.xml" });
        }*/

    }
}
