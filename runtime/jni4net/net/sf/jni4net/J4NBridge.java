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

import net.sf.jni4net.core.J4NBridgeExport;
import net.sf.jni4net.core.Logger;

public class J4NBridge {
    static CurrentBridgeSetup currentSetup;

    static public CurrentBridgeSetup getSetup(){
        if(currentSetup==null){
            throw new J4NException("Bridge is not initialized yet, please call J4NBridge.CreateCLR() first.");
        }
        return currentSetup;
    }

    public static void CreateCLR(){
        CreateCLR(new BridgeSetup());
    }

    public static void CreateCLR(BridgeSetup initialSetup){
        Logger.logInfo("java.version        :" + System.getProperty("java.version"));
        Logger.logInfo("sun.arch.data.model :" + System.getProperty("sun.arch.data.model") + "bit");
        Logger.logDebug("java.class.path     :" + System.getProperty("java.class.path"));
        if(J4NBridgeExport.isInitialized()){
            if(!initialSetup.isIgnoreReinit()){
                throw new J4NException("There is already existing CLR");
            }
            return;
        }
        J4NBridgeExport.init(initialSetup);
    }
}
