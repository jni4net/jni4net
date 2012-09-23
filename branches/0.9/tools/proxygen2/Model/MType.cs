using System.Collections.Generic;
using com.jni4net.proxygen.Interfaces;
using java.lang;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Model
{
    public class MType : IMType
    {
        public bool IsGenerate { get; set; }
        public bool IsExplore { get; set; }
        public bool IsVerbose { get; set; }
        public Class JvmType { get; set; }
        public Type ClrType { get; set; }
        public bool IsClr { get; set; }
        public bool IsJvm { get { return !IsClr; } set { IsClr = !value; } }

        public IMType Parent { get; set; }
        public IMType Base { get; set; }
        public List<IMType> Interfaces { get; set; }
        public Dictionary<ViewKind,IMTypeView> Views { get; set; }
        public List<IMMember> Members { get; set; }
        public ITypeRegistration Registration { get; set; }

        public override string ToString()
        {
            return IsClr 
                ? ClrType.FullName 
                : JvmType.getName();
        }
    }

    public class MTypeView : IMTypeView
    {
        public MTypeView(IMType owner, ViewKind viewKind)
        {
            Owner = owner;
            ViewKind = viewKind;
            Interfaces=new List<IMType>();
            Members=new List<IMMember>();
        }

        public ViewKind ViewKind { get; set; }

        public IMType Owner { get; set; }

        public List<IMType> Interfaces { get; set; }
        public List<IMMember> Members { get; set; }


        #region forward to owner

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

        public IMType Base
        {
            get { return Owner.Base; }
            set { Owner.Base = value; }
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
