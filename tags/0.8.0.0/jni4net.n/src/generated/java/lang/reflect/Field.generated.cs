//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Field : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.Member {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getBoolean4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getByte5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getShort6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChar7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInt8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFloat10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDouble11;
        
        internal static global::net.sf.jni4net.jni.MethodId _get12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericType13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getType14;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEnumConstant15;
        
        internal static global::net.sf.jni4net.jni.MethodId _set16;
        
        internal static global::net.sf.jni4net.jni.MethodId _setBoolean17;
        
        internal static global::net.sf.jni4net.jni.MethodId _setByte18;
        
        internal static global::net.sf.jni4net.jni.MethodId _setChar19;
        
        internal static global::net.sf.jni4net.jni.MethodId _setDouble20;
        
        internal static global::net.sf.jni4net.jni.MethodId _setFloat21;
        
        internal static global::net.sf.jni4net.jni.MethodId _setInt22;
        
        internal static global::net.sf.jni4net.jni.MethodId _setLong23;
        
        internal static global::net.sf.jni4net.jni.MethodId _setShort24;
        
        internal static global::net.sf.jni4net.jni.MethodId _toGenericString25;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC26;
        
        internal static global::net.sf.jni4net.jni.FieldId _DECLARED27;
        
        protected Field(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Field.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._PUBLIC26)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._DECLARED27)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Field.staticClass = @__class;
            global::java.lang.reflect.Field._getModifiers0 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.Field._getName1 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.Field._getDeclaringClass2 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.Field._isSynthetic3 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.Field._getBoolean4 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z");
            global::java.lang.reflect.Field._getByte5 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B");
            global::java.lang.reflect.Field._getShort6 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S");
            global::java.lang.reflect.Field._getChar7 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C");
            global::java.lang.reflect.Field._getInt8 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I");
            global::java.lang.reflect.Field._getLong9 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J");
            global::java.lang.reflect.Field._getFloat10 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F");
            global::java.lang.reflect.Field._getDouble11 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D");
            global::java.lang.reflect.Field._get12 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.lang.reflect.Field._getGenericType13 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Field._getType14 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;");
            global::java.lang.reflect.Field._isEnumConstant15 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z");
            global::java.lang.reflect.Field._set16 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
            global::java.lang.reflect.Field._setBoolean17 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V");
            global::java.lang.reflect.Field._setByte18 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V");
            global::java.lang.reflect.Field._setChar19 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V");
            global::java.lang.reflect.Field._setDouble20 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V");
            global::java.lang.reflect.Field._setFloat21 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V");
            global::java.lang.reflect.Field._setInt22 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V");
            global::java.lang.reflect.Field._setLong23 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V");
            global::java.lang.reflect.Field._setShort24 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V");
            global::java.lang.reflect.Field._toGenericString25 = @__env.GetMethodID(global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;");
            global::java.lang.reflect.Field._PUBLIC26 = @__env.GetStaticFieldID(global::java.lang.reflect.Field.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Field._DECLARED27 = @__env.GetStaticFieldID(global::java.lang.reflect.Field.staticClass, "DECLARED", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Field._getModifiers0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._getName1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._getDeclaringClass2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Field._isSynthetic3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool getBoolean(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Field._getBoolean4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)B")]
        public virtual byte getByte(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((byte)(@__env.CallByteMethod(this, global::java.lang.reflect.Field._getByte5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)S")]
        public virtual short getShort(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((short)(@__env.CallShortMethod(this, global::java.lang.reflect.Field._getShort6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)C")]
        public virtual char getChar(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((char)(@__env.CallCharMethod(this, global::java.lang.reflect.Field._getChar7, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int getInt(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Field._getInt8, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)J")]
        public virtual long getLong(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.lang.reflect.Field._getLong9, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)F")]
        public virtual float getFloat(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((float)(@__env.CallFloatMethod(this, global::java.lang.reflect.Field._getFloat10, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)D")]
        public virtual double getDouble(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::java.lang.reflect.Field._getDouble11, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object get(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._get12, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type getGenericType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._getGenericType13));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._getType14));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isEnumConstant() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Field._isEnumConstant15)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V")]
        public virtual void set(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._set16, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Z)V")]
        public virtual void setBoolean(global::java.lang.Object par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setBoolean17, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;B)V")]
        public virtual void setByte(global::java.lang.Object par0, byte par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setByte18, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;C)V")]
        public virtual void setChar(global::java.lang.Object par0, char par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setChar19, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;D)V")]
        public virtual void setDouble(global::java.lang.Object par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setDouble20, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;F)V")]
        public virtual void setFloat(global::java.lang.Object par0, float par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setFloat21, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;I)V")]
        public virtual void setInt(global::java.lang.Object par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setInt22, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;J)V")]
        public virtual void setLong(global::java.lang.Object par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setLong23, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;S)V")]
        public virtual void setShort(global::java.lang.Object par0, short par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.Field._setShort24, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGenericString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Field._toGenericString25));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Field(@__env);
            }
        }
    }
    #endregion
}
