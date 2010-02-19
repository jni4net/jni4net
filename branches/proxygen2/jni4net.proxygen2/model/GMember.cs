using System;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class GMember : IModel
    {
        public MMember Model { get; set; }

        public string Name
        {
            get { return Model.Name; }
        }

        public string Key
        {
            get { return Model.Key; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            
        }
    }
}
