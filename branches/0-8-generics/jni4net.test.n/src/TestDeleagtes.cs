using net.sf.jni4net.tested;
using NUnit.Framework;
using Object = java.lang.Object;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class TestDeleagtes : TestBase
    {
        [Test]
        public void DelegateCallback()
        {
            tested.TestDelegate td = TestDelegateImpl;
            Object del = Bridge.WrapCLR(td);
            Assert.IsNotNull(del);

            object res = del.Invoke<object>("Invoke", "(ILjava/lang/String;)Lsystem/Object;", 1, "ahoj");
            Assert.AreEqual("ahoj1",res);
        }

        object TestDelegateImpl(int i, string s)
        {
            return s+i;
        }


        [Test]
        public void DelegateConvert()
        {
            tested.TestDelegate del = JavaCallStaticMethods._class.Invoke<tested.TestDelegate>("testDelegate", "()Lnet/sf/jni4net/tested/TestDelegate;");
            Assert.IsNotNull(del);
            var res = del.Invoke(1, "ahoj");
            Assert.AreEqual("ahoj1", res);
        }

        [Test]
        public void DelegateJP()
        {
            JavaCallStaticMethods.testDelegatePtr();
            JavaCallStaticMethods.testDelegateEvent();
        }
    
    }
}
