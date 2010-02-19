using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public abstract class GFile : IModel
    {
        public MType MainType { get; set; }
        public string Path { get; set; }
        public string File { get; set; }

        public List<GType> GTypes = new List<GType>();
        public List<Context> GContexts = new List<Context>();

        public CodeNamespace DNamespace { get; set; }
        public StringBuilder DText { get; set; }

        private GType Main;

        public GFile(GType main)
        {
            Path = main.Namespace.Replace('.', '/').ToLowerInvariant();
            File = main.Name + "." + (main is JGType ? "java" : "j4n.cs");

            Main = main;
            MainType = main.Model;
            main.Model.GFiles.Add(this);

            DNamespace=new CodeNamespace(main.Namespace);
        }

        public void Add(GType type, Context context)
        {
            if (type.File != null && type.File != this)
            {
                throw new InvalidProgramException();
            }
            type.File = this;
            GTypes.Add(type);
            GContexts.Add(context);
        }

        public string Name
        {
            get { return Path + "/" + File; }
        }

        public string Key
        {
            get { return Path + "/" + File; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            visitor.VisitFile(this, repository);
            for (int i = 0; i < GTypes.Count; i++)
            {
                GType type = GTypes[i];
                Context context = GContexts[i];
                visitor.VisitGType(this, type, context, repository);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class CGFile : GFile
    {
        public CGFile(CGType main) : base(main)
        {
        }
    }

    public class JGFile : GFile
    {
        public JGFile(JGType main)
            : base(main)
        {
        }
    }
}
