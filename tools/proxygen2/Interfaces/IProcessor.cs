using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IProcessor
    {
        Stage Stage { get; }
        int Priority { get; }
        void Process(IMType model);
    }
}