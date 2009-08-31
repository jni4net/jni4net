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