using System;
using System.CodeDom;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class CLRStaticGen : CLRBaseGenerator
    {
        public override void GenerateType1Pass()
        {
            AddStaticProperty();
            base.GenerateType1Pass();
        }

        private void AddStaticProperty()
        {
            var claprop = new CodeMemberProperty();
            var staticfield = new CodeMemberField(Known.javaLangClass, "staticClass");

            claprop.Type = Known.javaLangClass;
            claprop.Name = "_class";
            claprop.GetStatements.Add(
                new CodeMethodReturnStatement(new CodeFieldReferenceExpression(type.DTypeReferenceEx, "staticClass")));

            claprop.Attributes = MemberAttributes.Static | MemberAttributes.Public;
            staticfield.Attributes = MemberAttributes.Static | MemberAttributes.FamilyAndAssembly;

            if (!type.Model.IsInterface && !type.Model.IsRootType && context.IsProxySide())
            {
                claprop.Attributes |= MemberAttributes.New;
                staticfield.Attributes |= MemberAttributes.New;
            }

            tgtType.Members.Add(claprop);
            tgtType.Members.Add(staticfield);

        }
    }
}
