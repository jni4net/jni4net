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
using polyglottos;

namespace com.jni4net.proxygen.Model
{
    [Flags]
    public enum GeneratorTarget
    {
        ClrApi=1,
        ClrProxy=2,
        ClrStatic=4,
        JvmApi=8,
        JvmProxy=16,
        JvmStatic=32,
        JvmBacking=64,

        ClrApiWildIn=128,
        ClrApiWildOut=256,
        ClrProxyWildOut=512,
    }

    public class MTypeTargets
    {
        private readonly Dictionary<GeneratorTarget, IGFile> files;
        private readonly Dictionary<GeneratorTarget, IGClass> classes;
        private readonly Dictionary<GeneratorTarget, IGClassContainer> containers;

        public MTypeTargets()
        {
            files = new Dictionary<GeneratorTarget, IGFile>();
            classes = new Dictionary<GeneratorTarget, IGClass>();
            containers = new Dictionary<GeneratorTarget, IGClassContainer>();
        }

        public void AddFile(IGFile file, GeneratorTarget target)
        {
            files.Add(target, file);
        }

        public void AddClass(IGClass cls, GeneratorTarget target)
        {
            classes[target]=cls;
        }

        public void AddContainer(IGClassContainer container, GeneratorTarget target)
        {
            containers.Add(target, container);
        }

        public Dictionary<GeneratorTarget, IGFile> Files
        {
            get { return files; }
        }

        public Dictionary<GeneratorTarget, IGClass> Classes
        {
            get { return classes; }
        }

        public Dictionary<GeneratorTarget, IGClassContainer> Containers
        {
            get { return containers; }
        }
    }
}
