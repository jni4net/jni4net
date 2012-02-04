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

using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using StringBuilder = System.Text.StringBuilder;

namespace com.jni4net.proxygen.Model
{
    public class NTypeName
    {
        public NTypeName(MType root, string localName)
        {
            Root = root;
            EnclosingTypes = new List<NTypeName>();
            LocalName = localName;
        }

        public NTypeName(NTypeName src)
        {
            Root = src.Root;
            EnclosingTypes = new List<NTypeName>();
            Namespace = src.Namespace;
            foreach (var enclosingType in src.EnclosingTypes)
            {
                EnclosingTypes.Add(new NTypeName(enclosingType));
            }
            LocalName = src.LocalName;
        }

        public NTypeName(MType root)
        {
            Root = root;
            EnclosingTypes=new List<NTypeName>();
        }

        public MType Root { get; set; }
        private string ns;
        public string Namespace
        {
            get { return EnclosingTypes.Count > 0 ? EnclosingTypes[0].Namespace : ns; }
            set
            {
                var val = string.IsNullOrEmpty(value) ? null : value;
                if (EnclosingTypes.Count > 0)
                {
                    EnclosingTypes[0].Namespace = val;
                }
                else
                {
                    ns = val;
                }
            }
        }

        public IList<NTypeName> EnclosingTypes { get; set; }
        public string LocalName { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Namespace!=null)
            {
                sb.Append(Namespace);
                sb.Append(".");
            }
            for (int i = 0; i < EnclosingTypes.Count; i++)
            {
                if(i>0)
                {
                    sb.Append(".");
                }
                var enclosingType = EnclosingTypes[i];
                sb.Append(enclosingType.LocalName);
            }
            sb.Append(LocalName);
            return sb.ToString();
        }


        public static void HackUpperCase(NTypeName clrName)
        {
            //TODO
            if (clrName.Namespace == null)
            {
                return;
            }
            if (clrName.Namespace.StartsWith("system"))
            {
                clrName.Namespace = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(clrName.Namespace);
                if (clrName.Namespace.StartsWith("System.Io"))
                {
                    clrName.Namespace = clrName.Namespace.Replace("System.Io", "System.IO");
                }
            }
        }

        public void UnnestInterfaces()
        {
            var nns = new StringBuilder(Namespace);
            int last = -1;
            int first = -1;
            MType enc = Root.Exploration.EnclosingType;
            for (int i = 0; i < EnclosingTypes.Count; i++)
            {
                if (EnclosingTypes[i].Root==null && enc!=null)
                {
                    EnclosingTypes[i].Root = enc;
                }
                if (EnclosingTypes[i].Root!=null && EnclosingTypes[i].Root.IsInterface)
                {
                    last = i;
                    if (first == -1)
                    {
                        first = i;
                    }
                }
                enc = enc != null && enc.Exploration != null
                          ? enc.Exploration.EnclosingType
                          : null;
            }
            if (last == -1)
            {
                return;
            }
            for (int i = 0; i < last + 1; i++)
            {
                nns.Append(".").Append(EnclosingTypes[i].LocalName);
                if (i >= first)
                {
                    nns.Append("Nest");
                }
            }
            for (int i = 0; i < last + 1; i++)
            {
                EnclosingTypes.RemoveAt(0);
            }
            Namespace = nns.ToString();
        }

        public static string ReplaceKeywords(string input, bool isJavaCode)
        {
            if (input == null)
                return null;
            if (isJavaCode)
            {
                return javaKeywords.Replace(input, (x) => "_" + x.Captures[0].Value);
            }
            else
            {
                return csharpKeywords.Replace(input, (x) => "@" + x.Captures[0].Value);
            }
        }

        protected static Regex csharpKeywords = new Regex("\\b(?<KEYWORD>abstract|event|new|struct|as|explicit|null|switch|base|extern|object|this|bool|false|operator|throw|break|finally|out|true|byte|fixed|override|try|case|float|params|typeof|catch|for|private|uint|char|foreach|protected|ulong|checked|goto|public|unchecked|class|if|readonly|unsafe|const|implicit|ref|ushort|continue|in|return|using|decimal|int|sbyte|virtual|default|interface|sealed|volatile|delegate|internal|short|void|do|is|sizeof|while|double|lock|stackalloc|else|long|static|enum|namespace|string)\\b", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);
        protected static Regex javaKeywords = new Regex("\\b(?<KEYWORD>abstract|new|null|switch|native|object|this|boolean|false|throw|break|finally|true|byte|try|case|float|catch|for|private|char|protected|goto|public|class|if|final|const|implements|extends|continue|return|int|virtual|interface|volatile|short|void|do|while|double|synchronized|else|long|static|enum|package)\\b", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

    }
}
