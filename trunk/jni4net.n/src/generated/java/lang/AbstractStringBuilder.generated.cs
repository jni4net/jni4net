//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class AbstractStringBuilder : global::java.lang.Object, global::java.lang.Appendable, global::java.lang.CharSequence {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _append0;
        
        internal static global::net.sf.jni4net.jni.MethodId _append1;
        
        internal static global::net.sf.jni4net.jni.MethodId _append2;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString3;
        
        internal static global::net.sf.jni4net.jni.MethodId _charAt4;
        
        internal static global::net.sf.jni4net.jni.MethodId _length5;
        
        internal static global::net.sf.jni4net.jni.MethodId _subSequence6;
        
        internal static global::net.sf.jni4net.jni.MethodId _indexOf7;
        
        internal static global::net.sf.jni4net.jni.MethodId _indexOf8;
        
        internal static global::net.sf.jni4net.jni.MethodId _append9;
        
        internal static global::net.sf.jni4net.jni.MethodId _append10;
        
        internal static global::net.sf.jni4net.jni.MethodId _append11;
        
        internal static global::net.sf.jni4net.jni.MethodId _append12;
        
        internal static global::net.sf.jni4net.jni.MethodId _append13;
        
        internal static global::net.sf.jni4net.jni.MethodId _append14;
        
        internal static global::net.sf.jni4net.jni.MethodId _append15;
        
        internal static global::net.sf.jni4net.jni.MethodId _append16;
        
        internal static global::net.sf.jni4net.jni.MethodId _append17;
        
        internal static global::net.sf.jni4net.jni.MethodId _append18;
        
        internal static global::net.sf.jni4net.jni.MethodId _codePointAt19;
        
        internal static global::net.sf.jni4net.jni.MethodId _codePointBefore20;
        
        internal static global::net.sf.jni4net.jni.MethodId _codePointCount21;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChars22;
        
        internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf23;
        
        internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf24;
        
        internal static global::net.sf.jni4net.jni.MethodId _offsetByCodePoints25;
        
        internal static global::net.sf.jni4net.jni.MethodId _replace26;
        
        internal static global::net.sf.jni4net.jni.MethodId _substring27;
        
        internal static global::net.sf.jni4net.jni.MethodId _substring28;
        
        internal static global::net.sf.jni4net.jni.MethodId _capacity29;
        
        internal static global::net.sf.jni4net.jni.MethodId _ensureCapacity30;
        
        internal static global::net.sf.jni4net.jni.MethodId _trimToSize31;
        
        internal static global::net.sf.jni4net.jni.MethodId _appendCodePoint32;
        
        internal static global::net.sf.jni4net.jni.MethodId _delete33;
        
        internal static global::net.sf.jni4net.jni.MethodId _deleteCharAt34;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert35;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert36;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert37;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert38;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert39;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert40;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert41;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert42;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert43;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert44;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert45;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert46;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverse47;
        
        internal static global::net.sf.jni4net.jni.MethodId _setCharAt48;
        
        internal static global::net.sf.jni4net.jni.MethodId _setLength49;
        
        protected AbstractStringBuilder(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.AbstractStringBuilder.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.AbstractStringBuilder.staticClass = staticClass;
            global::java.lang.AbstractStringBuilder._append0 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
            global::java.lang.AbstractStringBuilder._append1 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
            global::java.lang.AbstractStringBuilder._append2 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
            global::java.lang.AbstractStringBuilder._toString3 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.AbstractStringBuilder._charAt4 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C");
            global::java.lang.AbstractStringBuilder._length5 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "length", "()I");
            global::java.lang.AbstractStringBuilder._subSequence6 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
            global::java.lang.AbstractStringBuilder._indexOf7 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I");
            global::java.lang.AbstractStringBuilder._indexOf8 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I");
            global::java.lang.AbstractStringBuilder._append9 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append10 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append11 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append12 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append13 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append14 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append15 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append16 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append17 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._append18 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._codePointAt19 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I");
            global::java.lang.AbstractStringBuilder._codePointBefore20 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I");
            global::java.lang.AbstractStringBuilder._codePointCount21 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I");
            global::java.lang.AbstractStringBuilder._getChars22 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V");
            global::java.lang.AbstractStringBuilder._lastIndexOf23 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I");
            global::java.lang.AbstractStringBuilder._lastIndexOf24 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I");
            global::java.lang.AbstractStringBuilder._offsetByCodePoints25 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I");
            global::java.lang.AbstractStringBuilder._replace26 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._substring27 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;");
            global::java.lang.AbstractStringBuilder._substring28 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;");
            global::java.lang.AbstractStringBuilder._capacity29 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I");
            global::java.lang.AbstractStringBuilder._ensureCapacity30 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V");
            global::java.lang.AbstractStringBuilder._trimToSize31 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V");
            global::java.lang.AbstractStringBuilder._appendCodePoint32 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._delete33 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._deleteCharAt34 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert35 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert36 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert37 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert38 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert39 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert40 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert41 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert42 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert43 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert44 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert45 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._insert46 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._reverse47 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;");
            global::java.lang.AbstractStringBuilder._setCharAt48 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V");
            global::java.lang.AbstractStringBuilder._setLength49 = env.GetMethodID(global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(char par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append0, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(global::java.lang.CharSequence par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append1, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append2, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._toString3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)C")]
        public virtual char charAt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::java.lang.AbstractStringBuilder._charAt4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int length() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._length5);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/CharSequence;")]
        public virtual global::java.lang.CharSequence subSequence(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.CharSequence>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._subSequence6, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)I")]
        public virtual int indexOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._indexOf7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)I")]
        public virtual int indexOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._indexOf8, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(double par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append9, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(F)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(float par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append10, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append11, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append12, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append13, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([CII)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(char[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append14, global::net.sf.jni4net.jni.Value.CreateArray(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append15, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append16, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(global::java.lang.StringBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append17, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([C)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder append(char[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._append18, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public virtual int codePointAt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._codePointAt19, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public virtual int codePointBefore(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._codePointBefore20, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public virtual int codePointCount(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._codePointCount21, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II[CI)V")]
        public virtual void getChars(int par0, int par1, char[] par2, int par3) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.AbstractStringBuilder._getChars22, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), global::net.sf.jni4net.jni.Value.CreateArray(par2), new global::net.sf.jni4net.jni.Value(par3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)I")]
        public virtual int lastIndexOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._lastIndexOf23, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)I")]
        public virtual int lastIndexOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._lastIndexOf24, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public virtual int offsetByCodePoints(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._offsetByCodePoints25, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder replace(int par0, int par1, global::java.lang.String par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._replace26, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public virtual global::java.lang.String substring(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._substring27, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/String;")]
        public virtual global::java.lang.String substring(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._substring28, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int capacity() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.AbstractStringBuilder._capacity29);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void ensureCapacity(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.AbstractStringBuilder._ensureCapacity30, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void trimToSize() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.AbstractStringBuilder._trimToSize31);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._appendCodePoint32, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder delete(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._delete33, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._deleteCharAt34, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IZ)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert35, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IC)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, char par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert36, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert37, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IJ)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert38, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, global::java.lang.CharSequence par1, int par2, int par3) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert39, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2), new global::net.sf.jni4net.jni.Value(par3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ID)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert40, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert41, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert42, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I[CII)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, char[] par1, int par2, int par3) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert43, new global::net.sf.jni4net.jni.Value(par0), global::net.sf.jni4net.jni.Value.CreateArray(par1), new global::net.sf.jni4net.jni.Value(par2), new global::net.sf.jni4net.jni.Value(par3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, global::java.lang.CharSequence par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert44, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, float par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert45, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I[C)Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder insert(int par0, char[] par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._insert46, new global::net.sf.jni4net.jni.Value(par0), global::net.sf.jni4net.jni.Value.CreateArray(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/AbstractStringBuilder;")]
        public virtual global::java.lang.AbstractStringBuilder reverse() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.AbstractStringBuilder>(env.CallObjectMethod(this, global::java.lang.AbstractStringBuilder._reverse47));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IC)V")]
        public virtual void setCharAt(int par0, char par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.AbstractStringBuilder._setCharAt48, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setLength(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.AbstractStringBuilder._setLength49, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.AbstractStringBuilder(env);
            }
        }
    }
    #endregion
}
