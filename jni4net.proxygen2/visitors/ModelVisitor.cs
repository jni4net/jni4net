using System;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public interface IModel
    {
        string Name { get; }
        string Key { get; }
        void Accept(IModelVisitor visitor, Repository repository);
    }

    public interface IModelVisitor
    {
        void VisitAssembly(MAssembly assembly, Repository repository);
        void VisitType(MType type, Repository repository);
        void VisitMember(MMember member, Repository repository);
        void VisitParameter(MParameter mParameter, Repository repository);
        void VisitFile(GFile file, Repository repository);
        void VisitGType(GType type, Context context, Repository repository);
        void VisitGMember(GMember member, Context context, Repository repository);
    }

    public class BaseModelVisitor : IModelVisitor
    {
        public virtual void VisitAssembly(MAssembly assembly, Repository repository)
        {
        }

        public virtual void VisitType(MType type, Repository repository)
        {
        }

        public virtual void VisitMember(MMember member, Repository repository)
        {
        }

        public virtual void VisitParameter(MParameter mParameter, Repository repository)
        {
        }

        public virtual void VisitGType(GType type, Context context, Repository repository)
        {
        }

        public virtual void VisitGMember(GMember member, Context context, Repository repository)
        {
        }

        public virtual void VisitFile(GFile file, Repository repository)
        {
        }
    }
}
