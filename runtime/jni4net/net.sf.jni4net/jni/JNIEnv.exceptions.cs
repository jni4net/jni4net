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
using System.Diagnostics;
using java.lang;
using net.sf.jni4net.core;
using net.sf.jni4net.jni.utils;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        [ThreadStatic]
        private static bool exceptionPending;

        public void ThrowNew(IntPtr clazz, string message)
        {
            using (var str = new StringPtr(message))
            {
                if (Functions.throwNew(envPtr, clazz, str.Native) != JNIResult.JNI_OK)
                {
                    throw J4NException.ExceptionCantThrow();
                }
            }
        }

        public void ThrowExisting(Exception ex)
        {
            var ext = ex as IThrowable;
            if (ext == null)
            {
                IntPtr pexp = ConvertAbstract.ToPtr(this, ex, "java.lang.Throwable");
                Throw(pexp);
            }
            else
            {
                ext.SetStackTrace(new StackTrace(ex));
                Throw(ext.JvmHandle);
            }
        }

        public void ExceptionTest()
        {
#if DEBUG
            //TODO unrelated stuff, sorry
            if(LocalFrame.frameCount==0)
            {
                throw new J4NException("Please use LocalFrame");
            }
#endif
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                if (exceptionPending)
                {
                    ExceptionDescribe();
                    throw J4NException.ExceptionAlreadyPending();
                }
                Exception exception;
                try
                {
                    exceptionPending = true;
                    ExceptionClear();
                    exception = ConvertAbstract.ToCLR<Exception>(this, occurred);
                    if (!(exception is IJvmProxy) && Registry._innerException != null)
                    {
                        //TODO
                        var jvmException = (Exception)Registry.javaLangThrowable.JVMProxyFactory(this, occurred, new JvmInstanceInfo(Registry.javaLangThrowable.JVMApi, Registry.javaLangThrowable));

                        var innest = exception;
                        while (innest.InnerException != null)
                        {
                            innest = innest.InnerException;
                        }
                        var innerException = new InnerException(exception.Message, exception.StackTrace, jvmException);

                        Registry._innerException.SetValue(innest, innerException);
                        //exception = (Exception)Activator.CreateInstance(exception.GetType(), exception.Message, exception);
                    }
                }
                catch (Exception)
                {
                    ExceptionDescribe();
                    throw;
                }
                finally
                {
                    exceptionPending = false;
                }
                throw exception;
            }
        }

        public void Throw(IntPtr ptr)
        {
            if (Functions.@throw(envPtr, ptr) != JNIResult.JNI_OK)
            {
                throw J4NException.ExceptionCantThrow();
            }
        }

        public IntPtr ExceptionOccurred()
        {
            return Functions.exceptionOccurred(envPtr);
        }

        public void FatalError(string message)
        {
            using (var ptr = new StringPtr(message))
            {
                Functions.fatalError(envPtr, ptr.Native);
            }
        }

        public void ExceptionClear()
        {
            Functions.exceptionClear(envPtr);
        }

        public void ExceptionDescribe()
        {
            Functions.exceptionDescribe(envPtr);
        }


        public bool ExceptionRead()
        {
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                if (Logger.LogLevel >= LogLevel.Info)
                {
                    ExceptionDescribe();
                }
                ExceptionClear();
                return true;
            }
            return false;
        }

        public bool ExceptionCheck()
        {
            return Functions.exceptionCheck(envPtr) != 0;
        }
    }
}
