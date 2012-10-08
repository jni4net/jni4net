using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using java.lang;
using StringBuilder = System.Text.StringBuilder;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Model
{
    public class MType : IMType
    {
        public MType(IMType father)
        {
            Interfaces=new List<IMType>();
            Views=new Dictionary<ViewKind, IMTypeView>();
            Members=new List<IMMember>();
            Registration = new TypeRegistration
                {IsSyntetic = true, Parent = father == null ? null : father.Registration.Parent};
            Nested=new List<IMType>();
            HomeView=new MTypeView(this, ViewKind.Home);
            ForeignView = new MTypeView(this, ViewKind.Foreign);
            Views.Add(ViewKind.Home,HomeView);
            Views.Add(ViewKind.Foreign,ForeignView);
        }

        public Stage Stage { get; set; }

        public bool IsGenerate { get; set; }
        public bool IsGenerateIfMissing { get; set; }
        public bool IsExplore { get; set; }
        public bool IsQueueing { get; set; }
        public bool IsVerbose { get; set; }
        public Class JvmReflection { get; set; }
        public Type ClrReflection { get; set; }
        public bool IsClr { get; set; }
        public bool IsJvm { get { return !IsClr; } set { IsClr = !value; } }
        public bool IsSideLocked { get; set; }

        public IMType Parent { get; set; }
        public IMType Base { get; set; }
        public IMTypeView HomeView { get; private set; }
        public IMTypeView ForeignView { get; private set; }
        public IMType Enclosing { get; set; }
        public List<IMType> Interfaces { get; set; }
        public List<IMType> Nested { get; set; }
        public Dictionary<ViewKind, IMTypeView> Views { get; set; }
        public List<IMMember> Members { get; set; }
        public ITypeRegistration Registration { get; set; }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.Append(IsClr? ClrReflection.FullName : JvmReflection.getName());
            sb.Append('{');
            if(IsGenerate)
            {
                sb.Append('G');
            }
            else if(IsGenerateIfMissing)
            {
                sb.Append('g');
            }
            else if (IsExplore)
            {
                sb.Append('e');
            }
            else
            {
                sb.Append(' ');
            }
            if (IsClr)
            {
                sb.Append('C');
                sb.Append(JvmReflection != null ? 'j' : ' ');
            }
            else
            {
                sb.Append(ClrReflection != null ? 'c' : ' ');
                sb.Append('J');
            }
            //sb.Append(' ');
            //sb.Append(GetHashCode());
            sb.Append('}');
            return sb.ToString();
        }

        public bool IsAssignableFrom(IMType other, bool substitutions = false)
        {
            if (other == null) return false;
            if (Stage <= Stage.S0200_FindRoots || other.Stage <= Stage.S0200_FindRoots)
                throw new InvalidOperationException("Too early");
            if (other == this) return true;
            if (IsAssignableFrom(other.Base, substitutions)) 
                return true;
            if (other.Interfaces.Any(ifc=>IsAssignableFrom(ifc,substitutions))) 
                return true;
            if(substitutions)
                throw new NotImplementedException();
            return false;
        }

        public bool IsNestedIn(IMType other, bool substitutions = false)
        {
            if (other == null) return false;
            if (Stage <= Stage.S0200_FindRoots || other.Stage <= Stage.S0200_FindRoots)
                throw new InvalidOperationException("Too early");
            if (Enclosing == null) return false;
            if (other == this) return false;
            if (Enclosing == other) 
                return true;
            if (Enclosing.IsNestedIn(other, substitutions)) 
                return true;
            if (substitutions)
                throw new NotImplementedException();
            return false;
        }
    }
}
