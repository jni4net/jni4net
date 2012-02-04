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
using System.Linq;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Services.Translators;
using Microsoft.Practices.Unity;
using java.lang;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class ConfigureMembersTranslator : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2500_TranslatorStarted; }
        }

        public override bool IsBlockingAll
        {
            get { return true; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 100; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = model.TargetGeneration.Interfaces.Where(ifc =>
                                                                 ifc.Root.Pass < ProxyGenPass.P2600_MembersConfigured
                                                                 && !(model.IsClr ? ifc.IsClrSkip : ifc.IsJvmSkip)).
                Select(x => x.Root);
            return !waitingFor.Any();
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            foreach (var member in model.TargetGeneration.Members)
            {
                RenameMember(model, member);
                foreach (var param in member.ReturnAndParams)
                {
                    ChangeParameter(model, param);
                }

                if (member.ImplementsMember.Count > 0 && member.ImplementsMember[0].MemberRegistration != null)
                {
                    if (member.Return!=null)
                    {
                        ChangeTypeByInterface(model, member, member.Return, member.ImplementsMember[0].Return);
                    }
                    for (int i = 0; i < member.Params.Count; i++)
                    {
                        ChangeTypeByInterface(model, member, member.Params[i], member.ImplementsMember[0].Params[i]);
                    }
                }
            }

            model.Pass = ProxyGenPass.P2600_MembersConfigured;
            return false;
        }

        private void ChangeTypeByInterface(MType model, MMember member, UTypeUsage param, UTypeUsage implParam)
        {
            if (!model.IsInterface && implParam.ParameterRegistration != null && !string.IsNullOrEmpty(implParam.ParameterRegistration.changeType))
            {
                if (param.Pair.Equals(implParam.Pair))
                {
                    Logger.LogVerbose("Changed type " + model + " from " + param + " to " +
                                      implParam + " on " + model +"."+ member.Name + " because of config on" +
                                      member.ImplementsInterfaces[0],model);
                    param.Root = implParam.Root;
                    param.ParameterRegistration = implParam.ParameterRegistration;
                }
            }
        }

        protected virtual void ChangeParameter(MType model, UTypeUsage param)
        {
            if (param != null && param.ParameterRegistration != null)
            {
                ParameterRegistration parameterRegistration = param.ParameterRegistration;
                if (!string.IsNullOrEmpty(parameterRegistration.changeType))
                {
                    if (model.IsClr)
                    {
                        param.Root = KnownTypes.FakeTypes.SingleOrDefault(f => f.JvmFullName == parameterRegistration.changeType);
                        if (param.Root == null)
                        {
                            Class clazz = JvmResolver.LoadClass(parameterRegistration.changeType, true);
                            if (clazz != null)
                            {
                                param.Root = JvmResolver.Register(clazz, null, model);
                            }
                            else
                            {
                                Type type = ClrResolver.LoadType(parameterRegistration.changeType, true);
                                if (type == null)
                                {
                                    throw new ProxygenException("Can't load find " + parameterRegistration.changeType);
                                }
                                param.Root = ClrResolver.Register(type, null, model);
                            }
                        }
                    }
                    else
                    {
                        param.Root = KnownTypes.FakeTypes.SingleOrDefault(f => f.ClrFullName == parameterRegistration.changeType);
                        if (param.Root==null)
                        {
                            Type type = ClrResolver.LoadType(parameterRegistration.changeType, true);
                            if (type != null)
                            {
                                param.Root = ClrResolver.Register(type, null, model);
                            }
                            else
                            {
                                Class clazz = JvmResolver.LoadClass(parameterRegistration.changeType, true);
                                if (clazz == null)
                                {
                                    throw new ProxygenException("Can't load find " + parameterRegistration.changeType);
                                }
                                param.Root = JvmResolver.Register(clazz, null, model);
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(parameterRegistration.rename))
                {
                    param.MethodParameterName = parameterRegistration.rename;
                }
            }
        }

        protected virtual void RenameMember(MType model, MMember member)
        {
            if (member.IsProperty)
            {
                member.Name = member.Name.Substring(0, 3) + member.Name.Substring(4);
            }
            else if (member.IsEvent)
            {
                if (member.Name.StartsWith("add_"))
                {
                    member.Name = member.Name.Substring(0, 3) + member.Name.Substring(4);
                }
                else
                {
                    member.Name = member.Name.Substring(0, 6) + member.Name.Substring(7);
                }
            }
            if (member.ImplementsInterfaces.Count != 0)
            {
                if (member.Name != member.ImplementsMember[0].Name)
                {
                    Logger.LogVerbose("Renamed " + model + " from " + member.Name + " to " +
                                      member.ImplementsMember[0].Name + " on " + model + " because of " +
                                      member.ImplementsInterfaces[0],model);
                    member.Name = member.ImplementsMember[0].Name;
                }
                for (int i = 1; i < member.ImplementsMember.Count; i++)
                {
                    if (member.Name != member.ImplementsMember[i].Name)
                    {
                        Logger.LogMessage("Implementation of " + member.ImplementsMember[i].Name + " on " + model +
                                          " broken for " + member.ImplementsInterfaces[i], model);
                    }
                }
            }
            if (member.MemberRegistration!=null && member.MemberRegistration.rename!=null)
            {
                member.Name = member.MemberRegistration.rename;
            }
        }
    }
}


