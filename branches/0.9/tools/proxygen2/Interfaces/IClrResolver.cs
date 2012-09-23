﻿using System.Collections.Generic;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IClrResolver
    {
        void AddName(string fullName);
        void AddPath(string filename);
        void Init();
        List<IMType> GenerateAs(string asm, string regex = null);
        IMType ResolveType(Type clazz);
    }
}
