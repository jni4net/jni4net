#region Copyright (C) 2012 by Pavel Savara

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
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    public class LocalFrame : IDisposable
    {
#if DEBUG
        [ThreadStatic]
        internal static int frameCount;
#endif

        private readonly JNIEnv env;

        public LocalFrame(JNIEnv env, int size)
        {
            this.env = env;
#if DEBUG
            frameCount++;
#endif
            env.PushLocalFrame(size);
        }

        public LocalFrame(JNIEnv env)
            : this(env, 10)
        {
        }

        #region IDisposable Members

        public IntPtr Result;

        public void Dispose()
        {
            try
            {
#if DEBUG
                frameCount--;
#endif
                Result = env.PopLocalFrameNoTest(Result);
            }
            catch(Exception ex)
            {
                Logger.LogError("Can't dispose local JNI frame", ex);
            }
        }

        #endregion
    }
}