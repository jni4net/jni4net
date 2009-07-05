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
using System.Threading;
using System.Xml.Serialization;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.generator;
using net.sf.jni4net.proxygen.model;

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

                Generator.config = cfg;
                Repository.config = cfg;
                Repository.Register();
                Repository.Analyze();
                Generator.GenerateAll();
                Console.WriteLine("proxygen done");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return -1;
            }
        }
    }
}
