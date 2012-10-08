using System;
using System.Collections.Generic;
using System.Linq;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using java.lang.reflect;
using StringBuilder = System.Text.StringBuilder;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    public class LeavesProcessor : ProcessorBase
    {
        public override Stage Stage
        {
            get { return Stage.S0300_FindLeaves; }
        }

        public override int Priority
        {
            get { return 0; }
        }

        public override void Process(IMType model)
        {
            if (model.IsGenerate || model.IsGenerateIfMissing)
            {
                model = model.IsClr
                            ? Clr(model)
                            : Jvm(model);

                Logger.LogVerbose(GetType().Name + " " + model, model);
                WorkQueue.Enqueue(model, Stage.S9999_Done);
            }
        }

        private IMType Clr(IMType model)
        {
            var clr = model.ClrReflection;

            model.Nested.Clear();
            model.Members.Clear();
            model.HomeView.Members.Clear();

            if (model.Registration.Parent.GenerateNestedClasses)
            {
                var nestedTypes = clr.GetNestedTypes().Where(x => x.IsNestedPublic);
                foreach (var nestedType in nestedTypes)
                {
                    IMType nestedModel = ClrResolver.ResolveModel(ClrResolver.FindPlainType(nestedType), model);
                    model.Nested.Add(nestedModel);

                    WorkQueue.Enqueue(nestedModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
                }
            }

            var members =
                clr.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                               BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var member in members)
            {
                ClrMember(model, member);
            }

            var regMap = new Dictionary<string, IMemberRegistration>();
            foreach (var memberRegistration in model.Registration.Members)
            {
                regMap.Add(memberRegistration.Signature.Replace(" ", ""), memberRegistration);
            }

            foreach (var memberModel in model.Members)
            {
                string signature = memberModel.ClrReflection.ToString().Replace(" ", "");
                IMemberRegistration reg;
                if (regMap.TryGetValue(signature, out reg))
                {
                    regMap.Remove(signature);
                    memberModel.Registration = reg;
                    for (int i = 0; i < reg.Parameters.Count; i++)
                    {
                        var par = reg.Parameters[i];
                        memberModel.HomeView.Parameters[i].ParameterRegistration = par;
                    }
                }
            }

            if (regMap.Count > 0)
            {
                foreach (var memberReg in regMap.Values)
                {
                    Logger.LogMessage("Can't find member " + memberReg.Signature + " on " + model, model);
                }

                var sb = new StringBuilder();
                foreach (var memberModel in model.Members)
                {
                    string signature = memberModel.ClrReflection.ToString();
                    sb.AppendLine(signature);
                }
                Logger.LogMessage("Available signatures are :\n" + sb, model);
            }

            return model;
        }

        private IMMember ClrMember(IMType model, MemberInfo clrMember, bool special=false)
        {
            var memberModel = new MMember(model, clrMember.Name);

            var clrField = clrMember as FieldInfo;
            var clrMethod = clrMember as MethodInfo;
            var clrProperty = clrMember as PropertyInfo;
            var clrEvent = clrMember as EventInfo;
            var clrConstructor = clrMember as ConstructorInfo;
            if (clrMethod != null)
            {
                if (clrMethod.IsSpecialName)
                {
                    if (!special)
                    {
                        return null;
                    }
                }
                else
                {
                    memberModel.IsMethod = true;
                }
                if (clrMethod.GetBaseDefinition() != clrMethod)
                {
                    return null;
                }
                if (!ClrReturn(model, memberModel, clrMethod.ReturnType))
                {
                    return null;
                }
                if (!ClrParams(model, memberModel, clrMethod.GetParameters()))
                {
                    return null;
                }
                var li = memberModel.Name.LastIndexOf('.');
                if (li > 0)
                {
                    memberModel.Name = memberModel.Name.Substring(li + 1, memberModel.Name.Length - li - 1);
                    //memberModel.ExplicitInterface = TODO;
                }
                memberModel.IsStatic = clrMethod.IsStatic;
                memberModel.IsVirtual = clrMethod.IsVirtual;
                memberModel.IsFinal = clrMethod.IsFinal;
                memberModel.IsPublic = clrMethod.IsPublic;
            }
            else if (clrConstructor != null)
            {
                if (!clrConstructor.IsPublic)
                {
                    return null;
                }
                if (clrConstructor.IsStatic)
                {
                    return null;
                }
                memberModel.IsConstructor = true;
                if (!ClrParams(model, memberModel, clrConstructor.GetParameters()))
                {
                    return null;
                }
            }
            else if (clrField != null)
            {
                if (!clrField.IsPublic)
                {
                    return null;
                }
                if (clrField.IsSpecialName)
                {
                    return null;
                }
                if (!ClrReturn(model, memberModel, clrField.FieldType))
                {
                    return null;
                }

                var property = new MProperty(model, clrField.Name);

                memberModel.IsStatic = clrField.IsStatic;
                memberModel.IsField = true;
                property.Get = memberModel;
                property.Get.Property = property;

                if (!clrField.IsInitOnly && !clrField.IsLiteral)
                {
                    property.Set = new MMember(model, clrMember.Name);
                    property.Set.ClrReflection = clrMember;
                    property.Set.IsObsolete = ClrIsObsolete(clrMember);
                    property.Set.IsStatic = clrField.IsStatic;
                    property.Set.Property = property;
                    property.Set.IsField = true;
                    property.Set.HomeView.Ret = new UTypeUsage(KnownTypes.ClrVoid.HomeView, model.HomeView);
                    IUTypeUsage par = ClrResolver.CreateUsage(clrField.FieldType, model.HomeView);
                    par.MethodParameterName = "value";
                    property.Set.HomeView.Parameters.Add(par);
                    model.Members.Add(property.Set);
                }
            }
            else if (clrProperty != null)
            {
                var property = new MProperty(model, clrProperty.Name);
                var li = property.Name.LastIndexOf('.');
                if (li > 0)
                {
                    property.Name = property.Name.Substring(li + 1, property.Name.Length - li - 1);
                    property.IsExplicitInterface = true;
                }
                var g = clrProperty.GetGetMethod(true);
                if (g != null)
                {
                    property.Get = ClrMember(model, g, true);
                    if (property.Get != null)
                    {
                        property.Get.IsProperty = true;
                        property.Get.Property = property;
                    }
                }
                var s = clrProperty.GetSetMethod(true);
                if (s != null)
                {
                    property.Set = ClrMember(model, s, true);
                    if (property.Set != null)
                    {
                        property.Set.IsProperty = true;
                        property.Set.Property = property;
                    }
                }
                return null;
            }
            else if (clrEvent != null)
            {
                var property = new MProperty(model, clrEvent.Name);
                var li = property.Name.LastIndexOf('.');
                if (li > 0)
                {
                    property.Name = property.Name.Substring(li + 1, property.Name.Length - li - 1);
                    property.IsExplicitInterface = true;
                }
                var g = clrEvent.GetAddMethod(true);
                if (g != null)
                {
                    property.Get = ClrMember(model, g, true);
                    if (property.Get != null)
                    {
                        property.Get.IsEvent = true;
                        property.Get.Property = property;
                    }
                }
                var s = clrEvent.GetRemoveMethod(true);
                if (s != null)
                {
                    property.Set = ClrMember(model, s, true);
                    if (property.Set != null)
                    {
                        property.Set.IsEvent = true;
                        property.Set.Property = property;
                    }
                }
                return null;
            }
            else
            {
                throw new NotImplementedException(clrMember.MemberType.ToString());
            }

            model.HomeView.Members.Add(new MMemberView(memberModel, ViewKind.Home));
            model.Members.Add(memberModel);
            memberModel.ClrReflection = clrMember;

            return memberModel;
        }

        private bool ClrReturn(IMType model, IMMember memberModel, Type type)
        {
            memberModel.HomeView.Ret = ClrResolver.CreateUsage(type, memberModel.DeclaringType.HomeView);
            memberModel.HomeView.Ret.IsReturn = true;
            return true;
        }

        private bool ClrParams(IMType model, IMMember memberModel, IEnumerable<ParameterInfo> parameterInfos)
        {
            foreach (ParameterInfo parameter in parameterInfos)
            {
                var prm = ClrResolver.CreateUsage(parameter, memberModel.DeclaringType.HomeView);
                prm.IsParameter = true;
                memberModel.HomeView.Parameters.Add(prm);
            }
            return true;
        }

        private Type obsolete;
        public bool ClrIsObsolete(MemberInfo member)
        {
            if (obsolete == null)
            {
                obsolete = ClrResolver.LoadType("System.ObsoleteAttribute");
            }
            return member.IsDefined(obsolete, true);
        }


        private IMType Jvm(IMType model)
        {
            var jvm = model.JvmReflection;

            model.Nested.Clear();
            model.Members.Clear();
            model.HomeView.Members.Clear();
            var nestedTypes = jvm.getDeclaredClasses().Where(x => x.IsPublic());
            foreach (var nestedType in nestedTypes)
            {
                IMType nestedModel = JvmResolver.ResolveModel(JvmResolver.FindPlainType(nestedType), model);
                model.Nested.Add(nestedModel);

                WorkQueue.Enqueue(nestedModel, model.IsGenerate || model.IsGenerateIfMissing, model.IsExplore);
            }

            var jvmConstructors = jvm.getConstructors().OrderBy(x => x.ToString());
            foreach (Constructor member in jvmConstructors)
            {
                JvmMember(model, member);
            }

            var jvmMethods = jvm.getMethods().OrderBy(x => !x.IsStatic()).ThenBy(x => x.getName().ToString());
            foreach (Method member in jvmMethods)
            {
                JvmMember(model, member);
            }
            var jvmFields = jvm.getFields().OrderBy(x => !x.IsStatic()).ThenBy(x => x.getName().ToString());
            foreach (Field member in jvmFields)
            {
                JvmMember(model, member);
            }

            var regMap = new Dictionary<string, IMemberRegistration>();
            foreach (var memberRegistration in model.Registration.Members)
            {
                regMap.Add(memberRegistration.Signature.Replace(" ", ""), memberRegistration);
            }

            foreach (var memberModel in model.Members)
            {
                string signature = memberModel.JvmReflection.ToString().Replace(" ", "");
                IMemberRegistration reg;
                if (regMap.TryGetValue(signature, out reg))
                {
                    regMap.Remove(signature);
                    memberModel.Registration = reg;
                    for (int i = 0; i < reg.Parameters.Count; i++)
                    {
                        var par = reg.Parameters[i];
                        memberModel.HomeView.Parameters[i].ParameterRegistration = par;
                    }
                }
            }

            if (regMap.Count > 0)
            {
                foreach (var memberReg in regMap.Values)
                {
                    Logger.LogMessage("Can't find member " + memberReg.Signature + " on " + model, model);
                }

                var sb = new StringBuilder();
                foreach (var memberModel in model.Members)
                {
                    string signature = memberModel.ClrReflection.ToString();
                    sb.AppendLine(signature);
                }
                Logger.LogMessage("Available signatures are :\n" + sb, model);
            }

            return model;
        }

        private IMMember JvmMember(IMType model, Member jvmMember)
        {
            var jvm = model.JvmReflection;
            var modifiers = (ModifierFlags)jvmMember.getModifiers();
            if (!EnumUtils.IsSet(modifiers, ModifierFlags.Public))
            {
                return null;
            }
            Class declaringClass = jvmMember.getDeclaringClass();
            if (!jvm.equals(declaringClass))
            {
                return null;
            }

            var memberModel = new MMember(model, jvmMember.getName());

            var constructor = jvmMember as Constructor;
            var field = jvmMember as Field;
            var method = jvmMember as Method;
            if (constructor!=null)
            {
                if (EnumUtils.IsSet(modifiers, ModifierFlags.Static))
                {
                    return null;
                }
                memberModel.IsConstructor = true;

                JvmParams(model, memberModel, constructor.getParameterTypes());
            }

            if(field!=null)
            {
                JvmReturn(model, memberModel, field.getType());
            }

            if (method!=null)
            {
                JvmParams(model, memberModel, method.getParameterTypes());
                JvmReturn(model, memberModel, method.getReturnType());
            }

            memberModel.JvmReflection = jvmMember;
            model.Members.Add(memberModel);
            model.HomeView.Members.Add(new MMemberView(memberModel, ViewKind.Home));
            return memberModel;
        }

        private bool JvmReturn(IMType model, IMMember memberModel, Class type)
        {
            memberModel.HomeView.Ret = JvmResolver.CreateUsage(type, memberModel.DeclaringType.HomeView);
            memberModel.HomeView.Ret.IsReturn = true;
            return true;
        }

        private bool JvmParams(IMType model, IMMember memberModel, Class[] pars)
        {
            for (int i = 0; i < pars.Length; i++)
            {
                Class parameter = pars[i];
                var prm = JvmResolver.CreateUsage(parameter, "par"+i, memberModel.DeclaringType.HomeView);
                prm.IsParameter = true;
                memberModel.HomeView.Parameters.Add(prm);
            }
            return true;
        }
    }
}
