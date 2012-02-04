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

namespace com.jni4net.proxygen.Services.Renamers
{
    public class JvmTypePairRenamer : IClassRenamer
    {
        public virtual void Rename(MType model)
        {
            if (model.IsClr)
            {
                DeepCopy(model);
                var n = model.JvmName.Namespace.ToLowerInvariant();
                model.JvmName.Namespace = n;

                if (!string.IsNullOrEmpty(model.TypeRegistration.move))
                {
                    model.JvmName.Namespace = model.TypeRegistration.move;
                }
                if (!string.IsNullOrEmpty(model.TypeRegistration.rename))
                {
                    model.JvmName.LocalName = model.TypeRegistration.rename;
                }
            }
        }

        protected virtual void DeepCopy(MType model)
        {
            model.JvmName = new NTypeName(model.ClrName);
        }
    }
}
