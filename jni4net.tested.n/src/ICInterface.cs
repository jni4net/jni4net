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
}
