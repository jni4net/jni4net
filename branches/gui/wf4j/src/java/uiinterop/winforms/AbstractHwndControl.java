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
package uiinterop.winforms;

import com.sun.jna.examples.win32.W32API;
import poc.WINAPI_test;
import system.EventArgs;
import system.windows.forms.Control;
import uiinterop.Utils;

/**
 * Created by Daniel Leping.
 * Date: Feb 15, 2010
 * Time: 12:45:27 AM
 */
public abstract class AbstractHwndControl extends Control {
    static {
        WinForms.init();
    }

    private class HandleCreatedHandler extends AbstractWinFormsEventHandler {
        {
            addHandleCreated(this);
        }

        @Override
        protected void HandleEvent(system.Object sender, EventArgs e) {
            ControlCreated();
        }
    }

    private class HandleDestroyedHandler extends AbstractWinFormsEventHandler {
        {
            addHandleDestroyed(this);
        }

        @Override
        protected void HandleEvent(system.Object sender, EventArgs e) {
            ControlDestroyed();
        }
    }

    private HandleCreatedHandler handleCreatedHandler = new HandleCreatedHandler();
    private HandleDestroyedHandler handleDestroyedHandler = new HandleDestroyedHandler();

    protected void ControlCreated() {
        attachChild();
    }

    protected void ControlDestroyed() {
        detachChild();
    }

    private Utils.ParentChangeDTO parentChange = null;
    protected W32API.HWND childHwnd = null;

    protected W32API.HWND getHwnd() {
        return Utils.longToHWND(getRealHandle());
    }

    protected W32API.HWND getChildHwnd() {
        return childHwnd;
    }

    protected long getRealHandle() {
        Control c = this;
        do {
            if (c.isHandleCreated()) {
                break;
            }
            c = c.getParent();
        } while (c != null);
        return c == null ? 0 : c.getHandle();
    }

    protected void attachChild() {
        if (parentChange != null) {
            detachChild();
        }
        W32API.HWND child;
        parentChange = Utils.attachChild(getHwnd(), child = getChildHwnd());
        WinForms.registerForeignWindow(child);
    }

    protected void detachChild() {
        if (parentChange != null) {
            Utils.detachChild(getChildHwnd(), parentChange);
            parentChange = null;
        }
    }
}