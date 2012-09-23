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
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Services;
using com.jni4net.proxygen.Utils;
using Directory = System.IO.Directory;

namespace com.jni4net.proxygen.Config
{
    public class Configurator
    {
        [Dependency]
        public Logger Logger { get; set; }

        public Configurator()
        {
            Config=new ProxygenConfig();
            Verbose = false;
            Compile = false;
        }

        public bool Verbose { get; set; }
        public bool Compile { get; set; }
        public bool Debug { get; set; }
        public bool UpdateConfig { get; set; }

        public string PrivateMethodPrefix = "j4n_";
        public string PrivateFieldPrefix = "j4n_";
        public string PrivateParamPrefix = "j4n_";
        public string PrivateVarPrefix = "j4n_";

        public ProxygenConfig Config { get; set; }
        public string FileName { get; set; }

        public bool ProcessCommandLine(string[] args)
        {
            if (args.Length==0 || args.Any(x=>x.ToLowerInvariant().Contains("help")) || args.Any(x=>x.Contains("/?")))
            {
                Help();
                return false;
            }
            var ser = new XmlSerializer(typeof(ProxygenConfig));

            FileName = Path.GetFullPath(args[0]);
            if (File.Exists(FileName))
            {
                using (var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    Config = ser.Deserialize(fs) as ProxygenConfig;
                }
            }
            else
            {
                Config = new ProxygenConfig();
                UpdateConfig = true;
            }
            ProjectRegistration currentProject=null;
            if(Config.Project.Count>0)
            {
                currentProject = Config.Project[0];
            }

            foreach (var projectRegistration in Config.Project)
            {
                projectRegistration.Parent = this;
            }

            var options=new Queue<string>(args);
            options.Dequeue(); // config

            while (options.Count>0)
            {
                var o=options.Dequeue();
                if (o == "--verbose" || o == "--verbose+")
                {
                    Verbose = true;
                }
                else if (o == "--verbose-")
                {
                    Verbose = false;
                }
                else if (o == "--debug" || o == "--debug+")
                {
                    Debug = true;
                }
                else if (o == "--debug-")
                {
                    Debug = false;
                }
                else if (o == "--update-")
                {
                    UpdateConfig = false;
                }
                else if (o == "--update" || o == "--update+")
                {
                    UpdateConfig = true;
                }
                else if (o == "--compile" || o == "--compile+")
                {
                    Compile = true;
                }
                else if (o == "--compile-")
                {
                    Compile = false;
                }
                else if (o == "-jar")
                {
                    if(options.Count==0)
                    {
                        Logger.LogError("-jar argument missing");
                        return false;
                    }
                    var cp = Path.GetFullPath(options.Dequeue());
                    var file = File.Exists(cp);
                    if (!file && Directory.Exists(cp))
                    {
                        Logger.LogError(string.Format("Can't find jar file or directory {0}", cp));
                        return false;
                    }
                    string name;
                    if(file)
                    {
                        name = Path.GetFileNameWithoutExtension(cp);
                    }
                    else
                    {
                        name = Path.GetDirectoryName(cp);
                    }

                    currentProject = Config.Project.SingleOrDefault(p => p.ProjectName.ToLowerInvariant() == name.ToLowerInvariant());
                    if (currentProject==null)
                    {
                        currentProject = new ProjectRegistration();
                        currentProject.ProjectName = name+"-j4n";
                        Config.Project.Add(currentProject);
                        currentProject.Parent = this;
                    }

                    if (!AddCp(currentProject, cp, true))
                    {
                        return false;
                    }
                }
                else if (o == "-dll")
                {
                    if(options.Count==0)
                    {
                        Logger.LogError("-dll argument missing");
                        return false;
                    }
                    var dp = Path.GetFullPath(options.Dequeue());
                    if (!File.Exists(dp))
                    {
                        Logger.LogError(string.Format("Can't find dll file {0}", dp));
                        return false;
                    }
                    string name = Path.GetFileNameWithoutExtension(dp);

                    currentProject = Config.Project.SingleOrDefault(p => p.ProjectName.ToLowerInvariant() == name.ToLowerInvariant());
                    if (currentProject==null)
                    {
                        currentProject = new ProjectRegistration();
                        currentProject.ProjectName = name + "-j4n";
                        Config.Project.Add(currentProject);
                        currentProject.Parent = this;
                    }

                    if (!AddDp(currentProject, dp, true))
                    {
                        return false;
                    }
                }
                else if (o == "-cp")
                {
                    if(currentProject==null)
                    {
                        Logger.LogError("use -dll or -jar first");
                        return false;
                    }
                    if (options.Count == 0)
                    {
                        Logger.LogError("-cp argument missing");
                        return false;
                    }
                    if(!AddCp(currentProject,options.Dequeue(), false))
                    {
                        return false;
                    }
                }
                else if (o == "-dp")
                {
                    if (currentProject == null)
                    {
                        Logger.LogError("use -dll or -jar first");
                        return false;
                    }
                    if (options.Count == 0)
                    {
                        Logger.LogError("-dp argument missing");
                        return false;
                    }
                    if (!AddDp(currentProject, options.Dequeue(), false))
                    {
                        return false;
                    }
                }
                else if (o == "--keyfile")
                {
                    if (currentProject == null)
                    {
                        Logger.LogError("use -dll or -jar first");
                        return false;
                    }
                    if (options.Count == 0)
                    {
                        Logger.LogError("--keyfile argument missing");
                        return false;
                    }
                    var cp = Path.GetFullPath(options.Dequeue());
                    if (!File.Exists(cp))
                    {
                        Logger.LogError(string.Format("Can't find jar file or directory {0}", cp));
                        return false;
                    }
                    currentProject.ProjectKey = PathUtils.MakeRelativePath(currentProject.baseDirectory, cp);
                }
            }

            if(UpdateConfig)
            {
                var configDir = Path.GetDirectoryName(FileName);
                if (!Directory.Exists(configDir))
                {
                    Directory.CreateDirectory(configDir);
                }
                using (var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    ser.Serialize(fs, Config);
                }
            }

            return true;
        }

