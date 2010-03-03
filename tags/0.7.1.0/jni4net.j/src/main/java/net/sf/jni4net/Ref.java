/* Copyright (C) 2010 by Pavel Savara
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as
published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
