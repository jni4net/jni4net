#region Copyright (C) 2009 by Pavel Savara

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
using java.lang;
using java.nio;
using Buffer = net.sf.jni4net.nio.Buffer;
using Byte = java.lang.Byte;
using ByteBuffer = net.sf.jni4net.nio.ByteBuffer;
using Double = java.lang.Double;
using Exception=System.Exception;

// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToLambdaExpression

namespace net.sf.jni4net.test.BB
{
    /* Type-specific source code for unit test
     *
     * Regenerate the BasicX classes via genBasic.sh whenever this file changes.
     * We check in the generated source files so that the test tree can be used
     * independently of the rest of the source tree.
     */
    public class BasicByte : Basic
    {
        private static void relGet(ByteBuffer b)
        {
            int n = b.capacity();
            for (int i = 0; i < n; i++)
                ck(b, b.get(), ((byte)ic(i)));
            b.rewind();
        }

        private static void relGet(ByteBuffer b, int start)
        {
            int n = b.remaining();
            for (int i = start; i < n; i++)
                ck(b, b.get(), ((byte)ic(i)));
            b.rewind();
        }

        private static void absGet(ByteBuffer b)
        {
            int n = b.capacity();
            for (int i = 0; i < n; i++)
                ck(b, b.get(), ((byte)ic(i)));
            b.rewind();
        }

        private static void bulkGet(ByteBuffer b)
        {
            int n = b.capacity();
            var a = new byte[n + 7];
            b.get(a, 7, n);
            for (int i = 0; i < n; i++)
                ck(b, a[i + 7], ((byte)ic(i)));
        }

        private static void relPut(ByteBuffer b)
        {
            int n = b.capacity();
            b.clear();
            for (int i = 0; i < n; i++)
                b.put((byte)ic(i));
            b.flip();
        }

        private static void absPut(ByteBuffer b)
        {
            int n = b.capacity();
            b.clear();
            for (int i = 0; i < n; i++)
                b.put(i, (byte)ic(i));
            b.limit(n);
            b.position(0);
        }

        private static void bulkPutArray(ByteBuffer b)
        {
            int n = b.capacity();
            b.clear();
            var a = new byte[n + 7];
            for (int i = 0; i < n; i++)
                a[i + 7] = (byte)ic(i);
            b.put(a, 7, n);
            b.flip();
        }

        private static void bulkPutBuffer(ByteBuffer b)
        {
            int n = b.capacity();
            b.clear();
            ByteBuffer c = ByteBuffer.allocate(n + 7);
            c.position(7);
            for (int i = 0; i < n; i++)
                c.put((byte)ic(i));
            c.flip();
            c.position(7);
            b.put(c);
            b.flip();
        }

        //6231529
        private static void callReset(ByteBuffer b)
        {
            b.position(0);
            b.mark();

            b.duplicate().reset();
            //TODO b.asReadOnlyBuffer().reset();
        }


        private static void checkSlice(ByteBuffer b, ByteBuffer slice)
        {
            ck(slice, 0, slice.position());
            ck(slice, b.remaining(), slice.limit());
            ck(slice, b.remaining(), slice.capacity());
            if (b.isDirect() != slice.isDirect())
                fail("Lost direction", slice);
            if (b.isReadOnly() != slice.isReadOnly())
                fail("Lost read-only", slice);
        }


        private static void checkBytes(ByteBuffer b, byte[] bs)
        {
            int n = bs.Length;
            int p = b.position();
            byte v;
            if (b.order() == ByteOrder.BIG_ENDIAN)
            {
                for (int i = 0; i < n; i++)
                    ck(b, b.get(), bs[i]);
            }
            else
            {
                for (int i = n - 1; i >= 0; i--)
                    ck(b, b.get(), bs[i]);
            }
            b.position(p);
        }

        private static void compact(Buffer b)
        {
            /*
        try {
            Class<?> cl = b.getClass();
            Method m = cl.getDeclaredMethod("compact");
            m.setAccessible(true);
            m.invoke(b);
        } catch (Exception e) {
            fail(e.getMessage(), b);
        }
         */
            throw new NotImplementedException();
        }

