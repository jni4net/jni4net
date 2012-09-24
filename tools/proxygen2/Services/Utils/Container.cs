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
using System.Diagnostics;
using com.jni4net.proxygen.Interfaces;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services
{
    internal class Container : IContainer
    {
        private UnityContainer container;

        public Container()
        {
            container = new UnityContainer();
        }

        public UnityContainer UnityInstance
        {
            get { return container; }
        }

        [DebuggerStepThrough]
        public T Resolve<T>() where T : class
        {
            return container.Resolve(typeof (T)) as T;
        }

        [DebuggerStepThrough]
        public T Resolve<T>(string name) where T : class
        {
            return container.Resolve(typeof(T), name) as T;
        }

        
        public void Register<T>(T instance) where T : class
        {
            container.RegisterInstance(typeof (T), instance);
        }

        public void Dispose()
        {
            if(container!=null)
            {
                UnityContainer unityContainer = container;
                container = null;
                unityContainer.Dispose();
                
            }
        }
    }
}
