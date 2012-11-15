package mitza.jni4net.wrapper;

import java.util.ArrayList;
import java.util.Collection;
import java.util.HashSet;
import java.util.Set;

import system.collections.ICollection;
import system.collections.IDictionaryEnumerator;
import system.collections.IEnumerator;

/**
 * @author Mihai Cadariu
 */
public class Map<K, V> implements java.util.Map<K, V> {

	private system.collections.IDictionary iDictionary;
	private Class<?> keyClazz;
	private Class<?> valueClazz;

	public Map(system.collections.IDictionary iDictionary) {
		this.iDictionary = iDictionary;
	}

	public Map(system.collections.IDictionary iDictionary, Class<?> keyClazz, Class<?> valueClazz) {
		this.iDictionary = iDictionary;
		this.keyClazz = keyClazz;
		this.valueClazz = valueClazz;
	}

	@Override
	public void clear() {
		iDictionary.Clear();
	}

	@Override
	public boolean containsKey(Object key) {
		if (keyOk(key)) {
			return iDictionary.Contains(Convert.toObject(key));
		} else {
			return false;
		}
	}

	@SuppressWarnings("unchecked")
	@Override
	public boolean containsValue(Object value) {
		if (valueOk(value)) {
			ICollection values = iDictionary.getValues();
			if (value == null) {
				for (IEnumerator enumerator = values.GetEnumerator(); enumerator.MoveNext();) {
					if (enumerator.getCurrent() == null) {
						return true;
					}
				}
			} else {
				for (IEnumerator enumerator = values.GetEnumerator(); enumerator.MoveNext();) {
					Object v = enumerator.getCurrent();
					if (((V) v).equals((V) value)) {
						return true;
					}
				}
			}
		}
		return false;
	}

	@SuppressWarnings("unchecked")
	@Override
	public Set<java.util.Map.Entry<K, V>> entrySet() {
		Set<java.util.Map.Entry<K, V>> result = new HashSet<java.util.Map.Entry<K, V>>();
		for (IDictionaryEnumerator enumerator = iDictionary.GetEnumerator(); enumerator.MoveNext();) {
			Object key = enumerator.getKey();
			Object value = enumerator.getValue();
			if (keyOk(key) && valueOk(value)) {
				result.add(new SimpleEntry((K) key, (V) value));
			}
		}
		return result;
	}

	@SuppressWarnings("unchecked")
	@Override
	public V get(Object key) {
		if (keyOk(key) && containsKey(key)) {
			return (V) iDictionary.getItem(Convert.toObject(key));
		}
		return null;
	}

	@SuppressWarnings("unchecked")
	public V get(String key) {
		system.String k = new system.String(key);
		if (keyOk(k)) {
			return get((K) k);
		}
		return null;
	}

	@Override
	public boolean isEmpty() {
		return iDictionary.getCount() == 0;
	}

	@SuppressWarnings("unchecked")
	@Override
	public Set<K> keySet() {
		Set<K> result = new HashSet<K>();
		for (IEnumerator enumerator = iDictionary.getKeys().GetEnumerator(); enumerator.MoveNext();) {
			Object key = enumerator.getCurrent();
			if (keyOk(key)) {
				result.add((K) key);
			}
		}
		return result;
	}

	@Override
	public V put(K key, V value) {
		if (keyOk(key) && valueOk(value)) {
			V v = get(key);
			iDictionary.setItem(Convert.toObject(key), Convert.toObject(value));
			return v;
		}
		return null;
	}

	@SuppressWarnings("unchecked")
	public V put(String key, V value) {
		return put(((K) new system.String(key)), value);
	}

	@Override
	public void putAll(java.util.Map<? extends K, ? extends V> map) {
		for (Map.Entry<? extends K, ? extends V> entry : map.entrySet()) {
			put(entry.getKey(), entry.getValue());
		}
	}

	@Override
	public V remove(Object key) {
		if (keyOk(key) && containsKey(key)) {
			V result = get(key);
			iDictionary.Remove(Convert.toObject(key));
			return result;
		}
		return null;
	}

	@SuppressWarnings("unchecked")
	public V remove(String key) {
		system.String k = new system.String(key);
		if (keyOk(k)) {
			return remove((K) k);
		}
		return null;
	}

	@Override
	public int size() {
		return iDictionary.getCount();
	}

	@SuppressWarnings("unchecked")
	@Override
	public Collection<V> values() {
		Collection<V> result = new ArrayList<V>();
		for (IEnumerator enumerator = iDictionary.getValues().GetEnumerator(); enumerator.MoveNext();) {
			Object value = enumerator.getCurrent();
			if (keyOk(value)) {
				result.add((V) value);
			}
		}
		return result;
	}

	private boolean keyOk(Object o) {
		return keyClazz == null || keyClazz.isInstance(o);
	}

	private boolean valueOk(Object o) {
		return valueClazz == null || valueClazz.isInstance(o);
	}

	public class SimpleEntry implements Entry<K, V> {

		private K key;
		private V value;

		public SimpleEntry(K key, V value) {
			this.key = key;
			this.value = value;
		}

		@Override
		public K getKey() {
			return key;
		}

		@Override
		public V getValue() {
			return value;
		}

		@Override
		public V setValue(V value) {
			this.value = value;
			return this.value;
		}
	}
}
