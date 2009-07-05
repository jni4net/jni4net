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

using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace net.sf.jni4net.proxygen.model
{
    internal class GMethod
    {
        public bool IsConstructor { get; set; }
        public bool IsField { get; set; }
        public bool IsProperty { get; set; }
        public bool IsStatic { get; set; }
        public bool IsVoid { get; set; }
        public bool IsJVMMethod { get; set; }
        public bool IsCLRMethod { get; set; }
        public GType Type { get; set; }
        public bool UseExplicitInterface { get; set; }
        public GType DeclaringType { get; set; }
        public string JVMName { get; set; }
        public string CLRName { get; set; }
        public bool IsCLRPropertyGetter { get; set; }
        public bool IsCLRPropertySetter { get; set; }
        public PropertyInfo CLRProperty { get; set; }
        public GMethod CLRPropertyGetter { get; set; }
        public GMethod CLRPropertySetter { get; set; }
        public string JVMSignature { get; set; }
        public string CLRSignature { get; set; }
        public string Name { get; set; }
        public string LowerName { get; set; }
        public GType ReturnType { get; set; }
        public MemberAttributes Attributes { get; set; }

        private readonly List<string> _ParameterNames = new List<string>();

        public List<string> ParameterNames
        {
            get { return _ParameterNames; }
        }

        private readonly List<GType> _Parameters = new List<GType>();

        public List<GType> Parameters
        {
            get { return _Parameters; }
        }


        public string GetSignatureLowerNoRet()
        {
            var sb = new StringBuilder();
            sb.Append('(');
            for (int i = 0; i < _Parameters.Count; i++)
            {
                sb.Append(Bridge.GetSignature(_Parameters[i].LowerName));
            }
            sb.Append(')');
            return sb.ToString();
        }

        public string GetJVMSignature()
        {
            return GetJVMSignatureNoRet() + Bridge.GetSignature(ReturnType.JVMResolved);
        }

        public string GetCLRSignature()
        {
            return GetCLRSignatureNoRet() + Bridge.GetSignature(ReturnType.CLRResolved);
        }

        public string GetJVMSignatureNoRet()
        {
            var sb = new StringBuilder();
            if (!IsField)
            {
                sb.Append('(');
                for (int i = 0; i < _Parameters.Count; i++)
                {
                    sb.Append(Bridge.GetSignature(_Parameters[i].JVMResolved));
                }
                sb.Append(')');
            }
            return sb.ToString();
        }

        public string GetCLRSignatureNoRet()
        {
            var sb = new StringBuilder();
            if (!IsField)
            {
                sb.Append('(');
                for (int i = 0; i < _Parameters.Count; i++)
                {
                    sb.Append(Bridge.GetSignature(_Parameters[i].CLRResolved));
                }
                sb.Append(')');
            }
            return sb.ToString();
        }
        
        
        public override string ToString()
        {
            return LowerName;
        }

        public void UpdateNames()
        {
            IsVoid = (ReturnType == Repository.voidType);
            if (DeclaringType==null)
            {
                DeclaringType = Type;
            }
            if (IsCLRMethod)
            {
                if (JVMName==null)
                {
                    JVMName = CLRName;
                }
            }
            if (IsJVMMethod)
            {
                if(CLRName==null)
                {
                    CLRName = JVMName;
                }
            }
            if (JVMSignature == null)
            {
                JVMSignature = GetJVMSignature();
            }
            if (CLRSignature == null)
            {
                CLRSignature = GetCLRSignature();
            }
        }
    }
}
