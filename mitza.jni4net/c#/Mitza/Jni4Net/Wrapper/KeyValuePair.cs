namespace Mitza.Jni4Net.Wrapper {

    public class KeyValuePair {

        public KeyValuePair(object key, object value) {
            Key = key;
            Value = value;
        }

        public object Key { get; set; }

        public object Value { get; set; }
    }
}
