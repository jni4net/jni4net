#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

namespace java.lang
{
    partial class Short
    {
        public static implicit operator Short(short value)
        {
            return new Short(value);
        }

        public static explicit operator short(Short value)
        {
            return value.shortValue();
        }
    }
}