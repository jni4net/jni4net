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
package uiinterop.winforms.awt2wf;

import com.sun.jna.*;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import poc.DWM;
import poc.WINAPI_test;
import poc.WNDPROC;
import poc.WndProcImpl;
import system.EventArgs;
import system.EventHandler;
import uiinterop.Utils;
import uiinterop.winforms.JITCreatedHwndControl;
import uiinterop.winforms.WinForms;

import javax.swing.*;
import java.awt.*;

import static com.sun.jna.Proxy.*;

/**
 * Created by Daniel Leping.
 * Date: Feb 15, 2010
 * Time: 12:40:29 AM
 */
public abstract class AWTControl<TComponent extends Component> extends JITCreatedHwndControl {
    private TComponent component;

    {
        WinForms.registerControl(this);
    }

    

    WNDPROC wndProc;

    @Override
    protected W32API.HWND createChild() {
        component = createComponent();
        component.addNotify();

        //W32API.HWND hwnd = Utils.longToHWND(Native.getComponentID(component));

        //W32API.HRESULT i = DWM.INSTANCE.DwmExtendFrameIntoClientArea(hwnd, new DWM.MARGINS(0, 0, 0, 0));
        //W32API.LONG_PTR oldWndProc = User32.INSTANCE.GetWindowLongPtr(hwnd, User32.GWL_WNDPROC);
        //wndProc = (WNDPROC)Proxy.p2c(WNDPROC.class, Pointer.createConstant(oldWndProc.longValue()));
        //Pointer p = User32.INSTANCE.SetWindowLongPtr(hwnd, User32.GWL_WNDPROC, c2p(wndProc = new WndProcImpl(wndProc, component)));
        

        return Utils.longToHWND(Native.getComponentID(component));
    }

    @Override
    protected W32API.HWND getChildHwnd() {
        if (childHwnd == null) {
            return super.getChildHwnd();
        }
        return Utils.longToHWND(Native.getComponentID(component));
    }

    protected abstract TComponent createComponent();

    protected TComponent getComponent() {
        if (childHwnd == null) {
            childHwnd = createChild();
        }
        return component;
    }

    @Override
    protected void ControlCreated() {
        super.ControlCreated();
        adviseEvents();
        initBounds();
    }

    @Override
    protected void ControlDestroyed() {
        unadviseEvents();
        super.ControlDestroyed();
    }

    protected void adviseEvents() {
        /*this.addVisibleChanged(new EventHandler() {
            @Override
            public void Invoke(system.Object sender, EventArgs e) {
                component.setVisible(true);
            }
        });*/
        /*addResize(new AbstractWinFormsEventHandler() {
            @Override
            protected void HandleEvent(system.Object sender, EventArgs e) {
                //component.invalidate();
                //component.setSize(getClientSize().getWidth(), getClientSize().getHeight());
            }
        });*/
        addResize(new EventHandler() {
            @Override
            public void Invoke(system.Object sender, EventArgs e) {
                //WINAPI_test.INSTANCE.SendMessage(getHwnd(), 0x0005, new W32API.WPARAM(0), new W32API.LPARAM(getHeight() << 16 | getWidth()));
                //int i = WINAPI_test.INSTANCE.SetWindowPos(getChildHwnd(), null, 0, 0, getClientSize().getWidth(), getClientSize().getHeight(), WINAPI_test.SWP_NOMOVE | WINAPI_test.SWP_NOZORDER);
                //int a = 1;
                component.setSize(getClientSize().getWidth(), getClientSize().getHeight());
            }
        });
        /*addPaint(new PaintEventHandler() {
            @Override
            public void Invoke(system.Object sender, PaintEventArgs e) {
                //SwingUtilities.invokeLater(new Runnable() {
                //    public void run() {
                e.getGraphics().DrawRectangle(e.getGraphics().);
                        component.paint(component.getGraphics().);
                        System.out.println("PAINT@@@");
                //    }
                //});
            }
        });*/
    }

    protected void unadviseEvents() {
    }

    protected void initBounds() {
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                component.setVisible(true);
                component.setLocation(new Point(0, 0));
                component.setSize(getClientSize().getWidth(), getClientSize().getHeight());
            }
        });
    }
}
