using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IKnownTypes
    {
        IMType SystemObject { get; set; }
        IMType SystemType { get; set; }
        IMType SystemException { get; set; }
        
        IMType JavaLangObject { get; set; }
        IMType JavaLangClass { get; set; }
        IMType JavaLangThrowable { get; set; }
    }
}
