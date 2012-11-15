using System;
using System.Collections.Generic;
using java.lang;
using java.util;

namespace Mitza.Jni4Net.Wrapper {

    class Enumerator<T> : IEnumerator<T>, IDisposable, System.Collections.IEnumerator
        where T : java.lang.Object {

        private Iterable iterable;
        private Iterator iterator;
        private T current;

        internal Enumerator(Iterable iterable) {
            this.iterable = iterable;
            this.iterator = iterable.iterator();
            this.current = default(T);
        }

        public bool MoveNext() {
            if (iterator.hasNext()) {
                current = (T)iterator.next();
                return true;
            }

            current = default(T);
            return false;
        }

        public void Reset() {
            current = default(T);
            iterator = iterable.iterator();
        }

        object System.Collections.IEnumerator.Current {
            get {
                if (this.current == default(T)) {
                    throw new InvalidOperationException("Enumeration invalid state");
                }
                return this.current;
            }
        }

        public T Current {
            get {
                return current;
            }
        }

        public void Dispose() {
        }
    }
}