        private static void checkInvalidMarkException(Buffer b)
        {
            tryCatch(b, typeof(InvalidMarkException), () =>
            {
                b.mark();
                compact(b);
                b.reset();
            });
        }

        private static void testViews(int level, ByteBuffer b, bool direct)
        {
            /*
            ShortBuffer sb = b.asShortBuffer();
            BasicShort.test(level, sb, direct);
            checkBytes(b, new byte[] { 0, (byte)ic(0) });
            checkInvalidMarkException(sb);

            CharBuffer cb = b.asCharBuffer();
            BasicChar.test(level, cb, direct);
            checkBytes(b, new byte[] { 0, (byte)ic(0) });
            checkInvalidMarkException(cb);

            IntBuffer ib = b.asIntBuffer();
            BasicInt.test(level, ib, direct);
            checkBytes(b, new byte[] { 0, 0, 0, (byte)ic(0) });
            checkInvalidMarkException(ib);

            LongBuffer lb = b.asLongBuffer();
            BasicLong.test(level, lb, direct);
            checkBytes(b, new byte[] { 0, 0, 0, 0, 0, 0, 0, (byte)ic(0) });
            checkInvalidMarkException(lb);

            FloatBuffer fb = b.asFloatBuffer();
            BasicFloat.test(level, fb, direct);
            checkBytes(b, new byte[] { 0x42, (byte)0xc2, 0, 0 });
            checkInvalidMarkException(fb);

            DoubleBuffer db = b.asDoubleBuffer();
            BasicDouble.test(level, db, direct);
            checkBytes(b, new byte[] { 0x40, 0x58, 0x40, 0, 0, 0, 0, 0 });
            checkInvalidMarkException(db);*/
        }

        private static void testHet(int level, ByteBuffer b)
        {
            int p = b.position();
            b.limit(b.capacity());
            show(level, b);
            outt.print("    put:");

            b.putChar((char)1);
            b.putChar(Character.MAX_VALUE);
            outt.print(" char");

            b.putShort(1);
            b.putShort(Short.MAX_VALUE);
            outt.print(" short");

            b.putInt(1);
            b.putInt(Integer.MAX_VALUE);
            outt.print(" int");

            b.putLong(1);
            b.putLong(Long.MAX_VALUE);
            outt.print(" long");

            b.putFloat(1);
            b.putFloat(Float.MIN_VALUE);
            b.putFloat(Float.MAX_VALUE);
            outt.print(" float");

            b.putDouble(1);
            b.putDouble(Double.MIN_VALUE);
            b.putDouble(Double.MAX_VALUE);
            outt.print(" double");

            outt.println();
            b.limit(b.position());
            b.position(p);
            show(level, b);
            outt.print("    get:");

            ck(b, b.getChar(), 1);
            ck(b, b.getChar(), Character.MAX_VALUE);
            outt.print(" char");

            ck(b, b.getShort(), 1);
            ck(b, b.getShort(), Short.MAX_VALUE);
            outt.print(" short");

            ck(b, b.getInt(), 1);
            ck(b, b.getInt(), Integer.MAX_VALUE);
            outt.print(" int");

            ck(b, b.getLong(), 1);
            ck(b, b.getLong(), Long.MAX_VALUE);
            outt.print(" long");

            ck(b, (long)b.getFloat(), 1);
            ck(b, (long)b.getFloat(), (long)Float.MIN_VALUE);
            ck(b, (long)b.getFloat(), (long)Float.MAX_VALUE);
            outt.print(" float");

            ck(b, (long)b.getDouble(), 1);
            ck(b, (long)b.getDouble(), (long)Double.MIN_VALUE);
            ck(b, (long)b.getDouble(), (long)Double.MAX_VALUE);
            outt.print(" double");

            outt.println();
        }


        private delegate void Action();

        private static void tryCatch(Buffer b, Type ex, Action thunk)
        {
            bool caught = false;
            try
            {
                thunk();
            }
            catch (Exception x)
            {
                if (ex.IsAssignableFrom(x.GetType()))
                {
                    caught = true;
                }
                else
                {
                    fail(x.Message + " not expected");
                }
            }
            if (!caught)
                fail(ex.Name + " not thrown", b);
        }

