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

namespace com.jni4net.proxygen.Interfaces
{
    public enum ProxyGenPass
    {
        //explorer
        P0000_TypeLoaded = 0000,
        P0100_ProxyLoaded = 0100,//type rename
        P0200_EnclosingExplored = 0200,
        P0300_BasesExplored = 0300,
        P0400_InterfacesExplored = 0400,
        P0500_MembersExplored = 0500,

        //translator
        P1000_TweakerStarted = 1000,
        P2500_TranslatorStarted = 2500,
        P2600_MembersConfigured = 2600,//renames, parameter type changes
        P2700_MembersMapped = 2700,//interfaces, inheritance, signatures
        P2800_MembersPrimitivised = 2800,//java primitive types
        P3100_InterfacesProxyFilled = 3100,//java primitive types

        //generator
        P5000_GeneratorStarted=5000,
        P5100_FilesGenerateCreated = 5100,
        P5200_MembersGenerated = 5200,
        P9999_FilesDumped = 9999,

        Quit = 10000,
        Failed = -2,//thrown exception during exploration
        Any = -1000,
    }

    public interface IModelHandler
    {
        ProxyGenPass ExpectedPass { get; }
        int PassPriority { get; }
        bool IsBlockingAll { get; }
        bool IsHandlerForModel(MType model);
        bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor);
        bool HandleModel(MType model, Func<MType, bool> handleModel);
        void RoundStarted(IList<MType> models);
        void RoundFinished(IList<MType> models);
    }
}
