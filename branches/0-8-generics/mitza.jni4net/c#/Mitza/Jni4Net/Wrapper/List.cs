using System.Collections.Generic;
using java.util;

namespace Mitza.Jni4Net.Wrapper {

    public class List<T> : IList<T> where T : java.lang.Object {

        private List list;
        public List WrappedList {
            get { return list; }
        }

        public List(List list) {
            this.list = list;
        }

        public int IndexOf(T item) {
            return list.indexOf(item);
        }

        public void Insert(int index, T item) {
            list.add(index, item);
        }

        public void RemoveAt(int index) {
            list.remove(index);
        }

        public T this[int index] {
            get {
                return (T)list.get(index);
            }
            set {
                list.set(index, value);
            }
        }

        public void Add(T item) {
            list.add(item);
        }

        public void Clear() {
            list.clear();
        }

        public bool Contains(T item) {
            return list.contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) {
            int count = Count;
            int i = arrayIndex;
            foreach (T item in this) {
                array[i++] = item;
                if (i >= count) {
                    break;
                }
            }
        }

        public int Count {
            get { return list.size(); }
        }

        public bool IsReadOnly {
            get { return false; }
        }

        public bool Remove(T item) {
            return list.remove(item) != null;
        }

        public IEnumerator<T> GetEnumerator() {
            return new Enumerator<T>(list);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return new Enumerator<T>(list);
        }
    }
}