        private bool AddCp(ProjectRegistration currentProject, string cp, bool generate)
        {
            cp = Path.GetFullPath(cp);
            var file = File.Exists(cp);
            if (!file && Directory.Exists(cp))
            {
                Logger.LogError(string.Format("Can't find jar file or directory {0}", cp));
                return false;
            }

            ClassPath classPath;
            if (file)
            {
                var filename = Path.GetFileName(cp);
                classPath = currentProject.ClassPath.SingleOrDefault(c => c.JarFile != null && c.JarFile.ToLowerInvariant().EndsWith(filename.ToLowerInvariant()));
            }
            else
            {
                var directoryName = Path.GetDirectoryName(cp);
                classPath = currentProject.ClassPath.SingleOrDefault(c => c.JarFile != null && c.JarFile.ToLowerInvariant().EndsWith(directoryName.ToLowerInvariant()));
            }

            if (classPath == null)
            {
                classPath = new ClassPath();
                currentProject.ClassPath.Add(classPath);
            }
            if (file)
            {
                classPath.JarFile = PathUtils.MakeRelativePath(currentProject.baseDirectory, cp);
            }
            else
            {
                classPath.ClassPathDirectory = PathUtils.MakeRelativePath(currentProject.baseDirectory, cp);
            }
            if (generate && classPath.JavaClass.Count == 0)
            {
                classPath.Generate = true;
            }
            return true;
        }

        private bool AddDp(ProjectRegistration currentProject, string dp, bool generate)
        {
            dp = Path.GetFullPath(dp);
            if (!File.Exists(dp))
            {
                Logger.LogError(string.Format("Can't find jar file or directory {0}", dp));
                return false;
            }

            var filename = Path.GetFileName(dp);
            Assembly assembly = currentProject.Assembly.SingleOrDefault(c => c.File != null && c.File.ToLowerInvariant().EndsWith(filename.ToLowerInvariant()));

            if (assembly == null)
            {
                assembly = new Assembly();
                currentProject.Assembly.Add(assembly);
            }
            assembly.File = PathUtils.MakeRelativePath(currentProject.baseDirectory, dp);
            if (generate && assembly.ClrType.Count == 0)
            {
                assembly.Generate = true;
            }
            return true;
        }

        private void Help()
        {
            var sb = new StringBuilder();
            sb.AppendLine("proxygen.exe config-file-j4n.xml [options]");
            sb.AppendLine(" --verbose             turns on verbose mnessages");
            sb.AppendLine(" --debug               turns on all debug messages");
            sb.AppendLine(" --compile             will attemt compilation of proxies");
            sb.AppendLine("options below would create or update config file");
            sb.AppendLine(" -jar <path/file.jar>  will wrap the jar file");
            sb.AppendLine(" -dll <path/file.dll>  will wrap the dll file");
            sb.AppendLine(" -cp <path/file.jar>  java dependencies");
            sb.AppendLine(" -dp <path/file.dll>  .NET dependencies");

            Console.WriteLine(sb);
        }
    }
}
