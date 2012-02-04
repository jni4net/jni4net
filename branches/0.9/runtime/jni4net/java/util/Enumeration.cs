﻿#region Copyright (C) 2012 by Pavel Savara

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

namespace net.sf.jni4net
{
    public class Enumeration<T> : Adaptor<T>, IEnumerator
        where T : Enumeration
    {
        private object current;

        public Enumeration(T closeable)
            : base(closeable)
        {
            current = null;
        }

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
    }

    public static partial class Adapt
    {
        public static Enumeration<T> Enumeration<T>(T Enumeration)
            where T : Enumeration
        {
            return new Enumeration<T>(Enumeration);
        }
    }


}
