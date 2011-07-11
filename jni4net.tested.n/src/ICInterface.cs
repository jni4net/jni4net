using System;

namespace net.sf.jni4net.tested
{
    public interface ICInterface
    {
        int intProp { get; set; }

        TestDelegate fcePtr { get; set;}

        event TestDelegate EnvDispatcher;

        void xx(string[] strs);

        //BUG #2 void Refparam(ref string text);

        //BUG #2 void Outparam(out string text);

        string this[int i, int j] { get; }
    }
}
