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
using System.Text;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Utils;
using polyglottos;
using polyglottos.generators;

namespace com.jni4net.proxygen.Model
{
    public class GTypeUsageGenerator : GGeneratorBase, IGTypeGenerator
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override void Generate(IGSnippet snippet)
        {
            GenerateArgs((IGType)snippet, TypeArgs.NameNamespaceArgumentsPrefix);
        }

        public virtual void GenerateArgs(IGType snippet, TypeArgs nameArgs)
        {
            var typeUsage = (UTypeUsage)snippet;
            var contextJ4N = ((GContextJ4N) Context);
            KnownTypes = contextJ4N.KnownTypes;
            var name = CreateParametrizedName(typeUsage, nameArgs, !contextJ4N.IsClr);
            CodeWriter.Write(name);
        }

        public virtual string CreateParametrizedName(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode)
        {
            var sb=new StringBuilder();
            var typeName = isJavaCode
                               ? typeUsage.Root.JvmName
                               : typeUsage.Root.ClrName;

            bool isPrimitive = IsPrimitive(typeUsage, nameArgs, isJavaCode);

            WritePrefix(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb);
            WriteNamespace(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb);
            WriteName(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb);
            WriteArguments(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb);
            WritePostfix(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb);

            return sb.ToString();
        }

        private bool IsPrimitive(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode)
        {
            if (typeUsage.IsLocalName || typeUsage.MakeProxyName || typeUsage.MakeStaticName)
            {
                return false;
            }
            bool writeReflection = EnumUtils.IsSet(nameArgs, TypeArgs.Reflection);
            bool writeFileName = EnumUtils.IsSet(nameArgs, TypeArgs.Filename);
            if (writeReflection || writeFileName)
            {
                return false;
            }
            if (isJavaCode)
            {
                if (typeUsage.Root.IsJvm)
                {
                    return typeUsage.Root.IsPrimitive;
                }
            }
            else
            {
                if (typeUsage.Root == KnownTypes.SystemString)
                {
                    return true;
                }
                if (typeUsage.Root == KnownTypes.SystemObject)
                {
                    return true;
                }
                return typeUsage.Root.IsPrimitive;
            }
            return false;
        }

        protected virtual void WritePrefix(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
            bool writeSignature = EnumUtils.IsSet(nameArgs, TypeArgs.Signature);
            if (writeSignature)
            {
                if (typeUsage.IsRef)
                {
                    sb.Append("Lnet/sf/jni4net/Ref");
                }
                else if (typeUsage.IsOut)
                {
                    sb.Append("Lnet/sf/jni4net/Out");
                }
                else if (typeUsage.IsArray)
                {
                    for (int i = 0; i < typeUsage.ArrayRank.Length; i++)
                    {
                        for (int j = 0; j < typeUsage.ArrayRank[i]; j++)
                        {
                            sb.Append("[");
                        }
                    }
                    if (!isPrimitive)
                    {
                        sb.Append("L");
                    }
                }
                else if (!isPrimitive)
                {
                    sb.Append("L");
                }
            }
            else
            {
                if (isJavaCode)
                {
                    if (typeUsage.IsRef)
                    {
                        sb.Append("net.sf.jni4net.Ref<");
                    }
                    if (typeUsage.IsOut)
                    {
                        sb.Append("net.sf.jni4net.Out<");
                    }
                }
                else
                {
                    if (typeUsage.IsRef)
                    {
                        sb.Append("ref ");
                    }
                    if (typeUsage.IsOut)
                    {
                        sb.Append("out ");
                    }
                }
                bool writeGlobal = EnumUtils.IsSet(nameArgs, TypeArgs.GlobalPrefix);
                bool writeReflection = EnumUtils.IsSet(nameArgs, TypeArgs.Reflection);
                if (!isPrimitive
                    && !isJavaCode
                    && !typeUsage.IsLocalName
                    && writeGlobal
                    && !writeReflection
                    )
                {
                    sb.Append("global::");
                }
            }
        }

