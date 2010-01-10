#region Copyright (C) 2009 by Pavel Savara

/*
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

#endregion

using System;
using System.Collections;
using java.util;

namespace net.sf.jni4net.adaptors
{
    public partial class Adapt
    {
        public static Enumerator<T> Enumeration<T>(T closeable)
            where T : Enumeration
        {
            return new Enumerator<T>(closeable);
        }
    }

    public class Enumerator<T> : Adaptor<T>, IEnumerator, IEnumerable
        where T : Enumeration
    {
        public Enumerator(T enumeration)
            : base(enumeration)
        {
            current = null;
        }

        private object current;

        public bool MoveNext()
        {
            if (Real.hasMoreElements())
            {
                current = Real.nextElement();
                return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public object Current
        {
            get { return current; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
