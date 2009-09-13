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

import java.io.IOException;
import java.io.InputStream;
import java.net.URL;
import java.util.Properties;

/**
 * @author Pavel Savara (original)
 */
class CLRLoader {
	private static String nversion;

	public static void init(String fileOrDirectory) {
		if (!Bridge.isRegistered) {
			if (new java.io.File(fileOrDirectory).isDirectory()) {
				init(fileOrDirectory + "/jni4net.n-" + getVersion() + ".dll");
				return;
			}
			try {
				System.load(fileOrDirectory);
				final int res = Bridge.initDotNet(Bridge.verbose);
				if (res != 0) {
					System.err.println("Can't initialize jni4net Bridge");
					throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge");
				}
				Bridge.isRegistered = true;
			} catch (Throwable th) {
				System.err.println("Can't initialize jni4net Bridge" + th.getMessage());
				throw new net.sf.jni4net.inj.INJException("Can't initialize jni4net Bridge", th);
			}
		}
	}

	static String findDefaultDll() throws java.io.IOException {
		final java.security.CodeSource source = Bridge.class.getProtectionDomain().getCodeSource();
		final String file = source.getLocation().getFile();

		java.io.File path;
		if (file.endsWith("classes/")) {
			final String base = file.substring(0, file.length() - 8).replaceAll("jni4net.j", "jni4net.n") + "jni4net.n";
			path = new java.io.File(base + "-" + getVersion() + ".dll");
			if (!path.exists()) {
				throw new Error("Can't find " + path);
			}
		} else if (file.endsWith(".jar")) {
			final String base = file.substring(0, file.length() - 4).replaceAll("jni4net\\.j", "jni4net.n");
			path = new java.io.File(base + ".dll");
		} else {
			throw new Error("Can't find " + file);
		}
		return path.getCanonicalPath();
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

	public static synchronized String getVersion() {
		if (nversion == null) {
			nversion = getProperty("jni4net.nversion");
		}
		return nversion;
	}
}
