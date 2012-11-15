package mitza.jni4net.wrapper;

import java.util.Iterator;

/**
 * @author Mihai Cadariu
 */
public class Iterable<E> implements java.lang.Iterable<E> {

	private system.collections.IEnumerable iEnumerable;

	public Iterable(system.collections.IEnumerable iEnumerable) {
		this.iEnumerable = iEnumerable;
	}

	@Override
	public Iterator<E> iterator() {
		return new IteratorBase<E>(iEnumerable.GetEnumerator());
	}

	@Override
	public String toString() {
		return String.format("%s<%s>", getClass().getName(), iEnumerable);
	}

	public system.collections.IEnumerable getIEnumerable() {
		return iEnumerable;
	}
}
