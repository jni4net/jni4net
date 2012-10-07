using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services
{
    public class DoneProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S9999_Done; }
        }

        public override int Priority
        {
            get { return 0; }
        }

        public override void Process(IMType model)
        {
            model = model.IsClr
                        ? Clr(model)
                        : Jvm(model);

            Logger.LogVerbose(GetType().Name + " " + model, model);
            WorkQueue.Enqueue(model, Stage.S9999_Done);
        }

        private IMType Clr(IMType model)
        {
            var clr = model.ClrReflection;

            return model;
        }

        private IMType Jvm(IMType model)
        {
            var jvm = model.JvmReflection;

            return model;
        }
    }
}
