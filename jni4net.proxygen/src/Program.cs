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
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Xml;
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
                if (ex is SecurityException || ex is TypeInitializationException)
                {
                    Console.Error.WriteLine();
                    Console.Error.WriteLine("Proxygen must be run as trusted assembly! (shared drive could cause the problem)");
                }
                Console.Error.WriteLine();
                Console.Error.Write(ex.ToString());
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

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.Assertion | SecurityPermissionFlag.Execution)]
        [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
        private static int Work(string[] args)
        {
            ToolConfig cfg;
            string mainEntry = args[0];
            string ext = Path.GetExtension(mainEntry).ToLowerInvariant();
            string workDir = null;
            string clr = null;
            string jvm = null;
            if (ext == ".xml")
            {
                var ser = new XmlSerializer(typeof(ToolConfig));
                using (var reader = new FileStream(mainEntry, FileMode.Open))
                {
                    cfg = ser.Deserialize(reader) as ToolConfig;
                }
            }
            else
            {
                bool isDll = ext == ".dll";
                bool isCp = ext == ".jar" || Directory.Exists(mainEntry);
                if (isDll || isCp)
                {
                    cfg = new ToolConfig();
                    workDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    for (int i = 1; i < args.Length;i++ )
                    {
                        if (args.Length > i + 1)
                        {
                            ParseWd(ref workDir, args[i], args[i + 1]);
                            ParseCp(mainEntry, cfg, isCp, args[i], args[i + 1]);
                            ParseDl(mainEntry, cfg, isDll, args[i], args[i + 1]);
                        }
                    }
                    if (isDll)
                    {
                        if (cfg.AssemblyReference==null)
                        {
                            cfg.AssemblyReference=new AssemblyReference[1];
                        }
                        cfg.AssemblyReference[cfg.AssemblyReference.Length - 1] = new AssemblyReference() { Assembly = mainEntry, Generate = true };
                    }
                    if (isCp)
                    {
                        if (cfg.ClassPath == null)
                        {
                            cfg.ClassPath = new ClassPath[1];
                        }
                        cfg.ClassPath[cfg.ClassPath.Length - 1] = new ClassPath() { Path = mainEntry, Generate = true };
                    }



                    Directory.CreateDirectory(workDir);
                    clr = Path.Combine(workDir, "clr");
                    jvm = Path.Combine(workDir, "jvm");
                    Directory.CreateDirectory(clr);
                    Directory.CreateDirectory(jvm);
                    cfg.TargetDirClr = clr;
                    cfg.TargetDirJvm = jvm;
                }
                else
                {
                    return -1;
                }
            }

            Generator.config = cfg;
            Repository.config = cfg;
            Repository.Register();
            Repository.Analyze();
            Generator.GenerateAll();
            Console.WriteLine("proxygen done");


            if (workDir != null)
            {
                string fname = Path.GetFileNameWithoutExtension(mainEntry);
                WriteBuild(workDir, jvm, fname);

                var ser = new XmlSerializer(typeof (ToolConfig));
                using (var fs = new FileStream(Path.Combine(workDir, fname + ".proxygen.xml"), FileMode.Create))
                {
                    using (XmlWriter xw = XmlWriter.Create(fs, new XmlWriterSettings {Indent = true}))
                    {
                        ser.Serialize(xw, cfg);
                    }
                }
            }

            return 0;
        }

        private static void WriteBuild(string workDir, string jvm, string fname)
        {
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
                    jw.Write('"');
                    jw.Write(cp);
                    jw.Write('"');
                    jw.Write(";");
                }
                jw.Write(" @sources.txt");
                using (var sourceWriter = new StreamWriter(Path.Combine(workDir, "sources.txt")))
                    foreach (string file in Generator.filesJVM)
                {
                    int i = file.IndexOf("\\jvm\\");
                    string output = file.Substring(i+1);
                    sourceWriter.WriteLine(output);
                }
                jw.WriteLine();
                jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                jw.WriteLine();
                jw.WriteLine();

                jw.WriteLine("echo " + fname + ".j4n.jar ");
                jw.Write("jar cvf ");
                jw.Write(fname + ".j4n.jar ");
                jw.Write(" @classes.txt");
                using(var classWriter = new StreamWriter(Path.Combine(workDir, "classes.txt")))
                    foreach (string file in Generator.TypesJVM.Values)
                    {
                        classWriter.Write(" -C target\\classes ");
                        string output = file.Replace(".", "\\") + ".class";
                        classWriter.Write(output);
                    }
                jw.Write(" > nul ");
                jw.WriteLine();
                jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                jw.WriteLine();
                jw.WriteLine();


                jw.WriteLine("echo " + fname + ".j4n.dll ");
                jw.Write("csc /nologo /warn:0 /t:library /out:");
                jw.Write(fname + ".j4n.dll ");
                jw.Write("/recurse:clr\\*.cs ");

                foreach (Assembly assembly in Repository.KnownAssemblies)
                {
                    if (typeof(Program).Assembly != assembly
                        && typeof(int).Assembly != assembly)
                    {
                        jw.Write(" /reference:");
                        jw.Write('"');
                        jw.Write(assembly.Location);
                        jw.Write('"');
                    }
                }
                jw.WriteLine();
                jw.WriteLine("IF %ERRORLEVEL% NEQ 0 goto end");
                jw.WriteLine();
                jw.WriteLine();
                jw.WriteLine(":end");
            }
        }

        private static void ParseWd(ref string workDir, string swtch, string args)
        {
            if (swtch == "-wd")
            {
                workDir = args;
            }
        }

        private static void ParseDl(string mainEntry, ToolConfig cfg, bool isDll, string swtch, string args)
        {
            if (swtch == "-dp")
            {
                int adddp = isDll ? 1 : 0;
                string[] dps = args.Split(';');
                cfg.AssemblyReference = new AssemblyReference[dps.Length+adddp];
                for (int i = 0; i < dps.Length; i++)
                {
                    cfg.AssemblyReference[i] = new AssemblyReference() { Assembly = dps[i] };
                }
            }
        }

        private static void ParseCp(string mainEntry, ToolConfig cfg, bool isCp, string swtch, string args)
        {
            if (swtch == "-cp")
            {
                int addcp = (isCp) ? 1 : 0;
                string[] cps = args.Split(';');
                cfg.ClassPath = new ClassPath[cps.Length+addcp];
                for (int i = 0; i < cps.Length; i++)
                {
                    cfg.ClassPath[i] = new ClassPath() {Path = cps[i]};
                }
            }
        }
    }
}