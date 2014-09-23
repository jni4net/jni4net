#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

namespace net.sf.jni4net.adaptors
{
    public static partial class Adapt
    {
    }

    public abstract class Adaptor<TReal>
    {
        public Adaptor(TReal closeable)
        {
            this.closeable = closeable;
        }

        private TReal closeable;

        public TReal Real
        {
            get { return closeable; }
        }
    }

}
