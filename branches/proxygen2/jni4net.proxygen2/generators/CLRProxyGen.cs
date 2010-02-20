using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    class CLRProxyGen : CLRBaseGenerator
    {
        public override void GenerateType()
        {
            base.GenerateType();
            /*if (type.Model.IsInterface || context.IsProxySide())
            {
                GenerateConstructionHelper();
                tgtType.BaseTypes.Add(type.Model.IsInterface
                                          ? Known.javaLangObject
                                          : type.Model.Base.GFaceClr.DTypeReference);
            }
            else
            {
                tgtType.TypeAttributes |= TypeAttributes.Abstract | TypeAttributes.Sealed;
            }*/
        }
    }
}
