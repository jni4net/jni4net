/* Copyright (C) 2012 by Pavel Savara
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

package net.sf.jni4net.core;

import net.sf.jni4net.LogListener;
import net.sf.jni4net.LogLevel;

import java.util.ArrayList;
import java.util.List;

public class Logger {
    public static LogLevel LogLevel=net.sf.jni4net.LogLevel.ERROR;
    public static List<LogListener> Listeners = new ArrayList<LogListener>();


    public static void logDebug(String message) {
        if (LogLevel.value() < LogLevel.DEBUG.value()) {
            return;
        }
        if (Listeners.size() == 0) {
            System.err.println("JVM DEBUG: " + message);
        } else {
            for (LogListener log : Listeners) {
                log.logDebug(message);
            }
        }
    }

    public static void logInfo(String message) {
        if (LogLevel.value() < LogLevel.INFO.value()) {
            return;
        }
        if (Listeners.size() == 0) {
            System.err.println("JVM  INFO:  " + message);
        } else {
            for (LogListener log : Listeners) {
                log.logInfo(message);
            }
        }
    }

    public static void logWarn(String message) {
        if (LogLevel.value() < LogLevel.WARN.value()) {
            return;
        }
        if (Listeners.size() == 0) {
            System.err.println("JVM  WARN:  " + message);
        } else {
            for (LogListener log : Listeners) {
                log.logWarn(message);
            }
        }
    }

    public static void logError(String message, Exception ex) {
        if (LogLevel.value() < LogLevel.ERROR.value()) {
            return;
        }
        if (Listeners.size() == 0) {
            System.err.println("JVM ERROR: " + message);
            if (ex != null) {
                System.err.println(ex.toString());
            }
        } else {
            for (LogListener log : Listeners) {
                log.logError(message, ex);
            }
        }
    }
}
