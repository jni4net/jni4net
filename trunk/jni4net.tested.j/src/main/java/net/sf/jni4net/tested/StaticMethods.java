// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.jni4net.tested;

@net.sf.jni4net.attributes.ClrType
public class StaticMethods extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected StaticMethods(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public StaticMethods() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        net.sf.jni4net.tested.StaticMethods.__ctorStaticMethods0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorStaticMethods0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(II)I")
    public native static int add(int a, int b);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)V")
    public native static void TestOutParamS(net.sf.jni4net.Out<java.lang.String> text);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)V")
    public native static void TestRefParamS(net.sf.jni4net.Ref<java.lang.String> text);
    
    @net.sf.jni4net.attributes.ClrMethod("([Ljava/lang/String;)V")
    public native static void TestRefParamSa(net.sf.jni4net.Ref<system.Object> text);
    
    @net.sf.jni4net.attributes.ClrMethod("([C)V")
    public native static void TestRefParamPa(net.sf.jni4net.Ref<system.Object> text);
    
    @net.sf.jni4net.attributes.ClrMethod("([BIC)V")
    public native static void TestRefParamBa(net.sf.jni4net.Out<system.Object> text, int a, char f);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native static void TestOutParam(net.sf.jni4net.Out<java.lang.Integer> num);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)I")
    public native static int TestRefParam(net.sf.jni4net.Ref<java.lang.Integer> num);
    
    public static system.Type typeof() {
        return net.sf.jni4net.tested.StaticMethods.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.jni4net.tested.StaticMethods.staticType = staticType;
    }
    //</generated-proxy>
}
