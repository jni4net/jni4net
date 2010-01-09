#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using java.lang;
using java_.lang;

namespace net.sf.jni4net.jni
{
    public interface IJvmProxy : IObject
    {
        Class GetClass();

        /// <summary>
        /// Warning: if you take this handle and you don't use/hold the proxy any further.
        /// For example this is last operation on the object, you have just on stack.
        /// It could happen that GC will cleanup the proxy (call dispose and delete JVM reference)
        /// before you copy this handle into new globalRef. 
        /// For now use HoldThisHandle() on original proxy till you have your copy.
        /// TODO: better design ?
        /// </summary>
        IntPtr JvmHandle { get; set; }

        void Init(JNIEnv env, IntPtr obj, Class clazz);

        void Copy(JNIEnv env, IntPtr obj, Class clazz);

        void Copy(JNIEnv env, IJvmProxy src);

        void Dispose();

        /// <summary>
        /// empty operation
        /// trick to retain JVM handle till this point, protect from gc
        /// </summary>
        void HoldThisHandle();
    }
}