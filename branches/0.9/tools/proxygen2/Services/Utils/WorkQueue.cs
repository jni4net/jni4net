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
        readonly Dictionary<Stage, Queue<IMType>> work = new Dictionary<Stage, Queue<IMType>>();
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
                    var q = work[stage];
                    if (q.Count > 0)
                    {
                        IMType model = q.Dequeue();
                        workCount--;
                        if (model.Stage == stage)
                        {
                            model.IsQueueing = false;
                            foreach (var processor in processors[stage])
                            {
                                processor.Process(model);
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
                work[stage] = new Queue<IMType>();
                processors[stage] = Processors.Where(p => p.Stage == stage).OrderBy(p => p.Priority).ToList();
            }

            foreach (IMType model in TypeRepository.AllModels())
            {
                if (model.IsExplore)
                {
                    Enqueue(model, Stage.S0200_ToMatch);
                }
            }
        }

        public void Enqueue(IMType model, Stage stage)
        {
            if (model.IsQueueing)
            {
                if(stage==Stage.S9999_Done)
                {
                    model.IsQueueing = false;
                    model.Stage = Stage.S9999_Done;
                    work[model.Stage].Enqueue(model);
                    Logger.LogMessage("Done for " + model);
                }
            }
            else
            {
                model.IsQueueing = true;
                if (stage > model.Stage)
                {
                    model.Stage = stage;
                }
                work[model.Stage].Enqueue(model);
                if(model.Stage != Stage.S9999_Done)
                {
                    Logger.LogMessage("Queued for " + model + " "+model.Stage);
                    workCount++;
                }
            }
        }
    }
}
