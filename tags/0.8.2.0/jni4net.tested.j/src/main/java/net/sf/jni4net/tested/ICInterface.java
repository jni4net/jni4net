// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.jni4net.tested;

@net.sf.jni4net.attributes.ClrInterface
public interface ICInterface {
    
    //<generated-interface>
    @net.sf.jni4net.attributes.ClrMethod("()I")
    int getintProp();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    void setintProp(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("()Lnet/sf/jni4net/tested/TestDelegate;")
    net.sf.jni4net.tested.TestDelegate getfcePtr();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/jni4net/tested/TestDelegate;)V")
    void setfcePtr(net.sf.jni4net.tested.TestDelegate value);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/jni4net/tested/TestDelegate;)V")
    void addEnvDispatcher(net.sf.jni4net.tested.TestDelegate value);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/jni4net/tested/TestDelegate;)V")
    void removeEnvDispatcher(net.sf.jni4net.tested.TestDelegate value);
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/String;)V")
    void xx(java.lang.String[] strs);
    //</generated-interface>
}