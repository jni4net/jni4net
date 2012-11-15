package mitza.jni4net.wrapper;

import java.lang.reflect.Array;
import java.util.Collection;
import java.util.Iterator;

import system.collections.IEnumerator;

/**
 * @author Mihai Cadariu
 */
public class Set<E> implements java.util.Set<E> {

	private system.collections.IList iSet;
	private Class<?> clazz;
	protected transient int modCount;

	public Set(system.collections.IList iSet) {
		this.iSet = iSet;
	}

	public Set(system.collections.IList iSet, Class<?> clazz) {
		this.iSet = iSet;
		this.clazz = clazz;
	}

	@Override
	public boolean add(E element) {
		if (instanceOk(element)) {
			iSet.Add(Convert.toObject(element));
			return true;
		}
		return false;
	}

	@Override
	public boolean addAll(Collection<? extends E> collection) {
		if (collection == null) {
			return false;
		}

		for (E element : collection) {
			if (instanceOk(element)) {
				iSet.Add(Convert.toObject(element));
			}
			return true;
		}
		return false;
	}

	@Override
	public void clear() {
		iSet.Clear();
	}

	@Override
	public boolean contains(Object element) {
		if (instanceOk(element)) {
			return iSet.Contains(Convert.toObject(element));
		}
		return false;
	}

	@Override
	public boolean containsAll(Collection<?> collection) {
		for (Object element : collection) {
			if (!contains(element)) {
				return false;
			}
		}
		return true;
	}

	@Override
	public boolean isEmpty() {
		return size() == 0;
	}

	@Override
	public Iterator<E> iterator() {
		return new SetIterator<E>(iSet.GetEnumerator());
	}

	@Override
	public boolean remove(Object element) {
		if (instanceOk(element)) {
			return remove(Convert.toObject(element));
		}
		return false;
	}

	@Override
	public boolean removeAll(Collection<?> collection) {
		for (Object element : collection) {
			if (instanceOk(element)) {
				remove(Convert.toObject(element));
			} else {
				return false;
			}
		}
		return true;
	}

	@Override
	public boolean retainAll(Collection<?> collection) {
		for (Object element : collection) {
			if (!contains(element) && instanceOk(element)) {
				iSet.Remove(Convert.toObject(element));
			} else {
				return false;
			}
		}
		return true;
	}

	@Override
	public int size() {
		return iSet.getCount();
	}

	@Override
	public Object[] toArray() {
		Object[] result = new Object[size()];
		int i = 0;
		for (E element : this) {
			result[i++] = element;
		}
		return result;
	}

	@SuppressWarnings("unchecked")
	@Override
	public <T> T[] toArray(T[] a) {
		Class<?> cc = ((T) a).getClass().getComponentType();
		Object[] result = (Object[]) Array.newInstance(cc, size());
		int i = 0;
		for (E element : this) {
			if (cc.isInstance(element)) {
				result[i++] = element;
			} else {
				return null;
			}
		}
		return (T[]) result;
	}

	private boolean instanceOk(Object o) {
		return clazz == null || clazz.isInstance(o);
	}

	private class SetIterator<T> extends IteratorBase<T> {

		public SetIterator(IEnumerator enumerator) {
			super(enumerator);
		}

		@Override
		public void remove() {
			Set.this.remove(getCurrent());
		}
	}
}
