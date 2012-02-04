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
using System.IO;
using System.Runtime.InteropServices;
using net.sf.jni4net.core;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    internal unsafe partial class JNILib
    {
        private JNILibInterface functions;

        private LibDelegates.Cdecl.CreateJavaVM createJavaVM;
        private LibDelegates.Cdecl.GetCreatedJavaVMs getCreatedJavaVMs;
        private LibDelegates.Cdecl.GetDefaultJavaVMInitArgs getDefaultJavaVMInitArgs;



        const string jvmDllName = "jvm";
        private void InitMethods(string jvmPath, bool forceLoad)
        {
            functions = new JNILibInterface();

            if (OsUtils.IsRunningWindows)
            {
                IntPtr hModule = OsUtils.WindowsLoadDll(jvmPath, forceLoad, jvmDllName);
                functions.CreateJavaVM = OsUtils.WindowsGetProcAddress(hModule, "JNI_CreateJavaVM");
                functions.GetCreatedJavaVMs = OsUtils.WindowsGetProcAddress(hModule, "JNI_GetCreatedJavaVMs");
                functions.GetDefaultJavaVMInitArgs = OsUtils.WindowsGetProcAddress(hModule, "JNI_GetDefaultJavaVMInitArgs");
                //TODO clean up handle, see GetModuleHandleEx and FreeLibrary
            }
            else
            {
                throw new NotImplementedException();
            }

            bool IsStdCall = OsUtils.IsRunningWindows;
            Delegates.GetDelegateForFunctionPointer<LibDelegates.Cdecl.CreateJavaVM, LibDelegates.StdCall.CreateJavaVM>(functions.CreateJavaVM, ref createJavaVM, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<LibDelegates.Cdecl.GetCreatedJavaVMs, LibDelegates.StdCall.GetCreatedJavaVMs>(functions.GetCreatedJavaVMs, ref getCreatedJavaVMs, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<LibDelegates.Cdecl.GetDefaultJavaVMInitArgs, LibDelegates.StdCall.GetDefaultJavaVMInitArgs>(functions.GetDefaultJavaVMInitArgs, ref getDefaultJavaVMInitArgs, IsStdCall);
        }
    }
}
