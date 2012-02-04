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

import net.sf.jni4net.core.Logger;

import java.io.File;
import java.io.FilenameFilter;
import java.net.URISyntaxException;

public class BridgeSetup {
    public BridgeSetup(){
        ignoreReinit=true;
        enforceThreadDetach=false;
        bindClrProxies=true;
        javaHomeAutoSetup=true;
        allowCLRJoin=true;
        useNewAppDomain=true;
        try {
            jarLocation = new File(J4NBridge.class.getProtectionDomain().getCodeSource().getLocation().toURI().getPath()).getAbsolutePath();
            applicationBase = new File(jarLocation).getParentFile().getAbsolutePath();
            dllLocation = (new File(applicationBase, "jni4net.dll")).getAbsolutePath();
        } catch (URISyntaxException e) {
            applicationBase = new File(".").getAbsolutePath();
            jarLocation = new File("jni4net.jar").getAbsolutePath();
            dllLocation = new File("jni4net.dll").getAbsolutePath();
        }
    }

    private String jarLocation; //used during early load
    private String dllLocation; //used during early load
    private String dllLoaderLocation; //used during early load
    private String applicationBase; //used during early load
    private boolean useNewAppDomain; //used during early load

    private String javaHome;   //used during early load via reflection
    private int logLevel;      //used during early load via reflection
    private String jvmCoreLib; //used during early load via reflection
    private String clrCoreLib; //used during early load via reflection

    private static String platform;
    private String clrVersion;
    private LogLevel logLevelEnum = net.sf.jni4net.LogLevel.ERROR;
    private boolean ignoreReinit;
    private boolean enforceThreadDetach;
    private boolean enforceImmediateBinding;
    private boolean bindClrProxies;
    private boolean hideJNIFromStackTrace;
    private boolean javaHomeAutoSetup;
    private boolean allowCLRJoin;
    //TODO private static String j4nVersion;

    public void setClrVersion(String clrVersion) {
        this.clrVersion = clrVersion;
    }

    public synchronized LogLevel getLogLevel() {
        return logLevelEnum;
    }

    public synchronized void setLogLevel(LogLevel logLevelEnum) {
        this.logLevelEnum = logLevelEnum;
        this.logLevel = logLevelEnum.value();
    }

    public boolean isJavaHomeAutoSetup() {
        return javaHomeAutoSetup;
    }

    public boolean isHideJNIFromStackTrace() {
        return hideJNIFromStackTrace;
    }

    public void setHideJNIFromStackTrace(boolean hideJNIFromStackTrace) {
        this.hideJNIFromStackTrace = hideJNIFromStackTrace;
    }

    public boolean isBindClrProxies() {
        return bindClrProxies;
    }

    public void setBindClrProxies(boolean bindClrProxies) {
        this.bindClrProxies = bindClrProxies;
    }

    public boolean isEnforceThreadDetach() {
        return enforceThreadDetach;
    }

    public void setEnforceThreadDetach(boolean enforceThreadDetach) {
        this.enforceThreadDetach = enforceThreadDetach;
    }

    public boolean isIgnoreReinit() {
        return ignoreReinit;
    }

    public void setIgnoreReinit(boolean ignoreReinit) {
        this.ignoreReinit = ignoreReinit;
    }

    public String getJavaHome() {
        return System.getProperty("java.home");
    }

    public String getJvmCoreLib() {
        return jvmCoreLib;
    }

    public void setJvmCoreLib(String jvmCoreLib) {
        this.jvmCoreLib = jvmCoreLib;
    }

    public String getClrCoreLib() {
        return clrCoreLib;
    }

    public void setClrCoreLib(String clrCoreLib) {
        this.clrCoreLib = clrCoreLib;
    }

    public boolean isEnforceImmediateBinding() {
        return enforceImmediateBinding;
    }

    public void setEnforceImmediateBinding(boolean enforceImmediateBinding) {
        this.enforceImmediateBinding = enforceImmediateBinding;
    }

    public boolean isAllowCLRJoin() {
        return allowCLRJoin;
    }

    public void setAllowCLRJoin(boolean allowCLRJoin) {
        this.allowCLRJoin = allowCLRJoin;
    }

    public String getApplicationBase() {
        return applicationBase;
    }

    public void setApplicationBase(String applicationBase) {
        this.applicationBase = new File(applicationBase).getAbsolutePath();
    }

    public boolean isUseNewAppDomain() {
        return useNewAppDomain;
    }

    public void setUseNewAppDomain(boolean useNewAppDomain) {
        this.useNewAppDomain = useNewAppDomain;
    }

	public String getExportDll() throws java.io.IOException {
        String clrVersion = getClrVersion();
        if (clrVersion == null) {
            clrVersion = getClrVersion();
        }
        String platform = getPlatform();


        String loader = "jni4net-"+platform+clrVersion+getExtension();
        File exportDll = new File(getApplicationBase(), loader);
        return exportDll.getAbsolutePath();
    }

    synchronized String getClrVersion() {
        if (clrVersion == null) {
            clrVersion= "v20";
            if (getPlatform().startsWith("w")) {
                String sysRoot = System.getenv("SystemRoot");
                if (sysRoot == null || sysRoot.equals("")) {
                    sysRoot = "c:/Windows";
                }
                File d = new File(sysRoot, "Microsoft.NET/Framework/");
                final String[] versions = d.list(new FilenameFilter() {
                    public boolean accept(File dir, String name) {
                        return name.startsWith("v4.0.");
                    }
                });
                if (versions != null && versions.length > 0) {
                    clrVersion= "v40";
                }
            } else if (getPlatform().startsWith("l")) {
                clrVersion= "m28";
            }
        }
        return clrVersion;
    }

    synchronized String getPlatform() {
        if (platform == null) {
            String model = System.getProperty("sun.arch.data.model");
            String os = System.getProperty("os.name").toLowerCase();
            if (os.startsWith("windows")) {
                platform = "w";
            } else if (os.equals("linux")) {
                platform = "l";
            } else {
                System.out.println(os);
                throw new UnsupportedOperationException("Platform not supported " + os);
            }
            platform += model;
        }
        return platform;
    }

    synchronized String getExtension() {
        String os = System.getProperty("os.name").toLowerCase();
        if (os.startsWith("windows")) {
            return ".dll";
        } else if (os.equals("linux")) {
            return ".so";
        } else {
            System.out.println(os);
            throw new UnsupportedOperationException("Platform not supported " + os);
        }
    }

}
