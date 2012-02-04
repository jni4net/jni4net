#region Copyright (C) 2012 by Pavel Savara

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

namespace net.sf.jni4net.core
{
    public class MemberId
    {
        public MemberId(string name, string signature, bool isfield, bool isStatic)
        {
            Name = name;
            Signature = signature;
            IsField = isfield;
            IsStatic = isStatic;
        }

        public readonly string Name;
        public readonly string Signature;
        public readonly bool IsField;
        public readonly bool IsStatic;

        public override string ToString()
        {
            return Name + " " + Signature;
        }
    }
}