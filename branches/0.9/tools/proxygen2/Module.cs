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

using System.Collections.Generic;
using polyglottos;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen
{
    class Module : IModule
    {
        public void Init(IUnityContainer container)
        {
            container
                .RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager())
                .RegisterType<Configurator, Configurator>(new ContainerControlledLifetimeManager())
                .RegisterType<Proxygen>(new ContainerControlledLifetimeManager())


                .RegisterType<IExplorer,Explorer>(new ContainerControlledLifetimeManager())
                .RegisterType<IWorkQueue, WorkQueue>(new ContainerControlledLifetimeManager())
                .RegisterType<IJvmResolver, JvmResolver>(new ContainerControlledLifetimeManager())
                .RegisterType<IClrResolver, ClrResolver>(new ContainerControlledLifetimeManager())
                .RegisterType<ICommonResolver, CommonResolver>(new ContainerControlledLifetimeManager())
                .RegisterType<ITypeRepository, TypeRepository>(new ContainerControlledLifetimeManager())

                .RegisterType<IProcessor, NameProcessor>("NameProcessor")
                .RegisterType<IProcessor, RootsProcessor>("RootsProcessor")
                .RegisterType<IProcessor, LeavesProcessor>("LeavesProcessor")
                .RegisterType<IProcessor, DoneProcessor>("DoneProcessor")
                .RegisterType<IEnumerable<IProcessor>, IProcessor[]>()
                ;
            container
                .RegisterInstance<IKnownTypes>(container.Resolve<ITypeRepository>());

        }
    }
}
