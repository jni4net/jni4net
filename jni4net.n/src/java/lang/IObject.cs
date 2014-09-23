#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using java.lang;

namespace java_.lang
{
    public interface IObject
    {
        void wait();
        void wait(long longPar0, int intPar1);
        void wait(long longPar0);
        int hashCode();
        Class getClass();
        bool equals(Object objectPar0);
        String toString();
        void notify();
        void notifyAll();
    }
}