        private static void tryCatch(byte[] t, Type ex, Action thunk)
        {
            tryCatch(ByteBuffer.wrap(t), ex, thunk);
        }

        public static void test(int level, ByteBuffer b, bool direct)
        {
            show(level, b);

            //TODO if (direct != b.isDirect())
            //TODO     fail("Wrong direction", b);

            // Gets and puts

            relPut(b);
            relGet(b);
            absGet(b);
            bulkGet(b);

            absPut(b);
            relGet(b);
            absGet(b);
            bulkGet(b);

            bulkPutArray(b);
            relGet(b);

            bulkPutBuffer(b);
            relGet(b);


            // Compact

            relPut(b);
            b.position(13);
            b.compact();
            b.flip();
            relGet(b, 13);

            // Exceptions

            relPut(b);
            b.limit(b.capacity() / 2);
            b.position(b.limit());

            tryCatch(b, typeof(BufferUnderflowException), () => { b.get(); });

            tryCatch(b, typeof(BufferOverflowException), () => { b.put(42); });

            // The index must be non-negative and lesss than the buffer's limit.
            tryCatch(b, typeof(IndexOutOfBoundsException), () => { b.get(b.limit()); });
            tryCatch(b, typeof(IndexOutOfBoundsException), () => { b.get(-1); });

            tryCatch(b, typeof(IndexOutOfBoundsException), () => { b.put(b.limit(), 42); });

            tryCatch(b, typeof(InvalidMarkException), () =>
            {
                b.position(0);
                b.mark();
                b.compact();
                b.reset();
            });

            // Values

            b.clear();
            b.put(0);
            b.put(0xff);
            b.put(1);
            b.put(Byte.MAX_VALUE);
            b.put(Byte.MIN_VALUE);


            b.flip();
            ck(b, b.get(), 0);
            ck(b, b.get(), 0xff);
            ck(b, b.get(), 1);
            ck(b, b.get(), Byte.MAX_VALUE);
            ck(b, b.get(), Byte.MIN_VALUE);


            // Comparison
            b.rewind();
            ByteBuffer b2 = ByteBuffer.allocate(b.capacity());
            b2.put(b);
            b2.flip();
            b.position(2);
            b2.position(2);
            if (!b.equals(b2))
            {
                for (int i = 2; i < b.limit(); i++)
                {
                    byte x = b.get(i);
                    byte y = b2.get(i);
                    if (x != y
                        )
                        outt.println("[" + i + "] " + x + " != " + y);
                }
                fail("Identical buffers not equal", b, b2);
            }
            if (b.compareTo(b2) != 0)
                fail("Comparison to identical buffer != 0", b, b2);

            b.limit(b.limit() + 1);
            b.position(b.limit() - 1);
            b.put(99);
            b.rewind();
            b2.rewind();
            if (b.equals(b2))
                fail("Non-identical buffers equal", b, b2);
            if (b.compareTo(b2) <= 0)
                fail("Comparison to shorter buffer <= 0", b, b2);
            b.limit(b.limit() - 1);

            b.put(2, 42);
            if (b.equals(b2))
                fail("Non-identical buffers equal", b, b2);
            if (b.compareTo(b2) <= 0)
                fail("Comparison to lesser buffer <= 0", b, b2);

            // Sub, dup

            relPut(b);
            relGet(b.duplicate());
            b.position(13);
            relGet(b.duplicate(), 13);
            relGet(b.duplicate().slice(), 13);
            relGet(b.slice(), 13);
            relGet(b.slice().duplicate(), 13);

            // Slice

            b.position(5);
            ByteBuffer sb = b.slice();
            checkSlice(b, sb);
            b.position(0);
            ByteBuffer sb2 = sb.slice();
            checkSlice(sb, sb2);

            if (!sb.equals(sb2))
                fail("Sliced slices do not match", sb, sb2);
            if ((sb.hasArray()) && (sb.arrayOffset() != sb2.arrayOffset()))
                fail("Array offsets do not match: "
                     + sb.arrayOffset() + " != " + sb2.arrayOffset(), sb, sb2);


            // Views

            b.clear();
            b.order(ByteOrder.BIG_ENDIAN);
            testViews(level + 1, b, direct);

            for (int i = 1; i <= 9; i++)
            {
                b.position(i);
                show(level + 1, b);
                testViews(level + 2, b, direct);
            }

            b.position(0);
            b.order(ByteOrder.LITTLE_ENDIAN);
            testViews(level + 1, b, direct);

            // Heterogeneous accessors

            b.order(ByteOrder.BIG_ENDIAN);
            for (int i = 0; i <= 9; i++)
            {
                b.position(i);
                testHet(level + 1, b);
            }
            b.order(ByteOrder.LITTLE_ENDIAN);
            b.position(3);
            testHet(level + 1, b);


            // Read-only views
            /* TODO
            b.rewind();
            ByteBuffer rb = b.asReadOnlyBuffer();
            if (!b.equals(rb))
                fail("Buffer not equal to read-only view", b, rb);
            show(level + 1, rb);

            tryCatch(b, typeof(ReadOnlyBufferException), () => { relPut(rb); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { absPut(rb); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { bulkPutArray(rb); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { bulkPutBuffer(rb); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.compact(); });


            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putChar((char)1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putChar(0, (char)1); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putShort(1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putShort(0, 1); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putInt(1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putInt(0, 1); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putLong(1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putLong(0, 1); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putFloat(1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putFloat(0, 1); });

            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putDouble(1); });
            tryCatch(b, typeof(ReadOnlyBufferException), () => { rb.putDouble(0, 1); });


            // Bulk puts from read-only buffers

            b.clear();
            rb.rewind();
            b.put(rb);


            // For byte buffers, test both the direct and non-direct cases
            ByteBuffer ob
                = (b.isDirect()
                       ? ByteBuffer.allocate(rb.capacity())
                       : ByteBuffer.allocateDirect(rb.capacity()));
            rb.rewind();
            ob.put(rb);


             */
            relPut(b); // Required by testViews
        }


