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


import net.sf.jni4net.BridgeSetup;
import net.sf.jni4net.J4NBridge;
import net.sf.jni4net.CurrentBridgeSetup;

import java.io.FilenameFilter;
import java.io.IOException;
import java.io.File;
import java.net.URISyntaxException;

public class J4NBridgeExport {

    // this is registered by convention to Java_net_sf_jni4net_core_J4NBridgeExport_initDotNet
    static native int initDotNet(BridgeSetup currentJavaSetup, String applicationBase,boolean useNewAppdomain);

    static boolean isInitialized;

    public synchronized static boolean isInitialized(){
        return isInitialized;
    }

    public synchronized static void init(BridgeSetup initialSetup) {
        if(isInitialized){
            throw new net.sf.jni4net.J4NException("J4NBridgeExport is already initialized");
        }
        int res;
        try {
            System.out.println();
            final String file = initialSetup.getExportDll();
            Logger.logDebug("J4NBridgeExport loading " + file);
            System.load(file);
            res=initDotNet(initialSetup, initialSetup.getApplicationBase(), initialSetup.isUseNewAppDomain());
        } catch (Throwable th) {
            System.err.println("Can't initialize jni4net Bridge" + th.getMessage());
            throw new net.sf.jni4net.J4NException("Can't initialize jni4net J4NBridge", th);
        }
        if(res!=0){
            throw new net.sf.jni4net.J4NException("Can't initialize jni4net J4NBridge with code " + res);
        }
        isInitialized=true;
    }



}
