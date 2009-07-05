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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using Exception=java.lang.Exception;
using StringBuilder=System.Text.StringBuilder;

namespace net.sf.jni4net.proxygen
{
    public class Program
    {
        internal static int Main(string[] args)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                if (args.Length < 1 || !File.Exists(args[0]))
                {
                    Console.WriteLine("usage: proxygen.exe path\\to\\<config>.xml");
                    return -1;
                }
                var ser = new XmlSerializer(typeof (ToolConfig));
                string config = args[0];
                var cfg = ser.Deserialize(new FileStream(config, FileMode.Open)) as ToolConfig;
                Bridge.BindNative = false;
#if DEBUGa
                if (args.Length >= 2)
                {
                    cfg.TargetDirClr2Java = args[1] + cfg.TargetDirClr2Java;
                    cfg.TargetDirJava2Clr = args[1] + cfg.TargetDirJava2Clr;
                    cfg.TargetDirJava2Native = args[1] + cfg.TargetDirJava2Native;
                }
                cfg.Verbose = true;
                //Bridge.Verbose = true;
#endif
                Generate(cfg);
                Console.WriteLine("proxygen done");
                return 0;
            }
            catch(System.Exception ex)
            {
                Console.Write(ex.ToString());
                return -1;
            }
        }

        public static void Generate(ToolConfig config)
        {
            JavaVM vm;
            JNIEnv env;
            var knownAssemblies = new List<Assembly>();
            knownAssemblies.Add(typeof (object).Assembly);
            if (config.AssemblyReference != null)
            {
                foreach (string reference in config.AssemblyReference)
                {
                    if (Directory.Exists(reference))
                    {
                        foreach (string file in Directory.GetFiles(reference,"*.dll"))
                        {
                            LoadFile(knownAssemblies, config, file);
                        }
                        foreach (string file in Directory.GetFiles(reference, "*.exe"))
                        {
                            LoadFile(knownAssemblies, config, file);
                        }
                    }
                    else if (File.Exists(reference) || reference.Contains("..") || reference.Contains("\\") || reference.Contains("//"))
                    {
                        LoadFile(knownAssemblies, config, reference);
                    }
                    else
                    {
                        knownAssemblies.Add(Assembly.Load(reference));
                        if (config.Verbose)
                        {
                            Console.WriteLine("Loaded " + reference);
                        }
                    }
                }
            }
            if (config.AssemblyReference==null || config.AssemblyReference.Length==0)
            {
                knownAssemblies.Add(typeof(IJavaProxy).Assembly);
            }

            var cp = new StringBuilder();
            if (config.ClassPath != null)
            {
                cp.Append("-Djava.class.path=");
                foreach (string classPath in config.ClassPath)
                {
                    if (!Directory.Exists(classPath) && !File.Exists(classPath))
                    {
                        Console.Error.WriteLine("Can't find "+ Path.GetFullPath(classPath));
                    }
                    else if (config.Verbose)
                    {
                        Console.WriteLine("Adding "+ Path.GetFullPath(classPath));
                    }
                    cp.Append(classPath);
                    cp.Append(';');
                }
                cp.Length--;
                Bridge.CreateJVM(out vm, out env, cp.ToString());
            }
            else
            {
                Bridge.CreateJVM(out vm, out env);
            }
            var generator = new Generator(config);
            if (config.SkipKnown)
            {
                generator.RegisterKnownAssemblies(knownAssemblies);
            }
            else
            {
                knownAssemblies.Add(typeof(IJavaProxy).Assembly);
                generator.RegisterKnownCore(knownAssemblies);
            }
            if (config.JavaClass != null)
            {
                foreach (string className in config.JavaClass)
                {
                    string name = className.Replace(".", "/");
                    Class clazz = env.FindClassNoThrow(name);
                    if (clazz != null)
                    {
                        generator.RegisterClass(clazz);
                    }
                    else
                    {
                        Console.Error.WriteLine("Can't load class "+className);
                    }
                }
            }
            if (config.ClrType!=null)
            {
                foreach (string typeName in config.ClrType)
                {
                    Type type = null;
                    foreach (Assembly a in knownAssemblies)
                    {
                        type = a.GetType(typeName);
                        if (type != null)
                        {
                            break;
                        }
                    }

                    if (type == null)
                    {
                        Console.Error.WriteLine("Can't load type" + typeName);
                        return;
                    }
                    generator.RegisterType(type);
                }
            }
            generator.Analyze();
            generator.Generate(config);
        }

        private static void LoadFile(List<Assembly> knownAssemblies, ToolConfig config, string file)
        {
            string path = Path.GetFullPath(file);
            try
            {
                knownAssemblies.Add(Assembly.LoadFrom(path));
                if (config.Verbose)
                {
                    Console.WriteLine("Loaded " + path);
                }
            }
            catch(Exception)
            {
                Console.Error.WriteLine("Can't load " + path);
                //ignore
            }
        }
    }
}