/* Copyright (C) 2010 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/
package net.sf.jni4net;

/**
 * @author Pavel Savara (original)
 */
public class Ref<TRef> {
    private TRef value;

    public Ref(TRef value) {
        this.value = value;
    }

    public TRef getValue() {
        return value;
    }

    @Override
    public java.lang.String toString() {
        if (value == null) {
            return null;
        }
        return value.toString();
    }

    @Override
    public boolean equals(java.lang.Object o) {
        if (value == null && o == null) {
            return true;
        }
        if (value == null || o == null) {
            return false;
        }
        if (Ref.class.isAssignableFrom(o.getClass())) {
            return value.equals(((Ref) o).value);
        }
        return value.equals(o);
    }

    @Override
    public int hashCode() {
        if (value == null) {
            return 0;
        }
        return value.hashCode();
    }
}
