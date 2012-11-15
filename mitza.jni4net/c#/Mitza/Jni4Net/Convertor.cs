using System.Collections;
using System.Collections.Generic;

namespace Mitza.Jni4Net {

    public class Convertor {

        public static ICollection ToICollection<T>(ICollection<T> source) {
            return ToIList<T>(new List<T>(source));
        }

        public static IList ToICollection<K, V>(ICollection<KeyValuePair<K, V>> source) {
            IList result = new ArrayList();
            foreach (KeyValuePair<K, V> kvp in source) {
                Mitza.Jni4Net.Wrapper.KeyValuePair entry = new Mitza.Jni4Net.Wrapper.KeyValuePair(kvp.Key, kvp.Value);
                result.Add(entry);
            }
            return result;
        }

        public static IDictionary ToIDictionary<K, V>(IDictionary<K, V> source) {
            return new Hashtable((Dictionary<K, V>)source);
        }

        public static IEnumerable ToIEnumerable<T>(IEnumerable<T> source) {
            return (IEnumerable)source;
        }

        public static IList ToIEnumerable<K, V>(IEnumerable<KeyValuePair<K, V>> source) {
            IList result = new ArrayList();
            foreach (KeyValuePair<K, V> kvp in source) {
                Mitza.Jni4Net.Wrapper.KeyValuePair entry = new Mitza.Jni4Net.Wrapper.KeyValuePair(kvp.Key, kvp.Value);
                result.Add(entry);
            }
            return result;
        }

        public static IList ToIList<T>(IList<T> source) {
            return new ArrayList((List<T>)source);
        }

        public static IList ToIList<K, V>(IList<KeyValuePair<K, V>> source) {
            IList result = new ArrayList();
            foreach (KeyValuePair<K, V> kvp in source) {
                Mitza.Jni4Net.Wrapper.KeyValuePair entry = new Mitza.Jni4Net.Wrapper.KeyValuePair(kvp.Key, kvp.Value);
                result.Add(entry);
            }
            return result;
        }

        public static IList ToISet<T>(ISet<T> source) {
            return ToIList<T>(new List<T>(source));
        }

        public static IList ToISet<K, V>(ISet<KeyValuePair<K, V>> source) {
            IList result = new ArrayList();
            foreach (KeyValuePair<K, V> kvp in source) {
                Mitza.Jni4Net.Wrapper.KeyValuePair entry = new Mitza.Jni4Net.Wrapper.KeyValuePair(kvp.Key, kvp.Value);
                result.Add(entry);
            }
            return result;
        }
    }
}
