#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.IO;

namespace com.jni4net.proxygen.Utils
{
    public class PathUtils
    {
        /// <summary>
        /// Creates a relative path from one file or folder to another.
        /// </summary>
        /// <param name="fromPath">Contains the directory that defines the start of the relative path.</param>
        /// <param name="toPath">Contains the path that defines the endpoint of the relative path.</param>
        /// <returns>The relative path from the start directory to the end path.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static String MakeRelativePath(String fromPath, String toPath)
        {
            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");
            if (!fromPath.EndsWith(""+Path.DirectorySeparatorChar))
            {
                fromPath = fromPath + Path.DirectorySeparatorChar;
            }
            var fromUri = new Uri(fromPath);
            var toUri = new Uri(toPath);

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            String relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }

        public static string MakeAbsolutePath(string fromPath, string fromPathDefault, string toPath)
        {
            if (String.IsNullOrEmpty(toPath))
            {
                return MakeAbsoluteBase(fromPath, fromPathDefault);
            }
            fromPath = MakeAbsoluteBase(fromPath, fromPathDefault);
            return MakeAbsolutePath(fromPath, toPath);
        }

        public static string MakeAbsoluteBase(string fromPath, string fromPathDefault)
        {
            if (String.IsNullOrEmpty(fromPathDefault)) throw new ArgumentNullException("fromPathDefault");
            if (String.IsNullOrEmpty(fromPath))
            {
                fromPath = fromPathDefault;
            }
            if (!Path.IsPathRooted(fromPath))
            {
                fromPath = MakeAbsolutePath(fromPathDefault, fromPath);
            }
            return fromPath;
        }

        public static string MakeAbsolutePath(string fromPath, string toPath)
        {
            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");

            if (!Path.IsPathRooted(fromPath)) throw new ArgumentException("fromPath must be absolute");
            if (Path.IsPathRooted(toPath))
            {
                return Path.GetFullPath(toPath);
            }

            return Path.GetFullPath(Path.Combine(fromPath, toPath));
        }
    
    }
}
