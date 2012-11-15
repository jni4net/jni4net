using System.Collections.Generic;
using java.util;

namespace Mitza.Jni4Net.Wrapper {

    public class Collection<T> : ICollection<T> where T : java.lang.Object {

        private Collection collection;
        public Collection WrappedCollection {
            get { return collection; }
        }

        public Collection(Collection collection) {
            this.collection = collection;
        }

        public void Add(T item) {
            collection.add(item);
        }

        public void Clear() {
            collection.clear();
        }

        public bool Contains(T item) {
            return collection.contains(item);
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
            get { return collection.size(); }
        }

        public bool IsReadOnly {
            get { return false; }
        }

        public bool Remove(T item) {
            return collection.remove(item) != null;
        }

        public IEnumerator<T> GetEnumerator() {
            return new Enumerator<T>(collection);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return new Enumerator<T>(collection);
        }
    }
}
