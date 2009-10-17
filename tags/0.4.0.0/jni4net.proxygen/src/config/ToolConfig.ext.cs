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

    partial class TypeRegistration
    {
        public bool TestSkipMethod(string name, string signature)
        {
            if (MethodModifier != null)
            {
                foreach (MethodModifier method in MethodModifier)
                {
                    if (name == method.MethodName && signature == method.Signature)
                    {
                        return method.Skip;
                    }
                }
            }
            return false;
        }

        public bool TestForceMethod(string name, string signature)
        {
            if (MethodModifier != null)
            {
                foreach (MethodModifier method in MethodModifier)
                {
                    if (name == method.MethodName && signature == method.Signature)
                    {
                        return method.Force;
                    }
                }
            }
            return false;
        }

        public bool ReplaceReturn(string name, string signature, out string ret)
        {
            if (MethodModifier != null)
            {
                foreach (MethodModifier method in MethodModifier)
                {
                    if (name == method.MethodName && signature == method.Signature && method.Return != null)
                    {
                        ret = method.Return;
                        return true;
                    }
                }
            }
            ret = null;
            return false;
        }

        public bool ExplicitInterface(string name, string signature, out string ret)
        {
            if (MethodModifier != null)
            {
                foreach (MethodModifier method in MethodModifier)
                {
                    if (name == method.MethodName && signature == method.Signature && method.Interface != null)
                    {
                        ret = method.Interface;
                        return true;
                    }
                }
            }
            ret = null;
            return false;
        }

        public bool GetModifier(string name, string signature, out MethodModifier modifier)
        {
            if (MethodModifier != null)
            {
                foreach (MethodModifier method in MethodModifier)
                {
                    if (name == method.MethodName && signature == method.Signature)
                    {
                        modifier = method;
                        return true;
                    }
                }
            }
            modifier = null;
            return false;
        }

        public bool IsIgnoredInterface(string name)
        {
            if (IgnoreInterface != null)
            {
                foreach (TypeReference reference in IgnoreInterface)
                {
                    if (reference.TypeName == name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}