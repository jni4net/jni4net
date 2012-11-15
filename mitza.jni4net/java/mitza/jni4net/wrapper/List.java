package mitza.jni4net.wrapper;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collection;
import java.util.ConcurrentModificationException;
import java.util.Iterator;
import java.util.ListIterator;
import java.util.NoSuchElementException;

import system.collections.IEnumerator;
import system.collections.IList;

/**
 * @author Mihai Cadariu
 */
public class List<E extends system.Object> implements java.util.List<E> {

	private IList iList;
	// private final Type type;
	protected transient int modCount;

	public List(IList iList) {
		this.iList = iList;
		// this.type = getGenericType();
		// this.type = null;
		// System.out.println(type);
		// castToGeneric(iList);
	}

	@Override
	public boolean add(E element) {
		iList.Add(element);
		return true;
	}

	@Override
	public void add(int index, E element) {
		iList.Insert(index, element);
	}

	@Override
	public boolean addAll(Collection<? extends E> collection) {
		if (collection == null) {
			return false;
		}

		for (E element : collection) {
			iList.Add(element);
		}
		return true;
	}

	@Override
	public boolean addAll(int index, Collection<? extends E> collection) {
		if (collection == null) {
			return false;
		}

		for (E element : collection) {
			iList.Insert(index, element);
		}
		return true;
	}

	@Override
	public void clear() {
		iList.Clear();
	}

