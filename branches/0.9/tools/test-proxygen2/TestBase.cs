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
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using com.jni4net.proxygen;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services;
using net.sf.jni4net;
using NUnit.Framework;

namespace test.proxygen
{
    [TestFixture]
    public abstract class TestBase
    {
        private static bool _bridgeInit;
        protected IContainer Container;
        protected Proxygen Proxygen;
        protected Configurator Configurator;
        protected Explorer Explorer;
        protected IClrResolver ClrResolver;
        protected IJvmResolver JvmResolver;
        protected IKnownTypes TypeRepository;

        protected virtual bool LoadPlugins { get { return false; } }

        [TestFixtureSetUp]
        public void Init()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            if (!_bridgeInit)
            {
                var bridgeSetup = new BridgeSetup();
                bridgeSetup.JavaHome = @"c:\Program Files (x86)\Java\jdk1.5.0_22";
                bridgeSetup.AllowJVMJoin = true;
                bridgeSetup.BindClrProxies = false;
                bridgeSetup.AddAllJarsClassPathBaseDirectory();
                //bridgeSetup.IgnoreJavaHome = true;
                J4NBridge.CreateJVM(bridgeSetup);
                _bridgeInit = true;
            }
            Container = Proxygen.Configure(LoadPlugins);
            Configurator = Container.Resolve<Configurator>();
            Proxygen = Container.Resolve<Proxygen>();
            Explorer = Container.Resolve<Explorer>();
            ClrResolver = Container.Resolve<IClrResolver>();
            JvmResolver = Container.Resolve<IJvmResolver>();
            TypeRepository = Container.Resolve<IKnownTypes>();
        }
    }
}
