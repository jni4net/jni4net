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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Serialization;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.config
{
    public partial class TypeRegistration : ITypeRegistration
    {
        [XmlIgnore]
        public ProjectRegistration Parent { get; set; }

        [XmlIgnore]
        public bool IsSyntetic { get; set; }


        public TypeRegistration (string name,ProjectRegistration parent, bool generate )
            : this()
        {
            Parent = parent;
            this.Name = name;
            this.Generate = generate;
            IsSyntetic = true;
        }

        [XmlIgnore]
        public List<IMemberRegistration> Members
        {
            get { return Member.Cast<IMemberRegistration>().ToList(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class MemberRegistration : IMemberRegistration
    {
        public override string ToString()
        {
            return Signature;
        }

        [XmlIgnore]
        public List<IParameterRegistration> Parameters
        {
            get { return Parameter.Cast<IParameterRegistration>().ToList(); }
        }

        [XmlIgnore]
        public IParameterRegistration Return
        {
            get { return Ret; }
        }
    }

    public partial class ParameterRegistration : IParameterRegistration
    {
    }

    public class ModuleRegistration
    {
        public string CLRStaticApi;
        public string CLRApi;
        public string JVMApi;
    }

    public partial class ProjectRegistration
    {
        [XmlIgnore]
        internal Configurator Parent { get; set; }

        [XmlIgnore] public List<string> JavaFiles = new List<string>();

        [XmlIgnore] public List<string> CsharpFiles = new List<string>();

        [XmlIgnore] public List<ModuleRegistration> ClrProxies = new List<ModuleRegistration>();
        [XmlIgnore] public List<ModuleRegistration> JvmProxies = new List<ModuleRegistration>();

        [XmlIgnore]
        public string baseDirectory
        {
            get
            {
                if (baseDirectoryAbsolute == null)
                {
                    string configDir = Parent == null || Parent.FileName == null
                                           ? Environment.CurrentDirectory
                                           : Path.GetDirectoryName(Parent.FileName);

                    baseDirectoryAbsolute = PathUtils.MakeAbsolutePath(BaseDirectory, configDir, BaseDirectory);
                }
                return baseDirectoryAbsolute;
            }
        }

        private string baseDirectoryAbsolute;

        [XmlIgnore]
        public string AssemblyQualifiedName 
        {
            get
            {
                var aqName = ProjectName;
                if (ProjectVersion != null)
                {
                    aqName += ", Version=" + ProjectVersion;
                }
                string pkToken = PKToken;
                if (pkToken != null)
                {
                    aqName += ", PublicKeyToken=" + pkToken;
                }

                return aqName;
            }
        }

        [XmlIgnore]
        public string ProxyAssemblyQualifiedName
        {
            get
            {
                var aqName = ProjectName;
                if (ProjectVersion != null)
                {
                    aqName += ", Version=" + ProjectVersion;
                }
                string pkToken = PKToken;
                if (pkToken != null)
                {
                    aqName += ", PublicKeyToken=" + pkToken;
                }

                return aqName;
            }
        }
        
        [XmlIgnore]
        public string PKToken
        {
            get
            {
                if (pkToken == null && ProjectKey != null)
                {
                    string keyFile = MakeAbsolutePath(ProjectKey);
                    var pk = new StrongNameKeyPair(File.ReadAllBytes(keyFile));
                    byte[] bpkToken = GetKeyTokenFromFullKey(pk.PublicKey);
                    pkToken = BitConverter.ToString(bpkToken).Replace("-", "");
                }
                return pkToken;
            }
        }

        private string pkToken;

        private static byte[] GetKeyTokenFromFullKey(byte[] fullKey)
        {
            var csp = new SHA1CryptoServiceProvider();
            byte[] hash = csp.ComputeHash(fullKey);
            var token = new byte[8];
            for (int i = 0; i < 8; i++)
                token[i] = hash[hash.Length - (i + 1)];

            return token;
        }


        private string projectLocation;
        [XmlIgnore]
        public string ProjectLocation
        {
            get
            {
                if (projectLocation == null)
                {
                    projectLocation = TargetDirJvm;
                    if (string.IsNullOrEmpty(projectLocation))
                    {
                        projectLocation = baseDirectory;
                    }
                    projectLocation = PathUtils.MakeAbsolutePath(baseDirectory, projectLocation);
                    projectLocation = PathUtils.MakeAbsolutePath(projectLocation, "..");
                }
                return projectLocation;
            }
        }

        [XmlIgnore]
        public string TargetDirClr
        {
            get { return TargetDirClrTR(null); }
        }

        [XmlIgnore]
        public string TargetDirJvm
        {
            get { return TargetDirJvmTR(null); }
        }

        [XmlIgnore]
        public string ModuleName
        {
            get { return ProjectName.Replace("-", "").Replace(".", ""); }
        }

        [XmlIgnore]
        public string ModuleNamespace
        {
            get { return "net.sf.jni4net.modules"; }
        }

        public string MakeAbsolutePath(string relative)
        {
            return PathUtils.MakeAbsolutePath(baseDirectory, relative);
        }

        public string GetClrFileName(TypeRegistration typeRegistration, string clrNamespace, string clrName)
        {
            string fileName;
            if (!string.IsNullOrEmpty(clrNamespace))
            {
                fileName = clrNamespace.Replace('.', '/') + "/" + clrName + ".j4n.cs";
            }
            else
            {
                fileName = clrName + ".j4n.cs";
            }

            return Path.Combine(TargetDirClrTR(typeRegistration), fileName);
        }

        public string GetJvmFileName(TypeRegistration typeRegistration, string jvmNamespace, string jvmName)
        {
            string fileName;
            if (!string.IsNullOrEmpty(jvmNamespace))
            {
                fileName = jvmNamespace.Replace('.', '/') + "/" + jvmName + ".java";
            }
            else
            {
                fileName = jvmName + ".java";
            }

            return Path.Combine(TargetDirJvmTR(typeRegistration), fileName);
        }

        private string TargetDirClrTR(TypeRegistration typeRegistration)
        {
            string targetDir = TargetDirClr;
            if (typeRegistration != null)
            {
                if (!string.IsNullOrEmpty(typeRegistration.TargetDirClr))
                {
                    targetDir = typeRegistration.TargetDirClr;
                }
            }
            if (string.IsNullOrEmpty(targetDir))
            {
                targetDir = baseDirectory;
            }
            targetDir = MakeAbsolutePath(targetDir);
            return targetDir;
        }

        private string TargetDirJvmTR(TypeRegistration typeRegistration)
        {
            string targetDir = TargetDirJvm;
            if (typeRegistration != null)
            {
                if (!string.IsNullOrEmpty(typeRegistration.TargetDirJvm))
                {
                    targetDir = typeRegistration.TargetDirJvm;
                }
            }
            if (string.IsNullOrEmpty(targetDir))
            {
                targetDir = baseDirectory;
            }
            targetDir = MakeAbsolutePath(targetDir);
            return targetDir;
        }

        public override string ToString()
        {
            return ProjectName;
        }
    }
}