        public static void test(byte[] ba)
        {
            int offset = 47;
            int length = 900;
            ByteBuffer b = ByteBuffer.wrap(ba, offset, length);
            show(0, b);
            ck(b, b.capacity(), ba.Length);
            ck(b, b.position(), offset);
            ck(b, b.limit(), offset + length);

            // The offset must be non-negative and no larger than <array.length>.
            tryCatch(ba, typeof(IndexOutOfBoundsException), () => { ByteBuffer.wrap(ba, -1, ba.Length); });
            tryCatch(ba, typeof(IndexOutOfBoundsException), () => { ByteBuffer.wrap(ba, ba.Length + 1, ba.Length); });
            tryCatch(ba, typeof(IndexOutOfBoundsException), () => { ByteBuffer.wrap(ba, 0, -1); });
            tryCatch(ba, typeof(IndexOutOfBoundsException), () => { ByteBuffer.wrap(ba, 0, ba.Length + 1); });

            // A NullPointerException will be thrown if the array is null.
            tryCatch(ba, typeof(NullReferenceException), () => { ByteBuffer.wrap(null, 0, 5); });
            tryCatch(ba, typeof(NullReferenceException), () => { ByteBuffer.wrap(null); });
        }

        private static void testAllocate()
        {
            // An IllegalArgumentException will be thrown for negative capacities.
            tryCatch((Buffer)null, typeof(IllegalArgumentException), () => { ByteBuffer.allocate(-1); });

            tryCatch((Buffer)null, typeof(IllegalArgumentException), () => { ByteBuffer.allocateDirect(-1); });
        }

        public static void test()
        {
            testAllocate();
            test(0, ByteBuffer.allocate(7 * 1024), false);
            test(0, ByteBuffer.wrap(new byte[7 * 1024], 0, 7 * 1024), false);
            test(new byte[1024]);

            ByteBuffer b = ByteBuffer.allocateDirect(7 * 1024);
            for (b.position(0); b.position() < b.limit(); )
                ck(b, b.get(), 0);
            test(0, b, true);


            callReset(ByteBuffer.allocate(10));
        }
    }
}
