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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services.Generators
{
    public class StartGenerator : BaseHandler
    {
        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.Any; }
        }

        public override bool IsBlockingAll
        {
            get { return true; }
        }

        public override int PassPriority
        {
            get { return 5000; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return true;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            model.Pass = ProxyGenPass.P5000_GeneratorStarted;
            model.Targets=new MTypeTargets();
            return false;
        }
    }
}
