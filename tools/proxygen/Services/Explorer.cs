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
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services
{
    public class Explorer : ExplorerBase
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public void Explore()
        {
            JvmResolver.LoadJars();
            ClrResolver.LoadAssemblies();

            // load classes
            InitKnowTypes();
            JvmResolver.LoadClasses();
            ClrResolver.LoadTypes();
            Logger.LogMessage("Explorer started",null);
            Handle();
        }

        #region KnownTypes

        private void InitKnowTypes()
        {
            var kt = KnownTypes as KnownTypes;
            kt.FakeTypes.Add(LoadKnownFakeType("java.lang", "IClass"));
            kt.FakeTypes.Add(LoadKnownFakeType("system", "IType"));

            //kt.IClrProxy = LoadKnownClrType("net.sf.jni4net.inj.IClrProxy");
            //kt.IJvmProxy = LoadKnownClrType("net.sf.jni4net.jni.IJvmProxy");
            //kt.JavaInterfaceAttribute = ClrResolver.LoadType("net.sf.jni4net.attributes.JavaInterfaceAttribute", true);
            //kt.JavaClassAttribute = ClrResolver.LoadType("net.sf.jni4net.attributes.JavaClassAttribute", true);
            //kt.SystemIObject = LoadMappedJvmType("System.Object", "system.IObject");
            //kt.JavaLangIObject = LoadMappedClrType("java_.lang.IObject", "java.lang.Object");

            kt.SystemObject = LoadKnownClrType("System.Object", "system.Object");
            //kt.SystemObject.IsLocalName = true;
            kt.SystemString = LoadKnownClrType("System.String", "system.String");
            //kt.SystemString.IsLocalName = true;
            kt.SystemException = LoadKnownClrType("System.Exception", "system.Exception");
            kt.SystemType = LoadKnownClrType("System.Type", "system.Type");
            /*
            kt.ClrBool = LoadMappedClrType("System.Boolean", "boolean");
            kt.ClrByte = LoadMappedClrType("System.Byte", "byte");
            kt.ClrChar = LoadMappedClrType("System.Char", "char");
            kt.ClrShort = LoadMappedClrType("System.Int16", "short");
            kt.ClrInt = LoadMappedClrType("System.Int32", "int");
            kt.ClrLong = LoadMappedClrType("System.Int64", "long");
            kt.ClrFloat = LoadMappedClrType("System.Single", "float");
            kt.ClrDouble = LoadMappedClrType("System.Double", "double");
            kt.ClrSByte = LoadMappedClrType("System.SByte", "byte");
            kt.ClrUShort = LoadMappedClrType("System.UInt16", "short");
            kt.ClrUInt = LoadMappedClrType("System.UInt32", "int");
            kt.ClrULong = LoadMappedClrType("System.UInt64", "long");
             */

            kt.ClrBool = LoadMappedClrType("System.Boolean", "java.lang.Boolean");
            kt.ClrByte = LoadMappedClrType("System.Byte", "java.lang.Byte");
            kt.ClrChar = LoadMappedClrType("System.Char", "java.lang.Character");
            kt.ClrShort = LoadMappedClrType("System.Int16", "java.lang.Short");
            kt.ClrInt = LoadMappedClrType("System.Int32", "java.lang.Integer");
            kt.ClrLong = LoadMappedClrType("System.Int64", "java.lang.Long");
            kt.ClrFloat = LoadMappedClrType("System.Single", "java.lang.Float");
            kt.ClrDouble = LoadMappedClrType("System.Double", "java.lang.Double");
            kt.ClrSByte = LoadMappedClrType("System.SByte", "java.lang.Byte");
            kt.ClrUShort = LoadMappedClrType("System.UInt16", "java.lang.Short");
            kt.ClrUInt = LoadMappedClrType("System.UInt32", "java.lang.Integer");
            kt.ClrULong = LoadMappedClrType("System.UInt64", "java.lang.Long");

            kt.ClrIntPtr = LoadClrType("System.IntPtr");
            kt.ClrIntPtr.IsPrimitive = false;
            kt.ClrUIntPtr = LoadClrType("System.UIntPtr");
            kt.ClrUIntPtr.IsPrimitive = false;
            
            kt.ClrVoid = LoadMappedClrType("System.Void", "void");
            kt.ClrVoid.IsVoid = true;
            kt.ClrVoid.IsPrimitive = true;
            //kt.ClrVoid.IsLocalName = true;

            kt.JavaLangObject = LoadKnownJvmType("java.lang.Object");
            kt.JavaLangString = LoadKnownJvmType("java.lang.String");
            kt.JavaLangThrowable = LoadKnownJvmType("java.lang.Throwable");
            kt.JavaLangClass = LoadKnownJvmType("java.lang.Class");
            kt.JavaLangVoid = LoadMappedJvmType("System.Void", "java.lang.Void");
            kt.JavaLangVoid.IsVoid = true;
            //kt.JavaLangVoid.IsPrimitive = true;


            kt.JvmBool = LoadMappedJvmType("System.Boolean", "boolean");
            kt.JvmByte = LoadMappedJvmType("System.Byte", "byte");
            kt.JvmChar = LoadMappedJvmType("System.Char", "char");
            kt.JvmShort = LoadMappedJvmType("System.Int16", "short");
            kt.JvmInt = LoadMappedJvmType("System.Int32", "int");
            kt.JvmLong = LoadMappedJvmType("System.Int64", "long");
            kt.JvmFloat = LoadMappedJvmType("System.Single", "float");
            kt.JvmDouble = LoadMappedJvmType("System.Double", "double");
            kt.JvmVoid = LoadMappedJvmType("System.Void", "void");
            kt.JvmVoid.IsVoid = true;

            kt.JavaLangBoolean = LoadMappedJvmType("System.Boolean", "java.lang.Boolean");
            kt.JavaLangByte = LoadMappedJvmType("System.Byte", "java.lang.Byte");
            kt.JavaLangCharacter = LoadMappedJvmType("System.Char", "java.lang.Character");
            kt.JavaLangShort = LoadMappedJvmType("System.Int16", "java.lang.Short");
            kt.JavaLangInteger = LoadMappedJvmType("System.Int32", "java.lang.Integer");
            kt.JavaLangLong = LoadMappedJvmType("System.Int64", "java.lang.Long");
            kt.JavaLangFloat = LoadMappedJvmType("System.Single", "java.lang.Float");
            kt.JavaLangDouble = LoadMappedJvmType("System.Double", "java.lang.Double");

            kt.JavaLangBoolean.IsPrimitiveLike = true;
            kt.JavaLangByte.IsPrimitiveLike = true;
            kt.JavaLangCharacter.IsPrimitiveLike = true;
            kt.JavaLangShort.IsPrimitiveLike = true;
            kt.JavaLangInteger.IsPrimitiveLike = true;
            kt.JavaLangLong.IsPrimitiveLike = true;
            kt.JavaLangFloat.IsPrimitiveLike = true;
            kt.JavaLangDouble.IsPrimitiveLike = true;

            //kt.ClrVoid.IsPrimitive = true;
            //kt.JvmVoid.IsPrimitive = true;

            kt.SystemObject.IsRoot = true;
            kt.JavaLangObject.IsRoot = true;
            kt.SystemException.IsRoot = true;
            kt.JavaLangThrowable.IsRoot = true;

            kt.JavaLangString.Substitution = kt.SystemString;
            kt.SystemString.Substitution = kt.JavaLangString;

            kt.JavaLangObject.Substitution = kt.SystemObject;
            kt.SystemObject.Substitution = kt.JavaLangObject;

            kt.JavaLangThrowable.Substitution = kt.SystemException;
            kt.SystemException.Substitution = kt.JavaLangThrowable;

            kt.IsLoaded = true;

        }

        public static readonly ProjectRegistration knownProject = new ProjectRegistration
                                                       {
                                                           projectName = "known",
                                                           baseDirectory = "known-should-not-create-files"
                                                       };

        public static readonly ProjectRegistration unknownProject = new ProjectRegistration
                                                       {
                                                           projectName = "unknown",
                                                           baseDirectory = "unknown-should-not-create-files"
                                                       };

        private MType LoadKnownFakeType(string nameSpace, string localName)
        {
            var model = MType.Create(Repository, null, null, KnownTypeRegistration(nameSpace + "." + localName), null);
            model.IsClr = true;
            model.LockSide();
            model.JvmName = new NTypeName(model);
            model.ClrName = model.JvmName;
            model.ClrName.LocalName = localName;
            model.ClrName.Namespace = nameSpace;
            Repository.RegisterType(model);
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return model;
        }

        
        private MType LoadKnownClrType(string clrFullName,string jvmFullName)
        {
            var clr = ClrResolver.LoadType(clrFullName, true);
            var jvm = JvmResolver.LoadClass(jvmFullName, true);
            var typeRegistration = KnownTypeRegistration(clrFullName);
            var model = ClrResolver.Register(clr, typeRegistration, null);
            model.IsClr = true;
            model.LockSide();
            model.JvmReflection = jvm;
            Repository.RegisterType(model);
            model = JvmResolver.Register(jvm, typeRegistration, model);
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return model;
        }

        private MType LoadClrType(string clrFullName)
        {
            var clr = ClrResolver.LoadType(clrFullName, true);
            var model = ClrResolver.Register(clr, KnownTypeRegistration(clrFullName), null);
            model.IsClr = true;
            model.LockSide();
            Repository.RegisterType(model);
            model.Pass = ProxyGenPass.P0000_TypeLoaded;
            return model;
        }

        
        private MType LoadKnownJvmType(string fullName)
        {
            return LoadKnownJvmType(fullName, fullName);
        }

        private MType LoadKnownJvmType(string clrFullName, string jvmFullName)
        {
            var clr = ClrResolver.LoadType(clrFullName, true);
            var jvm = JvmResolver.LoadClass(jvmFullName, true);
            var typeRegistration = KnownTypeRegistration(clrFullName);
            var model = JvmResolver.Register(jvm, typeRegistration, null);
            model.IsJvm = true;
            model.LockSide();
            model.ClrReflection = clr;
            Repository.RegisterType(model);
            if(clr!=null)
            {
                model = ClrResolver.Register(clr, typeRegistration, model);
            }
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return model;
        }

        private MType LoadMappedClrType(string clrFullName, string jvmFullName)
        {
            var clr = ClrResolver.LoadType(clrFullName, true);
            var jvm = JvmResolver.LoadClass(jvmFullName, true);
            var typeRegistration = KnownTypeRegistration(clrFullName);
            var model = ClrResolver.Register(clr, typeRegistration, null);
            model.LockSide();
            model.Substitution = JvmResolver.Register(jvm, typeRegistration, model);
            model.Substitution.LockSide();
            //model.Substitution.Pass = ProxyGenPass.ProxyLoaded;
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return model;
        }

        private MType LoadMappedJvmType(string clrFullName, string jvmFullName)
        {
            var jvm = JvmResolver.LoadClass(jvmFullName, true);
            var clr = ClrResolver.LoadType(clrFullName, true);
            var typeRegistration = KnownTypeRegistration(clrFullName);
            var model = JvmResolver.Register(jvm, typeRegistration, null);
            model.LockSide();
            model.Substitution = ClrResolver.Register(clr, typeRegistration, model);
            model.Substitution.LockSide();
            //model.Substitution.Pass = ProxyGenPass.ProxyLoaded;
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return model;
        }

        private static TypeRegistration KnownTypeRegistration(string name)
        {
            return new TypeRegistration(name, knownProject, false);
        }

        #endregion
    }

    public class KnownTypes : IKnownTypes
    {
        public KnownTypes()
        {
            FakeTypes=new List<MType>();
        }

        //public MType IClrProxy { get; internal set; }
        //public MType IJvmProxy { get; internal set; }
        //public Type JavaClassAttribute { get; internal set; }
        //public Type JavaInterfaceAttribute { get; internal set; }

        //public MType SystemIObject { get; internal set; }
        //public MType JavaLangIObject { get; internal set; }

        public List<MType> FakeTypes { get; internal set; }

        public MType SystemObject { get; internal set; }
        public MType SystemString { get; internal set; }
        public MType SystemException { get; internal set; }
        public MType SystemType { get; internal set; }
        public MType ClrBool { get; internal set; }
        public MType ClrByte { get; internal set; }
        public MType ClrChar { get; internal set; }
        public MType ClrShort { get; internal set; }
        public MType ClrInt { get; internal set; }
        public MType ClrLong { get; internal set; }
        public MType ClrFloat { get; internal set; }
        public MType ClrDouble { get; internal set; }
        public MType ClrSByte { get; internal set; }
        public MType ClrUShort { get; internal set; }
        public MType ClrUInt { get; internal set; }
        public MType ClrULong { get; internal set; }
        public MType ClrVoid { get; internal set; }
        public MType ClrIntPtr { get; internal set; }
        public MType ClrUIntPtr { get; internal set; }

        public MType JavaLangObject { get; internal set; }
        public MType JavaLangString { get; internal set; }
        public MType JavaLangThrowable { get; internal set; }
        public MType JavaLangClass { get; internal set; }
        public MType JavaLangVoid { get; internal set; }

        public MType JavaLangBoolean { get; internal set; }
        public MType JavaLangByte { get; internal set; }
        public MType JavaLangCharacter { get; internal set; }
        public MType JavaLangShort { get; internal set; }
        public MType JavaLangInteger { get; internal set; }
        public MType JavaLangLong { get; internal set; }
        public MType JavaLangFloat { get; internal set; }
        public MType JavaLangDouble { get; internal set; }
        
        public MType JvmBool { get; internal set; }
        public MType JvmByte { get; internal set; }
        public MType JvmChar { get; internal set; }
        public MType JvmShort { get; internal set; }
        public MType JvmInt { get; internal set; }
        public MType JvmLong { get; internal set; }
        public MType JvmFloat { get; internal set; }
        public MType JvmDouble { get; internal set; }
        public MType JvmVoid { get; internal set; }

        public bool IsLoaded { get; internal set; }
    }
}
