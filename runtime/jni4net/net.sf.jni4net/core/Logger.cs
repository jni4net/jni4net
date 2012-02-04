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
using System.Collections.Generic;

namespace net.sf.jni4net.core
{
    internal static class Logger
    {
        public static LogLevel LogLevel = LogLevel.Error;
        public static List<ILogListener> Listeners=new List<ILogListener>();

        public static void LogDebug(string message)
        {
            if (LogLevel < LogLevel.Debug)
            {
                return;
            }
            if (Listeners.Count == 0)
            {
                Console.Error.WriteLine("CLR DEBUG: " + message);
            }
            else
            {
                foreach (var log in Listeners)
                {
                    log.LogDebug(message);
                }
            }
        }

        public static void LogInfo(string message)
        {
            if (LogLevel < LogLevel.Info)
            {
                return;
            }
            if (Listeners.Count == 0)
            {
                Console.Error.WriteLine("CLR  INFO: " + message);
            }
            else
            {
                foreach (var log in Listeners)
                {
                    log.LogInfo(message);
                }
            }
        }

        public static void LogWarn(string message)
        {
            if (LogLevel<LogLevel.Warn)
            {
                return;
            }
            if (Listeners.Count==0)
            {
                Console.Error.WriteLine("CLR  WARN: " + message);
            }
            else
            {
                foreach (var log in Listeners)
                {
                    log.LogWarn(message);
                }
            }
        }

        public static void LogError(string message, Exception ex)
        {
            if (LogLevel < LogLevel.Error)
            {
                return;
            }
            if (Listeners.Count == 0)
            {
                Console.Error.WriteLine("CLR ERROR: " + message);
                if (ex != null)
                {
                    Console.Error.WriteLine(ex.ToString());
                }
            }
            else
            {
                foreach (var log in Listeners)
                {
                    log.LogError(message, ex);
                }
            }
        }
    }
}
