using System.Linq;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen.Services
{
    public class LeavesProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S0400_FindLeaves; }
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

            if (model.Registration.Parent.GenerateNestedClasses && model.IsGenerate)
            {
                var nestedTypes = clr.GetNestedTypes().Where(x => x.IsNestedPublic);
                foreach (var nestedType in nestedTypes)
                {
                    IMType enclosingModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(nestedType), model);

                    WorkQueue.Enqueue(enclosingModel, true, true);
                }
            }

            return model;
        }

        private IMType Jvm(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var jvm = model.JvmReflection;

            if (model.Registration.Parent.GenerateNestedClasses && model.IsGenerate)
            {
                var nestedTypes = jvm.getDeclaredClasses().Where(x => x.IsPublic());
                foreach (var nestedType in nestedTypes)
                {
                    IMType enclosingModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(nestedType), model);

                    WorkQueue.Enqueue(enclosingModel, true, true);
                }
            }


            return model;
        }
    }
}
