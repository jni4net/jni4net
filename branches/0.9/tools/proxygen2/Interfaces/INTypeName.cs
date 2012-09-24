using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jni4net.proxygen.Interfaces
{
    public interface INTypeName
    {
        List<string> Namespaces { get; set; }
        List<string> Enclosing { get; set; }
        string Name { get; set; }
    }
}
