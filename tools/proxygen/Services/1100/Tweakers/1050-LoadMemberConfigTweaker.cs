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
using System.Text;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class LoadMemberConfigTweaker : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P1000_TweakerStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.TypeRegistration.member.Count > 0;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if (model.TypeRegistration.verbose)
            {
                model.IsVerbose = true;
            }
            var regMap=new Dictionary<string, MemberRegistration>();
            foreach (var memberRegistration in model.TypeRegistration.member)
            {
                regMap.Add(memberRegistration.signature.Replace(" ",""), memberRegistration);
            }

            foreach (var member in model.Exploration.Members)
            {
                MemberRegistration reg;
                string signature = model.IsClr
                                       ? member.ClrReflection.ToString()
                                       : member.JvmReflection.ToString();
                if (regMap.TryGetValue(signature.Replace(" ", ""), out reg))
                {
                    regMap.Remove(reg.signature.Replace(" ", ""));
                    member.MemberRegistration = reg;
                    if (reg.exclude)
                    {
                        if (model.IsClr)
                        {
                            member.IsJvmSkip = true;
                        }
                        else
                        {
                            member.IsClrSkip = true;
                        }
                    }

                    if (reg.ret != null && member.Return!=null)
                    {
                        member.Return.ParameterRegistration = reg.ret;
                    }

                    for (int i = 0; i < reg.parameter.Count; i++)
                    {
                        member.Params[i].ParameterRegistration = reg.parameter[i];
                    }
                }
            }
            if (regMap.Count>0)
            {
                foreach (var memberReg in regMap.Values)
                {
                    Logger.LogMessage("Can't find member " + memberReg.signature + " on " + model, model);
                }

                var sb=new StringBuilder();
                foreach (var member in model.Exploration.Members)
                {
                    string signature = model.IsClr
                                           ? member.ClrReflection.ToString()
                                           : member.JvmReflection.ToString();
                    sb.AppendLine(signature);
                }
                Logger.LogMessage("Available signatures are :\n" + sb, model);
            }

            return false;
        }
    }
}
