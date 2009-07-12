using System;
using java.lang;
using net.sf.jni4net.tested;
using NUnit.Framework;
using Object=java.lang.Object;

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
            Assert.AreEqual(1, cw1.compareTo(Bridge.ToJVM<Object>(cw2)));

            cw2.run();
            Assert.AreEqual(3, cw2.Value);
        }

        [Test]
        [Ignore]
        public void jIfaceUnreg()
        {
            var cw1 = new CWithJavaInterfaceUnreg(1);
            var cw2 = new CWithJavaInterfaceUnreg(2);

            Assert.AreEqual(1, cw1.compareTo(Bridge.ToJVM<Object>(cw2)));

            cw2.run();
            Assert.AreEqual(3, cw2.Value);
        }

        [Test]
        public void cIface()
        {
            var cw1 = new JWithClrInterface(1);
            var cw2 = new JWithClrInterface(2);

            Assert.AreEqual(1, cw1.CompareTo(cw2));

            cw2.run();
            Assert.AreEqual(3, cw2.getValue());
        }

        [Test]
        [Ignore]
        public void cIfaceUnreg()
        {
            IComparable cw1 = testInstance.createJWithClrInterfaceUnreg(1);
            IComparable cw2 = testInstance.createJWithClrInterfaceUnreg(1);

            Assert.AreEqual(1, cw1.CompareTo(cw2));

            ((Object) cw2).Invoke<int>("run", "()V");
            Assert.AreEqual(3, ((Object)cw2).Invoke<int>("getValue","()I"));
        }
        
        [Test]
        public void Interfaces1()
        {
            CWithJavaInterface a = new CWithJavaInterface(4);
            Runnable cw = testInstance.getCWithJavaInterface((Runnable)a);
            CWithJavaInterface cwi = (CWithJavaInterface)testInstance.getCWithJavaInterfaceC(a);
            cwi.run();
            cw.run();
            CWithJavaInterface tt = cw as CWithJavaInterface;
            Assert.AreEqual(6, tt.Value);
        }

        
    }
}
