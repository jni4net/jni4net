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
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator {

    internal abstract partial class Generator {

        public static List<string> filesCLR = new List<string>();
        public static List<string> filesJVM = new List<string>();
        public static Dictionary<string, string> TypesCLR = new Dictionary<string, string>();
        public static Dictionary<string, string> TypesJVM = new Dictionary<string, string>();

        public static ToolConfig config;
        protected GType type;

        protected Generator(GType type) {
            this.type = type;
            SetCurrentType(type.CLRNamespace + "." + type.Name);
        }

        protected void SetCurrentType(string current) {
            SetCurrentType(current, current, current, current);
        }

        protected void AddTypeCLR(string type) {
            if (!TypesCLR.ContainsKey(type)) {
                TypesCLR.Add(type, type);
            }
        }

        protected void AddTypeJVM(string type) {
            if (!TypesJVM.ContainsKey(type)) {
                TypesJVM.Add(type, type);
            }
        }

        protected void SetCurrentType(string current, string real, string proxy, string statc) {

            CurrentType = new CodeTypeReference(current, CodeTypeReferenceOptions.GlobalReference);
            CurrentTypeEx =
                new CodeTypeReferenceExpression(new CodeTypeReference(current, CodeTypeReferenceOptions.GlobalReference));
            RealType = new CodeTypeReference(real, CodeTypeReferenceOptions.GlobalReference);
            RealTypeEx =
                new CodeTypeReferenceExpression(new CodeTypeReference(real, CodeTypeReferenceOptions.GlobalReference));

            ProxyType = new CodeTypeReference(proxy, CodeTypeReferenceOptions.GlobalReference);
            ProxyTypeEx = new CodeTypeReferenceExpression(new CodeTypeReference(proxy, CodeTypeReferenceOptions.GlobalReference));

            StaticType = new CodeTypeReference(statc, CodeTypeReferenceOptions.GlobalReference);
            StaticTypeEx = new CodeTypeReferenceExpression(new CodeTypeReference(statc, CodeTypeReferenceOptions.GlobalReference));
        }

        protected abstract void Generate();

        protected abstract void Generate(CodeNamespace nameSpace);

        public static void GenerateAll() {
            foreach (GType ifc in Repository.GetGenInterfaces()) {
                new JVMInterfaceGenerator(ifc).Generate();
                new JVMInterfaceProxyGenerator(ifc).Generate();
                new CLRInterfaceGenerator(ifc).Generate();
            }

            foreach (GType type in Repository.JVMGenTypes()) {
                new JVMClassGenerator(type).Generate();
                new CLRWrapperGenerator(type).Generate();
            }

            foreach (GType type in Repository.CLRGenTypes()) {
                new CLRClassGenerator(type).Generate();
                new JVMStaticGenerator(type).Generate();
            }
        }

        ///@@@ Mihai
        protected bool CheckGenericMethod(GMethod method) {
            switch (method.ReturnType.CLRReference.BaseType) {
                case "System.Collections.Generic.ICollection`1":
                case "System.Collections.Generic.IDictionary`2":
                case "System.Collections.Generic.IEnumerable`1":
                case "System.Collections.Generic.IList`1":
                case "System.Collections.Generic.ISet`1":
                    return true;
            }
            return false;
        }

        ///@@@ Mihai
        protected string GetWrapperClassNameFull(string genericType) {
            string nonGeneritType = genericType;
            int idx = nonGeneritType.LastIndexOf(".");
            if (idx >= 0) {
                nonGeneritType = nonGeneritType.Substring(idx);
            }
            idx = nonGeneritType.IndexOf("`");
            if (idx >= 0) {
                nonGeneritType = nonGeneritType.Substring(0, idx);
            }

            return GetWrapperClassName(nonGeneritType);
        }

        ///@@@ Mihai
        protected string GetWrapperClassName(string nonGenericType) {
            string wrapperName = string.Empty;
            switch (nonGenericType) {
                case "ICollection":
                    wrapperName = "Collection";
                    break;

                case "IDictionary":
                    wrapperName = "Map";
                    break;

                case "IEnumerable":
                    wrapperName = "Iterable";
                    break;

                case "IList":
                    wrapperName = "List";
                    break;

                case "ISet":
                    wrapperName = "Set";
                    break;
            }
            return wrapperName;
        }
    }
}