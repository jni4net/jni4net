using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using java.lang.reflect;

namespace com.jni4net.proxygen.Model
{
    public class MMemberView : IMMemberView
    {
        public MMemberView(IMMember owner, ViewKind viewKind)
        {
            Owner = owner;
            ViewKind = viewKind;
            Parameters=new List<IUTypeUsage>();
        }

        public ViewKind ViewKind { get; set; }

        public IMMember Owner { get; set; }

        public string Name { get; set; }

        public IUTypeUsage Ret { get; set; }
        public List<IUTypeUsage> Parameters { get; set; }
        public IEnumerable<IUTypeUsage> RetAndParams
        {
            get
            {
                return Ret == null
                           ? Parameters
                           : new List<IUTypeUsage>(Parameters) { Ret };
            }
        }

        #region forward to owner

        public IMemberRegistration Registration
        {
            get { return Owner.Registration; }
            set { Owner.Registration = value; }
        }

        public IMType DeclaringType
        {
            get { return Owner.DeclaringType; }
            set { Owner.DeclaringType = value; }
        }

        public MemberInfo ClrReflection
        {
            get { return Owner.ClrReflection; }
            set { Owner.ClrReflection = value; }
        }

        public Member JvmReflection
        {
            get { return Owner.JvmReflection; }
            set { Owner.JvmReflection = value; }
        }

        public bool IsEvent
        {
            get { return Owner.IsEvent; }
            set { Owner.IsEvent = value; }
        }

        public bool IsField
        {
            get { return Owner.IsField; }
            set { Owner.IsField = value; }
        }

        public bool IsConstructor
        {
            get { return Owner.IsConstructor; }
            set { Owner.IsConstructor = value; }
        }

        public bool IsFinal
        {
            get { return Owner.IsFinal; }
            set { Owner.IsFinal = value; }
        }

        public bool IsGeneric
        {
            get { return Owner.IsGeneric; }
            set { Owner.IsGeneric = value; }
        }

        public bool IsMethod
        {
            get { return Owner.IsMethod; }
            set { Owner.IsMethod = value; }
        }

        public bool IsObsolete
        {
            get { return Owner.IsObsolete; }
            set { Owner.IsObsolete = value; }
        }


        public bool IsProperty
        {
            get { return Owner.IsProperty; }
            set { Owner.IsProperty = value; }
        }


        public bool IsPublic
        {
            get { return Owner.IsPublic; }
            set { Owner.IsPublic = value; }
        }

        public bool IsStatic
        {
            get { return Owner.IsStatic; }
            set { Owner.IsStatic = value; }
        }

        public bool IsVirtual
        {
            get { return Owner.IsVirtual; }
            set { Owner.IsVirtual = value; }
        }

        public bool IsVoid
        {
            get { return Owner.IsVoid; }
            set { Owner.IsVoid = value; }
        }

        public IMMemberView HomeView
        {
            get { return Owner.HomeView; }
        }

        public IMProperty Property
        {
            get { return Owner.Property; }
            set { Owner.Property = value; }
        }

        #endregion

    }
}