using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IUTypeUsage
    {
        IParameterRegistration ParameterRegistration { get; set; }
        string MethodParameterName { get; set; }
        bool IsReturn { get; set; }
        bool IsParameter { get; set; }

        IMTypeView DeclaringType { get; set; }
        IMTypeView UsedType { get; set; }
    }
}
