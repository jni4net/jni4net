using System;
using System.CodeDom;
using System.Collections.Generic;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class GMember : IModel
    {
        public GMember(MMember model)
        {
            Model = model;
            Name = Model.Name;
        }

        public MMember Model { get; set; }
        public List<CodeParameterDeclarationExpression> Parameters=new List<CodeParameterDeclarationExpression>();
        public CodeTypeReference ReturnType { get; set; }

        public MemberAttributes Attributes { get; set; }

        public string Name { get; set; }

        public string Key
        {
            get { return Model.Key; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            
        }

        public override string ToString()
        {
            return Model.ToString();
        }

        public override bool Equals(object obj)
        {
            return Model.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Model.GetHashCode();
        }
    }
}
