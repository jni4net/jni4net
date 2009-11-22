using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using net.sf.jni4net.tested;
using NUnit.Framework;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class Serialization : TestBase
    {
        [Test]
        public void Ser()
        {
            JavaInstanceFields s = new JavaInstanceFields();
            MemoryStream ms=new MemoryStream();
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            binaryFormatter.Serialize(ms, s);
            ms.Close();

            MemoryStream mso=new MemoryStream(ms.GetBuffer());
            var des = (JavaInstanceFields)binaryFormatter.Deserialize(mso);
            Assert.AreEqual(6, des.byteField);
        }
    }
}
