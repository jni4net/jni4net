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
            model = model.IsClr 
                ? Clr(model) 
                : Jvm(model);

            Logger.LogVerbose(GetType().Name + " " + model, model);
            WorkQueue.Enqueue(model, Stage.S0200_FindRoots);
        }

        private IMType Clr(IMType model)
        {
            var homeName = CreateClrName(model.ClrReflection);
            model.HomeView.Name = homeName;

            var foreignName = new NTypeName(homeName);
            model.ForeignView.Name = foreignName;
            if (model.Registration.Rename != null)
            {
                foreignName.Name = model.Registration.Rename;
            }
            if (model.Registration.Move != null)
            {
                foreignName.Namespaces = new List<string>(model.Registration.Move.Split('.'));
            }
            else
            {
                for (int i = 0; i < foreignName.Namespaces.Count; i++)
                {
                    foreignName.Namespaces[i] = foreignName.Namespaces[i].ToLowerInvariant();
                }
            }

            IMType foreignModel = JvmResolver.ResolveModel(foreignName.ToString(), model);
            if (foreignModel!=null)
            {
                model.ForeignView.Name = CreateJvmName(foreignModel.JvmReflection);
                var detectIsClr = ReflectionUtils.DetectIsClr(foreignModel.JvmReflection, model.ClrReflection);
                if(foreignModel!=model)
                {
                    throw new NotImplementedException();
                    // need to kill one of them and remap all usages so far
                    if (detectIsClr)
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
                        foreignModel.ForeignView.Name = model.HomeView.Name;
                        model = foreignModel;
                    }
                    foreignModel.IsClr = detectIsClr;
                    foreignModel.IsSideLocked = true;
                }
                model.IsClr = detectIsClr;
                model.IsSideLocked = true;
            }
            return model;
        }

        private IMType Jvm(IMType model)
        {
            var homeName = CreateJvmName(model.JvmReflection);
            model.HomeView.Name = homeName;

            var foreignName = new NTypeName(homeName);
            model.ForeignView.Name = foreignName;
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
                model.ForeignView.Name = CreateClrName(foreignModel.ClrReflection);
                var detectIsClr = ReflectionUtils.DetectIsClr(model.JvmReflection, foreignModel.ClrReflection);
                if(foreignModel!=model)
                {
                    throw new NotImplementedException();
                    // need to kill one of them and remap all usages so far
                    if (!detectIsClr)
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
                        foreignModel.ForeignView.Name = model.HomeView.Name;
                        model = foreignModel;
                    }
                    foreignModel.IsClr = detectIsClr;
                    foreignModel.IsSideLocked = true;
                }
                model.IsClr = detectIsClr;
                model.IsSideLocked = true;
            }
            return model;
        }

        private static NTypeName CreateClrName(Type clrType)
        {
            var name = new NTypeName();
            name.Name = clrType.Name;
            name.Namespaces.AddRange(clrType.Namespace.Split('.'));

            var decl = clrType.DeclaringType;
            while (decl != null)
            {
                name.Enclosing.Insert(0, decl.Name);
                decl = decl.DeclaringType;
            }
            
            return name;
        }

        private static NTypeName CreateJvmName(Class jvmType)
        {
            var name = new NTypeName();
            name.Name = jvmType.GetShortName();
            name.Namespaces.AddRange(jvmType.GetPackageName().Split('.'));

            var decl = jvmType.getDeclaringClass();
            while (decl!=null)
            {
                name.Enclosing.Insert(0, decl.GetShortName());
                decl = decl.getDeclaringClass();
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
