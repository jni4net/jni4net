using System;
using System.Collections.Generic;
using System.Reflection;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class MAssembly : IModel
    {
        public MAssemblyJvm Jvm { get; set; }
        public MAssemblyClr Clr { get; set; }
        public string Name { get; set; }

        public string Key
        {
            get { return Name; }
        }

        public List<MType> Types=new List<MType>();

        public MAssembly(Assembly assembly)
        {
            Clr=new MAssemblyClr();
            Clr.Assembly = assembly;
            Name = assembly.FullName;
        }

        public class MAssemblyJvm
        {
            public string Jar { get; set; }
        }

        public class MAssemblyClr
        {
            public Assembly Assembly { get; set; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            visitor.VisitAssembly(this, repository);
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            MAssembly o = obj as MAssembly;
            if (o == null)
                return false;
            return Name.Equals(o.Name);
        }
    }
}
