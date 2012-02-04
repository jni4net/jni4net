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

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public IntPtr GetStaticFieldID(IClass clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticFieldID(envPtr, clazz.JvmHandle, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticFieldID(envPtr, clazz, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetFieldID(IClass clazz, string name, string sig)
        {
            IntPtr res = Functions.getFieldID.Invoke(envPtr, clazz.JvmHandle, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticFieldIDNoThrow(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticFieldID(envPtr, clazz, name, sig);
            ExceptionRead();
            return res;
        }

        public IntPtr GetFieldIDNoThrow(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getFieldID.Invoke(envPtr, clazz, name, sig);
            ExceptionRead();
            return res;
        }

        public IntPtr GetFieldID(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getFieldID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetObjectField(obj.JvmHandle, fieldID);
        }

        public IntPtr GetStaticObjectField(IClass clazz, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticObjectField(clazz.JvmHandle, fieldID);
        }

        public string GetStringField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = GetObjectField(obj.JvmHandle, fieldID);
            return GetString(lh);
        }

        public string GetStaticStringField(IClass clazz, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = GetStaticObjectField(clazz.JvmHandle, fieldID);
            return GetString(lh);
        }

        public bool GetBooleanField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetBooleanField(obj.JvmHandle, fieldID);
        }

        public byte GetByteField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetByteField(obj.JvmHandle, fieldID);
        }

        public char GetCharField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetCharField(obj.JvmHandle, fieldID);
        }

        public short GetShortField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetShortField(obj.JvmHandle, fieldID);
        }

        public int GetIntField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetIntField(obj.JvmHandle, fieldID);
        }

        public long GetLongField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetLongField(obj.JvmHandle, fieldID);
        }

        public float GetFloatField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetFloatField(obj.JvmHandle, fieldID);
        }

        public double GetDoubleField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetDoubleField(obj.JvmHandle, fieldID);
        }

        public bool GetStaticBooleanField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticBooleanField(obj.JvmHandle, fieldID);
        }

        public byte GetStaticByteField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticByteField(obj.JvmHandle, fieldID);
        }

        public char GetStaticCharField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticCharField(obj.JvmHandle, fieldID);
        }

        public short GetStaticShortField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticShortField(obj.JvmHandle, fieldID);
        }

        public int GetStaticIntField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticIntField(obj.JvmHandle, fieldID);
        }

        public long GetStaticLongField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticLongField(obj.JvmHandle, fieldID);
        }

        public float GetStaticFloatField(IJvmProxy obj, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticFloatField(obj.JvmHandle, fieldID);
        }
        
        public double GetStaticDoubleField(IClass clazz, IntPtr fieldID)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return GetStaticDoubleField(clazz.JvmHandle, fieldID);
        }

        public string GetStringField(IntPtr obj, string name)
        {
            IntPtr clazz = GetObjectClass(obj);
            IntPtr fieldID = GetFieldID(clazz, name, "Ljava/lang/String;");
            IntPtr str = GetObjectField(obj, fieldID);
            return GetString(str);
        }

        public int GetIntField(IntPtr obj, string name)
        {
            IntPtr clazz = GetObjectClass(obj);
            IntPtr fieldID = GetFieldID(clazz, name, "I");
            var res = Functions.getIntField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
        {
            IntPtr res = Functions.getObjectField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public bool GetBooleanField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getBooleanField(envPtr, obj, fieldID);
            ExceptionTest();
            return res != 0;
        }

        public byte GetByteField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getByteField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public char GetCharField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getCharField(envPtr, obj, fieldID);
            ExceptionTest();
            return (char)res;
        }

        public short GetShortField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getShortField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public int GetIntField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getIntField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public long GetLongField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getLongField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public float GetFloatField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getFloatField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public double GetDoubleField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getDoubleField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticObjectField(IntPtr obj, IntPtr fieldID)
        {
            IntPtr res = Functions.getStaticObjectField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public bool GetStaticBooleanField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticBooleanField(envPtr, obj, fieldID);
            ExceptionTest();
            return res != 0;
        }

        public byte GetStaticByteField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticByteField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public char GetStaticCharField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticCharField(envPtr, obj, fieldID);
            ExceptionTest();
            return (char)res;
        }

        public short GetStaticShortField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticShortField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public int GetStaticIntField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticIntField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }


        public long GetStaticLongField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticLongField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public float GetStaticFloatField(IntPtr obj, IntPtr fieldID)
        {
            var res = Functions.getStaticFloatField(envPtr, obj, fieldID);
            ExceptionTest();
            return res;
        }

        public double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
        {
            var res = Functions.getStaticDoubleField(envPtr, clazz, fieldID);
            ExceptionTest();
            return res;
        }

        public void SetObjectField(IJvmProxy obj, IntPtr fieldID, IntPtr value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetObjectField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticObjectField(IClass clazz, IntPtr fieldID, IntPtr value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticObjectField(clazz.JvmHandle, fieldID, value);
        }

        public void SetStringField(IJvmProxy obj, IntPtr fieldID, string value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetObjectField(obj.JvmHandle, fieldID, NewString(value));
        }

        public void SetStaticStringField(IClass clazz, IntPtr fieldID, string value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticObjectField(clazz.JvmHandle, fieldID, NewString(value));
        }

        public void SetBooleanField(IJvmProxy obj, IntPtr fieldID, bool value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetBooleanField(obj.JvmHandle, fieldID, value);
        }

        public void SetByteField(IJvmProxy obj, IntPtr fieldID, byte value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetByteField(obj.JvmHandle, fieldID, value);
        }

        public void SetCharField(IJvmProxy obj, IntPtr fieldID, char value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetCharField(obj.JvmHandle, fieldID, value);
        }

        public void SetShortField(IJvmProxy obj, IntPtr fieldID, short value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetShortField(obj.JvmHandle, fieldID, value);
        }

        public void SetIntField(IJvmProxy obj, IntPtr fieldID, int value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetIntField(obj.JvmHandle, fieldID, value);
        }

        public void SetLongField(IJvmProxy obj, IntPtr fieldID, long value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetLongField(obj.JvmHandle, fieldID, value);
        }

        public void SetFloatField(IJvmProxy obj, IntPtr fieldID, float value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetFloatField(obj.JvmHandle, fieldID, value);
        }

        public void SetDoubleField(IJvmProxy obj, IntPtr fieldID, double value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetDoubleField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticBooleanField(IJvmProxy obj, IntPtr fieldID, bool value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticBooleanField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticByteField(IJvmProxy obj, IntPtr fieldID, byte value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticByteField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticCharField(IJvmProxy obj, IntPtr fieldID, char value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticCharField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticShortField(IJvmProxy obj, IntPtr fieldID, short value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticShortField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticIntField(IJvmProxy obj, IntPtr fieldID, int value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticIntField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticLongField(IJvmProxy obj, IntPtr fieldID, long value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticLongField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticFloatField(IJvmProxy obj, IntPtr fieldID, float value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticFloatField(obj.JvmHandle, fieldID, value);
        }

        public void SetStaticDoubleField(IClass clazz, IntPtr fieldID, double value)
        {
            if (fieldID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            SetStaticDoubleField(clazz.JvmHandle, fieldID, value);
        }

        public void SetStaticObjectField(IClass clazz, string name, string signature, IntPtr value)
        {
            IntPtr fieldID = GetStaticFieldID(clazz, name, signature);
            SetStaticObjectField(clazz, fieldID, value);
        }

        public void SetObjectField(IntPtr obj, string name, string signature, IntPtr value)
        {
            IntPtr clazz = GetObjectClass(obj);
            IntPtr fieldID = GetFieldID(clazz, name, signature);
            SetObjectField(obj, fieldID, value);
        }

        public void SetStringField(IntPtr obj, string name, string value)
        {
            IntPtr clazz = GetObjectClass(obj);
            IntPtr fieldID = GetFieldID(clazz, name, "Ljava/lang/String;");
            SetObjectField(obj, fieldID, NewString(value));
        }

        public void SetIntField(IntPtr obj, string name, int value)
        {
            IntPtr clazz = GetObjectClass(obj);
            IntPtr fieldID = GetFieldID(clazz, name, "I");
            Functions.setIntField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr value)
        {
            Functions.setObjectField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetBooleanField(IntPtr obj, IntPtr fieldID, bool value)
        {
            Functions.setBooleanField(envPtr, obj, fieldID, value ? (byte)1 : (byte)0);
            ExceptionTest();
        }

        public void SetByteField(IntPtr obj, IntPtr fieldID, byte value)
        {
            Functions.setByteField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetCharField(IntPtr obj, IntPtr fieldID, char value)
        {
            Functions.setCharField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetShortField(IntPtr obj, IntPtr fieldID, short value)
        {
            Functions.setShortField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetIntField(IntPtr obj, IntPtr fieldID, int value)
        {
            Functions.setIntField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetLongField(IntPtr obj, IntPtr fieldID, long value)
        {
            Functions.setLongField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetFloatField(IntPtr obj, IntPtr fieldID, float value)
        {
            Functions.setFloatField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetDoubleField(IntPtr obj, IntPtr fieldID, double value)
        {
            Functions.setDoubleField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticObjectField(IntPtr obj, IntPtr fieldID, IntPtr value)
        {
            Functions.setStaticObjectField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticBooleanField(IntPtr obj, IntPtr fieldID, bool value)
        {
            Functions.setStaticBooleanField(envPtr, obj, fieldID, value ? (byte)1 : (byte)0);
            ExceptionTest();
        }

        public void SetStaticByteField(IntPtr obj, IntPtr fieldID, byte value)
        {
            Functions.setStaticByteField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticCharField(IntPtr obj, IntPtr fieldID, char value)
        {
            Functions.setStaticCharField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticShortField(IntPtr obj, IntPtr fieldID, short value)
        {
            Functions.setStaticShortField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticIntField(IntPtr obj, IntPtr fieldID, int value)
        {
            Functions.setStaticIntField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticLongField(IntPtr obj, IntPtr fieldID, long value)
        {
            Functions.setStaticLongField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticFloatField(IntPtr obj, IntPtr fieldID, float value)
        {
            Functions.setStaticFloatField(envPtr, obj, fieldID, value);
            ExceptionTest();
        }

        public void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double value)
        {
            Functions.setStaticDoubleField(envPtr, clazz, fieldID, value);
            ExceptionTest();
        }
    }
}
