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

using System.Collections.Generic;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Services.Compilation;
using polyglottos;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services;
using com.jni4net.proxygen.Services.Explorers;
using com.jni4net.proxygen.Services.Generators;
using com.jni4net.proxygen.Services.Renamers;
using com.jni4net.proxygen.Services.Resolvers;
using com.jni4net.proxygen.Services.Translators;
using com.jni4net.proxygen.Services.Tweakers;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen
{
    class Module : IModule
    {
        public void Init(IUnityContainer container)
        {
            container
                .RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager())
                .RegisterType<Configurator, Configurator>(new ContainerControlledLifetimeManager())
                .RegisterType<Proxygen>(new ContainerControlledLifetimeManager());

            container
                .RegisterType<ITypeRepository, TypeRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IKnownTypes, KnownTypes>(new ContainerControlledLifetimeManager())
                .RegisterType<IJvmResolver, JvmResolver>(new ContainerControlledLifetimeManager())
                .RegisterType<IClrResolver, ClrResolver>(new ContainerControlledLifetimeManager());
            container
                .RegisterType<IClassRenamer, JvmTypePairRenamer>("JvmTypePairRenamer")
                .RegisterType<IClassRenamer, ClrTypePairRenamer>("ClrTypePairRenamer")
                .RegisterType<IEnumerable<IClassRenamer>, IClassRenamer[]>();

            container
                .RegisterType<IModelHandler, ClrEnclosedExplorer>("ClrEnclosedExplorer")
                .RegisterType<IModelHandler, JvmEnclosedExplorer>("JvmEnclosedExplorer")

                .RegisterType<IModelHandler, ClrPairExplorer>("ClrPairExplorer")
                .RegisterType<IModelHandler, JvmPairExplorer>("JvmPairExplorer")

                .RegisterType<IModelHandler, ClrExtendsExplorer>("ClrExtendsExplorer")
                .RegisterType<IModelHandler, JvmExtendsExplorer>("JvmExtendsExplorer")

                .RegisterType<IModelHandler, ClrImplementsExplorer>("ClrImplementsExplorer")
                .RegisterType<IModelHandler, JvmImplementsExplorer>("JvmImplementsExplorer")

                .RegisterType<IModelHandler, ClrMembersExplorer>("ClrMembersExplorer")
                .RegisterType<IModelHandler, JvmMembersExplorer>("JvmMembersExplorer")

                .RegisterType<IEnumerable<IModelHandler>, IModelHandler[]>()
                .RegisterType<Explorer, Explorer>();


            container
                .RegisterType<IModelHandler, StartTweaker>("StartTweaker")
                .RegisterType<IModelHandler, LoadMemberConfigTweaker>("LoadMemberConfigTweaker")
                .RegisterType<IModelHandler, SubstituteTypeTweaker>("SubstituteTypeTweaker")
                .RegisterType<IModelHandler, ClrMembersTweaker>("ClrMembersTweaker")
                .RegisterType<IModelHandler, JvmMembersTweaker>("JvmMembersTweaker")
                ;

            container
                .RegisterType<IModelHandler, StartTranslator>("StartTranslator")
                .RegisterType<IModelHandler, BaseMethodsTranslator>("BaseMethodsTranslator")
                .RegisterType<IModelHandler, SubstituteTypeUsageTranslator>("SubstituteTypeUsageTranslator")
                .RegisterType<IModelHandler, JvmMoveNestedInInterfaceTranslator>("JvmMoveNestedInInterfaceTranslator")
                .RegisterType<IModelHandler, ClrSkipOrRenameDuplicateMembersTranslator>("ClrSkipOrRenameDuplicateMembersTranslator")
                .RegisterType<IModelHandler, JvmSkipOrRenameDuplicateMembersTranslator>("JvmSkipOrRenameDuplicateMembersTranslator")
                .RegisterType<IModelHandler, ConfigureMembersTranslator>("ConfigureMembersTranslator")
                .RegisterType<IModelHandler, ClrSubstitutePrimitiveTypeUsageTranslator>("ClrSubstitutePrimitiveTypeUsageTranslator")
                .RegisterType<IModelHandler, JvmSubstitutePrimitiveTypeUsageTranslator>("JvmSubstitutePrimitiveTypeUsageTranslator")
                .RegisterType<IModelHandler, ClrProxyCopyTranslator>("ClrInterfaceProxyCopyTranslator")
                .RegisterType<IModelHandler, JvmProxyCopyTranslator>("JvmInterfaceProxyCopyTranslator")
                ;

            container
                .RegisterType<IModelHandler, StartGenerator>("StartGenerator")
                .RegisterType<IModelHandler, ClrInterfaceGenerator>("ClrInterfaceGenerator")
                .RegisterType<IModelHandler, JvmInterfaceGenerator>("JvmInterfaceGenerator")
                .RegisterType<IModelHandler, JvmClassGenerator>("JvmClassGenerator")
                .RegisterType<IModelHandler, ClrClassGenerator>("ClrClassGenerator")
                .RegisterType<IModelHandler, MethodGenerator>("MethodGenerator")
                .RegisterType<IModelHandler, DumpFilesGenerator>("DumpFilesGenerator")
                .RegisterType<GTypeUsageGenerator, GTypeUsageGenerator>("GTypeUsageGenerator")
                ;

            container
                .RegisterType<BaseJavaGenerator, BaseJavaGenerator>()
                .RegisterType<BaseCSharpGenerator, BaseCSharpGenerator>()
                .RegisterType<IGProject, GProjectCSharpJ4N>("GProjectCSharp")
                .RegisterType<IGProject, GGProjectJavaJ4N>("GProjectJava")
                ;

            container
                .RegisterType<ProjectsGenerator, ProjectsGenerator>(new ContainerControlledLifetimeManager())
                ;
            

        }
    }
}
