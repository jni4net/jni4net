// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.definition.process;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Connection_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.definition.process.Connection_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.definition.process.Connection_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Connection extends system.Object implements org.drools.definition.process.Connection {
    
    protected __Connection(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Ljava/lang/Object;")
    public native java.lang.Object getMetaData(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Map;")
    public native java.util.Map getMetaData();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/definition/process/Node;")
    public native org.drools.definition.process.Node getFrom();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/definition/process/Node;")
    public native org.drools.definition.process.Node getTo();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getFromType();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getToType();
}
//</generated-proxy>
