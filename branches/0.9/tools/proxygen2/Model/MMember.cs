using System;
using System.Linq;
using System.Text;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Model
{
    public class MMember : IMMember
    {
        public IMType DeclaringType { get; set; }
        public IMemberRegistration Registration { get; set; }
        public string Name { get; set; }
    }
}
