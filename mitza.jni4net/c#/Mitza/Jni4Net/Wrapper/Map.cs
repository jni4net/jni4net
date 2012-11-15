using System;
using System.Collections;
using System.Collections.Generic;
using java.util;

namespace Mitza.Jni4Net.Wrapper {

    public class Map<K, V> : IDictionary<K, V>
        where K : java.lang.Object
        where V : java.lang.Object {

        private Map map;
        public Map WrappedMap {
            get { return map; }
        }

        public Map(Map map) {
            this.map = map;
        }

        public void Add(K key, V value) {
            map.put(key, value);
        }

        public bool ContainsKey(K key) {
            return map.containsKey(key);
        }

        public ICollection<K> Keys {
            get { return new Set<K>(map.keySet()); }
        }

        public bool Remove(K key) {
            return map.remove(key) != null;
        }

        public bool TryGetValue(K key, out V value) {
            value = (V)map.get(key);
            return value != null;
        }

        public ICollection<V> Values {
            get { return new Collection<V>(map.values()); }
        }

        public V this[K key] {
            get {
                return (V)map.get(key);
            }
            set {
                map.put(key, value);
            }
        }

        public void Add(KeyValuePair<K, V> item) {
            map.put(item.Key, item.Value);
        }

        public void Clear() {
            map.clear();
        }

        public bool Contains(KeyValuePair<K, V> item) {
            return (V)map.get(item.Key) == item.Value;
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex) {
            int count = Count;
            int i = arrayIndex;
            foreach (KeyValuePair<K, V> entry in this) {
                array[i++] = entry;
                if (i >= count) {
                    break;
                }
            }
        }

        public int Count {
            get { return map.size(); }
        }

        public bool IsReadOnly {
            get { return false; }
        }

        public bool Remove(KeyValuePair<K, V> item) {
            return map.remove(item.Key) != null;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator() {
            return new MapEnumerator<K, V>(map);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return new MapEnumerator<K, V>(map);
        }

        private class MapEnumerator<K, V> : IEnumerator<KeyValuePair<K, V>>, IDisposable, IDictionaryEnumerator, IEnumerator
            where K : java.lang.Object
            where V : java.lang.Object {

            private Map map;
            private Iterator keyIterator;
            private KeyValuePair<K, V> current;

            internal MapEnumerator(Map map) {
                this.map = map;
                ((IEnumerator)this).Reset();
            }

            public bool MoveNext() {
                while (keyIterator.hasNext()) {
                    K key = (K)keyIterator.next();
                    if (key.hashCode() > 0) {
                        V value = (V)map.get(key);
                        current = new KeyValuePair<K, V>(key, value);
                        return true;
                    }
                }

                current = new KeyValuePair<K, V>();
                return false;
            }

            public KeyValuePair<K, V> Current {
                get { return current; }
            }

            public void Dispose() {
            }

            object IEnumerator.Current {
                get {
                    if (current.Key == default(K) && current.Value == default(V)) {
                        throw new InvalidOperationException("Enumerator in invalid state");
                    }
                    return new KeyValuePair<K, V>(current.Key, current.Value);
                }
            }

            void IEnumerator.Reset() {
                keyIterator = map.keySet().iterator();
                current = new KeyValuePair<K, V>();
            }

            DictionaryEntry IDictionaryEnumerator.Entry {
                get {
                    if (current.Key == default(K) && current.Value == default(V)) {
                        throw new InvalidOperationException("Enumerator in invalid state");
                    }
                    return new DictionaryEntry(current.Key, current.Value);
                }
            }

            object IDictionaryEnumerator.Key {
                get {
                    if (current.Key == default(K) && current.Value == default(V)) {
                        throw new InvalidOperationException("Enumerator in invalid state");
                    }
                    return current.Key;
                }
            }

            object IDictionaryEnumerator.Value {
                get {
                    if (current.Key == default(K) && current.Value == default(V)) {
                        throw new InvalidOperationException("Enumerator in invalid state");
                    }
                    return current.Value;
                }
            }
        }
    }
}
