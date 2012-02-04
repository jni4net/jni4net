#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as
published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class ClrCoreHooks : IClrCoreHooks
    {
        public void InitJ4N(JNIEnv env, CallBack initPending, IJvmCoreHooks jvmCoreHooks)
        {
            Registry.systemObject = Registry.InitClrProxy(typeof(Object_), env);
            Registry.systemException = Registry.InitClrProxy(typeof(Exception_), env);
            Registry.currentBridgeSetup = Registry.InitClrProxy(typeof(CurrentBridgeSetup_), env);

            initPending(null);

            IClass bridge = J4NBridge.currentSetup.DefaultClassLoader.loadClass("net.sf.jni4net.J4NBridge");
            IntPtr wrapper = Registry.currentBridgeSetup.CLRProxyFactory(env, J4NBridge.currentSetup, typeof (CurrentBridgeSetup));
            env.SetStaticObjectField(bridge, "currentSetup", "Lnet/sf/jni4net/CurrentBridgeSetup;", wrapper);

            Registry.outWrapper = Registry.InitJvmProxy(typeof(Out), env);
            Registry.refWrapper = Registry.InitJvmProxy(typeof(Ref), env);
            Registry.outWrapperConstructor = env.GetMethodID(Registry.outWrapper.JVMApi, "<init>", "()V");
            Registry.refWrapperConstructor = env.GetMethodID(Registry.refWrapper.JVMApi, "<init>", "(Ljava/lang/Object;)V");
            Registry.outWrapperField = env.GetFieldID(Registry.outWrapper.JVMApi, "value", "Ljava/lang/Object;");
            Registry.refWrapperField = env.GetFieldID(Registry.refWrapper.JVMApi, "value", "Ljava/lang/Object;");

            Registry.systemString = Registry.InitClrProxy(typeof(String_), env);
            Registry.systemType = Registry.InitClrProxy(typeof(Type_), env);
            Registry.systemBool = Registry.InitClrProxy(typeof(Boolean_), env);
            Registry.systemByte = Registry.InitClrProxy(typeof(Byte_), env);
            Registry.systemChar = Registry.InitClrProxy(typeof(Char_), env);
            Registry.systemShort = Registry.InitClrProxy(typeof(Int16_), env);
            Registry.systemInt = Registry.InitClrProxy(typeof(Int32_), env);
            Registry.systemLong = Registry.InitClrProxy(typeof(Int64_), env);
            Registry.systemFloat = Registry.InitClrProxy(typeof(Single_), env);
            Registry.systemDouble = Registry.InitClrProxy(typeof(Double_), env);

            Registry.systemObject.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemObject.JVMApi);
            Registry.systemType.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemType.JVMApi);
            Registry.systemString.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemString.JVMApi);
            Registry.systemBool.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemBool.JVMApi);
            Registry.systemByte.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemByte.JVMApi);
            Registry.systemChar.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemChar.JVMApi);
            Registry.systemShort.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemShort.JVMApi);
            Registry.systemInt.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemInt.JVMApi);
            Registry.systemLong.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemLong.JVMApi);
            Registry.systemFloat.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemFloat.JVMApi);
            Registry.systemDouble.JVMApiArray = ConvertClass.MakeArray(env, Registry.systemDouble.JVMApi);
        }


        public void UnloadJ4N(JNIEnv env)
        {
            IntPtr bslh = env.FindClass("net.sf.jni4net.J4NBridge");
            IntPtr cbs = env.GetStaticFieldID(bslh, "currentSetup", "Lnet/sf/jni4net/CurrentBridgeSetup;");
            env.SetStaticObjectField(bslh, cbs, IntPtr.Zero);
        }

        public ProxyInfo BindSealedToJvm(JNIEnv env, Type typeOfApi)
        {
            ProxyInfo proxyInfo = Registry.InitClrProxy(typeOfApi, env);
            if(proxyInfo==null)
            {
                throw new NotImplementedException("Unmapped sealed class");
            }
            return proxyInfo;
        }

        public ProxyInfo BindAbstractToJvm(JNIEnv env, Registry.CLRConversion conversion)
        {
            return Registry.BindCLRConversion(env, conversion);
        }
    }
}
