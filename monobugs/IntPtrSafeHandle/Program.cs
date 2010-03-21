using System;
using System.Runtime.InteropServices;

namespace ReturnIntPtrStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------ IntPtr ----------------------------"); 
            Works.test();
            Console.WriteLine("++++++++++++++++++++++++ IntPtr ++++++++++++++++++++++++++++");

            Console.WriteLine("------------------------ SafeHandle ----------------------------");
            BrokenSafeHandle.test();
            Console.WriteLine("++++++++++++++++++++++++ SafeHandle ++++++++++++++++++++++++++++");
        }
    }

    public class BrokenSafeHandle
    {
        public class IntPtrSafe : SafeHandle
        {
            public IntPtrSafe() : base(IntPtr.Zero, true)
            {
            }

            protected override bool ReleaseHandle()
            {
                return true;
            }

            public IntPtr Handle
            {
                get
                {
                    return handle;
                }
                set
                {
                    handle = value;
                }
            }

            public override bool IsInvalid
            {
                get { return handle == IntPtr.Zero; }
            }
        }

        delegate IntPtrSafe DummyDelegate(IntPtrSafe ptrSafe);

        [DllImport("dummy.so")]
        static extern IntPtrSafe jni4net_zero();

        [DllImport("dummy.so")]
        static extern IntPtrSafe jni4net_dummy(IntPtrSafe ptrSafe);

        [DllImport("dummy.so")]
        static extern IntPtr jni4net_gimme();

        [DllImport("dummy.so")]
        static extern IntPtrSafe jni4net_callme(IntPtr delegatePtr, IntPtrSafe ptrSafe);

        public static void test()
        {
            IntPtr callBackPtr = jni4net_gimme();
            DummyDelegate delegate_dummy = (DummyDelegate)Marshal.GetDelegateForFunctionPointer(callBackPtr, typeof(DummyDelegate));

            IntPtrSafe test0 = jni4net_zero();
            if (test0.Handle != IntPtr.Zero)
            {
                Console.WriteLine("safehandle 0 IntPtr.Zero failed" + test0.Handle);
            }

            try{
	            IntPtrSafe test1 = jni4net_dummy(new IntPtrSafe());
	            if (test1.Handle != IntPtr.Zero)
	            {
	                Console.WriteLine("safehandle 1 IntPtr.Zero failed" + test1.Handle);
	            }
            }catch(Exception ex){
           	    Console.WriteLine("safehandle 1 "+ex);
           	}

            IntPtr intPtrOne = new IntPtr(1);
            IntPtrSafe test2 = jni4net_dummy(new IntPtrSafe() { Handle = intPtrOne });
            if (test2.Handle != intPtrOne)
            {
                Console.WriteLine("safehandle 2 IntPtr.One failed" + test2.Handle);
            }

            IntPtrSafe test3 = delegate_dummy(new IntPtrSafe());
            if (test3.Handle != IntPtr.Zero)
            {
                Console.WriteLine("safehandle 3 IntPtr.Zero failed" + test3.Handle);
            }

            IntPtrSafe test4 = delegate_dummy(new IntPtrSafe() { Handle = intPtrOne });
            if (test4.Handle != intPtrOne)
            {
                Console.WriteLine("safehandle 4 IntPtr.One failed" + test4.Handle);
            }
        }


    }


    public class Works
    {
        delegate IntPtr DummyDelegate(IntPtr ptr);

        [DllImport("dummy.so")]
        static extern IntPtr jni4net_zero();

        [DllImport("dummy.so")]
        static extern IntPtr jni4net_dummy(IntPtr ptr);

        [DllImport("dummy.so")]
        static extern IntPtr jni4net_gimme();

        [DllImport("dummy.so")]
        static extern IntPtr jni4net_callme(IntPtr delegatePtr, IntPtr ptr);
        
        public static void test()
        {
            IntPtr callBackPtr = jni4net_gimme();
            DummyDelegate delegate_dummy = (DummyDelegate)Marshal.GetDelegateForFunctionPointer(callBackPtr, typeof(DummyDelegate));

            IntPtr test0 = jni4net_zero();
            if (test0 != IntPtr.Zero)
            {
                Console.WriteLine("works 0 IntPtr.Zero failed" + test0);
            }

            IntPtr test1 = jni4net_dummy(IntPtr.Zero);
            if (test1!=IntPtr.Zero)
            {
                Console.WriteLine("works 1 IntPtr.Zero failed" + test1);
            }

            IntPtr intPtrOne = new IntPtr(1);
            IntPtr test2 = jni4net_dummy(intPtrOne);
            if (test2 != intPtrOne)
            {
                Console.WriteLine("works 2 IntPtr.One failed" + test2);
            }

            IntPtr test3 = delegate_dummy(IntPtr.Zero);
            if (test3 != IntPtr.Zero)
            {
                Console.WriteLine("works 3 IntPtr.Zero failed");
            }

            IntPtr test4 = delegate_dummy(intPtrOne);
            if (test4 != intPtrOne)
            {
                Console.WriteLine("works 4 IntPtr.One failed");
            }
        }

    }
}
