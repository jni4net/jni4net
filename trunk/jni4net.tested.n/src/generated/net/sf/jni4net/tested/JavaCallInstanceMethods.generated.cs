//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class JavaCallInstanceMethods : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _stringMethod0;
        
        internal static global::net.sf.jni4net.jni.MethodId _objectMethod1;
        
        internal static global::net.sf.jni4net.jni.MethodId _testObjectMethod2;
        
        internal static global::net.sf.jni4net.jni.MethodId _testStringMethod3;
        
        internal static global::net.sf.jni4net.jni.MethodId _integerMethod4;
        
        internal static global::net.sf.jni4net.jni.MethodId _testIntegerMethod5;
        
        internal static global::net.sf.jni4net.jni.MethodId _classLoaderMethod6;
        
        internal static global::net.sf.jni4net.jni.MethodId _testClassLoaderMethod7;
        
        internal static global::net.sf.jni4net.jni.MethodId _objectArray8;
        
        internal static global::net.sf.jni4net.jni.MethodId _charArray9;
        
        internal static global::net.sf.jni4net.jni.MethodId _intArray10;
        
        internal static global::net.sf.jni4net.jni.MethodId _integerArray11;
        
        internal static global::net.sf.jni4net.jni.MethodId _stringArray12;
        
        internal static global::net.sf.jni4net.jni.MethodId _booleanArray13;
        
        internal static global::net.sf.jni4net.jni.MethodId _stringList14;
        
        internal static global::net.sf.jni4net.jni.MethodId _buffer15;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait16;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait17;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait18;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode19;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass20;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals21;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString22;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify23;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll24;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor25;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JavaCallInstanceMethods() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, global::net.sf.jni4net.tested.JavaCallInstanceMethods.@__ctor25, this);
        }
        
        protected JavaCallInstanceMethods(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass = staticClass;
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringMethod0 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "stringMethod", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._objectMethod1 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "objectMethod", "()Ljava/lang/Object;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._testObjectMethod2 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "testObjectMethod", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._testStringMethod3 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "testStringMethod", "(Ljava/lang/String;)Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._integerMethod4 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "integerMethod", "()Ljava/lang/Integer;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._testIntegerMethod5 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "testIntegerMethod", "(Ljava/lang/Integer;)Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._classLoaderMethod6 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "classLoaderMethod", "()Ljava/lang/ClassLoader;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._testClassLoaderMethod7 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "testClassLoaderMethod", "(Ljava/lang/ClassLoader;)Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._objectArray8 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "objectArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._charArray9 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "charArray", "([C)[C");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._intArray10 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "intArray", "([I)[I");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._integerArray11 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "integerArray", "([Ljava/lang/Integer;)[Ljava/lang/Integer;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringArray12 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "stringArray", "([Ljava/lang/String;)[Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._booleanArray13 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "booleanArray", "([Z)[Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringList14 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "stringList", "()Ljava/util/List;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._buffer15 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "buffer", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait16 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "wait", "()V");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait17 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "wait", "(JI)V");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait18 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "wait", "(J)V");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._hashCode19 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "hashCode", "()I");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._getClass20 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "getClass", "()Ljava/lang/Class;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._equals21 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._toString22 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "toString", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._notify23 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "notify", "()V");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods._notifyAll24 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "notifyAll", "()V");
            global::net.sf.jni4net.tested.JavaCallInstanceMethods.@__ctor25 = env.GetMethodID(global::net.sf.jni4net.tested.JavaCallInstanceMethods.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String stringMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringMethod0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object objectMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._objectMethod1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool testObjectMethod(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._testObjectMethod2, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Z")]
        public virtual bool testStringMethod(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._testStringMethod3, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Integer;")]
        public virtual global::java.lang.Integer integerMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._integerMethod4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Integer;)Z")]
        public virtual bool testIntegerMethod(global::java.lang.Integer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._testIntegerMethod5, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/ClassLoader;")]
        public virtual global::java.lang.ClassLoader classLoaderMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.ClassLoader>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._classLoaderMethod6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/ClassLoader;)Z")]
        public virtual bool testClassLoaderMethod(global::java.lang.ClassLoader par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._testClassLoaderMethod7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;")]
        public virtual java.lang.Object[] objectArray(java.lang.Object[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Object[])(env.ConvertArrayToNet<java.lang.Object>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._objectArray8, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([C)[C")]
        public virtual char[] charArray(char[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((char[])(env.ConvertArrayToNet<char>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._charArray9, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([I)[I")]
        public virtual int[] intArray(int[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((int[])(env.ConvertArrayToNet<int>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._intArray10, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Integer;)[Ljava/lang/Integer;")]
        public virtual java.lang.Integer[] integerArray(java.lang.Integer[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Integer[])(env.ConvertArrayToNet<java.lang.Integer>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._integerArray11, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)[Ljava/lang/String;")]
        public virtual java.lang.String[] stringArray(java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.String[])(env.ConvertArrayToNet<java.lang.String>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringArray12, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Z)[Z")]
        public virtual bool[] booleanArray(bool[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((bool[])(env.ConvertArrayToNet<bool>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._booleanArray13, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/List;")]
        public virtual global::java.util.List stringList() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.List>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._stringList14));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer buffer(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._buffer15, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait16);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait17, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._wait18, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._hashCode19);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._getClass20));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._equals21, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._toString22));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._notify23);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaCallInstanceMethods._notifyAll24);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.JavaCallInstanceMethods(env);
            }
        }
    }
    #endregion
}
