#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using java.io;

namespace net.sf.jni4net.adaptors
{
    public partial class Adapt
    {
        public static Disposable<T> Disposable<T>(T closeable)
            where T : Closeable
        {
            return new Disposable<T>(closeable);
        }
    }

    public class Disposable<T> : Adaptor<T>, IDisposable
        where T : Closeable
    {
        public Disposable(T closeable)
            : base(closeable)
        {
        }

        public void Dispose()
        {
            Real.close();
        }
    }
}
