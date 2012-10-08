using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services
{
    public class SubstituteProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S0400_Substitute; }
        }

        public override int Priority
        {
            get { return 0; }
        }

        public override void Process(IMType model)
        {
            if (model.IsExplore)
            {
                Logger.LogVerbose(GetType().Name + " " + model, model);
            }
            WorkQueue.Enqueue(model, Stage.S9999_Done);
        }
    }
}
