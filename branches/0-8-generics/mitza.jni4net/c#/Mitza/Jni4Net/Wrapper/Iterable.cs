using System.Collections.Generic;
using java.lang;

namespace Mitza.Jni4Net.Wrapper {

    public class Iterable<T> : IEnumerable<T> where T : java.lang.Object {

        private Iterable iterable;
        public Iterable WrappedIterable {
            get { return iterable; }
        }

        public Iterable(Iterable iterable) {
            this.iterable = iterable;
        }

        public IEnumerator<T> GetEnumerator() {
            return new Enumerator<T>(iterable);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return new Enumerator<T>(iterable);
        }
    }
}