        protected virtual void WriteNamespace(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
            bool writeSignature = EnumUtils.IsSet(nameArgs, TypeArgs.Signature);
            if (isJavaCode && (typeUsage.IsRef || typeUsage.IsOut ))
            {
                if(writeSignature)
                {
                    return;
                }
            }
            else if (isPrimitive)
            {
                return;
            }
            
            bool writeNamespace = EnumUtils.IsSet(nameArgs, TypeArgs.Namespace);
            if (writeNamespace)
            {
                bool writeReflection = EnumUtils.IsSet(nameArgs, TypeArgs.Reflection);

                string nsp = typeName.Namespace;
                if (!String.IsNullOrEmpty(nsp))
                {
                    if(writeSignature)
                    {
                        nsp = nsp.Replace(".", "/");
                    }

                    if (isJavaCode && (typeUsage.MakeProxyName || typeUsage.MakeStaticName))
                    {
                        if (nsp.StartsWith("java."))
                        {
                            nsp = nsp.Replace("java.", "java_.");
                        }
                    }

                    sb.Append(NTypeName.ReplaceKeywords(nsp, isJavaCode));
                    sb.Append(writeSignature ? '/' : '.');
                }
                for (int i = 0; i < typeName.EnclosingTypes.Count; i++)
                {
                    var nest = typeName.EnclosingTypes[i];
                    if (i > 0)
                    {
                        sb.Append(writeReflection || writeSignature
                                      ? isJavaCode
                                            ? "$"
                                            : "+"
                                      : ".");
                    }
                    sb.Append(NTypeName.ReplaceKeywords(nest.LocalName, isJavaCode));
                    if (typeUsage.MakeProxyName || typeUsage.MakeStaticName)
                    {
                        if (isJavaCode && (typeUsage.Root.IsJvm || nest.Root.IsInterface))
                        {
                            sb.Append('_');
                        }
                        else if (!isJavaCode && (typeUsage.Root.IsClr || nest.Root.IsInterface))
                        {
                            sb.Append('_');
                        }
                    }
                    WriteNestedArguments(typeUsage, nameArgs, isJavaCode, isPrimitive, typeName, sb, i);
                }
                if (typeName.EnclosingTypes.Count > 0)
                {
                    sb.Append(writeReflection || writeSignature
                                  ? isJavaCode
                                        ? "$"
                                        : "+"
                                  : ".");
                }
                bool writeName = EnumUtils.IsSet(nameArgs, TypeArgs.Name);
                if (!writeName && sb.Length>0)
                {
                    sb.Length--;//last dot
                }
            }
        }

        protected virtual void WriteName(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
            bool writeName = EnumUtils.IsSet(nameArgs, TypeArgs.Name);
            if (writeName)
            {
                bool writeSignature = EnumUtils.IsSet(nameArgs, TypeArgs.Signature);
                if (isJavaCode && (typeUsage.IsRef || typeUsage.IsOut))
                {
                    if (writeSignature)
                    {
                        return;
                    }
                }
                else if (isPrimitive)
                {
                    WritePrimitive(typeUsage, nameArgs, isJavaCode, true, typeName, sb);
                    return;
                }

                if (typeUsage.MakeProxyName && (typeUsage.Root.IsInterface || isJavaCode == typeUsage.Root.IsJvm))
                {
                    sb.Append("_");
                }
                sb.Append(typeName.LocalName);
                if (typeUsage.MakeStaticName && (typeUsage.Root.IsInterface || isJavaCode == typeUsage.Root.IsJvm))
                {
                    sb.Append("_");
                }
            }
        }

