using System;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class MParameter : IModel
    {
        public MType Type { get; set; }
        public string Name { get; set; }

        public string Key
        {
            get { return Name; }
        }

        public bool IsOut { get; set; }
        public bool IsRef { get; set; }
        public bool IsReturn { get; set; }

        public MParameter(MType type, string name, bool isReturn)
        {
            Type = type;
            Name = name;
            IsReturn = isReturn;
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            visitor.VisitParameter(this, repository);
        }

        public override string ToString()
        {
            return Type + " " + Name;
        }
    }
}
