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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using java.lang.reflect;
using Microsoft.Practices.Unity;
using String = java.lang.String;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class JvmMembersTweaker : BaseHandler
    {
        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P1000_TweakerStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 110; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate
                   && model.IsJvm
                ;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if (model.IsInterface)
            {
                foreach (var member in model.Exploration.Members)
                {
                    member.ImplementsInterfaces.Add(model.Exploration.Declaration);
                    member.ImplementsMember.Add(member);
                }
                return false;
            }

            var methodMap = new Dictionary<Method, KeyValuePair<MMember, UTypeUsage>>();
            BuildMap(model, methodMap);

            foreach (var member in model.Exploration.Members)
            {
                if (member.IsMethod && !member.IsStatic)
                {
                    var jvmMethod = (Method)member.JvmReflection;
                    var methodName = jvmMethod.getName();
                    Class[] pars = jvmMethod.getParameterTypes();

                    FindInterface(methodMap, member, model, methodName, pars);
                }
            }
            return false;
        }

        private static void FindInterface(Dictionary<Method, KeyValuePair<MMember, UTypeUsage>> methodMap, MMember member, MType model, String methodName, Class[] pars)
        {
            foreach (var ifc in model.Exploration.Interfaces)
            {
                if(!ifc.IsJvmSkip && !ifc.Root.IsExcluded)
                {
                    KeyValuePair<MMember, UTypeUsage> src;
                    Method superMethod = ReflectionUtils.GetMethodNoThrow(ifc.Root.JvmReflection, methodName, pars);
                    if (superMethod != null && methodMap.TryGetValue(superMethod, out src))
                    {
                        member.ImplementsMember.Add(src.Key);
                        member.ImplementsInterfaces.Add(src.Value);
                        break;
                    }
                }
                FindInterface(methodMap, member, ifc.Root, methodName, pars);
            }
            if (model.Exploration.Base != null && !model.Exploration.Base.IsJvmSkip)
            {
                FindInterface(methodMap, member, model.Exploration.Base.Root, methodName, pars);
            }
        }

        private static void BuildMap(MType model, Dictionary<Method, KeyValuePair<MMember, UTypeUsage>> methodMap)
        {
            if (model.Exploration.Base!=null)
            {
                BuildMap(model.Exploration.Base.Root, methodMap);
            }

            foreach (var ifc in model.Exploration.Interfaces)
            {
                BuildMap(ifc.Root, methodMap);
                foreach (var member in ifc.Root.Exploration.Members)
                {
                    if(member.IsMethod)
                    {
                        var jvmMethod = (Method)member.JvmReflection;
                        if (jvmMethod!=null && !methodMap.ContainsKey(jvmMethod))
                        {
                            methodMap.Add(jvmMethod, new KeyValuePair<MMember, UTypeUsage>(member, ifc));
                        }
                    }
                }
            }
        }
    }
}
