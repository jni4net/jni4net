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

using com.jni4net.config;
using com.jni4net.proxygen.Model;
using java.lang;
using java.lang.reflect;
using JType = java.lang.reflect.Type;
using Type = IKVM.Reflection.Type;
using SType = System.Type;
using ParameterInfo = IKVM.Reflection.ParameterInfo;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IClrResolver
    {
        void LoadAssemblies();
        void LoadTypes();
        Type LoadType(string codeFullName, bool reportError);
        MType Register(Type clr, TypeRegistration tr, MType father);
        MType Register(SType clr, TypeRegistration tr, MType father);

        UTypeUsage CreateUsage(ParameterInfo clr, MType father);
        UTypeUsage CreateUsage(Type clr, MType father);
        Type FindPlainType(Type clr);
        bool CheckSupportedType(Type clr);
    }

    public interface IJvmResolver
    {
        void LoadJars();
        void LoadClasses();
        Class LoadClass(string codeFullName, bool reportError);
        MType Register(JType jvm, TypeRegistration tr, MType father);
        UTypeUsage CreateDeclaration(JType jvm, MType father);
        UTypeUsage CreateUsage(JType jvm, MType father);
        UTypeUsage CreateUsage(JType jvm, string paramName, MType father);
        Class FindPlainType(JType jvm);
        bool IsAssignableFrom(JType ar, JType br);
        bool IsOverridden(Method higher, Method lower);
    }
}