        protected virtual void WritePrimitive(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
            bool writeSignature = EnumUtils.IsSet(nameArgs, TypeArgs.Signature);
            //TODO if (isJavaCode)
            if (typeUsage.Root.IsJvm)
            {
                if (typeUsage.Root == KnownTypes.JvmBool)
                {
                    sb.Append(writeSignature ? "Z" : "boolean");
                }
                else if (typeUsage.Root == KnownTypes.JvmByte)
                {
                    sb.Append(writeSignature ? "B" : "byte");
                }
                else if (typeUsage.Root == KnownTypes.JvmChar)
                {
                    sb.Append(writeSignature ? "C" : "char");
                }
                else if (typeUsage.Root == KnownTypes.JvmShort)
                {
                    sb.Append(writeSignature ? "S" : "short");
                }
                else if (typeUsage.Root == KnownTypes.JvmInt)
                {
                    sb.Append(writeSignature ? "I" : "int");
                }
                else if (typeUsage.Root == KnownTypes.JvmLong)
                {
                    sb.Append(writeSignature ? "J" : "long");
                }
                else if (typeUsage.Root == KnownTypes.JvmFloat)
                {
                    sb.Append(writeSignature ? "F" : "float");
                }
                else if (typeUsage.Root == KnownTypes.JvmDouble)
                {
                    sb.Append(writeSignature ? "D" : "double");
                }
                else if (typeUsage.Root == KnownTypes.JvmVoid)
                {
                    sb.Append(writeSignature ? "V" : "void");
                }
                /*else if (typeUsage.Root == KnownTypes.JavaLangVoid)
                {
                    sb.Append(writeSignature ? "V" : "void");
                }*/
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                if (typeUsage.Root == KnownTypes.ClrBool)
                {
                    sb.Append(writeSignature ? "Z" : "bool");
                }
                else if (typeUsage.Root == KnownTypes.ClrByte)
                {
                    sb.Append(writeSignature ? "B" : "byte");
                }
                else if (typeUsage.Root == KnownTypes.ClrChar)
                {
                    sb.Append(writeSignature ? "C" : "char");
                }
                else if (typeUsage.Root == KnownTypes.ClrShort)
                {
                    sb.Append(writeSignature ? "S" : "short");
                }
                else if (typeUsage.Root == KnownTypes.ClrInt)
                {
                    sb.Append(writeSignature ? "I" : "int");
                }
                else if (typeUsage.Root == KnownTypes.ClrLong)
                {
                    sb.Append(writeSignature ? "J" : "long");
                }
                else if (typeUsage.Root == KnownTypes.ClrFloat)
                {
                    sb.Append(writeSignature ? "F" : "float");
                }
                else if (typeUsage.Root == KnownTypes.ClrDouble)
                {
                    sb.Append(writeSignature ? "D" : "double");
                }
                else if (typeUsage.Root == KnownTypes.ClrSByte)
                {
                    sb.Append(writeSignature ? "b" : "sbyte");
                }
                else if (typeUsage.Root == KnownTypes.ClrUShort)
                {
                    sb.Append(writeSignature ? "s" : "ushort");
                }
                else if (typeUsage.Root == KnownTypes.ClrUInt)
                {
                    sb.Append(writeSignature ? "i" : "uint");
                }
                else if (typeUsage.Root == KnownTypes.ClrULong)
                {
                    sb.Append(writeSignature ? "j" : "ulong");
                }
                else if (typeUsage.Root == KnownTypes.ClrVoid)
                {
                    sb.Append(writeSignature ? "V" : "void");
                }
                else if (typeUsage.Root == KnownTypes.SystemObject)
                {
                    sb.Append(writeSignature ? "Lsystem/Object;" : "object");
                }
                else if (typeUsage.Root == KnownTypes.SystemString)
                {
                    sb.Append(writeSignature ? "Lsystem/String;" : "string");
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        protected virtual void WriteNestedArguments(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb, int index)
        {
        }

        protected virtual void WriteArguments(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
        }

        protected virtual void WritePostfix(UTypeUsageBase typeUsage, TypeArgs nameArgs, bool isJavaCode, bool isPrimitive, NTypeName typeName, StringBuilder sb)
        {
            bool writeSignature = EnumUtils.IsSet(nameArgs, TypeArgs.Signature);
            if (writeSignature)
            {
                if (!isPrimitive || (typeUsage.IsRef || typeUsage.IsOut))
                {
                    sb.Append(";");
                }
                return;
            }

            if (typeUsage.IsArray)
            {
                for (int i = 0; i < typeUsage.ArrayRank.Length; i++)
                {
                    if (typeUsage.ArrayRank[i] > 0)
                    {
                        sb.Append('[');
                        sb.Append(',', typeUsage.ArrayRank[i] - 1);
                        sb.Append(']');
                    }
                }
            }
            if (isJavaCode)
            {
                if (typeUsage.IsRef)
                {
                    sb.Append(">");
                }
                if (typeUsage.IsOut)
                {
                    sb.Append(">");
                }
            }
            else
            {
                if (typeUsage.IsPointer)
                {
                    sb.Append("*");
                }
            }
        }
    
    }
}