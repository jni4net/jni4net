//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:2.0.50727.4016
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
namespace net.sf.jni4net.proxygen.config {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.2.0.0/toolConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("jni4net-proxygen", Namespace="http://jni4net.sf.net/0.2.0.0/toolConfig.xsd", IsNullable=false)]
    public partial class ToolConfig {
        
        private string targetDirJvmField;
        
        private string targetDirClrField;
        
        private bool skipSignaturesField;
        
        private bool skipInterfaceTypeInfoField;
        
        private string[] classPathField;
        
        private string[] assemblyReferenceField;
        
        private bool verboseField;
        
        private TypeRegistration[] javaClassField;
        
        private TypeRegistration[] clrTypeField;
        
        public ToolConfig() {
            this.skipSignaturesField = false;
            this.skipInterfaceTypeInfoField = false;
            this.verboseField = false;
        }
        
        /// <remarks/>
        public string TargetDirJvm {
            get {
                return this.targetDirJvmField;
            }
            set {
                this.targetDirJvmField = value;
            }
        }
        
        /// <remarks/>
        public string TargetDirClr {
            get {
                return this.targetDirClrField;
            }
            set {
                this.targetDirClrField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SkipSignatures {
            get {
                return this.skipSignaturesField;
            }
            set {
                this.skipSignaturesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SkipInterfaceTypeInfo {
            get {
                return this.skipInterfaceTypeInfoField;
            }
            set {
                this.skipInterfaceTypeInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassPath")]
        public string[] ClassPath {
            get {
                return this.classPathField;
            }
            set {
                this.classPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyReference")]
        public string[] AssemblyReference {
            get {
                return this.assemblyReferenceField;
            }
            set {
                this.assemblyReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Verbose {
            get {
                return this.verboseField;
            }
            set {
                this.verboseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JavaClass")]
        public TypeRegistration[] JavaClass {
            get {
                return this.javaClassField;
            }
            set {
                this.javaClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClrType")]
        public TypeRegistration[] ClrType {
            get {
                return this.clrTypeField;
            }
            set {
                this.clrTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.2.0.0/toolConfig.xsd")]
    public partial class TypeRegistration {
        
        private TypeReference[] ignoreInterfaceField;
        
        private MethodModifier[] methodModifierField;
        
        private string typeNameField;
        
        private bool noMethodsField;
        
        private bool syncInterfaceField;
        
        private bool mergeJavaSourceField;
        
        public TypeRegistration() {
            this.noMethodsField = false;
            this.syncInterfaceField = false;
            this.mergeJavaSourceField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IgnoreInterface")]
        public TypeReference[] IgnoreInterface {
            get {
                return this.ignoreInterfaceField;
            }
            set {
                this.ignoreInterfaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MethodModifier")]
        public MethodModifier[] MethodModifier {
            get {
                return this.methodModifierField;
            }
            set {
                this.methodModifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName {
            get {
                return this.typeNameField;
            }
            set {
                this.typeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NoMethods {
            get {
                return this.noMethodsField;
            }
            set {
                this.noMethodsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SyncInterface {
            get {
                return this.syncInterfaceField;
            }
            set {
                this.syncInterfaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MergeJavaSource {
            get {
                return this.mergeJavaSourceField;
            }
            set {
                this.mergeJavaSourceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.2.0.0/toolConfig.xsd")]
    public partial class TypeReference {
        
        private string typeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName {
            get {
                return this.typeNameField;
            }
            set {
                this.typeNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.2.0.0/toolConfig.xsd")]
    public partial class MethodModifier {
        
        private string methodNameField;
        
        private string signatureField;
        
        private bool skipField;
        
        private bool hideField;
        
        private bool forceField;
        
        private string returnField;
        
        private string interfaceField;
        
        private string renameJVMField;
        
        private string renameCLRField;
        
        public MethodModifier() {
            this.skipField = false;
            this.hideField = false;
            this.forceField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MethodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Skip {
            get {
                return this.skipField;
            }
            set {
                this.skipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Hide {
            get {
                return this.hideField;
            }
            set {
                this.hideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Force {
            get {
                return this.forceField;
            }
            set {
                this.forceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RenameJVM {
            get {
                return this.renameJVMField;
            }
            set {
                this.renameJVMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RenameCLR {
            get {
                return this.renameCLRField;
            }
            set {
                this.renameCLRField = value;
            }
        }
    }
}