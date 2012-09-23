using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Model
{
    public class MMember : IMMember
    {
        public IMType DeclaringType { get; set; }
        public IMemberRegistration Registration { get; set; }
    }

    public class MMemberView : IMMemberView
    {
        public MMemberView(IMMember owner, ViewKind viewKind)
        {
            Owner = owner;
            ViewKind = viewKind;
        }

        public ViewKind ViewKind { get; set; }

        public IMMember Owner { get; set; }

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

        #endregion
    }
}
