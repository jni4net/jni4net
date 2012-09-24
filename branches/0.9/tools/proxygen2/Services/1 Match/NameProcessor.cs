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
            get { return Stage.S0200_ToMatch; }
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
            
            if(model.IsClr)
            {
                Clr(model, home, foreign);
            }
            else
            {
                Jvm(model, home, foreign);
            }

            Logger.LogMessage("Name", model);
        }

        private void Clr(IMType model, MTypeView home, MTypeView foreign)
        {
            var homeName = CreateClrName(model.ClrType);
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

            IMType foreignModel = JvmResolver.ResolveModel(foreignName.ToString());
            if (foreignModel!=null)
            {
                if (ReflectionUtils.DetectIsClr(foreignModel.JvmType, model.ClrType))
                {
                    model.JvmType = foreignModel.JvmType;
                    JvmResolver.UpdateModel(model);
                    WorkQueue.Enqueue(foreignModel, Stage.S9999_Done);
                }
                else
                {
                    foreignModel.ClrType = model.ClrType;
                    ClrResolver.UpdateModel(foreignModel);
                    WorkQueue.Enqueue(model, Stage.S9999_Done);
                    model = foreignModel;
                }
            }
            WorkQueue.Enqueue(model, Stage.S0300_FindBase);
        }

        private void Jvm(IMType model, MTypeView home, MTypeView foreign)
        {
            var homeName = CreateJvmName(model.JvmType);
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

            IMType foreignModel = ClrResolver.ResolveModel(foreignName.ToString());
            if (foreignModel != null)
            {
                if (!ReflectionUtils.DetectIsClr(model.JvmType, foreignModel.ClrType))
                {
                    model.ClrType = foreignModel.ClrType;
                    ClrResolver.UpdateModel(model);
                    WorkQueue.Enqueue(foreignModel, Stage.S9999_Done);
                }
                else
                {
                    foreignModel.JvmType = model.JvmType;
                    JvmResolver.UpdateModel(foreignModel);
                    WorkQueue.Enqueue(model, Stage.S9999_Done);
                    model = foreignModel;
                }
            }
            WorkQueue.Enqueue(model, Stage.S0300_FindBase);
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
