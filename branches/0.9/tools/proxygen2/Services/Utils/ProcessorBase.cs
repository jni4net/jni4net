using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services
{
    public abstract class ProcessorBase : IProcessor
    {
        private IWorkQueue workQueue;
        public IWorkQueue WorkQueue
        {
            get { return workQueue ?? (workQueue = Container.Resolve<IWorkQueue>()); }
        }

        [Dependency]
        public IContainer Container { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        public abstract Stage Stage { get; }
        public abstract int Priority { get; }
        public abstract void Process(IMType model);
    }
}
