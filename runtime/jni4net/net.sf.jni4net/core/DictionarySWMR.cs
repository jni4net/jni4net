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

using System.Collections;
using System.Collections.Generic;

namespace net.sf.jni4net.core
{
    internal class DictionarySWMR<TKey, TValue> where TValue : ProxyInfo
    {
        private readonly object syncroot;
        public DictionarySWMR(object syncroot)
        {
            this.syncroot=syncroot;
        }

        public IList<TValue> Values
        {
            get
            {
                var values = new List<TValue>();
                foreach (var value in table.Values)
                {
                    values.Add((TValue)value);
                }
                return values;
            }
        }

        private readonly Hashtable table=new Hashtable();

        public bool ContainsKey(TKey key)
        {
            return table.ContainsKey(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = (TValue)table[key];
            return (value != null);
        }

        public void TryAdd(TKey key, ref TValue value)
        {
            lock (syncroot)
            {
                if(table.ContainsKey(key))
                {
                    var old = (ProxyInfo) table[key];
                    if (old!=value)
                    {
                        if(old.IsStub)
                        {
                            value.Merge(old);
                            table[key] = value;
                        }
                        else
                        {
                            old.Merge(value);
                            value = (TValue)old;
                        }
                    }
                }
                else
                {
                    table.Add(key, value);
                }
            }
        }

        public void Clear()
        {
            lock (syncroot)
            {
                table.Clear();
            }
        }


    }
}
