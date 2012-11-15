using System.Collections.Generic;
using System.Linq;
using java.util;

namespace Mitza.Jni4Net.Wrapper {

    public class Set<T> : ISet<T> where T : java.lang.Object {

        private Set set;
        public Set WrappedSet {
            get { return set; }
        }

        public Set(Set set) {
            this.set = set;
        }

        public bool Add(T item) {
            return set.add(item);
        }

        public void ExceptWith(IEnumerable<T> other) {
            foreach (T item in other) {
                set.remove(item);
            }
        }

        public void IntersectWith(IEnumerable<T> other) {
            foreach (T item in this) {
                if (!other.Contains(item)) {
                    set.remove(item);
                }
            }
        }

        public bool IsProperSubsetOf(IEnumerable<T> other) {
            foreach (T item in this) {
                if (!other.Contains(item)) {
                    return false;
                }
            }
            return true;
        }

        public bool IsProperSupersetOf(IEnumerable<T> other) {
            if (Count <= other.Count()) {
                return false;
            }
            foreach (T item in this) {
                if (!other.Contains(item)) {
                    return true;
                }
            }
            return false;
        }

        public bool IsSubsetOf(IEnumerable<T> other) {
            foreach (T item in this) {
                if (!other.Contains(item)) {
                    return false;
                }
            }
            return true;
        }

        public bool IsSupersetOf(IEnumerable<T> other) {
            if (Count < other.Count()) {
                return false;
            }
            foreach (T item in other) {
                if (!Contains(item)) {
                    return false;
                }
            }
            return true;
        }

        public bool Overlaps(IEnumerable<T> other) {
            foreach (T item in this) {
                if (other.Contains(item)) {
                    return true;
                }
            }
            return false;
        }

        public bool SetEquals(IEnumerable<T> other) {
            if (Count != other.Count()) {
                return false;
            }
            foreach (T item in this) {
                if (!other.Contains(item)) {
                    return false;
                }
            }
            return true;
        }

        public void SymmetricExceptWith(IEnumerable<T> other) {
            foreach (T item in other) {
                if (Contains(item)) {
                    Remove(item);
                } else {
                    Add(item);
                }
            }
        }

        public void UnionWith(IEnumerable<T> other) {
            foreach (T item in other) {
                Add(item);
            }
        }

        void ICollection<T>.Add(T item) {
            set.add(item);
        }

        public void Clear() {
            set.clear();
        }

        public bool Contains(T item) {
            return set.contains(item);
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
            get { return set.size(); }
        }

        public bool IsReadOnly {
            get { return false; }
        }

        public bool Remove(T item) {
            return set.remove(item);
        }

        public IEnumerator<T> GetEnumerator() {
            return new Enumerator<T>(set);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return new Enumerator<T>(set);
        }
    }
}
