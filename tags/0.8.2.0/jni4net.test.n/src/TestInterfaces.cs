using System;
using java.lang;
using java_.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.tested;
using NUnit.Framework;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class TestInterfaces : TestBase
    {
        private JInterfacesHelper testInstance;

        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
            testInstance = new JInterfacesHelper();
        }

        [Test]
        public void jIface()
        {
            var cw1 = new CWithJavaInterface(1);
            var cw2 = new CWithJavaInterface(2);
            Object other = (Object)Bridge.WrapCLR(cw2);
            Assert.AreEqual(1, cw1.compareTo(other));

            cw2.run();
            Assert.AreEqual(3, cw2.Value);
        }

        [Test]
        public void jIfaceUnreg()
        {
            var cw1 = new CWithJavaInterfaceUnreg(1);
            var cw2 = new CWithJavaInterfaceUnreg(2);

            Object other = (Object)Bridge.WrapCLR(cw2);
            Assert.AreEqual(1, cw1.compareTo(other));

            cw2.run();
            Assert.AreEqual(3, cw2.Value);
        }

        [Test]
        public void cIface()
        {
            var cw1 = new JWithClrInterface(1);
            var cw2 = new JWithClrInterface(2);

            int res = cw1.CompareTo(cw2);

            Assert.AreEqual(1, res);

            cw2.run();
            Assert.AreEqual(3, cw2.getValue());
        }

        [Test]
        [ExpectedException(typeof(JNIException))]
        public void cIfaceCant()
        {
            var cw1 = new JWithClrInterface(1);
            Bridge.WrapCLR(cw1);
        }

        [Test]
        [ExpectedException(typeof(JNIException))]
        public void cIfaceCant2()
        {
            var cw1 = new String("sdfd");
            Bridge.UnwrapCLR<IClrProxy>(cw1);
        }

        [Test]
        public void cIfaceCanString()
        {
            var cw1 = "sdfd";
            Object proxy = Bridge.WrapCLR(cw1);
            Class clazz = proxy.getClass();
            Assert.AreEqual(System.String_._class, clazz);
            object res = Bridge.UnwrapCLR<object>(proxy);
            Assert.AreSame(cw1, res);
        }

        [Test]
        public void cIfaceCanInt()
        {
            var cw1 = 1;
            Object proxy = Bridge.WrapCLR(cw1);
            Class clazz = proxy.getClass();
            //TODO Assert.AreEqual(System.Int32_._class, clazz);
            object res = Bridge.UnwrapCLR<object>(proxy);
            Assert.AreEqual(cw1, res);
        }

        [Test]
        public void cIfaceUnreg()
        {
            IComparable cw1 = testInstance.createJWithClrInterfaceUnreg(1);
            IComparable cw2 = testInstance.createJWithClrInterfaceUnreg(2);

            Assert.AreEqual(1, cw1.CompareTo(cw2));

            ((Object) cw2).Invoke<int>("run", "()V");
            Assert.AreEqual(3, ((Object)cw2).Invoke<int>("getValue","()I"));
        }

        [Test]
        public void cIfaceUnreg2()
        {
            IComparable comparable = testInstance.createJWithClrInterfaceUnreg(1);
            Runnable cw1 = Bridge.Cast<Runnable>(comparable);
            cw1.run();
            cw1.run();
            cw1.run();
            var cw2 = testInstance.createJWithClrInterfaceUnreg(4);

            Assert.AreEqual(0, cw2.CompareTo(cw1));

            cw1.run();
            Assert.AreEqual((String)"5", cw1.ToString());
        }

        [Test]
        public void cIfaceUnreg3()
        {
            Runnable runnable = testInstance.createJWithClrInterfaceUnregRun(1);
            runnable.run();
            runnable.run();
            runnable.run();
            var cw2 = testInstance.createJWithClrInterfaceUnreg(4);

            IComparable comparable = Bridge.Cast<IComparable>(runnable);

            Assert.AreEqual(0, comparable.CompareTo(cw2));

            runnable.run();
            Assert.AreEqual((String)"5", runnable.ToString());
        }

        [Test]
        public void Interfaces1()
        {
            CWithJavaInterface a = new CWithJavaInterface(4);
            Runnable cw = testInstance.getCWithJavaInterface(a);
            CWithJavaInterface cwi = testInstance.getCWithJavaInterfaceC(a);
            cwi.run();
            cw.run();
            CWithJavaInterface tt = cw as CWithJavaInterface;
            Assert.AreEqual(6, tt.Value);
        }

        [Test]
        public void InterfacesstringArray()
        {
            Class loadClass = ICInterface_._class.getClassLoader().loadClass("net.sf.jni4net.tested.CInterfaceImpl");
            ICInterface impl = Bridge.Cast<ICInterface>(loadClass.newInstance());
            impl.xx(new []{"a",null,"b"});
            ;
        }
        
    }
}
