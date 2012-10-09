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

                // if is known, we don't have to substitute
                if (!model.IsAlreadyKnown && model.Substitution == null)
                {
                    // will be generated and therefore known ?
                    if(!model.IsGenerate)
                    {
                        // no it would not be generated and it's not known
                        model.Substitution = FindSubstitute(model, model);
                    }
                }
            }
            WorkQueue.Enqueue(model, Stage.S9999_Done);
        }

        private IMType FindSubstitute(IMType original, IMType current, bool interfaces = false)
        {
            if (interfaces)
            {
                if (current.IsRoot) 
                    return null;

                foreach (var ifc in current.Interfaces)
                {
                    if (current.IsGoingToBeKnown)
                        return current;
                    if (current.Substitution != null)
                        return current.Substitution;

                    var res = FindSubstitute(original, ifc, true);
                    if (res != null) 
                        return res;
                }
                if (current.Base != null)
                {
                    var res = FindSubstitute(original, current.Base, true);
                    if (res != null)
                        return res;
                }
            }
            else
            {
                if (current.IsRoot) 
                    return FindSubstitute(original, original, true);
                if (current.IsGoingToBeKnown)
                    return current;
                if (current.Substitution!=null)
                    return current.Substitution;
                if (current.Base != null) 
                    return FindSubstitute(original, current.Base, false);
            }

            return original.IsClr
                ? KnownTypes.JavaLangObject
                : KnownTypes.SystemObject;
        }
    }
}
