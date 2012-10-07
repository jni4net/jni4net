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
            var foreign = model.Views[ViewKind.Foreign];
            var home = model.Views[ViewKind.Home];

            model = model.IsClr
                        ? Clr(model, home, foreign)
                        : Jvm(model, home, foreign);

            Logger.LogVerbose(GetType().Name + " " + model, model);
            WorkQueue.Enqueue(model, Stage.S9999_Done);
        }

        private IMType Clr(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var clr = model.ClrReflection;

            return model;
        }

        private IMType Jvm(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var jvm = model.JvmReflection;

            return model;
        }
    }
}
