#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services
{
    public abstract class ExplorerBase
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IModelHandler[] Handlers { get; set; }

        protected void Handle()
        {
            Handlers = Handlers.OrderBy(handler => handler.PassPriority).ToArray();
            foreach (var modelHandler in Handlers)
            {
                Logger.LogVerbose("Explorer sequence :" + modelHandler.PassPriority.ToString("0000") + "-" + modelHandler.GetType().Name, null);
            }


            int start = 0;
            for (int i = 0; i < Handlers.Length; i++)
            {
                if (Handlers[i].IsBlockingAll)
                {
                    var pipeline = Handlers.Skip(start).Take(i - start).ToList();
                    var split = Handlers.Skip(i).Take(1).ToList();

                    CreateRound(pipeline).RunRound();
                    CreateRound(split).RunRound();
                    start = i+1;
                }
                else if (i==Handlers.Length-1)
                {
                    var pipeline = Handlers.Skip(start).Take(i - start + 1).ToList();
                    CreateRound(pipeline).RunRound();
                }
            }

        }

        private Round CreateRound(List<IModelHandler> roundHandlers)
        {
            return new Round
                       {
                           Logger = Logger,
                           Handlers = roundHandlers,
                           Repository = Repository,
                       };
        }

        private class Round
        {
            public ILogger Logger { get; set; }

            public ITypeRepository Repository { get; set; }

            public List<IModelHandler> Handlers { get; set; }
            private IModelHandler LastHandler;
            private IModelHandler FirstHandler;

            private IList<MType> GetModels()
            {
                return Repository.GetModelsToExplore()
                    .Where(model =>
                           (model.Pass <= LastHandler.ExpectedPass
                           && model.Pass >= FirstHandler.ExpectedPass) || (FirstHandler.ExpectedPass == ProxyGenPass.Any || LastHandler.ExpectedPass == ProxyGenPass.Any)
                    )
                    .ToList();
            }

            public void RunRound()
            {
                if (Handlers.Count==0)
                {
                    return;
                }

                Logger.LogVerbose("",null);
                Logger.LogMessage("Explorer round :" + Handlers.Aggregate("", (x, y) => x + " " + y.PassPriority.ToString("0000")+"-"+ y.GetType().Name),null);

                FirstHandler = Handlers.FirstOrDefault(x => x.ExpectedPass != ProxyGenPass.Any);
                LastHandler = Handlers.LastOrDefault(x => x.ExpectedPass != ProxyGenPass.Any);
                if (FirstHandler==null)
                {
                    LastHandler = FirstHandler = Handlers[0];
                }
                foreach (var model in Repository.GetModelsToExplore())
                {
                    model.Handlers = null;
                }

                var models = GetModels();
                foreach (var handler in Handlers)
                {
                    handler.RoundStarted(models);
                }
                
                var lastCount = 0;
                var currentCount = models.Count;
                bool madeProgress = false;
                bool pendingHandlers = true;
                while ((lastCount < currentCount || madeProgress) && pendingHandlers)
                {
                    madeProgress = false;
                    //pendingHandlers = false;
                    foreach (var model in models)
                    {
                        if (ExploreModel(model))
                        {
                            madeProgress = true;
                        }
                        if(model.Handlers!=null && model.Handlers.Count!=0)
                        {
                            pendingHandlers = true;
                        }
                    }

                    lastCount = currentCount;
                    models = GetModels();
                    currentCount = models.Count;
                }

                foreach (var handler in Handlers)
                {
                    handler.RoundFinished(models);
                }

            }

            private IEnumerable<IModelHandler> FindHandlers(MType model)
            {
                return Handlers
                    .Where(x =>
                           x.IsHandlerForModel(model)
                           && (x.ExpectedPass >= model.Pass || x.ExpectedPass==ProxyGenPass.Any)
                    )
                    .OrderBy(x => x.PassPriority);
            }

            private bool ExploreModel(MType model)
            {
                bool madeProgress=false;
                if (model.InProgress)
                {
                    return false;
                }
                if (model.Handlers==null)
                {
                    model.Handlers = new Queue<IModelHandler>(FindHandlers(model));
                }
                while (model.Handlers.Count > 0)
                {
                    IEnumerable<MType> waitfor;
                    var handler = model.Handlers.Peek();
                    if (handler.ExpectedPass < model.Pass && handler.ExpectedPass != ProxyGenPass.Any)
                    {
                        Logger.LogVerbose("missed " + handler.GetType().Name + " for " + model + " in " + model.Pass, model);
                        model.Handlers.Dequeue();
                    }
                    else if (handler.ExpectedPass > model.Pass && handler.ExpectedPass != ProxyGenPass.Any)
                    {
                        Logger.LogVerbose("reload " + handler.GetType().Name + " for " + model + " in " + model.Pass, model);
                        return madeProgress;
                    }
                    else if (!handler.CheckOtherPrerequisites(model, out waitfor))
                    {
                        Logger.LogVerbose("wait " + handler.GetType().Name + " for " + model + " in " + model.Pass + " |<- " + waitfor.Aggregate("", (s, m) => s + " " + m.ToShortString()), model);
                        return true;
                    }
                    else
                    {
                        if (CallHandler(model, handler, ref madeProgress))
                        {
                            return true;
                        }
                    }
                }
                return madeProgress;
            }

            private bool CallHandler(MType model, IModelHandler handler, ref bool madeProgress)
            {
                model.Handlers.Dequeue();
                try
                {
                    string message = handler.GetType().Name + ": running " + model;
                    Logger.LogVerbose(message, model);

                    Report(model, Logger, handler, true);

                    model.InProgress = true;
                    madeProgress = true;
                    if (handler.HandleModel(model, ExploreModel))
                    {
                        model.Handlers = null;
                        Report(model, Logger, handler, false);
                        return true;
                    }
                    Report(model, Logger, handler, false);
                }
                catch (Exception ex)
                {
                    Logger.LogError(handler.GetType().Name + " failed on", ex, model);
                    Logger.LogVerbose(ex.ToString(), model);
                    model.Pass = ProxyGenPass.Failed;
                    throw;
                }
                finally
                {
                    model.InProgress = false;
                }
                return false;
            }

            private static void Report(MType model, ILogger logger, IModelHandler handler, bool pre)
            {
                /*try
                {
                    if (model.JvmFullName == "system.Guid")
                    {
                        if (model.JvmGeneration != null)
                        {
                            foreach (var member in model.JvmGeneration.Members)
                            {
                                if(member.Name=="Equals")
                                {
                                    logger.LogMessage(handler.GetType() + "  " + member.Return.Root, model);
                                }
                            }
                        }
                    }
                }
                // ReSharper disable EmptyGeneralCatchClause
                catch(Exception ignore)
                {
                }*/
            }
        }
    }
}
