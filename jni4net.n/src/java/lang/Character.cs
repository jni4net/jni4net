#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

namespace java.lang
{
    partial class Character
    {
        public static implicit operator Character(char value)
        {
            return new Character(value);
        }

        public static explicit operator char(Character value)
        {
            return value.charValue();
        }
    }
}