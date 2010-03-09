using java.lang;
using net.sf.jni4net.proxygen.model;
using Exception = System.Exception;
using Object = java.lang.Object;

namespace net.sf.jni4net.proxygen.visitors
{
    public class Resolver : BaseModelVisitor
    {
        public override void VisitType(MType type, Repository repository)
        {
            if (type.Clr != null && (type.Clr == typeof (object) || type.Clr == typeof (Exception)))
            {
                type.IsRootType = true;
                type.IsKnown = true;
                type.Subst = type;
                return;
            }
            if (type.Jvm != null && (type.Jvm == Object._class || type.Jvm == Throwable._class))
            {
                type.IsRootType = true;
                type.IsKnown = true;
                type.Subst = type;
                return;
            }
            if (type.Jvm != null && type.IsGenClr)
            {
                type.IsKnown = true;
            }
            if (type.Clr != null && type.IsGenJvm)
            {
                type.IsKnown = true;
            }
            if (type.IsKnown)
            {
                type.Subst = type;
                return;
            }
            if (type.IsInterface)
            {
                if (SubstInterface(type, type))
                {
                    return;
                }
                type.Subst = repository.AddOrResolve(typeof (object));
            }
            else
            {
                MType current = type;
                while (true)
                {
                    if (current.IsKnown)
                    {
                        type.Subst = current;
                        return;
                    }
                    if (current.Subst != null)
                    {
                        type.Subst = current.Subst;
                        return;
                    }
                    current = current.Base;
                }
            }
        }

        private static bool SubstInterface(MType type, MType sType)
        {
            foreach (MType ifc in sType.Interfaces)
            {
                if (ifc.IsKnown)
                {
                    type.Subst = ifc;
                    return true;
                }
                if (ifc.Subst != null)
                {
                    type.Subst = ifc.Subst;
                    return true;
                }
                SubstInterface(type, ifc);
            }
            return false;
        }
    }
}
