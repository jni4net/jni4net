using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using java.lang;

namespace com.jni4net.proxygen.Model
{
    public class MTypeView : IMTypeView
    {
        public MTypeView(IMType owner, ViewKind viewKind)
        {
            Owner = owner;
            ViewKind = viewKind;
            Interfaces=new List<IUTypeUsage>();
            Members=new List<IMMemberView>();
            Name=new NTypeName();
        }

        public ViewKind ViewKind { get; set; }
        public IMType Owner { get; set; }
        public INTypeName Name { get; set; }

        public IUTypeUsage Base { get; set; }
        public List<IMMemberView> Members { get; set; }
        public List<IUTypeUsage> Interfaces { get; set; }

        #region forward to owner

        List<IMType> IMType.Interfaces
        {
            get { return Owner.Interfaces; }
        }

        List<IMType> IMType.Nested
        {
            get { return Owner.Nested; }
        }

        List<IMMember> IMType.Members
        {
            get { return Owner.Members; }
        }

        IMType IMType.Base
        {
            get { return Owner.Base; }
            set { Owner.Base = value; }
        }

        public IMTypeView HomeView {
            get { return Owner.HomeView; }
        }

        public IMTypeView ForeignView {
            get { return Owner.ForeignView; }
        }

        IMType IMType.Enclosing
        {
            get { return Owner.Enclosing; }
            set { Owner.Enclosing = value; }
        }

        public Stage Stage
        {
            get { return Owner.Stage; }
            set { Owner.Stage = value; }
        }
        
        public Class JvmReflection
        {
            get { return Owner.JvmReflection; }
            set { Owner.JvmReflection = value; }
        }
        
        public Type ClrReflection 
        {
            get { return Owner.ClrReflection; }
            set { Owner.ClrReflection = value; }
        }

        public IMType Parent
        {
            get { return Owner.Parent; }
            set { Owner.Parent = value; }
        }

        public IMType Substitution
        {
            get { return Owner.Substitution; }
            set { Owner.Substitution = value; }
        }

        public Dictionary<ViewKind, IMTypeView> Views
        {
            get { return Owner.Views; }
        }

        public bool IsClr
        {
            get { return Owner.IsClr; }
            set { Owner.IsClr = value; }
        }
        public bool IsJvm
        {
            get { return Owner.IsJvm; }
            set { Owner.IsJvm = value; }
        }

        public bool IsSideLocked
        {
            get { return Owner.IsSideLocked; }
            set { Owner.IsSideLocked = value; }
        }

        public bool IsQueueing
        {
            get { return Owner.IsQueueing; }
            set { Owner.IsQueueing = value; }
        }

        public bool IsGenerate
        {
            get { return Owner.IsGenerate; }
            set { Owner.IsGenerate = value; }
        }

        public bool IsGenerateIfMissing
        {
            get { return Owner.IsGenerateIfMissing; }
            set { Owner.IsGenerateIfMissing = value; }
        }

        public bool IsExplore
        {
            get { return Owner.IsExplore; }
            set { Owner.IsExplore = value; }
        }

        public bool IsVerbose
        {
            get { return Owner.IsVerbose; }
            set { Owner.IsVerbose = value; }
        }

        public ITypeRegistration Registration
        {
            get { return Owner.Registration; }
            set { Owner.Registration = value; }
        }


        public override string ToString()
        {
            return Owner.ToString();
        }

        public bool IsAssignableFrom(IMType other, bool substitutions = false)
        {
            return Owner.IsAssignableFrom(other, substitutions);
        }

        public bool IsNestedIn(IMType other, bool substitutions = false)
        {
            return Owner.IsNestedIn(other, substitutions);
        }

        #endregion
    }
}