﻿#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/
It's derived work on top of OpenJDK 
*/

#endregion
#region Copyright 2000-2008 Sun Microsystems, Inc.  All Rights Reserved.
/*
 * Copyright 2000-2008 Sun Microsystems, Inc.  All Rights Reserved.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * This code is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License version 2 only, as
 * published by the Free Software Foundation.
 *
 * This code is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
 * version 2 for more details (a copy is included in the LICENSE file that
 * accompanied this code).
 *
 * You should have received a copy of the GNU General Public License version
 * 2 along with this work; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 * Please contact Sun Microsystems, Inc., 4150 Network Circle, Santa Clara,
 * CA 95054 USA or visit www.sun.com if you need additional information or
 * have any questions.
 */
#endregion

using System;
using java.io;
using java.lang;
using Buffer=net.sf.jni4net.nio.Buffer;
using ByteBuffer=net.sf.jni4net.nio.ByteBuffer;
using Double=java.lang.Double;
using String=java.lang.String;

// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToLambdaExpression

namespace net.sf.jni4net.test.BB
{
    /* @test
     * @summary Unit test for buffers
     * @bug 4413135 4414911 4416536 4416562 4418782 4471053 4472779 4490253 4523725
     *      4526177 4463011 4660660 4661219 4663521 4782970 4804304 4938424 6231529
     *      6221101 6234263 6535542 6591971 6593946 6795561
     * @author Mark Reinhold
     */
    public class Basic
    {
        internal static PrintStream outt = java.lang.System.err;

        internal static long ic(int i)
        {
            int j = i%54;
            return j + 'a' + ((j > 26) ? 128 : 0);
        }

        internal static String toString(Buffer b)
        {
            return (b.GetType().Name
                    + "[pos=" + b.position()
                    + " lim=" + b.limit()
                    + " cap=" + b.capacity()
                    + "]");
        }

        internal static void show(int level, Buffer b)
        {
            for (int i = 0; i < level; i++)
                outt.print("  ");
            outt.println(toString(b) + " " + Integer.toHexString(b.GetHashCode()));
        }

        internal static void fail(String s)
        {
            throw new RuntimeException(s);
        }

        internal static void fail(String s, Buffer b)
        {
            throw new RuntimeException(s + ": " + toString(b));
        }

        internal static void fail(String s, Buffer b, Buffer b2)
        {
            throw new RuntimeException(s + ": "
                                       + toString(b) + ", " + toString(b2));
        }

        internal static void fail(Buffer b,
                                  String expected, char expectedChar,
                                  String got, char gotChar)
        {
            if (b is ByteBuffer)
            {
                var bb = (ByteBuffer) b;
                int n = Math.Min(16, bb.limit());
                for (int i = 0; i < n; i++)
                    outt.print(" " + Integer.toHexString(bb.get(i) & 0xff));
                outt.println();
            }
            /*if (b is CharBuffer) {
            CharBuffer bb = (CharBuffer)b;
            int n = Math.min(16, bb.limit());
            for (int i = 0; i < n; i++)
                outt.print(" " + Integer.toHexString(bb.get(i) & 0xffff));
            outt.println();
        }*/
            throw new RuntimeException(toString(b)
                                       + ": Expected '" + expectedChar + "'=0x"
                                       + expected
                                       + ", got '" + gotChar + "'=0x"
                                       + got);
        }

        internal static void fail(Buffer b, long expected, long got)
        {
            fail(b,
                 Long.toHexString(expected), (char) expected,
                 Long.toHexString(got), (char) got);
        }

        internal static void ck(Buffer b, bool cond)
        {
            if (!cond)
                fail("Condition failed", b);
        }

        internal static void ck(Buffer b, long got, long expected)
        {
            if (expected != got)
                fail(b, expected, got);
        }

        internal static void ck(Buffer b, float got, float expected)
        {
            if (expected != got)
                fail(b,
                     Float.toString(expected), (char) expected,
                     Float.toString(got), (char) got);
        }

        internal static void ck(Buffer b, double got, double expected)
        {
            if (expected != got)
                fail(b,
                     Double.toString(expected), (char) expected,
                     Double.toString(got), (char) got);
        }
    }
}
