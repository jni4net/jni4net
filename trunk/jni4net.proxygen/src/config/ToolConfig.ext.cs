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

namespace net.sf.jni4net.proxygen.config
{
    partial class ToolConfig
    {
    }

    partial class SkipMethod
    {
        public SkipMethod()
        {
        }

        public SkipMethod(string clazz, string method, string signature)
        {
            ClassName = clazz;
            MethodName = method;
            Signature = signature;
        }

        public override bool Equals(object obj)
        {
            var other = obj as SkipMethod;
            if (other == null)
                return false;

            return other.ClassName == ClassName && other.Signature == Signature && other.MethodName == MethodName;
        }

        public override int GetHashCode()
        {
            return ClassName.GetHashCode() ^ MethodName.GetHashCode() ^ Signature.GetHashCode();
        }
    }
}