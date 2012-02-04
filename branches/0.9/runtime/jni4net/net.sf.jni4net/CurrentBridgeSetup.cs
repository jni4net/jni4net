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

using System;
using java.lang;
using net.sf.jni4net.core;
using net.sf.jni4net.utils;

namespace net.sf.jni4net
{
    public class CurrentBridgeSetup
    {
        internal CurrentBridgeSetup(BridgeSetup setup)
        {
            LogLevel = setup.LogLevel;
            JavaHome = setup.JavaHome;
            JVMCoreLib = setup.JVMCoreLib;
            CLRCoreLib = setup.CLRCoreLib;
            BindClrProxies = setup.BindClrProxies;
            AllowJVMJoin = setup.AllowJVMJoin;
            EnforceThreadDetach = setup.EnforceThreadDetach;
            HideJNIFromStackTrace = setup.HideJNIFromStackTrace;
            EnforceImmediateBinding = setup.EnforceImmediateBinding;
            DisableJavaHomeDetection = setup.DisableJavaHomeDetection;
            AutoCreateLocalFrame = setup.AutoCreateLocalFrame;
        }

        public bool AllowJVMJoin { get; set; }
        public bool EnforceThreadDetach { get; set; }
        public bool AutoCreateLocalFrame { get; set; }
        public bool BindClrProxies { get; set; }
        public bool HideJNIFromStackTrace { get; set; }
        public bool EnforceImmediateBinding { get; set; }
        public bool DisableJavaHomeDetection { get; set; }

        public string JavaHome { get; internal set; }
        
        public IClassLoader DefaultClassLoader { get; set; }

        public string JVMCoreLib { get; internal set; }
        public string CLRCoreLib { get; internal set; }

        public LogLevel LogLevel
        {
            get { return Logger.LogLevel; }
            set { Logger.LogLevel = value; }
        }

        public void AddLogListener(ILogListener listener)
        {
            Logger.Listeners.Add(listener);
        }
    }
}