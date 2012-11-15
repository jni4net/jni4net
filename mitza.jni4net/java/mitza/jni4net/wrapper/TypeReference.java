package mitza.jni4net.wrapper;

import java.lang.reflect.ParameterizedType;
import java.lang.reflect.Type;

/**
 * References a generic type.
 * 
 * @author crazybob@google.com (Bob Lee)
 */
public abstract class TypeReference<T> {

	private final Type type;

	protected TypeReference() {
		Type superclass = getClass().getGenericSuperclass();
		if (superclass instanceof Class) {
			throw new RuntimeException("Missing type parameter.");
		}
		this.type = ((ParameterizedType) superclass).getActualTypeArguments()[0];
	}

	public Type getType() {
		return this.type;
	}
}
