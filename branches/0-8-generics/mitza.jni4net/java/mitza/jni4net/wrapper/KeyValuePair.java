package mitza.jni4net.wrapper;

@net.sf.jni4net.attributes.ClrType
public class KeyValuePair<K extends system.Object, V extends system.Object> extends system.ValueType implements
		Map.Entry<K, V> {

	private static system.Type staticType;

	protected KeyValuePair(net.sf.jni4net.inj.INJEnv __env, long __handle) {
		super(__env, __handle);
	}

	@net.sf.jni4net.attributes.ClrConstructor("(LSystem/Object;LSystem/Object;)V")
	public KeyValuePair(system.Object key, system.Object value) {
		super(((net.sf.jni4net.inj.INJEnv) (null)), 0);
		mitza.jni4net.wrapper.KeyValuePair.__ctorKeyValuePair0(this, key, value);
	}

	@net.sf.jni4net.attributes.ClrMethod("(Lsystem/Object;Lsystem/Object;)V")
	private native static void __ctorKeyValuePair0(net.sf.jni4net.inj.IClrProxy thiz, system.Object key,
			system.Object value);

	@Override
	@net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
	public native K getKey();

	@net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
	public native void setKey(K value);

	@net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
	@Override
	public native V getValue();

	@net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)LSystem/Object;")
	@Override
	public native V setValue(V value);

	public static system.Type typeof() {
		return mitza.jni4net.wrapper.KeyValuePair.staticType;
	}

	@SuppressWarnings("unchecked")
	@Override
	public boolean equals(Object o) {
		if (!(o instanceof KeyValuePair)) {
			return false;
		}

		KeyValuePair<K, V> e1 = this;
		KeyValuePair<K, V> e2 = (KeyValuePair<K, V>) o;

		return (e1.getKey() == null ? e2.getKey() == null : e1.getKey().equals(e2.getKey())) &&
				(e1.getValue() == null ? e2.getValue() == null : e1.getValue().equals(e2.getValue()));
	}

	@Override
	public String toString() {
		return String.format("%s: %s", getKey(), getValue());
	}

	private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
		mitza.jni4net.wrapper.KeyValuePair.staticType = staticType;
	}
}
