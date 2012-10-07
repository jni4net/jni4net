using System.Linq;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;

namespace com.jni4net.proxygen.Services
{
    public class RootsProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S0200_FindBase; }
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
            WorkQueue.Enqueue(model, Stage.S0400_FindLeaves);
        }

        private IMType Clr(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var clr = model.ClrReflection;
            if (clr == KnownTypes.SystemObject.ClrReflection || clr.IsInterface)
            {
                return model;
            }

            Type clrBase = clr.BaseType;
            if (clrBase != null)
            {
                IMType baseModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrBase), model);
                WorkQueue.Enqueue(baseModel, model.IsGenerate, model.IsExplore);
            }

            model.Interfaces.Clear();
            Type[] clrInterfaces = clr.GetInterfaces();
            foreach (var ifc in clrInterfaces)
            {
                if (clrInterfaces.Any(other => other != ifc && other.Implements(ifc)))
                {
                    continue;
                }

                IMType ifcModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrBase), model);
                model.Interfaces.Add(ifcModel);

                WorkQueue.Enqueue(ifcModel, model.IsGenerate,model.IsExplore);
            }

            Type clrEnclosing = clr.DeclaringType;
            if (clrEnclosing != null)
            {
                IMType clrEnclosingModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrEnclosing), model);
                WorkQueue.Enqueue(clrEnclosingModel, model.IsGenerate, model.IsExplore);
            }

            return model;
        }

        private IMType Jvm(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var jvm = model.JvmReflection;
            if (jvm == KnownTypes.JavaLangObject.JvmReflection || jvm.isInterface())
            {
                return model;
            }

            Class jvmBase = jvm.getSuperclass();
            if (jvmBase != null)
            {
                IMType baseModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(jvmBase), model);
                WorkQueue.Enqueue(baseModel, model.IsGenerate, model.IsExplore);
            }

            model.Interfaces.Clear();
            Class[] jvmInterfaces = jvm.getInterfaces();
            foreach (var ifc in jvmInterfaces)
            {
                if (jvmInterfaces.Any(other => other != ifc && ifc.isAssignableFrom(other)))
                {
                    continue;
                }

                IMType ifcModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(jvmBase), model);
                model.Interfaces.Add(ifcModel);

                WorkQueue.Enqueue(ifcModel, model.IsGenerate, model.IsExplore);
            }

            Class jvmEnclosing = jvm.getEnclosingClass();
            if (jvmEnclosing!=null)
            {
                IMType enclosingModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(jvmEnclosing), model);
                WorkQueue.Enqueue(enclosingModel, model.IsGenerate, model.IsExplore);
            }

            return model;
        }
    }
}
