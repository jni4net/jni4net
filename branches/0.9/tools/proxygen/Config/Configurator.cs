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
using System.IO;
using System.Xml.Serialization;
using com.jni4net.config;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen.Config
{
    public class Configurator
    {
        public Configurator()
        {
            Config=new ProxygenConfig();
            Verbose = false;
            Generate = true;
            Compile = false;
        }

        public bool Verbose { get; set; }
        public bool Generate { get; set; }
        public bool Compile { get; set; }
        public bool Debug { get; set; }

        public string PrivateMethodPrefix = "j4n_";
        public string PrivateFieldPrefix = "j4n_";
        public string PrivateParamPrefix = "j4n_";
        public string PrivateVarPrefix = "j4n_";

        public ProxygenConfig Config { get; set; }
        public string FileName { get; set; }

        public void ProcessCommandLine(string[] args)
        {
            var ser = new XmlSerializer(typeof (ProxygenConfig));

            //TODO
            if (args==null || args.Length==0)
            {
                FileName = @"c:\Data\Sf\jni4net.pro\trunk\proxygen\Config\jni4net-proxygen.xml";
            }
            else
            {
                FileName = args[0];
            }
            FileName = Path.GetFullPath(FileName);

            using (var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                Config = ser.Deserialize(fs) as ProxygenConfig;
            }

            foreach (var projectRegistration in Config.project)
            {
                projectRegistration.Parent = this;
            }

            //TODO
            //Verbose = true;
            //Debug = true;
            Generate = true;
        }
    }
}
