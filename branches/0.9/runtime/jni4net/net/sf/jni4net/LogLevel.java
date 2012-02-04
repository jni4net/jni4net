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

package net.sf.jni4net;

import java.security.InvalidParameterException;

public enum LogLevel implements Comparable<LogLevel> {
    NONE(0),
    ERROR(1),
    WARN(2),
    INFO(3),
    DEBUG(4);

    private int value;

    public int value(){
        return value;
    }

    public static LogLevel fromValue(int value){
        switch (value){
            case 0:
                return NONE;
            case 1:
                return ERROR;
            case 2:
                return WARN;
            case 3:
                return INFO;
            case 4:
                return DEBUG;
            default:
                throw new InvalidParameterException(Integer.toString(value));
        }
    }

    LogLevel(int value){
        this.value=value;
    }
}
