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

        List<IMMember> IMType.Members
        {
            get { return Owner.Members; }
        }

        IMType IMType.Base
        {
            get { return Owner.Base; }
            set { Owner.Base = value; }
        }

        public Stage Stage
        {
            get { return Owner.Stage; }
            set { Owner.Stage = value; }
        }
        
        public Class JvmType
        {
            get { return Owner.JvmType; }
            set { Owner.JvmType = value; }
        }
        
        public Type ClrType 
        {
            get { return Owner.ClrType; }
            set { Owner.ClrType = value; }
        }

        public IMType Parent
        {
            get { return Owner.Parent; }
            set { Owner.Parent = value; }
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

        #endregion
    }
}