	@SuppressWarnings("unchecked")
	@Override
	public boolean contains(Object element) {
		return iList.Contains((E) element);
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

	@SuppressWarnings("unchecked")
	@Override
	public E get(int index) {
		return (E) iList.getItem(index);
	}

	@SuppressWarnings("unchecked")
	@Override
	public int indexOf(Object element) {
		return iList.IndexOf((E) element);
	}

	@Override
	public boolean isEmpty() {
		return iList.getCount() == 0;
	}

	@Override
	public Iterator<E> iterator() {
		return new Itr<E>();
	}

	@Override
	public int lastIndexOf(Object element) {
		ListIterator<E> listiterator = listIterator(size());

		if (element == null) {
			do {
				if (!listiterator.hasPrevious()) {
					return -1;
				}
			} while (listiterator.previous() != null);

			return listiterator.nextIndex();
		}

		do {
			if (!listiterator.hasPrevious()) {
				return -1;
			}
		} while (!element.equals(listiterator.previous()));

		return listiterator.nextIndex();
	}

	@Override
	public ListIterator<E> listIterator() {
		return listIterator(0);
	}

	@Override
	public ListIterator<E> listIterator(int index) {
		if (index < 0 || index > size()) {
			throw new IndexOutOfBoundsException((new StringBuilder()).append("Index: ").append(index).toString());
		} else {
			return new ListItr<E>(index);
		}
	}

	@SuppressWarnings("unchecked")
	@Override
	public boolean remove(Object element) {
		if (contains(element)) {
			iList.Remove((E) element);
			return true;
		}
		return false;
	}

	@Override
	public E remove(int index) {
		E element = get(index);
		if (element != null) {
			iList.RemoveAt(index);
			return element;
		}
		return null;
	}

	@Override
	public boolean removeAll(Collection<?> collection) {
		boolean result = false;
		for (Iterator<E> iterator = iterator(); iterator.hasNext();) {
			E element = iterator.next();
			if (collection.contains(element)) {
				iterator.remove();
				result = true;
			}
		}
		return result;
	}

	@Override
	public boolean retainAll(Collection<?> collection) {
		boolean result = false;
		for (Iterator<E> iterator = iterator(); iterator.hasNext();) {
			E element = iterator.next();
			if (!collection.contains(element)) {
				iterator.remove();
				result = true;
			}
		}
		return result;
	}

	@Override
	public E set(int index, E element) {
		iList.setItem(index, element);
		return element;
	}

	@Override
	public int size() {
		return iList.getCount();
	}

	@SuppressWarnings("unchecked")
	@Override
	public java.util.List<E> subList(int fromIndex, int toIndex) {
		java.util.List<E> result = new ArrayList<E>(toIndex - fromIndex + 1);
		for (int i = fromIndex; i < toIndex; i++) {
			E element = (E) iList.getItem(i);
			result.add(element);
		}
		return result;
	}

	@SuppressWarnings("unchecked")
	@Override
	public Object[] toArray() {
		Object[] result = new Object[size()];
		int i = 0;
		for (IEnumerator enumerator = iList.GetEnumerator(); enumerator.MoveNext();) {
			E element = (E) enumerator.getCurrent();
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
		for (IEnumerator enumerator = iList.GetEnumerator(); enumerator.MoveNext();) {
			E element = (E) enumerator.getCurrent();
			if (cc.isInstance(element)) {
				result[i++] = element;
			} else {
				return null;
			}
		}
		return (T[]) result;
	}

	@Override
	public String toString() {
		return String.format("%s<%s>", getClass().getName(), iList);
	}

	public IList getIList() {
		return iList;
	}

	/*
	 * 
	 * private Type getGenericType() { Type superclass = getClass().getGenericSuperclass(); if (superclass instanceof
	 * Class) { throw new RuntimeException("Missing type parameter."); } return ((ParameterizedType)
	 * superclass).getActualTypeArguments()[0]; }
	 * 
	 * private void castToGeneric(IList iList) { ParameterizedType pType = (ParameterizedType) type; // Type rawType =
	 * pType.getRawType(); Class<?> rawClass = type instanceof Class<?> ? (Class<?>) type : (Class<?>)
	 * ((ParameterizedType) type) .getRawType();
	 * 
	 * E item = (E) iList.getItem(0); System.out.println("\t" + item);
	 * 
	 * if (rawClass.getName().equals("mitza.jni4net.wrapper.KeyValuePair")) { // Type[] typeArguments =
	 * pType.getActualTypeArguments(); // Type keyType = typeArguments[0]; // Type valueType = typeArguments[1]; try {
	 * Constructor<E> constructor = (Constructor<E>) rawClass.getConstructors()[0]; java.util.List<E> list = new
	 * ArrayList<E>(size()); for (IEnumerator enumerator = iList.GetEnumerator(); enumerator.MoveNext();) {
	 * system.Object obj = enumerator.getCurrent(); if (DictionaryEntry.class.isInstance(obj)) { DictionaryEntry entry =
	 * (DictionaryEntry) obj; list.add(constructor.newInstance(entry.getKey(), entry.getValue())); } }
	 * 
	 * int i = 0; for (E kvp : list) { System.out.println("\t" + kvp); iList.setItem(i, kvp);
	 * 
	 * E itemOut = (E) iList.getItem(i); i++; System.out.println("\t" + itemOut); } } catch (Exception e) {
	 * e.printStackTrace(); } } }
	 * 
	 * @SuppressWarnings({ "rawtypes", "unchecked" }) private void castTo(IList iList) { java.util.List<E> list = new
	 * ArrayList<E>(size()); for (IEnumerator enumerator = iList.GetEnumerator(); enumerator.MoveNext();) {
	 * system.Object obj = enumerator.getCurrent(); if (DictionaryEntry.class.isInstance(obj)) { DictionaryEntry entry =
	 * (DictionaryEntry) obj; list.add((E) new KeyValuePair(entry.getKey(), entry.getValue())); } }
	 * 
	 * int i = 0; for (E element : list) { this.iList.setItem(i++, element); } }
	 */

	private class Itr<I> implements Iterator<E> {
		int cursor;
		int lastRet;
		int expectedModCount;

		public boolean hasNext() {
			return cursor != size();
		}

		public E next() {
			checkForComodification();

			try {
				E obj = (E) get(cursor);
				lastRet = cursor++;
				return obj;
			} catch (IndexOutOfBoundsException indexoutofboundsexception) {
				checkForComodification();
			}
			throw new NoSuchElementException();
		}

		public void remove() {
			if (lastRet == -1) {
				throw new IllegalStateException();
			}
			checkForComodification();

			try {
				List.this.remove(lastRet);
				if (lastRet < cursor) {
					cursor--;
				}
				lastRet = -1;
				expectedModCount = modCount;
			} catch (IndexOutOfBoundsException indexoutofboundsexception) {
				throw new ConcurrentModificationException();
			}
		}

		final void checkForComodification() {
			if (modCount != expectedModCount) {
				throw new ConcurrentModificationException();
			} else {
				return;
			}
		}

		private Itr() {
			super();
			cursor = 0;
			lastRet = -1;
			expectedModCount = modCount;
		}
	}

	private class ListItr<I> extends Itr<E> implements ListIterator<E> {
		public boolean hasPrevious() {
			return cursor != 0;
		}

		public E previous() {
			checkForComodification();
			try {
				int i = cursor - 1;
				E obj = (E) get(i);
				lastRet = cursor = i;
				return obj;
			} catch (IndexOutOfBoundsException indexoutofboundsexception) {
				checkForComodification();
			}
			throw new NoSuchElementException();
		}

		public int nextIndex() {
			return cursor;
		}

		public int previousIndex() {
			return cursor - 1;
		}

		public void set(E obj) {
			if (lastRet == -1) {
				throw new IllegalStateException();
			}
			checkForComodification();
			try {
				List.this.set(lastRet, obj);
				expectedModCount = modCount;
			} catch (IndexOutOfBoundsException indexoutofboundsexception) {
				throw new ConcurrentModificationException();
			}
		}

		public void add(E obj) {
			checkForComodification();
			try {
				List.this.add(cursor++, obj);
				lastRet = -1;
				expectedModCount = modCount;
			} catch (IndexOutOfBoundsException indexoutofboundsexception) {
				throw new ConcurrentModificationException();
			}
		}

		ListItr(int i) {
			super();
			cursor = i;
		}
	}
}
