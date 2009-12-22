using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using java.lang;
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

        [Test]
        public void BinarySerException()
        {
            try
            {

                throw new IllegalArgumentException("test");
            }
            catch (Exception ex)
            {
                MemoryStream ms = new MemoryStream();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(ms, ex);
                ms.Close();

                MemoryStream mso = new MemoryStream(ms.GetBuffer());
                var des = (IllegalArgumentException)binaryFormatter.Deserialize(mso);
                Assert.AreEqual("test", des.Message);
            }
        }

    }
}
