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
class VersionReader {
	private static String nversion;
	private static String version;

	public static String getProperty(String property) {
		final URL resource = VersionReader.class.getClassLoader().getResource("META-INF/jni4net.properties");
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
		if (version == null) {
			version = getProperty("jni4net.version");
		}
		return version;
	}

	public static synchronized String getNVersion() {
		if (nversion == null) {
			nversion = getProperty("jni4net.nversion");
		}
		return nversion;
	}
}
