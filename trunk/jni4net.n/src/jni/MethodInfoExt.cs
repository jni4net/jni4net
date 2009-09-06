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
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    public static class MethodInfoExt
    {
        public static string GetSignature(MethodInfo thiz)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            foreach (ParameterInfo par in thiz.GetParameters())
            {
                sb.Append(Registry.ClrSignature(par.ParameterType));
            }
            sb.Append(')');
            sb.Append(Registry.ClrSignature(thiz.ReturnType));
            return sb.ToString();
        }

        public static string GetSignature(ConstructorInfo thiz)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            foreach (ParameterInfo par in thiz.GetParameters())
            {
                sb.Append(Registry.ClrSignature(par.ParameterType));
            }
            sb.Append(')');
            sb.Append('V');
            return sb.ToString();
        }

        public static string GetClrSignature(CodeMemberMethod thiz)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            foreach (CodeParameterDeclarationExpression par in thiz.Parameters)
            {
                if (par.Type.ArrayRank > 1)
                {
                    throw new NotImplementedException();
                }
                if (par.Type.ArrayRank == 1)
                {
                    sb.Append(Registry.GetSignature(par.Type.BaseType + "[]"));
                }
                else
                {
                    sb.Append(Registry.GetSignature(par.Type.BaseType));
                }
            }
            sb.Append(')');

            if (thiz.ReturnType.ArrayRank == 1)
            {
                sb.Append(Registry.GetSignature(thiz.ReturnType.BaseType + "[]"));
            }
            else
            {
                sb.Append(Registry.GetSignature(thiz.ReturnType.BaseType));
            }
            return sb.ToString();
        }

        public static string GetSignatureNoRet(CodeMemberMethod thiz)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            foreach (CodeParameterDeclarationExpression par in thiz.Parameters)
            {
                sb.Append(Registry.GetSignature(par.Type.BaseType));
            }
            sb.Append(')');
            return sb.ToString();
        }

        public static Type GetReturnType(string signature)
        {
            string type = signature.Substring(signature.LastIndexOf(')') + 1);
            int i = 0;
            Type item = GetType(ref i, type, type[0]);
            return item;
        }

        public static Type[] GetParameterTypes(string signature)
        {
            var types = new List<Type>();
            string parms = signature.Substring(1, signature.LastIndexOf(')') - 1);
            for (int i = 0; i < parms.Length; i++)
            {
                char curr = parms[i];
                Type item = GetType(ref i, parms, curr);
                types.Add(item);
            }
            return types.ToArray();
        }

        private static Type GetType(ref int position, string signature, char curr)
        {
            Type item = null;
            bool cont = true;
            int arr = 0;
            while (cont)
            {
                cont = false;
                switch (curr)
                {
                    case 'Z':
                        item = Type.GetType("System.Boolean");
                        break;
                    case 'I':
                        item = Type.GetType("System.Int32");
                        break;
                    case 'D':
                        item = Type.GetType("System.Double");
                        break;
                    case 'F':
                        item = Type.GetType("System.Single");
                        break;
                    case 'S':
                        item = Type.GetType("System.Int16");
                        break;
                    case 'J':
                        item = Type.GetType("System.Int64");
                        break;
                    case 'C':
                        item = Type.GetType("System.Char");
                        break;
                    case 'B':
                        item = Type.GetType("System.byte");
                        break;
                    case 'V':
                        item = Type.GetType("System.Void");
                        break;
                    case 'L':
                        int last = signature.IndexOf(';', position + 1);
                        string name = signature.Substring(position + 1, last - position - 1).Replace('/', '.');
                        item = Type.GetType(name);
                        if (item == null)
                        {
                            //name = Util.ConvertClassName(name);
                            item = Type.GetType(name, false, true);
                            //Class clazz = Class.forName(name);
                            //item = ClassResolver.ConvertClass(clazz);
                        }
                        position = last;
                        break;
                    case '[':
                        cont = true;
                        position++;
                        arr++;
                        curr = signature[position];
                        break;
                }
            }
            if (item == null)
            {
                throw new JNIException("Can't find mapping to " + curr);
            }
            if (arr > 0)
            {
                item = item.MakeArrayType(arr);
            }
            return item;
        }
    }
}