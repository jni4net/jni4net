using System.Collections.Generic;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Services
{
    public class KnownTypes : IKnownTypes
    {
        [Dependency]
        public ILogger Logger { get; set; }

        readonly List<IMType> models=new List<IMType>();

        public void Register(IMType type)
        {
            //Logger.LogMessage(type.ToString());
            models.Add(type);
        }

        public List<IMType> AllModels()
        {
            return models;
        }

        public IMType SystemObject { get; set; }
        public IMType SystemString { get; set; }
        public IMType SystemType { get; set; }
        public IMType SystemException { get; set; }
        public IMType ClrBool { get; set; }
        public IMType ClrByte { get; set; }
        public IMType ClrChar { get; set; }
        public IMType ClrShort { get; set; }
        public IMType ClrInt { get; set; }
        public IMType ClrLong { get; set; }
        public IMType ClrFloat { get; set; }
        public IMType ClrDouble { get; set; }
        public IMType ClrSByte { get; set; }
        public IMType ClrUShort { get; set; }
        public IMType ClrUInt { get; set; }
        public IMType ClrULong { get; set; }
        public IMType ClrVoid { get; set; }
        public IMType ClrIntPtr { get; set; }
        public IMType ClrUIntPtr { get; set; }
        public IMType JavaLangObject { get; set; }
        public IMType JavaLangString { get; set; }
        public IMType JavaLangClass { get; set; }
        public IMType JavaLangVoid { get; set; }
        public IMType JavaLangBoolean { get; set; }
        public IMType JavaLangByte { get; set; }
        public IMType JavaLangCharacter { get; set; }
        public IMType JavaLangShort { get; set; }
        public IMType JavaLangInteger { get; set; }
        public IMType JavaLangLong { get; set; }
        public IMType JavaLangFloat { get; set; }
        public IMType JavaLangDouble { get; set; }
        public IMType JvmBool { get; set; }
        public IMType JvmByte { get; set; }
        public IMType JvmChar { get; set; }
        public IMType JvmShort { get; set; }
        public IMType JvmInt { get; set; }
        public IMType JvmLong { get; set; }
        public IMType JvmFloat { get; set; }
        public IMType JvmDouble { get; set; }
        public IMType JavaLangThrowable { get; set; }
        public IMType JvmVoid { get; set; }
    }
}
