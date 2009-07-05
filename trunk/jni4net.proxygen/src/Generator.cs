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
using java.lang;
using net.sf.jni4net.proxygen.config;

namespace net.sf.jni4net.proxygen
{
    internal partial class Generator : Analyzer
    {
        private const string cdc = "Component Designer generated code ";
        private readonly Java2Net java2Net;
        private readonly Net2Java net2Java;

        public Generator(ToolConfig config)
            :base(config)
        {
            java2Net = new Java2Net(config.SkipJavaMethod ?? new SkipMethod[0], this);
            net2Java = new Net2Java(config.SkipClrMethod ?? new SkipMethod[0], this);
        }

        public void Generate(ToolConfig cfg)
        {
            foreach (Class clazz in knownClasses.Keys)
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Generating " + clazz.FullName);
                }
                java2Net.Generate(clazz, cfg.TargetDirJava2Clr);
            }
            foreach (Type type in knownTypes.Keys)
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Generating " + type.FullName);
                }
                net2Java.Generate(type, cfg.TargetDirClr2Java, cfg.TargetDirJava2Native);
            }
        }
    }
}