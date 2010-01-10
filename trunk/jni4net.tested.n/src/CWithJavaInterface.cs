#region Copyright (C) 2009 by Pavel Savara
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

using java.lang;

namespace net.sf.jni4net.tested
{
    public class CWithJavaInterface : Comparable, Runnable
    {
        public int Value { get; set; }

        public CWithJavaInterface(int value)
        {
            Value = value;
        }

        public int compareTo(Object objectPar0)
        {
            var other = Bridge.UnwrapCLR<CWithJavaInterface>(objectPar0);
            if (other == null)
            {
                return -1;
            }
            return other.Value.CompareTo(Value);
        }

        public void run()
        {
            Value++;
        }
    }
}
