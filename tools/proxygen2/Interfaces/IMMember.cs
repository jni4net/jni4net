using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IMMember
    {
        IMType DeclaringType { get; set; }
        IMemberRegistration Registration { get; set; }
    }

    public interface IMMemberView : IMMember
    {
    }
}
