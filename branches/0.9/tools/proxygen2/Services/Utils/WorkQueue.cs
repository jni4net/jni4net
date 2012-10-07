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

        [Dependency("NameProcessor")]
        public IProcessor NameProcessors { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public void Init()
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

        public void Run()
        {
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
                        work[stage].Reverse();

                        for (int i = q.Count - 1; q.Count > 0; i = q.Count - 1)
                        {
                            var model = q[i];
                            if (model.Stage == stage)
                            {
                                Dequeue(model);
                                foreach (var processor in processors[stage])
                                {
                                    processor.Process(model);
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
            }
        }

        private void Dequeue(IMType model)
        {
            if (model.IsQueueing)
            {
                workCount--;
                work[model.Stage].Remove(model);
                model.IsQueueing = false;
            }
        }

        public void Enqueue(IMType model, bool generate, bool explore)
        {
            bool reexplore = false;
            if (!model.IsGenerateIfMissing && generate)
            {
                //enforce reevaluation
                model.IsExplore = true;
                model.IsGenerateIfMissing = true;
                reexplore = true;
                Logger.LogVerbose("Reevaluate generate " + model, model);
            }
            if (!model.IsExplore && explore)
            {
                //enforce reevaluation
                model.IsExplore = true;
                reexplore = true;
                Logger.LogVerbose("Reevaluate explore " + model, model);
            }
            if(reexplore)
            {
                Dequeue(model);
                model.Stage = Stage.S0100_ToMatch;

                // this should be processed inline
                NameProcessors.Process(model);
            }
        }

        public void Enqueue(IMType model, Stage stage)
        {
            if(model.IsQueueing && model.Stage==stage)
            {
                return;
            }

            Dequeue(model);
            
            if (stage > model.Stage)
            {
                model.Stage = stage;
            }

            if (model.Stage == Stage.S9999_Done)
            {
                Logger.LogMessage("Done for " + model, model);
                return;
            }
            
            work[model.Stage].Add(model);
            workCount++;
            model.IsQueueing = true;

            Logger.LogVerbose("Queued for " + model + " " + model.Stage, model);
        }
    }
}
