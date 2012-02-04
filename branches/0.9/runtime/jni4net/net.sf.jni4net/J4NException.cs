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
using System.Runtime.Serialization;
using net.sf.jni4net.jni;

namespace net.sf.jni4net
{
    [Serializable]
    public class J4NException : Exception
    {
        public const string cantThrowAlreadyPending = "Can't properly marshal an exception. (subsequent exception trapped during marshaling)";

        public static J4NException CantFindJavaHome(Exception inner = null)
        {
            return new J4NException("Can't find JAVA_HOME. Please specify BridgeSetup.JavaHome", inner);
        }

        public static J4NException InitBridgeFirst(Exception inner = null)
        {
            return new J4NException("Bridge is not initialized yet, please call J4NBridge.CreateJVM() first.", inner);
        }

        public static J4NException ExceptionAlreadyPending(Exception inner = null)
        {
            return new J4NException(cantThrowAlreadyPending, inner);
        }

        public static J4NException ExceptionAlreadyPending(string className, Exception inner = null)
        {
            return new J4NException(cantThrowAlreadyPending + " during " + className, inner);
        }

        public static J4NException ExceptionCantThrow(Exception inner = null)
        {
            return new J4NException("Can't throw JVM exception)", inner);
        }

        public static J4NException CantBindNative(string className, Exception inner = null)
        {
            return new J4NException("Can't bind native methods to class " + className, inner);
        }

        public static J4NException CantUnbindNative(string className, Exception inner = null)
        {
            return new J4NException("Can't unbind native methods to class " + className, inner);
        }

        public static J4NException CantFindCLRCoreAssembly(Exception inner = null)
        {
            return new J4NException("Can't find core CLR assembly. Please specify BridgeSetup.CLRCoreLib", inner);
        }

        public static J4NException CantFindJVMCoreAssembly(Exception inner = null)
        {
            return new J4NException("Can't find core CLR assembly. Please specify BridgeSetup.CLRCoreLib", inner);
        }

        public static J4NException CantDestroyJvm(JNIResult result)
        {
            return new J4NException("Can't destroy JVM " + result);
        }

        public static J4NException CantCreateJvm(JNIResult result)
        {
            return new J4NException("Can't create JVM " + result);
        }

        public static J4NException ExistingJvm()
        {
            return new J4NException("There is already existing JVM. Use BridgeSetp.AllowJVMJoin");
        }

        protected J4NException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public J4NException()
        {
        }

        public J4NException(string message)
            : base(message)
        {
        }

        public J4NException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }

    [Serializable]
    class InnerException : Exception
    {
        private readonly string innerStackTrace;
        protected InnerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }


        public InnerException()
        {
        }

        public InnerException(string message, string innerStackTrace, Exception ex)
            : base(message, ex)
        {
            this.innerStackTrace = innerStackTrace;
        }

        public InnerException(string message, Exception ex)
            : base(message, ex)
        {
        }

        public override string StackTrace
        {
            get
            {
                if(innerStackTrace!=null)
                {
                    return innerStackTrace;
                }
                return base.StackTrace;
            }
        }
    }

}
