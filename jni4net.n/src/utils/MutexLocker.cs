#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Threading;

namespace net.sf.jni4net.utils
{
    internal class MutexLocker : IDisposable
    {
        private Mutex mutex;

        public MutexLocker(Mutex mutex)
        {
            this.mutex = mutex;
            mutex.WaitOne();
        }

        public void Dispose()
        {
            mutex.ReleaseMutex();
            GC.SuppressFinalize(this);
        }
    }
}
