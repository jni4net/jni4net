using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IWorkQueue
    {
        void Run();
        void Enqueue(IMType model, Stage stage);
        void Enqueue(IMType model, bool generate, bool explore);
    }
}
