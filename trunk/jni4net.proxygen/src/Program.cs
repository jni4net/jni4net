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
using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.generator;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen
{
    public class Program
    {
        private static string lib;
        internal static int Main(string[] args)
        {
            try
            {
                Console.WriteLine("jni4net.proxygen - Copyright (C) 2009 Pavel Savara - licensed under GPLv3");

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                if (args.Length < 1 || (!File.Exists(args[0])) && !Directory.Exists(args[0]))
                {
                    Console.WriteLine();
                    Console.WriteLine("usage: proxygen.exe path\\to\\<config>.xml");
                    Console.WriteLine("usage: proxygen.exe path\\to\\<library>.jar -wd work\\directory -cp java\\dependencies;comma\\separated;classpath -dp .NET\\dependencies;comma\\separated;assemblies");
                    Console.WriteLine("usage: proxygen.exe path\\to\\<library>.dll -wd work\\directory -cp java\\dependencies;comma\\separated;classpath -dp .NET\\dependencies;comma\\separated;assemblies");
                    return -1;
                }

                Version version = typeof(Program).Assembly.GetName().Version;
                lib = typeof(Program).Assembly.Location.Replace("proxygen.exe", "jni4net.n-" + version + ".dll").Replace("jni4net.jni4net.n", "jni4net.n");
                if (!File.Exists(lib))
                {
                    lib = lib.Replace("\\bin\\", "\\lib\\");
                }

                AppDomain currentDomain = AppDomain.CurrentDomain;
                currentDomain.AssemblyResolve += AssemblyResolve;
                
                return Work(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.Write(ex.ToString());
                return -1;
            }
        }

        static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("jni4net.n"))
            {
                return Assembly.LoadFrom(lib);
            }
            return null;
        }

        private static int Work(string[] args)
        {
            ToolConfig cfg;
            string ext = Path.GetExtension(args[0]).ToLowerInvariant();
            string workDir = null;
            string clr = null;
            string jvm = null;
            if (ext == ".xml")
            {
                string config = args[0];
                var ser = new XmlSerializer(typeof(ToolConfig));
                cfg = ser.Deserialize(new FileStream(config, FileMode.Open)) as ToolConfig;
            }
            else if (ext == ".dll" || ext == ".jar" || Directory.Exists(args[0]))
            {
                cfg = new ToolConfig();
                if (args[1] == "-wd")
                {
                    workDir = args[2];
                }
                else
                {
                    workDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    Console.WriteLine("writing to " + workDir);
                }
                Directory.CreateDirectory(workDir);
                clr = Path.Combine(workDir, "clr");
                jvm = Path.Combine(workDir, "jvm");
                Directory.CreateDirectory(clr);
                Directory.CreateDirectory(jvm);
                cfg.TargetDirClr = clr;
                cfg.TargetDirJvm = jvm;
                int addcp = (ext == ".jar" || Directory.Exists(args[0])) ? 1 : 0;
                int adddp = ext == ".dll" ? 1 : 0;

                if (args[3] == "-cp")
                {
                    string[] cps = args[4].Split(';');
                    cfg.ClassPath = new ClassPath[cps.Length+addcp];
                    for (int i = 0; i < cps.Length; i++)
                    {
                        cfg.ClassPath[i] = new ClassPath() {Path = cps[i]};
                    }
                    if (ext == ".jar" || Directory.Exists(args[0]))
                    {
                        cfg.ClassPath[cps.Length] = new ClassPath() { Path = args[0], Generate = true };
                    }
                }

                if (args[5] == "-dp")
                {
                    string[] dps = args[6].Split(';');
                    cfg.AssemblyReference = new AssemblyReference[dps.Length+adddp];
                    for (int i = 0; i < dps.Length; i++)
                    {
                        cfg.AssemblyReference[i] = new AssemblyReference() { Assembly = dps[i] };
                    }
                    if (ext == ".dll")
                    {
                        cfg.AssemblyReference[dps.Length] = new AssemblyReference() { Assembly = args[0], Generate = true};
                    }
                }
            }
            else
            {
                return -1;
            }

            Generator.config = cfg;
            Repository.config = cfg;
            Repository.Register();
            Repository.Analyze();
            Generator.GenerateAll();
            Console.WriteLine("proxygen done");


            if (workDir != null)
            {
                string fname = Path.GetFileNameWithoutExtension(args[0]);
                using (var jw = new StreamWriter(Path.Combine(workDir, "build.cmd")))
                {
                    jw.WriteLine("@echo off");
                    jw.WriteLine("if not exist target mkdir target");
                    jw.WriteLine("if not exist target\\classes mkdir target\\classes");
                    jw.WriteLine();
                    jw.WriteLine();
                    
                    jw.WriteLine("echo compile classes");
                    jw.Write("javac -nowarn -d target\\classes -sourcepath jvm -cp ");
                    foreach (string cp in Bridge.Setup.JVMCLassPath)
                    {
                        jw.Write(cp);
                        jw.Write(";");
                    }
                    jw.Write(" ");
                    foreach (string file in Directory.GetFiles(jvm, "*.java", SearchOption.AllDirectories))
                    {
                        int i = file.IndexOf("\\jvm\\");
                        string output = file.Substring(i+1);
                        jw.Write(output);
                        jw.Write(" ");
                    }
                    jw.WriteLine();
                    jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                    jw.WriteLine();
                    jw.WriteLine();

                    jw.WriteLine("echo " + fname + ".j4n.jar ");
                    jw.Write("jar cvf target\\");
                    jw.Write(fname + ".j4n.jar ");
                    foreach (string file in Directory.GetFiles(jvm, "*.java", SearchOption.AllDirectories))
                    {
                        jw.Write(" -C target\\classes ");
                        int i = file.IndexOf("\\jvm\\");
                        string output = file.Substring(i+5).Replace(".java", ".class");
                        jw.Write(output);
                        jw.Write(" ");
                    }
                    jw.Write(" > nul ");
                    jw.WriteLine();
                    jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                    jw.WriteLine();
                    jw.WriteLine();


                    jw.WriteLine("echo " + fname + ".j4n.dll ");
                    jw.Write("csc /nologo /warn:0 /t:library /out:target\\");
                    jw.Write(fname + ".j4n.dll ");
                    jw.Write("/recurse:clr\\*.cs ");

                    foreach (Assembly assembly in Repository.KnownAssemblies)
                    {
                        if (typeof(Program).Assembly != assembly)
                        {
                            jw.Write(" /reference:");
                            jw.Write(assembly.Location);
                        }
                    }
                    jw.WriteLine();
                    jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                    jw.WriteLine();
                    jw.WriteLine();
                    jw.WriteLine(":end");
                }
            }

            return 0;
        }
    }
}