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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using com.jni4net.proxygen.Config;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services;

namespace com.jni4net.proxygen
{
    public class Proxygen
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public IExplorer Explorer { get; set; }

        [Dependency]
        public IWorkQueue WorkQueue { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public static IContainer Configure(bool loadPlugins)
        {
            var c = new Container();
            c.UnityInstance
                .RegisterInstance<IContainer>(c);

            LoadModules(c.UnityInstance, loadPlugins);
            return c;
        }

        private static void LoadModules(IUnityContainer container, bool loadPlugins)
        {
            Assembly myAssembly = typeof(Proxygen).Assembly;
            LoadAssembly(myAssembly, container);
            if (loadPlugins)
            {
                var exeDir = Path.GetDirectoryName(myAssembly.Location);
                foreach (var dll in Directory.GetFiles(exeDir, "proxy*.dll"))
                {
                    var ma = Assembly.LoadFrom(dll);
                    LoadAssembly(ma, container);
                }
            }
        }

        private static void LoadAssembly(Assembly assembly, IUnityContainer container)
        {
            var moduleTypes = assembly.GetTypes().Where(mt => typeof(IModule).IsAssignableFrom(mt) && !mt.IsInterface && !mt.IsAbstract);
            foreach (var moduleType in moduleTypes)
            {
                var module = Activator.CreateInstance(moduleType) as IModule;
                module.Init(container);
            }
        }

        public static int Run(string[] args)
        {
            IContainer container = Configure(true);
            var proxygen = container.Resolve<Proxygen>();
            int res = proxygen.RunImpl(args);
            container.Dispose();
            return res;
        }

        public int RunImpl(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            // process commandline
            if(!Configurator.ProcessCommandLine(args))
            {
                return -1;
            }

            Logger.Verbose = Configurator.Verbose;

            Explorer.Init(Configurator.Config);

            WorkQueue.Run();

            return 0;
        }


    }
}
