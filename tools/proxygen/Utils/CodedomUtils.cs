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

using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using polyglottos;
using polyglottos.csharp;
using polyglottos.generators;
using polyglottos.java;
using polyglottos.snippets;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Utils
{
    public class GTypeJ4N
    {
        public static readonly IGType LocalFrame = new GTextType ( "net.sf.jni4net.jni.LocalFrame" );
        public static readonly IGType INJEnv = new GTextType ( "net.sf.jni4net.inj.INJEnv" );
        public static readonly IGType JNIEnv = new GTextType ( "net.sf.jni4net.jni.JNIEnv" );
        public static readonly IGType ProxyInfo = new GTextType ( "net.sf.jni4net.core.ProxyInfo" );
        public static readonly IGType JvmInstanceInfo = new GTextType("net.sf.jni4net.core.JvmInstanceInfo");
        public static readonly IGType ClrInstanceInfo = new GTextType("net.sf.jni4net.core.ClrInstanceInfo");
        public static readonly IGType Registry = new GTextType ( "net.sf.jni4net.core.Registry" );
        public static readonly IGType MethodId = new GTextType ( "net.sf.jni4net.core.MethodId" );
        public static readonly IGType IJvmProxy = new GTextType ( "net.sf.jni4net.IJvmProxy" );
        public static readonly IGType IClrProxy = new GTextType ( "net.sf.jni4net.IClrProxy" );
        public static readonly IGType JavaLangIClass = new GTextType ( "java.lang.IClass" );
        public static readonly IGType JavaLangObject = new GTextType ( "java.lang.Object" );
        public static readonly IGType J4NProxyAttribute = new GTextType("net.sf.jni4net.attributes.J4NProxy");
        public static readonly IGType SystemObject = new GTextType("system.Object");
        public static readonly IGType SystemIType = new GTextType("system.IType");
        public static readonly IGType SystemType = new GTextType("system.Type");
        public static readonly IGType IClrProxyFactory = new GTextType("net.sf.jni4net.core.IClrProxyFactory");

        public static readonly IGType JNIValue = new GTextType("net.sf.jni4net.jni.JNIValue");
        public static readonly IGType JNIValueOut = new GTextType("net.sf.jni4net.jni.JNIValueOut");
        public static readonly IGType JNIValueRef = new GTextType("net.sf.jni4net.jni.JNIValueRef");
        public static readonly IGType JNIHandle = new GTextType("net.sf.jni4net.jni.JNIHandle");
        public static readonly IGType JNIGlobalHandle = new GTextType("net.sf.jni4net.jni.JNIGlobalHandle");

        public static readonly IGType ConvertBoolean = new GTextType("net.sf.jni4net.core.ConvertBoolean");
        public static readonly IGType ConvertByte = new GTextType("net.sf.jni4net.core.ConvertByte");
        public static readonly IGType ConvertChar = new GTextType("net.sf.jni4net.core.ConvertChar");
        public static readonly IGType ConvertShort = new GTextType("net.sf.jni4net.core.ConvertShort");
        public static readonly IGType ConvertInt = new GTextType("net.sf.jni4net.core.ConvertInt");
        public static readonly IGType ConvertLong = new GTextType("net.sf.jni4net.core.ConvertLong");
        public static readonly IGType ConvertDouble = new GTextType("net.sf.jni4net.core.ConvertDouble");
        public static readonly IGType ConvertFloat = new GTextType("net.sf.jni4net.core.ConvertFloat");
        public static readonly IGType ConvertSealed = new GTextType("net.sf.jni4net.core.ConvertSealed");
        public static readonly IGType ConvertString = new GTextType("net.sf.jni4net.core.ConvertString");
        public static readonly IGType ConvertAbstract = new GTextType("net.sf.jni4net.core.ConvertAbstract");
    
    }

    public class GProjectCSharpJ4N : GProjectCSharp
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override IGCodeGenerator CreateGenerator(IGContext context = null)
        {
            return new CSharpCodeGeneratorJ4N(KnownTypes);
        }
    }

    public class GGProjectJavaJ4N : GProjectJava
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override IGCodeGenerator CreateGenerator(IGContext context = null)
        {
            return new JavaCodeGeneratorJ4N(KnownTypes);
        }
    }

    public class CSharpCodeGeneratorJ4N : CSharpCodeGenerator
    {
        public CSharpCodeGeneratorJ4N(IKnownTypes knownTypes)
            : base(new GContextJ4N {IsClr = true})
        {
            ((GContextJ4N)Context).Generator = this;
            ((GContextJ4N)Context).KnownTypes = knownTypes;
        }

        protected override void RegisterKnownGenerators()
        {
            base.RegisterKnownGenerators();
            RegisterStrategy<UTypeUsage, GTypeUsageGenerator>();
        }
    }

    public class JavaCodeGeneratorJ4N : JavaCodeGenerator
    {
        public JavaCodeGeneratorJ4N(IKnownTypes knownTypes)
            : base(new GContextJ4N { IsClr = false})
        {
            ((GContextJ4N) Context).Generator = this;
            ((GContextJ4N)Context).KnownTypes = knownTypes;
        }

        protected override void RegisterKnownGenerators()
        {
            base.RegisterKnownGenerators();
            RegisterStrategy<UTypeUsage, GTypeUsageGenerator>();
        }
    }

    public class GContextJ4N : GContext
    {
        public IKnownTypes KnownTypes { get; set; }
        public bool IsClr { get; set; }
        public CodeGeneratorBase Generator { get; set; }
    }
}
