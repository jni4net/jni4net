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

import com.sun.jna.Native;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import poc.WINAPI_test;

import java.awt.*;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 3:33:33 PM
 */
public class AbstractHwndCanvas extends Canvas {
    private Utils.ParentChangeDTO parentChange = null;
    protected W32API.HWND childHwnd = null;

    protected W32API.HWND getHwnd() {
        return Utils.longToHWND(Native.getComponentID(this));
    }

    protected W32API.HWND getChildHwnd() {
        return childHwnd;
    }

    @Override
    public void addNotify() {
        super.addNotify();
        attachChild();
    }

    @Override
    public void removeNotify() {
        detachChild();
        super.removeNotify();
    }

    protected void attachChild() {
        if(parentChange != null) {
            detachChild();
        }
        parentChange = Utils.attachChild(getHwnd(), getChildHwnd());
    }

    protected void detachChild() {
        if(parentChange != null) {
            Utils.detachChild(getChildHwnd(), parentChange);
            parentChange = null;
        }
    }

    @Override
    public void paint(Graphics g) {
    }
}
