using System;
using System.Collections.Generic;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using StringBuilder = System.Text.StringBuilder;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    public class NameProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S0100_ToMatch; }
        }

        public override int Priority
        {
            get { return 0; }
        }

        public override void Process(IMType model)
        {
            var foreign = new MTypeView(model, ViewKind.Foreign);
            var home = new MTypeView(model, ViewKind.Home);
            model.Views[ViewKind.Foreign] = foreign;
            model.Views[ViewKind.Home] = home;
            
            model = model.IsClr 
                ? Clr(model, home, foreign) 
                : Jvm(model, home, foreign);

            Logger.LogVerbose(GetType().Name + " " + model, model);
            WorkQueue.Enqueue(model, Stage.S0200_FindBase);
        }

        private IMType Clr(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var homeName = CreateClrName(model.ClrReflection);
            home.Name = homeName;

            var foreignName = new NTypeName(homeName);
            foreign.Name = foreignName;
            for (int i = 0; i < foreignName.Namespaces.Count; i++)
            {
                foreignName.Namespaces[i] = foreignName.Namespaces[i].ToLowerInvariant();
            }
            if (model.Registration.Rename != null)
            {
                foreignName.Name = model.Registration.Rename;
            }
            if (model.Registration.Move != null)
            {
                foreignName.Namespaces = new List<string>(model.Registration.Move.Split('.'));
            }

            IMType foreignModel = JvmResolver.ResolveModel(foreignName.ToString(), model);
            if (foreignModel!=null)
            {
                if (ReflectionUtils.DetectIsClr(foreignModel.JvmReflection, model.ClrReflection))
                {
                    model.JvmReflection = foreignModel.JvmReflection;
                    JvmResolver.UpdateModel(model);
                    WorkQueue.Enqueue(foreignModel, Stage.S9999_Done);
                }
                else
                {
                    foreignModel.ClrReflection = model.ClrReflection;
                    ClrResolver.UpdateModel(foreignModel);
                    WorkQueue.Enqueue(model, Stage.S9999_Done);
                    model = foreignModel;
                }
            }
            return model;
        }

        private IMType Jvm(IMType model, IMTypeView home, IMTypeView foreign)
        {
            var homeName = CreateJvmName(model.JvmReflection);
            home.Name = homeName;

            var foreignName = new NTypeName(homeName);
            foreign.Name = foreignName;
            for (int i = 0; i < foreignName.Namespaces.Count; i++)
            {
                foreignName.Namespaces[i] = CamelCase(foreignName.Namespaces[i]);
            }
            if(model.Registration.Rename!=null)
            {
                foreignName.Name = model.Registration.Rename;
            }
            if (model.Registration.Move != null)
            {
                foreignName.Namespaces = new List<string>(model.Registration.Move.Split('.'));
            }

            IMType foreignModel = ClrResolver.ResolveModel(foreignName.ToString(), model);
            if (foreignModel != null)
            {
                if (!ReflectionUtils.DetectIsClr(model.JvmReflection, foreignModel.ClrReflection))
                {
                    model.ClrReflection = foreignModel.ClrReflection;
                    ClrResolver.UpdateModel(model);
                    WorkQueue.Enqueue(foreignModel, Stage.S9999_Done);
                }
                else
                {
                    foreignModel.JvmReflection = model.JvmReflection;
                    JvmResolver.UpdateModel(foreignModel);
                    WorkQueue.Enqueue(model, Stage.S9999_Done);
                    model = foreignModel;
                }
            }
            return model;
        }

        private static NTypeName CreateClrName(Type clrType)
        {
            var homeName = new NTypeName();
            homeName.Name = clrType.Name;
            homeName.Namespaces.AddRange(clrType.Namespace.Split('.'));
            if (clrType.IsNested)
            {
                throw new NotImplementedException();
            }
            return homeName;
        }

        private static NTypeName CreateJvmName(Class jvmType)
        {
            var name = new NTypeName();
            name.Name = jvmType.GetShortName();
            name.Namespaces.AddRange(jvmType.GetPackageName().Split('.'));
            if (jvmType.IsNested())
            {
                throw new NotImplementedException();
            }
            return name;
        }

        private string CamelCase(string nmspace)
        {
            // attempt to guess it
            if (nmspace == "io")
            {
                return "IO";
            }
            var sb = new StringBuilder(nmspace);
            sb[0] = Char.ToUpperInvariant(sb[0]);
            return sb.ToString();
        }
    }
}
