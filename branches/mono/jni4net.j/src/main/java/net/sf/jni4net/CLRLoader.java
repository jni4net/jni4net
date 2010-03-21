/* Copyright (C) 2009 by Pavel Savara
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

import system.NotSupportedException;

import java.io.IOException;
import java.io.InputStream;
import java.io.File;
import java.net.URISyntaxException;
import java.net.URL;
import java.util.Properties;

/**
 * @author Pavel Savara (original)
 */
class CLRLoader {
	private static String version;
    private static String platform;

    public static void 	init(File fileOrDirectory) throws IOException {
		if (!Bridge.isRegistered) {
			if (fileOrDirectory.isDirectory()) {
                final String myDllName = "jni4net.n." + getPlatform() +"." + getClr()+ "-" + getVersion() + ".dll";
                init(new File(fileOrDirectory , myDllName).getAbsoluteFile());
				return;
			}
			try {
                final String file = fileOrDirectory.getPath();
                System.load(file);
				final int res = Bridge.initDotNet();
				if (res != 0) {
					System.err.println("Can't initialize jni4net Bridge from " + file);
					throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge. Code:"+res);
				}
				Bridge.isRegistered = true;
			} catch (Throwable th) {
				System.err.println("Can't initialize jni4net Bridge" + th.getMessage());
				throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge", th);
			}
		}
	}

	static File findDefaultDll() throws java.io.IOException {
		final java.security.CodeSource source = Bridge.class.getProtectionDomain().getCodeSource();
        final String file;
        try {
            file = new File(source.getLocation().toURI()).getAbsolutePath();
        } catch (URISyntaxException e) {
            throw new IOException(e.getMessage());
        }

        java.io.File path;
		if (file.endsWith("classes")) {
			final String base = file.substring(0, file.length() - 7).replaceAll("jni4net\\.j", "jni4net.n."+getPlatform()+"."+getClr()) + "/jni4net.n";
			path = new java.io.File(base + "."+ getPlatform()+"." + getClr()+ "-" + getVersion() + ".dll");
			if (!path.exists()) {
				throw new Error("Can't find " + path);
			}
		} else if (file.endsWith(".jar")) {
			final String base = file.substring(0, file.length() - 4).replaceAll("jni4net\\.j", "jni4net.n."+getPlatform()+"."+getClr());
			path = new java.io.File(base + ".dll");
		} else {
			throw new Error("Can't find " + file);
		}
		return path;
	}

	public static String getProperty(String property) {
		final URL resource = CLRLoader.class.getClassLoader().getResource("META-INF/jni4net.properties");
		if (resource != null) {
			try {
				Properties p = new Properties();
				InputStream ins = resource.openStream();
				p.load(ins);
				ins.close();
				return p.getProperty(property, null);
			}
			catch (IOException ignore) {
			}
		}
		return null;
	}

    public static synchronized String getClr() {
        if (Bridge.clrVersion == null) {
            Bridge.clrVersion = "v20";
	    if (getPlatform().startsWith("w")){
                if (new File("c:/Windows/Microsoft.NET/Framework/v4.0.30128").exists()) {
                    Bridge.clrVersion = "v40";
		}
            }
	    if (getPlatform().startsWith("l")){
                Bridge.clrVersion = "m26";
	    }
        }
        return Bridge.clrVersion;
    }

    public static synchronized String getPlatform() {
        if (platform == null) {
            String model = System.getProperty("sun.arch.data.model");
            String os = System.getProperty("os.name").toLowerCase();
            if (os.startsWith("windows")) {
                platform = "w";
            } else if (os.equals("linux")){
		platform = "l";
            } else {
System.out.println(os);
                throw new UnsupportedOperationException("Platform not supported " + os);
            }
            platform += model;
        }
        return platform;
    }

	public static synchronized String getVersion() {
		if (version == null) {
			version = getProperty("jni4net.version");
		}
		return version;
	}
}
