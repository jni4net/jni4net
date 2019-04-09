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
using net.sf.jni4net.utils;

namespace net.sf.jni4net.proxygen.model
{
    internal class GMethod
    {
        private readonly List<string> _ParameterNames = new List<string>();
        private readonly List<GType> _Parameters = new List<GType>();
        public bool IsConstructor { get; set; }
        public bool IsField { get; set; }
        public bool IsProperty { get; set; }
        public bool IsEvent { get; set; }
        public bool IsStatic { get; set; }
        public bool IsFinal { get; set; }
        public bool IsVoid { get; set; }
        public bool IsJVMMethod { get; set; }
        public bool IsCLRMethod { get; set; }
        public GType Type { get; set; }
        public bool UseExplicitInterface { get; set; }
        public GType DeclaringType { get; set; }
        public string JVMName { get; set; }

        private string _clrName;
        public string CLRName
        {
            get { return _clrName; }
            set { _clrName = value.Replace("$", "S"); }
        }

        public bool IsCLRPropertyGetter { get; set; }
        public bool IsCLRPropertySetter { get; set; }
        public bool IsCLRPropertyAdd { get; set; }
        public bool IsCLRPropertyRemove { get; set; }
        public PropertyInfo CLRProperty { get; set; }
        public EventInfo CLREvent { get; set; }
        public GMethod CLRPropertyGetter { get; set; }
        public GMethod CLRPropertySetter { get; set; }
        public GMethod CLRPropertyAdd { get; set; }
        public GMethod CLRPropertyRemove { get; set; }
        public string JVMSignature { get; set; }
        public string CLRSignature { get; set; }
        public string Name { get; set; }
        public string LowerName { get; set; }
        public GType ReturnType { get; set; }
        public MemberAttributes Attributes { get; set; }

        public List<string> ParameterNames
        {
            get { return _ParameterNames; }
        }

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
                sb.Append(Registry.GetSignature(_Parameters[i].LowerName));
            }
            sb.Append(')');
            return sb.ToString();
        }

        public string GetJVMSignature()
        {
            return GetJVMSignatureNoRet() + Registry.GetSignature(ReturnType.JVMResolved);
        }

        public string GetCLRSignature()
        {
            return GetCLRSignatureNoRet() + Registry.GetSignature(ReturnType.CLRResolved);
        }

        public string GetJVMSignatureNoRet()
        {
            var sb = new StringBuilder();
            if (!IsField)
            {
                sb.Append('(');
                for (int i = 0; i < _Parameters.Count; i++)
                {
                    if (_Parameters[i].IsOut)
                    {
                        sb.Append("Lnet/sf/jni4net/Out;");
                    }
                    else if (_Parameters[i].IsRef)
                    {
                        sb.Append("Lnet/sf/jni4net/Ref;");
                    }
                    else
                    {
                        sb.Append(Registry.GetSignature(_Parameters[i].JVMResolved));
                    }
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
                    sb.Append(Registry.GetSignature(_Parameters[i].CLRResolved));
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
            if (DeclaringType == null)
            {
                DeclaringType = Type;
            }
            if (IsCLRMethod)
            {
                if (JVMName == null)
                {
                    JVMName = CLRName;
                }
            }
            if (IsJVMMethod)
            {
                if (CLRName == null)
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