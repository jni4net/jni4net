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

// ReSharper disable ConvertToLambdaExpression
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Services.Generators;
using com.jni4net.proxygen.Utils;
using net.sf.jni4net;
using polyglottos;
using Directory = System.IO.Directory;

namespace com.jni4net.proxygen.Services.Compilation
{
    public class ProjectsGenerator
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency("GProjectJava")]
        public IGProject GProjectJava { get; set; }

        [Dependency("GProjectCSharp")]
        public IGProject GProjectCSharp { get; set; }

        [Dependency("GTypeUsageGenerator")]
        public GTypeUsageGenerator GTypeUsageGenerator { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public void CreateClrModule()
        {
            foreach (var p in Configurator.Config.project)
            {
                ProjectRegistration project = p;

                string csFullPath = project.GetClrFileName(null, project.ModuleNamespace, project.ModuleName);
                var csFile=GProjectCSharp.AddFile(csFullPath);
                project.CsharpFiles.Add(csFullPath);

                IGFileRegion module = BaseCSharpGenerator.CreateGeneratedRegion(csFile);
                module.AddNamespace(project.ModuleNamespace,
                    ns => ns.AddClass(project.ModuleName+"j4n",
                    mcls =>
                        {
                            mcls.AddField(GTypeClr.Bool, "isModuleInitialized",
                                isModuleInitialized=>
                                    {
                                        isModuleInitialized.IsStatic = true;
                                        isModuleInitialized.IsPrivate = true;
                                    });
                            mcls.AddMethod(GTypeClr.Void, "InitModule",
                                           init =>
                                               {
                                                   init.IsStatic = true;

                                                   init.AddTextLine("if(!isModuleInitialized) lock(typeof(" + project.ModuleName + "j4n" + "))");
                                                   init.BlockStatement(
                                                       lck =>
                                                        {
                                                            lck.AddTextStatement("isModuleInitialized = true");
                                                            lck.CallStatic(GTypeJ4N.Registry, "RegisterModule",
                                                                call =>
                                                                    {
                                                                        call.AddParameter().TypeOf(project.ModuleName + "j4n");
                                                                        call.AddParameter().Value(project.ModuleNamespace + "." + project.ModuleName + "j4n");
                                                                        call.AddParameter().Value(project.projectName);
                                                                    });

                                                            foreach (var jvmProxy in project.JvmProxies)
                                                            {
                                                                ModuleRegistration proxy = jvmProxy;
                                                                lck.CallStatic(GTypeJ4N.Registry, "RegisterJvmProxy",
                                                                                call =>
                                                                                    {
                                                                                        call.AddParameter().TypeOf(proxy.CLRStaticApi);
                                                                                        call.AddParameter().TypeOf(proxy.CLRApi);
                                                                                        call.AddParameterValue(proxy.JVMApi);
                                                                                    });
                                                            }
                                                            foreach (var clrProxy in project.ClrProxies)
                                                            {
                                                                ModuleRegistration proxy = clrProxy;
                                                                lck.CallStatic(GTypeJ4N.Registry, "RegisterClrProxy",
                                                                                call =>
                                                                                    {
                                                                                        call.AddParameter().TypeOf(proxy.CLRStaticApi);
                                                                                        call.AddParameter().TypeOf(proxy.CLRApi);
                                                                                        call.AddParameterValue(proxy.JVMApi);
                                                                                    });
                                                            }
                                                        });
                                               });
                        }));
                GProjectCSharp.GenerateFile(csFile);

                string jvFullPath = project.GetJvmFileName(null, project.ModuleNamespace, project.ModuleName + "j4n");
                var jvFile = GProjectJava.AddFile(jvFullPath);
                project.JavaFiles.Add(jvFullPath);

                jvFile.AddNamespace(project.ModuleNamespace)
                    .AddClass(project.ModuleName + "j4n",
                        mcls =>
                            {
                                mcls.AddField(GTypeJvm.String, "assemblyName",
                                    assemblyName =>
                                    {
                                        assemblyName.IsStatic = true;
                                        assemblyName.IsPublic = true;
                                        assemblyName.IsSealed = true;
                                    }).TextExpression(" \"" + project.AssemblyQualifiedName + "\"");

                                mcls.AddField(GTypeJvm.String, "proxyAssemblyName",
                                    assemblyName =>
                                    {
                                        assemblyName.IsStatic = true;
                                        assemblyName.IsPublic = true;
                                        assemblyName.IsSealed = true;
                                    }).TextExpression(" \"" + project.ProxyAssemblyQualifiedName + "\"");
                                /*
                                mcls.AddField(GTypeJvm.Bool, "isModuleInitialized",
                                    isModuleInitialized =>
                                        {
                                            isModuleInitialized.IsStatic = true;
                                            isModuleInitialized.IsPrivate = true;
                                        });
                                mcls.AddMethod(GTypeJvm.Void, "InitModule",
                                    init =>
                                        {
                                            init.IsStatic = true;
                                            init.IsSynchronized = true;

                                            init.AddTextLine("if(!isModuleInitialized)");
                                            init.BlockStatement(
                                                lck =>
                                                    {
                                                        lck.AddTextStatement("isModuleInitialized = true");
                                                        lck.AddComment("//TODO call init");
                                                    });
                                        });*/
                            });
                GProjectJava.GenerateFile(jvFile);
            }
        }

        public void CreateProjectFiles()
        {
            var nsManager=new XmlNamespaceManager(new NameTable());
            const string vsns = "http://schemas.microsoft.com/developer/msbuild/2003";
            nsManager.AddNamespace("ms", vsns);

            foreach (var project in Configurator.Config.project)
            {
                if (project.disableProjectGeneration)
                {
                    continue;
                }

                
                var csprojFile = Path.Combine(project.ProjectLocation, project.projectName + ".csproj");
                var imlFile = Path.Combine(project.ProjectLocation, project.projectName + ".iml");
                var javacFile = Path.Combine(project.ProjectLocation, project.projectName + ".javac");
                var cmdFile = Path.Combine(project.ProjectLocation, project.projectName + ".cmd");
                var guid = Guid.NewGuid().ToString().ToUpperInvariant();
                XDocument xDocument;

                #region .csproj

                XElement group;
                // ReSharper disable AssignNullToNotNullAttribute
                if (File.Exists(csprojFile))
                {
                    using (var s=File.Open(csprojFile, FileMode.Open))
                    {
                        xDocument = XDocument.Load(XmlReader.Create(s), LoadOptions.PreserveWhitespace);
                    }
                    var guidEl = xDocument.Root.XPathSelectElement("ms:PropertyGroup/ms:ProjectGuid", nsManager);
                    guid = guidEl.Value.Replace("{", "").Replace("}", "").ToUpperInvariant();
                }
                else
                {
                    using (var s = GetType().Assembly.GetManifestResourceStream("com.jni4net.proxygen.Services._5000.Compilation.template-vs.xml"))
                    {
                        xDocument = XDocument.Load(XmlReader.Create(s), LoadOptions.PreserveWhitespace);
                    }

                    var guidEl = xDocument.Root.XPathSelectElement("ms:PropertyGroup/ms:ProjectGuid", nsManager);
                    guidEl.Value = "{" + guid + "}";

                    var an = xDocument.Root.XPathSelectElement("ms:PropertyGroup/ms:AssemblyName", nsManager);
                    an.Value = project.projectName+"-j4n";

                    var refer = xDocument.Root.XPathSelectElement("ms:ItemGroup/ms:Reference[@Include='jni4net']", nsManager);
                    refer.SetAttributeValue(XName.Get("Include"), J4NBridge.Setup.J4NAssembly);
                    var hint = refer.XPathSelectElement("ms:HintPath", nsManager);
                    hint.Value = PathUtils.MakeRelativePath(project.ProjectLocation,J4NBridge.Setup.J4NDllLocation).Replace("\\","\\\\");

                    var grp = refer.Parent;

                    foreach (var assembly in project.assembly)
                    {
                        var refe = new XElement(XName.Get("Reference", vsns));
                        var inc = new XAttribute(XName.Get("Include"), assembly.assemblyName);
                        refe.Add(inc);
                        var sv = new XElement(XName.Get("SpecificVersion", vsns));
                        sv.Value = "False";
                        refe.Add(sv);
                        if (assembly.file!=null)
                        {
                            var hp = new XElement(XName.Get("HintPath", vsns));
                            var absolutePath = PathUtils.MakeAbsolutePath(project.BaseDirectory, assembly.file);
                            hp.Value = PathUtils.MakeRelativePath(project.ProjectLocation, absolutePath).Replace("\\","\\\\");
                            refe.Add(hp);
                        }
                        grp.Add(refe);
                        refe.AddAfterSelf("\r\n    ");
                    }
                    {
                        var refe = new XElement(XName.Get("Reference", vsns));
                        var inc = new XAttribute(XName.Get("Include"), J4NBridge.Setup.JVMCoreAssembly);
                        refe.Add(inc);
                        var sv = new XElement(XName.Get("SpecificVersion", vsns));
                        sv.Value = "False";
                        refe.Add(sv);
                        var hp = new XElement(XName.Get("HintPath", vsns));
                        hp.Value =PathUtils.MakeRelativePath(project.ProjectLocation, J4NBridge.Setup.JVMCoreDllLocation).Replace("\\", "\\\\");
                        refe.Add(hp);
                        grp.Add(refe);
                        refe.AddAfterSelf("\r\n    ");
                    }

                    var cnt = xDocument.Root.XPathSelectElement("ms:ItemGroup/ms:Content", nsManager);
                    var pgConfig = Path.GetFileName(Configurator.FileName);
                    cnt.SetAttributeValue(XName.Get("Include"), pgConfig);
                }
                // ReSharper enable AssignNullToNotNullAttribute

                var elements = xDocument.Root.XPathSelectElements("ms:ItemGroup/ms:Compile", nsManager).ToList();
                foreach (var element in elements)
                {
                    var attribute = element.Attribute(XName.Get("Include"));
                    if (attribute!=null && attribute.Value.StartsWith(project.targetDirClr))
                    {
                        var ws = element.NodesAfterSelf().TakeWhile(e => e is XText).ToList();
                        foreach (var space in ws)
                        {
                            space.Remove();
                        }
                        element.Remove();
                    }
                }

                group = xDocument.Root.XPathSelectElement("ms:ItemGroup", nsManager);
                for (int i = 0; i < project.CsharpFiles.Count; i++)
                {
                    var file = project.CsharpFiles[i];
                    var relative = PathUtils.MakeRelativePath(project.ProjectLocation, file).Replace("\\","\\\\");
                    var compile = new XElement(XName.Get("Compile", vsns));
                    compile.SetAttributeValue(XName.Get("Include"), relative);
                    @group.Add(compile);
                    if (i < project.CsharpFiles.Count - 1)
                    {
                        compile.AddAfterSelf("\r\n    ");
                    }
                    else
                    {
                        compile.AddAfterSelf("\r\n  ");
                    }
                }

                if (!File.Exists(csprojFile))
                {
                    xDocument.Save(csprojFile);
                }
                else
                {
                    var ms=new MemoryStream();
                    using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8 }))
                    {
                        xDocument.Save(xw);
                    }
                    var original = File.ReadAllBytes(csprojFile);
                    var newtext = ms.ToArray();

                    if (original.Length != newtext.Length || original.Where((t, i) => t != newtext[i]).Any())
                    {
                        File.WriteAllBytes(csprojFile, newtext);
                    }
                }
                #endregion

                #region AssemblyInfo

                var props = Path.Combine(project.ProjectLocation, "Properties");
                var aiFile = Path.Combine(props, "AssemblyInfo.cs");
                if (!Directory.Exists(props))
                {
                    Directory.CreateDirectory(props);
                }

                string ai;
                using (var s = GetType().Assembly.GetManifestResourceStream("com.jni4net.proxygen.Services._5000.Compilation.template-ai.cs"))
                {
                    using (var sr = new StreamReader(s))
                    {
                        ai = sr.ReadToEnd();
                    }
                }
                var sb = new StringBuilder(ai);
                sb.Replace("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA", guid);
                sb.Replace("jni4net", "jni4net proxy - " + project.projectName);
                if (project.projectVersion != null)
                {
                    sb.AppendLine("[assembly: AssemblyVersion(\"" + project.projectVersion + "\")]");
                    sb.AppendLine("[assembly: AssemblyFileVersion(\""+project.projectVersion+"\")]");
                }
                if (project.projectKey != null)
                {
                    var keyFile = project.MakeAbsolutePath(project.projectKey);
                    if (!File.Exists(keyFile))
                    {
                        Logger.LogError("Can't find file" + project.projectKey, null, null);
                    }
                    else
                    {
                        string keyRelative = PathUtils.MakeRelativePath(project.ProjectLocation, keyFile);
                        sb.AppendLine("[assembly: AssemblyKeyFileAttribute(@\"" + keyRelative + "\")]");
                    }
                }
                File.WriteAllText(aiFile, sb.ToString());

                #endregion

                #region .iml

                if (!File.Exists(imlFile))
                {
                    using (var s = GetType().Assembly.GetManifestResourceStream("com.jni4net.proxygen.Services._5000.Compilation.template-iml.xml"))
                    {
                        xDocument = XDocument.Load(XmlReader.Create(s));
                    }

                    var nameEl = xDocument.Root.XPathSelectElement("component/orderEntry[@type='module']");
                    nameEl.SetAttributeValue(XName.Get("module-name"), project.projectName+"-j4n");
                    xDocument.Save(imlFile);

                    using (var xw = new XmlTextWriter(imlFile, new UTF8Encoding(false)))
                    {
                        xDocument.Save(xw);
                    }
                }

                #endregion

                #region .javac

                var javac = new StringBuilder();
                javac.Append("-classpath ");
                foreach (var classPath in project.classPath)
                {
                    javac.Append(classPath.jarFile ?? classPath.classPathDirectory);
                    javac.Append(";");
                }
                javac.Append(PathUtils.MakeRelativePath(project.ProjectLocation, J4NBridge.Setup.J4NJarLocation ?? J4NBridge.Setup.J4NDllLocation.Replace(".dll", ".jar")));
                if (J4NBridge.Setup.CLRCoreDllLocation!=null)
                {
                    javac.Append(";");
                    javac.Append(PathUtils.MakeRelativePath(project.ProjectLocation, J4NBridge.Setup.CLRCoreJarLocation ?? J4NBridge.Setup.CLRCoreDllLocation.Replace(".dll", ".jar")));
                }

                javac.AppendLine();

                for (int i = 0; i < project.JavaFiles.Count; i++)
                {
                    var file = project.JavaFiles[i];
                    var relative = PathUtils.MakeRelativePath(project.ProjectLocation, file);
                    javac.AppendLine(relative);
                }

                File.WriteAllText(javacFile, javac.ToString());

                #endregion

                #region .cmd
                if(!File.Exists(cmdFile))
                {
                    var cmd = new StringBuilder();
                    cmd.AppendLine("@echo off");
                    cmd.AppendLine("REM change this to your JDK location");
                    cmd.AppendLine("set JAVA_HOME=\"c:\\Program Files\\Java\\jdk1.5.0_22\\\"");
                    cmd.AppendLine("");
                    cmd.AppendLine("PUSHD %~dp0\\");
                    cmd.AppendLine("mkdir bin\\classes");
                    cmd.AppendLine("echo compile java");
                    cmd.AppendLine("%JAVA_HOME%\\bin\\javac -d bin\\classes -encoding UTF-8 -g:none @" + project.projectName + ".javac");
                    cmd.AppendLine("");
                    cmd.AppendLine("echo create jar");
                    cmd.AppendLine("%JAVA_HOME%\\bin\\jar -cf bin\\" + project.projectName + "-j4n.jar -C bin\\classes .");
                    cmd.AppendLine("");
                    cmd.AppendLine("echo create dll");
                    cmd.AppendLine("c:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe /verbosity:m /nologo " + project.projectName + ".csproj");
                    cmd.AppendLine("");
                    cmd.AppendLine("POPD");
                    File.WriteAllText(cmdFile, cmd.ToString());
                }

                #endregion


            }
        }
    }
}
