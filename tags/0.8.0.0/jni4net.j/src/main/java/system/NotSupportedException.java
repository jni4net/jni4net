// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrType
public class NotSupportedException extends system.SystemException {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected NotSupportedException(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public NotSupportedException() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.NotSupportedException.__ctorNotSupportedException0(this);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;)V")
    public NotSupportedException(java.lang.String message) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.NotSupportedException.__ctorNotSupportedException1(this, message);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;LSystem/Exception;)V")
    public NotSupportedException(java.lang.String message, system.Exception innerException) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.NotSupportedException.__ctorNotSupportedException2(this, message, innerException);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorNotSupportedException0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)V")
    private native static void __ctorNotSupportedException1(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String message);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Lsystem/Exception;)V")
    private native static void __ctorNotSupportedException2(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String message, system.Exception innerException);
    
    public static system.Type typeof() {
        return system.NotSupportedException.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.NotSupportedException.staticType = staticType;
    }
    //</generated-proxy>
}
