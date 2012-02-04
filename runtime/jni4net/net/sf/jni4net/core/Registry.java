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

import net.sf.jni4net.inj.INJEnv;

public class Registry {
    public static ProxyInfo registerProxy(INJEnv env, String backingFullName, Class api, Class staticApi, Class proxy, IClrProxyFactory factory){
        try{
            RegisterProxy(backingFullName);
        }
        catch (java.lang.UnsatisfiedLinkError ex){
            throw new net.sf.jni4net.J4NException("Bridge is not initialized yet, please call J4NBridge.CreateCLR() first.", ex);
        }
        return new ProxyInfo();
    }

    public static void disposeClrHandle(long clrHandle){
        DisposeClrHandle(clrHandle);
    }


    private native static int RegisterProxy(String backingFullName);
    private native static void DisposeClrHandle(long clrHandle);

    public native static long CreateBoxedBool(boolean value);
    public native static long CreateBoxedByte(byte value);
    public native static long CreateBoxedChar(char value);
    public native static long CreateBoxedShort(short value);
    public native static long CreateBoxedInteger(int value);
    public native static long CreateBoxedLong(long value);
    public native static long CreateBoxedFloat(float value);
    public native static long CreateBoxedDouble(double value);
    public native static long CreateBoxedString(java.lang.String value);

    public native static boolean UnboxBool(long clrHandle);
    public native static byte UnboxByte(long clrHandle);
    public native static char UnboxChar(long clrHandle);
    public native static short UnboxShort(long clrHandle);
    public native static int UnboxInteger(long clrHandle);
    public native static long UnboxLong(long clrHandle);
    public native static float UnboxFloat(long clrHandle);
    public native static double UnboxDouble(long clrHandle);
    public native static java.lang.String UnboxString(long clrHandle);

}
