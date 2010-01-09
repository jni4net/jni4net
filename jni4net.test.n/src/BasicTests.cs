#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.nio;
using java.util;
using java_.lang;
using net.sf.jni4net.adaptors;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.nio;
using net.sf.jni4net.test.BB;
using net.sf.jni4net.tested;
using NUnit.Framework;
using Byte=java.lang.Byte;
using ByteBuffer=java.nio.ByteBuffer;
using Object=java.lang.Object;
using String=java.lang.String;
using StringBuilder=java.lang.StringBuilder;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class BasicTests : TestBase
    {
        [Test]
        public void ArrayTest()
        {
            String s1 = env.NewString("test");
            Class clazz = s1.getClass();
            Method[] methods = clazz.getMethods();
            Assert.Greater(methods.Length, 20);
            foreach (Method method in methods)
            {
                Class returnType = method.getReturnType();
                Console.WriteLine(method + " " + returnType);
            }
        }

        [Test]
        public void ArrayTest2()
        {
            Method method = JInterface_._class.getMethod("cdefined", new Class[] {});
            Annotation[] annotations = method.getAnnotations();
            Assert.Greater(annotations.Length, 0);
        }

        [Test]
        public void PrimitiveObjects()
        {
            Object integer = Bridge.WrapCLR(13);
            int integ = Bridge.UnwrapCLR<int>(integer);
            Assert.AreEqual(13, integ);
        }

        [Test]
        public void WrapClrString1()
        {
            Object str1 = Bridge.WrapCLR("jni4net");
            string str2 = Bridge.UnwrapCLR<string>(str1);
            Assert.AreEqual("jni4net", str2);
        }

        [Test]
        public void ByteConstructor()
        {
            var b = new Byte(7);
            byte value = b.byteValue();
            Assert.AreEqual(7, value);
        }

        [Test]
        public void CreateEquals()
        {
            var outStream = env.GetStaticField<Object>("java/lang/System", "out", "Ljava/io/PrintStream;");
            var outStream2 = env.GetStaticField<Object>("java/lang/System", "out", "Ljava/io/PrintStream;");
            Assert.AreEqual(outStream2, outStream);
            String s1 = env.NewString("test");
            String s2 = env.NewString("test");
            Assert.AreNotSame(s1, s2);
            Assert.AreEqual(s1, s2);
        }

        [Test]
        public void Dispose()
        {
            String s1 = env.NewString("test");
            ((IJvmProxy)s1).Dispose();
        }

        [Test]
        [Explicit]
        public void HeavyAlloc()
        {
            DateTime start = DateTime.Now;
            var list = new List<String>();
            for (int i = 0; i < 1000000; i++)
            {
                String s3 = "test" + i;
                list.Add(s3);
            }

            foreach (String s in list)
            {
                ((IJvmProxy)s).Dispose();
            }
            DateTime end = DateTime.Now;

            Console.WriteLine(end - start);
        }

        [Test]
        [Explicit]
        public void HeavyHandles()
        {
            Thread t1 = new Thread(aloc);
            Thread t2 = new Thread(aloc);
            Thread t3 = new Thread(aloc);
            Thread t4 = new Thread(aloc);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            GC.WaitForPendingFinalizers();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            GC.Collect(3, GCCollectionMode.Forced);
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }

        public void aloc()
        {
            String s3 = "test";
            for (int i = 0; i < 100000; i++)
            {
                String copy = Bridge.CreateProxy<String>(((IJvmProxy)s3).JvmHandle);
                if (i%1000==0)
                {
                    //Console.WriteLine(i);
                    GC.Collect(3,GCCollectionMode.Forced);
                }
            }
            ((IJvmProxy)s3).HoldThisHandle();
        }

        
        [Test]
        [Explicit]
        public void HeavyCall()
        {
            var sb = new StringBuilder();
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                sb.append('a');
            }
            DateTime end = DateTime.Now;

            Console.WriteLine(end - start);
        }


        [Test]
        public void Length()
        {
            String s1 = env.NewString("test");
            Assert.AreEqual(4, s1.length());
        }

        [Test]
        [ExpectedException(typeof (NoClassDefFoundError))]
        public void BadClassThrow()
        {
            env.FindClass("asdfadf");
        }


        [Test]
        public void PrimitiveClass()
        {
            Class clazz = env.FindClass("java/lang/Integer");
            var intType = clazz.GetFieldValue<Object>("TYPE", "Ljava/lang/Class;");
            Class intType2 = Class.getPrimitiveClass("int");
            Assert.AreEqual(intType2, intType);
        }

        [Test]
        public void Print()
        {
            var outStream = env.GetStaticField<Object>("java/lang/System", "out", "Ljava/io/PrintStream;");
            outStream.Invoke("println", "(Ljava/lang/String;)V", "message from Java");
        }


        [Test]
        public void StaticString()
        {
            String s1 = env.NewString("test");
            Assert.AreEqual(4, s1.length());
        }

        [Test]
        public void StringConstructor()
        {
            var s = new String("Tetsts");
            Assert.IsTrue("Tetsts".Equals(s));
            Assert.IsTrue(s.Equals("Tetsts"));
        }

        [Test]
        public void SystemOut()
        {
            java.lang.System.@out.println("Test");
        }


        [Test]
        public void Wrap()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            Object proxy = Bridge.WrapCLR(builder);
            long handle = ((IClrProxy)proxy).getClrHandle();
            System.Text.StringBuilder res = Bridge.UnwrapCLR<System.Text.StringBuilder>(proxy);
            Assert.AreSame(builder, res);
        }

        private byte[] PrepareData()
        {
            byte[] myLovelyData = new byte[2048];
            myLovelyData[0] = 0x00;
            myLovelyData[1] = 0x01;
            myLovelyData[0xfe] = 0xfe;
            myLovelyData[0xff] = 0xff;
            char expected;
            using (var bw = new BinaryWriter(new MemoryStream(myLovelyData, 0, 2048, true, true), Encoding.Unicode))
            {
                bw.Seek(0x1CC, SeekOrigin.Begin);
                bw.Write('Ž');

                bw.Seek(0x1aa, SeekOrigin.Begin);
                bw.Write(0.112233d);
            }
            using (var br = new BinaryReader(new MemoryStream(myLovelyData, 0, 2048, true, true), Encoding.Unicode))
            {
                br.BaseStream.Seek(0xfe, SeekOrigin.Begin);
                Assert.AreEqual(0xfe, br.ReadByte());
                br.BaseStream.Seek(0x1CC, SeekOrigin.Begin);
                expected = br.ReadChar();
            }
            return myLovelyData;
        }

        [Test]
        public void BB()
        {
            byte[] myLovelyData = PrepareData();

            GCHandle pin = GCHandle.Alloc(myLovelyData, GCHandleType.Pinned);
            IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(myLovelyData, 0);
            ByteBuffer buffer = JNIEnv.ThreadEnv.NewDirectByteBuffer(ptr, 2048);
            buffer.order(ByteOrder.LITTLE_ENDIAN);

            Assert.AreEqual(0x00, buffer.get());
            Assert.AreEqual(0x01, buffer.get());
            buffer.position(0xfe);
            Assert.AreEqual(0xfe, buffer.get());
            Assert.AreEqual(0xff, buffer.get());
            buffer.position(0x1CC);
            Assert.AreEqual('Ž', buffer.getChar());
            buffer.position(0x1aa);
            Assert.AreEqual(0.112233d, buffer.getDouble());
        }


        [Test]
        public void BBwrap()
        {
            List<Thread> threads=new List<Thread>();
            for (int i = 0; i < 100; i++)
            {
                Thread t=new Thread(sss);
                t.Start();
                threads.Add(t);
           }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        private void sss()
        {
            int size = 13*1024*1024;
            ByteBuffer bb = a(size);
            bb.capacity();
        }

        private ByteBuffer a(int size)
        {
            var sharedBuffer = new byte[size];
            var buffer = new DirectByteBuffer(sharedBuffer);
            buffer.position(size - 1);
            buffer.put(0xEE);
            ByteBuffer byteBuffer = Bridge.Cast<ByteBuffer>(buffer);

            return byteBuffer;
        }

        [Test]
        [ExpectedException(typeof(BufferOverflowException))]
        public void BBwrapThrow()
        {
            byte[] myLovelyData = PrepareData();

            DirectByteBuffer buffer = new DirectByteBuffer(myLovelyData);

            buffer.position(myLovelyData.Length - 1);
            buffer.put(0xEE);
            buffer.put(0xEE);
        }

        
        [Test]
        public void BB4net()
        {
            byte[] myLovelyData = PrepareData();

            nio.ByteBufferN buffer = nio.ByteBufferN.wrap(myLovelyData);

            Assert.AreEqual(0x00, buffer.get());
            Assert.AreEqual(0x01, buffer.get());
            buffer.position(0xfe);
            Assert.AreEqual(0xfe, buffer.get());
            Assert.AreEqual(0xff, buffer.get());
            buffer.position(0x1CC);
            Assert.AreEqual('Ž', buffer.getChar());
            buffer.position(0x1aa);
            Assert.AreEqual(0.112233d, buffer.getDouble());
        }

        [Test]
        public void BBJdk()
        {
            BasicByte.test();            
        }

        [Test]
        public void IEnum()
        {
            int cnt = 0;
            Properties javaSystemProperties = java.lang.System.getProperties();
            foreach (var prop in Adapt.Enumeration(javaSystemProperties.keys()))
            {
                cnt++;
            }
            Assert.AreEqual(javaSystemProperties.size(), cnt);
        }

        [Test]
        public void Throwable()
        {
            NullPointerException npe = new NullPointerException("tst");
            NullPointerException npe2 = new NullPointerException("tst2");
            Assert.IsTrue(npe.Equals(npe));
            Assert.IsFalse(npe.Equals(npe2));
        }


        [Test]
        public void ClassLoader()
        {
            ClassLoader classLoader = java.lang.ClassLoader.getSystemClassLoader();
            ClassLoader loader = Object._class.getClassLoader();
        }

        [Test]
        public void WasJvmCrash()
        {
            String o = new String();
            IntPtr handle = ((IJvmProxy)o).JvmHandle;
            for (int i = 0; i < 100; i++)
            {
                crash(i, handle);
            }
            // this solved the problem
            ((IJvmProxy)o).HoldThisHandle();
        }

        public static void crash(int i, IntPtr handle)
        {
            Console.WriteLine("a" + i);
            var sharedBuffer = new byte[10 * 1024 * 100];

            Console.WriteLine("b");
            DirectByteBuffer execJavaBuffer = new DirectByteBuffer(sharedBuffer);

            Console.WriteLine("c");
            try
            {
                String duplicate = Bridge.CreateProxy<String>(handle);
                string s = duplicate.toString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                throw;
            }

            Console.WriteLine("d");
            GC.Collect(3, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }

        public static void Main()
        {
            //var test =  new BridgeTest();
            //test.Setup();
            //test.HeavyAlloc();

            var test = new CallBackTest();
            test.Setup();
            test.HeavyCallMeFromJava();
        }
    }
}