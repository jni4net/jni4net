using System.Collections.Generic;
using com.jni4net.proxygen.Interfaces;

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

        public List<IUTypeUsage> Ret { get; private set; }
        public List<IUTypeUsage> Parameters { get; private set; }

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