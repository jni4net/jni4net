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
public class MethodBase extends system.reflection.MemberInfo {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected MethodBase(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected MethodBase() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/RuntimeMethodHandle;)LSystem/Reflection/MethodBase;")
    public native static system.reflection.MethodBase GetMethodFromHandle(system.ValueType handle);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/RuntimeMethodHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/MethodBase;")
    public native static system.reflection.MethodBase GetMethodFromHandle(system.ValueType handle, system.ValueType declaringType);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodBase;")
    public native static system.reflection.MethodBase GetCurrentMethod();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Reflection/ParameterInfo;")
    public native system.reflection.ParameterInfo[] GetParameters();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodImplAttributes;")
    public native system.Enum GetMethodImplementationFlags();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/RuntimeMethodHandle;")
    public native system.ValueType getMethodHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodAttributes;")
    public native system.Enum getAttributes();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;")
    public native system.Object Invoke(system.Object obj, system.reflection.BindingFlags invokeAttr, system.Object binder, system.Object[] parameters, system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/CallingConventions;")
    public native system.Enum getCallingConvention();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Type;")
    public native system.Type[] GetGenericArguments();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isGenericMethodDefinition();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getContainsGenericParameters();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isGenericMethod();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;[LSystem/Object;)LSystem/Object;")
    public native system.Object Invoke(system.Object obj, system.Object[] parameters);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPublic();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPrivate();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamily();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamilyAndAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFamilyOrAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isStatic();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFinal();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isVirtual();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isHideBySig();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isAbstract();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSpecialName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isConstructor();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodBody;")
    public native system.Object GetMethodBody();
    
    public static system.Type typeof() {
        return system.reflection.MethodBase.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.reflection.MethodBase.staticType = staticType;
    }
    //</generated-proxy>
}
