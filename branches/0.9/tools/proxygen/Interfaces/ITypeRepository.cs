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
using System.Collections.Generic;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using JType = java.lang.reflect.Type;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IKnownTypes
    {
        //MType IClrProxy { get; }
        //MType IJvmProxy { get; }
        //MType SystemIObject { get; }
        //MType JavaLangIObject { get; }
        //Type JavaClassAttribute { get; }
        //Type JavaInterfaceAttribute { get; }

        List<MType> FakeTypes { get; }

        MType SystemObject { get; }
        MType SystemString { get; }
        MType SystemException { get; }
        MType SystemType { get; }

        MType ClrBool { get; }
        MType ClrByte { get; }
        MType ClrChar { get; }
        MType ClrShort { get; }
        MType ClrInt { get; }
        MType ClrLong { get; }
        MType ClrFloat { get; }
        MType ClrDouble { get; }

        MType ClrSByte { get; }
        MType ClrUShort { get; }
        MType ClrUInt { get; }
        MType ClrULong { get; }
        MType ClrVoid { get; }
        MType ClrIntPtr { get; }
        MType ClrUIntPtr { get; }

        MType JavaLangObject { get; }
        MType JavaLangString { get; }
        MType JavaLangThrowable { get; }
        MType JavaLangClass { get; }
        MType JavaLangVoid { get; }

        MType JavaLangBoolean { get; }
        MType JavaLangByte { get; }
        MType JavaLangCharacter { get; }
        MType JavaLangShort { get; }
        MType JavaLangInteger { get; }
        MType JavaLangLong { get; }
        MType JavaLangFloat { get; }
        MType JavaLangDouble { get; }

        MType JvmBool { get; }
        MType JvmByte { get; }
        MType JvmChar { get; }
        MType JvmShort { get; }
        MType JvmInt { get; }
        MType JvmLong { get; }
        MType JvmFloat { get; }
        MType JvmDouble { get; }
        MType JvmVoid { get; }

        bool IsLoaded { get; }

    }

    public interface ITypeRepository
    {
        IEnumerable<MType> GetModelsToExplore();
        void ResetModelsToExplore(IList<MType> models);
        void DumpExploredModels(bool dep);

        T GetModel<T>(Type handle) where T : MType;
        T GetModel<T>(Class handle) where T : MType;
        void RegisterType(MType model);
        void ExploreType(MType model);
        void ProcessType(MType model);
        void GenerateType(MType model);

        IKnownTypes KnownTypes { get; }
        ILogger Logger { get; }
        IContainer Container { get; }
    }
}
