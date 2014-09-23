/* Copyright (C) 2009 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

package net.sf.jni4net;

import system.NotSupportedException;

import java.io.FilenameFilter;
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
            if (getPlatform().startsWith("w")) {
                String sysRoot = System.getenv("SystemRoot");
                if (sysRoot == null || sysRoot.equals("")) {
                    sysRoot = "c:/Windows";
                }
                File d = new File(sysRoot, "Microsoft.NET/Framework/");
                final String[] vers = d.list(new FilenameFilter() {
                    public boolean accept(File dir, String name) {
                        return name.startsWith("v4.0.");
                    }
                });
                if (vers != null && vers.length > 0) {
                    Bridge.clrVersion = "v40";
                }
            }
            else if (getPlatform().startsWith("l")) {
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
