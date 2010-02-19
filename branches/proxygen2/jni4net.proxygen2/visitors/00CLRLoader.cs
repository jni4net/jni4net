using System;
using System.Reflection;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.visitors
{
    public class CLRLoader : BaseModelVisitor
    {
        public override void VisitAssembly(MAssembly assembly, Repository repository)
        {
            if(assembly.Clr==null)
            {
                return;
            }
            Assembly clrAssembly = assembly.Clr.Assembly;
            foreach (Type clrType in clrAssembly.GetTypes())
            {
                if (!clrType.IsOKType())
                {
                    continue;
                }
                MType type = repository.AddOrResolve(clrType);
                assembly.Types.Add(type);
            }
        }

        public override void VisitType(MType type, Repository repository)
        {
            if (type.Clr==null)
            {
                return;
            }
            Type clrType = type.Clr;

            //info
            type.IsInterface = clrType.IsInterface;
            type.IsAbstract = clrType.IsAbstract;
            type.IsFinal = clrType.IsSealed;
            type.IsNested = clrType.IsNested;
            type.IsPrimitive = clrType.IsPrimitive;
            if (typeof(Delegate).IsAssignableFrom(clrType) && typeof(Delegate) != clrType && typeof(MulticastDelegate) != clrType)
            {
                type.IsDelegate = true;
            }
            type.IsException = typeof(Exception).IsAssignableFrom(clrType);


            //base type
            if (clrType.BaseType != null)
            {
                type.Base = repository.AddOrResolve(clrType.BaseType);
            }

            //array
            if (clrType.IsArray)
            {
                type.IsArray = true;
                type.Element = repository.AddOrResolve(clrType.GetElementType());
            }

            //interfaces
            foreach (Type ifcClr in clrType.GetInterfaces())
            {
                if (ifcClr.IsAssignableFrom(clrType.BaseType))
                {
                    continue;
                }
                MType ifc = repository.AddOrResolve(ifcClr);
                type.Interfaces.Add(ifc);
            }

            //nested types
            if (clrType.IsNested)
            {
                int pos = clrType.FullName.LastIndexOf('+');
                Type encl = clrType.Assembly.GetType(clrType.FullName.Substring(0, pos));
                type.Enclosing = repository.AddOrResolve(encl);
                type.Enclosing.IsGenClr |= type.IsGenClr;
                type.Enclosing.IsGenJvm |= type.IsGenJvm;
            }
            foreach (Type nestedTypeClr in clrType.GetNestedTypes())
            {
                if (!nestedTypeClr.IsOKType())
                {
                    continue;
                }
                MType nestedType = repository.AddOrResolve(nestedTypeClr);
                nestedType.IsNested = true;
                nestedType.Enclosing = type;
                nestedType.IsGenClr |= type.IsGenClr;
                nestedType.IsGenJvm |= type.IsGenJvm;
                type.NextedTypes.Add(nestedType);
            }

            //methods
            foreach (MethodInfo methodInfo in clrType.GetMethods())
            {
                if (methodInfo.DeclaringType != clrType && clrType != typeof(Exception))
                {
                    continue;
                }
                if (methodInfo.IsSpecialName)
                {
                    continue;
                }
                if (!methodInfo.IsPublic)
                {
                    //TODO explicit interface - non public?
                    continue;
                }
                if (methodInfo.HasAttribute(Known.JavaMethodAttribute) != null)
                {
                    continue;
                }
                MMember member = new MMember(type, methodInfo);
                if (methodInfo.IsGenericMethod)
                {
                    type.SkippedMethods.Add(member);
                }
                else
                {
                    type.Methods.Add(member);
                    repository.AddOrResolve(member);
                }
            }

            //events
            foreach (EventInfo eventInfo in clrType.GetEvents())
            {
                if (eventInfo.DeclaringType != clrType)
                {
                    continue;
                }
                if (eventInfo.EventHandlerType.IsGenericType)
                {
                    type.SkippedMethods.Add(new MMember(type, eventInfo));
                }
                MMember rem = null;
                MMember add = null;

                MethodInfo addInfo = eventInfo.GetAddMethod();
                if (addInfo != null && addInfo.IsPublic)
                {
                    add = new MMember(type, addInfo);
                    add.Clr.EventInfo = eventInfo;
                    type.Methods.Add(add);
                    repository.AddOrResolve(add);
                }

                MethodInfo remInfo = eventInfo.GetRemoveMethod();
                if (remInfo != null && remInfo.IsPublic)
                {
                    rem = new MMember(type, remInfo);
                    rem.Clr.EventInfo = eventInfo;
                    type.Methods.Add(rem);
                    repository.AddOrResolve(rem);
                }

                if (add!=null && rem!=null)
                {
                    add.Pair = rem;
                    rem.Pair = add;
                }
            }

            //properties
            foreach (PropertyInfo propertyInfo in clrType.GetProperties())
            {
                if (propertyInfo.DeclaringType != clrType)
                {
                    continue;
                }
                if (propertyInfo.PropertyType.IsGenericType)
                {
                    type.SkippedMethods.Add(new MMember(type, propertyInfo));
                }
                MMember get = null;
                MMember set = null;
                MethodInfo getInfo = propertyInfo.GetGetMethod();
                if (getInfo != null && getInfo.IsPublic)
                {
                    get = new MMember(type, getInfo);
                    get.Clr.PropertyInfo = propertyInfo;
                    type.Methods.Add(get);
                    repository.AddOrResolve(get);
                }

                MethodInfo setInfo = propertyInfo.GetSetMethod();
                if (setInfo != null && setInfo.IsPublic)
                {
                    set = new MMember(type, setInfo);
                    set.Clr.PropertyInfo = propertyInfo;
                    type.Methods.Add(set);
                    repository.AddOrResolve(set);
                }
                if (get != null && set!=null)
                {
                    set.Pair = get;
                    get.Pair = set;
                }
            }

            foreach (ConstructorInfo constructorInfo in clrType.GetConstructors())
            {
                if (constructorInfo.DeclaringType != clrType)
                {
                    continue;
                }
                if (constructorInfo.HasAttribute(Known.JavaMethodAttribute) != null)
                {
                    continue;
                }
                
            }

            //todo fields
        }

        public override void VisitMember(MMember member, Repository repository)
        {
            if (member.Clr==null)
            {
                return;
            }
            if (member.Clr.MethodInfo != null)
            {
                VisitMethodInfo(member, repository);
            }
            if (member.Clr.EventInfo != null)
            {
                VisitEventInfo(member, repository);
            }
        }

        private static void VisitEventInfo(MMember member, Repository repository)
        {
            EventInfo eventInfo = member.Clr.EventInfo;
            if (!eventInfo.EventHandlerType.IsOKType())
            {
                member.Parent.Methods.Remove(member);
                member.Parent.SkippedMethods.Add(member);
                return;
            }
        }

        private static void VisitMethodInfo(MMember member, Repository repository)
        {
            MethodInfo methodInfo = member.Clr.MethodInfo;
            if (methodInfo.ReturnType != null)
            {
                if (!methodInfo.ReturnType.IsOKType())
                {
                    member.Parent.Methods.Remove(member);
                    member.Parent.SkippedMethods.Add(member);
                    return;
                }
                MType rType = repository.AddOrResolve(methodInfo.ReturnType);
                MParameter rpar = new MParameter(rType, "--return--");
                member.ReturnParameter = rpar;
                repository.AddOrResolve(rpar);
            }
            else
            {
                member.IsVoid = true;
            }
            member.IsStatic = methodInfo.IsStatic;

            ParameterInfo[] pars = methodInfo.GetParameters();
            for (int i = 0; i < pars.Length; i++)
            {
                ParameterInfo parameterInfo = pars[i];
                Type parameterType = parameterInfo.ParameterType;
                if (!parameterType.IsOKType())
                {
                    member.Parent.Methods.Remove(member);
                    member.Parent.SkippedMethods.Add(member);
                    return;
                }
                bool isOut = false;
                bool isRef = false;
                // we ignore IsOut when IsIn is set as well, because they are probably just attributes
                // see System.IO.TextReader.Read([In, Out] char[] buffer, int index, int count)
                if (parameterInfo.IsOut && !parameterInfo.IsIn)
                {
                    parameterType = parameterType.GetElementType();
                    isOut = true;
                }
                else if (parameterType.IsByRef)
                {
                    parameterType = parameterType.GetElementType();
                    isRef = true;
                }

                MType pType = repository.AddOrResolve(parameterType);
                string name = parameterInfo.Name;
                if (name == null)
                {
                    name = pType.Name.ToLower() +"_"+ i;
                }
                MParameter par = new MParameter(pType, name);
                par.IsOut = isOut;
                par.IsRef = isRef;
                member.Parameters.Add(par);
                repository.AddOrResolve(par);
            }
        }
    }
}
