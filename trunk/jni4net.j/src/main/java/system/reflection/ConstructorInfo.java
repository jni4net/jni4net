// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.reflection;

@net.sf.jni4net.attributes.ClrType
public class ConstructorInfo extends system.reflection.MethodBase {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ConstructorInfo(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    protected ConstructorInfo() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;")
    public native system.Object Invoke(system.reflection.BindingFlags invokeAttr, system.Object binder, system.Object[] parameters, system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Object;)LSystem/Object;")
    public native final system.Object Invoke(system.Object[] parameters);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;")
    public native system.Object Invoke_2(system.Object obj, system.reflection.BindingFlags invokeAttr, system.Object binder, system.Object[] parameters, system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;[LSystem/Object;)LSystem/Object;")
    public native system.Object Invoke_3(system.Object obj, system.Object[] parameters);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;")
    public native system.Object Invoke_4(system.reflection.BindingFlags invokeAttr, system.Object binder, system.Object[] parameters, system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Object;)LSystem/Object;")
    public native system.Object Invoke_5(system.Object[] parameters);
    
    public static system.Type typeof() {
        return system.reflection.ConstructorInfo.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.reflection.ConstructorInfo.staticType = staticType;
    }
    //</generated-proxy>
}