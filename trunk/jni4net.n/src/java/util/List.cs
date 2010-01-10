#region Copyright (C) 2009 by Pavel Savara

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

namespace java.util
{
    /*
    public partial interface List : IList
    {
    }

    internal partial class __List
    {
        private class ListEnumerator : IEnumerator
        {
            public ListEnumerator(__List list)
            {
                this.list = list;
                Reset();
            }

            private Object current;
            private Iterator iterator;
            private __List list;

            public bool MoveNext()
            {
                if (!iterator.hasNext())
                    return false;
                current = iterator.next();
                return true;
            }

            public void Reset()
            {
                iterator = list.iterator();
                current = null;
            }

            public object Current
            {
                get { return current; }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(this);
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(this[i], i + index);
            }
        }

        public int Count
        {
            get { return size(); }
        }

        public object SyncRoot
        {
            get { throw new NotSupportedException(); }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public int Add(object value)
        {
            add((Object) value);
            return size() - 1;
        }

        public bool Contains(object value)
        {
            return contains((Object) value);
        }

        public void Clear()
        {
            clear();
        }

        public int IndexOf(object value)
        {
            return indexOf((Object) value);
        }

        public void Insert(int index, object value)
        {
            add(index, (Object) value);
        }

        public void Remove(object value)
        {
            remove((Object) value);
        }

        public void RemoveAt(int index)
        {
            remove(index);
        }

        public object this[int index]
        {
            get { return get(index); }
            set { set(index, (Object) value); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }
    }*/
}