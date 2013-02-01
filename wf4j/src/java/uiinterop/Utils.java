/*
wf4j (WinForms for Java) is a library that allows to provide interop betwean WinForms and Java windows
Copyright (C) 2009-2013 Daniel Leping

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

If you have any questions contact me by e-mail: dileping@gmail.com
*/
package uiinterop;

import com.sun.jna.Pointer;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import poc.WINAPI_test;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 3:35:24 PM
 */
public class Utils {
    public static class ParentChangeDTO {
        private W32API.HWND parent;
        private int style;

        public ParentChangeDTO() {
        }

        public ParentChangeDTO(W32API.HWND parent, int style) {
            this.parent = parent;
            this.style = style;
        }

        public W32API.HWND getParent() {
            return parent;
        }

        public void setParent(W32API.HWND parent) {
            this.parent = parent;
        }

        public int getStyle() {
            return style;
        }

        public void setStyle(int style) {
            this.style = style;
        }
    }

    public static W32API.HWND longToHWND(long handle) {
        return new W32API.HWND(Pointer.createConstant(handle));
    }

    public static ParentChangeDTO attachChild(W32API.HWND parent, W32API.HWND child) {
        ParentChangeDTO parentChangeDTO = new ParentChangeDTO();
        parentChangeDTO.setParent(WINAPI_test.INSTANCE.SetParent(child, parent));
        parentChangeDTO.setStyle(applyChildStyles(child));
        return parentChangeDTO;
    }

    /**
     *
     * @param child
     * @return Old style
     */
    public static int applyChildStyles(W32API.HWND child) {
        int result;
        int style = result = User32.INSTANCE.GetWindowLong(child, User32.GWL_STYLE);
        style |= WINAPI_test.WS_CHILD | WINAPI_test.WS_VISIBLE;
        style &= ~WINAPI_test.WS_OVERLAPPEDWINDOW;
        style &= ~WINAPI_test.WS_POPUP;
        applyStyle(child, style);
        return result;
    }

    public static void detachChild(W32API.HWND child, ParentChangeDTO parentChangeDTO) {
        applyStyle(child, parentChangeDTO.getStyle());
        WINAPI_test.INSTANCE.SetParent(child, parentChangeDTO.getParent());
    }

    public static void applyStyle(W32API.HWND hwnd, int style) {
        User32.INSTANCE.SetWindowLong(hwnd, User32.GWL_STYLE, style);
    }
}
