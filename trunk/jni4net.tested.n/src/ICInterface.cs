using System;
using System.Collections.Generic;
using System.Text;

namespace net.sf.jni4net.tested
{
    public interface ICInterface
    {
        int intProp { get; set; }

        TestDelegate fcePtr { get; set;}

        event TestDelegate EnvDispatcher;
    }

    public class CIfcImpl :  ICInterface
    {
        public int intProp { get; set; }
        private TestDelegate _fcePtr;
        public TestDelegate fcePtr { get
        {
            return _fcePtr;
        } set
        {
            _fcePtr = value;
        }

        }
        public event TestDelegate EnvDispatcher;

        public object RunPtr()
        {
            return fcePtr(1, "ahoj");
        }

        public object RunEvnt()
        {
            return EnvDispatcher(2, "ahoj");
        }
    }
}
