#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as
published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using net.sf.jni4net.core;

namespace net.sf.jni4net
{
    /// <summary>
    /// Initial bridge setup
    /// </summary>
    public class BridgeSetup
    {
        public BridgeSetup()
        {
            AllowJVMJoin = true;
            BindClrProxies = true;
            HideJNIFromStackTrace = true;
            AutoLoadBaseDirecoryJars = true;
        }

        /// <summary>
        /// True: Will use JavaHome or fail
        /// </summary>
        public bool DisableJavaHomeDetection { get; set; }

        /// <summary>
        /// True: Will use existing JVM if it's already loaded in the procees.
        /// False: Will faile if JVM is already loaded in the procees.
        /// </summary>
        public bool AllowJVMJoin { get; set; }


        public bool BindClrProxies { get; set; }

        /// <summary>
        /// JAVA_HOME, the location of JVM to use
        /// <example>c:\Program Files (x86)\Java\jdk1.5.0_22</example>
        /// </summary>
        public string JavaHome { get; set; }

        /// <summary>
        /// Version in JAVA_HOME name, when searching by directories
        /// <example>1.5</example>
        /// <example>jre6</example>
        /// </summary>
        public string JavaVersion { get; set; }

        /// <summary>
        /// Assembly with JRE version to bind.
        /// <example>jre15-core-j4n</example>
        /// </summary>
        public string JVMCoreLib { get; set; }

        /// <summary>
        /// Assembly with mscorlib version to bind.
        /// <example>mscorlib-20-j4n</example>
        /// </summary>
        public string CLRCoreLib { get; set; }

        /// <summary>
        /// If true, it will throw exception for any thread which was not attached via <typeparamref name="net.sf.jni4net.core.AttachedThread"/>
        /// </summary>
        public bool EnforceThreadDetach { get; set; }

        public bool EnforceImmediateBinding { get; set; }

        public bool AutoCreateLocalFrame { get; set; }

        public bool AutoLoadBaseDirecoryJars { get; set; }

        public bool HideJNIFromStackTrace { get; set; }

        public LogLevel LogLevel { get; set; }

        readonly List<string> classPathList = new List<string>();
        internal string[] ClassPathList { get { return classPathList.ToArray(); } }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public void AddClassPath(string classPath)
        {
            string fullPath = Path.GetFullPath(classPath);
            if (!File.Exists(fullPath))
            {
                if (!Directory.Exists(fullPath))
                {
                    Logger.LogWarn("Can't find classPath " + fullPath);
                }
                else
                {
                    fullPath += "\\";
                }
            }
            if (classPathList.Contains(fullPath))
            {
                Logger.LogWarn("Duplicates classPath " + fullPath);
            }
            classPathList.Add(fullPath);
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public void AddAllJarsClassPath(string directory)
        {
            foreach (string jar in Directory.GetFiles(directory, "*.jar"))
            {
                AddClassPath(jar);
            }
        }

        internal readonly List<string> jvmOptions = new List<string>();
        public void AddJVMOption(string name, string value)
        {
            jvmOptions.Add(name + "=" + value);
        }

        public void AddJVMOption(string setting)
        {
            jvmOptions.Add(setting);
        }
    }
}