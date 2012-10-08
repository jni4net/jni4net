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
            get { return Stage.S0200_FindRoots; }
        }

        public override int Priority
        {
            get { return 0; }
        }

        public override void Process(IMType model)
        {
            if(model.IsExplore)
            {
                model = model.IsClr
                            ? Clr(model)
                            : Jvm(model);

                Logger.LogVerbose(GetType().Name + " " + model, model);
                WorkQueue.Enqueue(model, Stage.S0300_FindLeaves);
            }
            else
            {
                WorkQueue.Enqueue(model, Stage.S9999_Done);
            }
        }

        private IMType Clr(IMType model)
        {
            var clr = model.ClrReflection;
            if (clr == KnownTypes.SystemObject.ClrReflection)
            {
                return model;
            }

            Type clrBase = clr.BaseType;
            if (clrBase != null)
            {
                IMType baseModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrBase), model);
                model.Base = baseModel;
                model.HomeView.Base = ClrResolver.CreateUsage(clrBase, model.HomeView);
                WorkQueue.Enqueue(baseModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }
            else
            {
                model.Base = KnownTypes.SystemObject;
            }

            model.Interfaces.Clear();
            model.HomeView.Interfaces.Clear();
            Type[] clrInterfaces = clr.GetInterfaces();
            foreach (var ifc in clrInterfaces)
            {
                if (clrInterfaces.Any(other => other != ifc && other.Implements(ifc)))
                {
                    continue;
                }

                IMType ifcModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrBase), model);
                model.HomeView.Interfaces.Add(ClrResolver.CreateUsage(ifc, model.HomeView));
                model.Interfaces.Add(ifcModel);

                WorkQueue.Enqueue(ifcModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }

            Type clrEnclosing = clr.DeclaringType;
            if (clrEnclosing != null)
            {
                IMType enclosingModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(clrEnclosing), model);
                model.Enclosing = enclosingModel;
                WorkQueue.Enqueue(enclosingModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }

            return model;
        }

        private IMType Jvm(IMType model)
        {
            var jvm = model.JvmReflection;
            if (jvm == KnownTypes.JavaLangObject.JvmReflection)
            {
                return model;
            }

            Class jvmBase = jvm.getSuperclass();
            if (jvmBase != null)
            {
                IMType baseModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(jvmBase), model);
                model.Base = baseModel;
                model.HomeView.Base = JvmResolver.CreateUsage(jvmBase, model.HomeView);
                WorkQueue.Enqueue(baseModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }
            else
            {
                model.Base = KnownTypes.JavaLangObject;
            }

            model.Interfaces.Clear();
            model.HomeView.Interfaces.Clear();
            Class[] jvmInterfaces = jvm.getInterfaces();
            foreach (var ifc in jvmInterfaces)
            {
                if (jvmInterfaces.Any(other => other != ifc && ifc.isAssignableFrom(other)))
                {
                    continue;
                }

                IMType ifcModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(ifc), model);
                model.HomeView.Interfaces.Add(JvmResolver.CreateUsage(ifc, model.HomeView));
                model.Interfaces.Add(ifcModel);

                WorkQueue.Enqueue(ifcModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }

            Class jvmEnclosing = jvm.getEnclosingClass();
            if (jvmEnclosing!=null)
            {
                IMType enclosingModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(jvmEnclosing), model);
                model.Enclosing = enclosingModel;
                WorkQueue.Enqueue(enclosingModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }

            return model;
        }
    }
}
