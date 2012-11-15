package mitza.jni4net.wrapper;

import java.util.Iterator;
import java.util.NoSuchElementException;

import mitza.jni4net.wrapper.IteratorState.State;
import system.collections.IEnumerator;

/**
 * @author Mihai Cadariu
 */
class IteratorBase<T> implements Iterator<T> {

	private IEnumerator enumerator;
	private State state;

	public IteratorBase(IEnumerator enumerator) {
		super();
		this.enumerator = enumerator;
		state = State.NOT_INITIALIZED;
	}

	public boolean hasNext() {
		if (state == State.NOT_INITIALIZED) {
			return moveNext();
		}
		return state == State.HAS_NEXT;
	}

	public T next() {
		if (state == State.NOT_INITIALIZED) {
			moveNext();
		}
		if (state == State.INVALID) {
			throw new NoSuchElementException();
		}
		T result = getCurrent();
		state = enumerator.MoveNext() ? State.HAS_NEXT : State.INVALID;

		return result;
	}

	public void remove() {
		throw new UnsupportedOperationException();
	}

	protected boolean moveNext() {
		state = enumerator.MoveNext() ? State.HAS_NEXT : State.INVALID;
		return state == State.HAS_NEXT;
	}

	@SuppressWarnings("unchecked")
	protected T getCurrent() {
		if (state == State.NOT_INITIALIZED) {
			throw new NoSuchElementException();
		}
		return (T) enumerator.getCurrent();
	}
}
