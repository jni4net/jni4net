package mitza.jni4net.wrapper;

import java.lang.reflect.Array;
import java.util.ConcurrentModificationException;
import java.util.Iterator;
import java.util.NoSuchElementException;

import system.NotSupportedException;
import system.collections.IEnumerator;

/**
 * @author Mihai Cadariu
 */
public class Collection<E extends system.Object> implements java.util.Collection<E> {

	private system.collections.ICollection iCollection;
	private Class<?> clazz;
	protected transient int modCount;

	public Collection(system.collections.ICollection iCollection) {
		this.iCollection = iCollection;
	}

	public Collection(system.collections.ICollection iCollection, Class<?> clazz) {
		this.iCollection = iCollection;
		this.clazz = clazz;
	}

	@Override
	public boolean add(E element) {
		throw new NotSupportedException();
	}

	@Override
	public boolean addAll(java.util.Collection<? extends E> arg0) {
		throw new NotSupportedException();
	}

	@Override
	public void clear() {
		throw new NotSupportedException();
	}

	@Override
	public boolean contains(Object arg0) {
		throw new NotSupportedException();
	}

	@Override
	public boolean containsAll(java.util.Collection<?> arg0) {
		throw new NotSupportedException();
	}

	@Override
	public boolean isEmpty() {
		return size() == 0;
	}

	@Override
	public Iterator<E> iterator() {
		return new Itr<E>(iCollection.GetEnumerator());
	}

	@Override
	public boolean remove(Object arg0) {
		throw new NotSupportedException();
	}

	@Override
	public boolean removeAll(java.util.Collection<?> arg0) {
		throw new NotSupportedException();
	}

	@Override
	public boolean retainAll(java.util.Collection<?> arg0) {
		throw new NotSupportedException();
	}

	@Override
	public int size() {
		return iCollection.getCount();
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

	private class Itr<T> implements Iterator<T> {
		int expectedModCount;
		IEnumerator enumerator;
		int state = 0;

		public Itr(IEnumerator enumerator) {
			this.enumerator = enumerator;
			Collection.this.modCount = expectedModCount = Collection.this.size();
		}

		public boolean hasNext() {
			if (state == 0) {
				state = enumerator.MoveNext() ? 1 : -1;
			}
			return state == 1;
		}

		@SuppressWarnings("unchecked")
		public T next() {
			if (state == 0) {
				state = enumerator.MoveNext() ? 1 : -1;
			}
			if (state < 0) {
				throw new NoSuchElementException();
			}
			checkForComodification();
			T current = (T) enumerator.getCurrent();
			state = enumerator.MoveNext() ? 1 : -1;

			return current;
		}

		public void remove() {
			if (state <= 0) {
				throw new IllegalStateException();
			}
			checkForComodification();

			Collection.this.remove(enumerator.getCurrent());
			modCount--;
			expectedModCount = modCount;
		}

		final void checkForComodification() {
			if (modCount != expectedModCount) {
				throw new ConcurrentModificationException();
			}
		}
	}
}
