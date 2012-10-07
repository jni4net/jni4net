using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services
{
    public class WorkQueue : IWorkQueue
    {
        private int workCount;
        readonly Stage[] stages = (Stage[])Enum.GetValues(typeof(Stage));
        readonly Dictionary<Stage, List<IMType>> work = new Dictionary<Stage, List<IMType>>();
        readonly Dictionary<Stage, List<IProcessor>> processors = new Dictionary<Stage, List<IProcessor>>();

        [Dependency]
        public ITypeRepository TypeRepository { get; set; }

        [Dependency]
        public IProcessor[] Processors { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public void Run()
        {
            Init();
            while (workCount>0)
            {
                foreach (Stage stage in stages)
                {
                    // there is queue for each stage
                    var q = work[stage];
                    if (q.Count > 0)
                    {
                        if (processors[stage].Count == 0)
                        {
                            throw new Exception("Processor missing for " + stage);
                        }

                        //clear the queue
                        work[stage] = new List<IMType>();

                        foreach (var model in q)
                        {
                            workCount--;
                            if (model.Stage == stage)
                            {
                                model.IsQueueing = false;
                                foreach (var processor in processors[stage])
                                {
                                    processor.Process(model);
                                }
                            }
                            else if (model.Stage < stage)
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
            }
        }

        private void Init()
        {
            foreach (Stage stage in stages)
            {
                work[stage] = new List<IMType>();
                processors[stage] = Processors.Where(p => p.Stage == stage).OrderBy(p => p.Priority).ToList();
            }

            var allModels = TypeRepository.AllModels();
            foreach (IMType model in allModels)
            {
                if (model.IsExplore)
                {
                    Enqueue(model, Stage.S0100_ToMatch);
                }
            }
        }

        public void Enqueue(IMType model, bool generate, bool explore)
        {
            if(!model.IsGenerate && generate)
            {
                //enforce reevaluation
                model.IsExplore = true;
                model.IsGenerate = true;
                model.Stage = Stage.S0100_ToMatch;
                Logger.LogVerbose("Reevaluate generate " + model, model);
            }
            if (!model.IsExplore && explore)
            {
                //enforce reevaluation
                model.IsExplore = true;
                model.Stage = Stage.S0100_ToMatch;
                Logger.LogVerbose("Reevaluate explore " + model, model);
            }
            Enqueue(model, Stage.S0100_ToMatch);
        }

        public void Enqueue(IMType model, Stage stage)
        {
            if (model.IsQueueing)
            {
                if (stage == Stage.S9999_Done)
                {
                    work[model.Stage].Remove(model);
                    model.IsQueueing = false;
                    model.Stage = Stage.S9999_Done;
                    work[model.Stage].Add(model);
                    Logger.LogMessage("Done for " + model, model);
                }
            }
            else
            {
                model.IsQueueing = true;
                if (stage > model.Stage)
                {
                    model.Stage = stage;
                }
                work[model.Stage].Add(model);
                if(model.Stage != Stage.S9999_Done)
                {
                    Logger.LogVerbose("Queued for " + model + " " + model.Stage, model);
                    workCount++;
                }
                else
                {
                    Logger.LogMessage("Done for " + model, model);
                }
            }
        }
    }
}
