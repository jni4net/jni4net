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
package poc;

import com.sun.jna.Native;
import com.sun.jna.Pointer;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import system.drawing.Size;
import system.windows.forms.WebBrowser;
import uiinterop.winforms.WinForms;

import java.awt.*;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 5:19:51 PM
 */
public class TestCanvas extends Canvas {
    static {
        WinForms.init();
    }

    private boolean inited = false;
    private W32API.HWND hwndOld;
    //private WebBrowser browser;
    private system.windows.forms.Button browser;

    private W32API.HWND getHandle(long handle) {
        return new W32API.HWND(Pointer.createConstant(handle));
    }

    private W32API.HWND getHandle() {
        return getHandle(Native.getComponentID(this));
    }

    private W32API.HWND getBrowser() {
        return getHandle(browser.getHandle());
    }

    @Override
    public void addNotify() {
        super.addNotify();
        WinForms.invokeLater(new Runnable() {
                    public void run() {
                        //browser = new WebBrowser();
                        //browser.Navigate("http://www.google.com/");
                        browser = new system.windows.forms.Button();
                        browser.setText("lalala");
                        browser.CreateControl();
                    }
                });
        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            e.printStackTrace();  //To change body of catch statement use File | Settings | File Templates.
        }
        hwndOld = WINAPI_test.INSTANCE.SetParent(getBrowser(), getHandle());
        int style = User32.INSTANCE.GetWindowLong(getBrowser(), User32.GWL_STYLE);
        style |= WINAPI_test.WS_CHILD | WINAPI_test.WS_VISIBLE;
        User32.INSTANCE.SetWindowLong(getBrowser(), User32.GWL_STYLE, style);
        inited = true;
        addComponentListener(new ComponentAdapter() {
            public void componentResized(ComponentEvent evt) {
                if (inited) {
                    final Dimension d = getSize();
                    //System.err.println( poc.WINAPI_test.INSTANCE.SetWindowPos(getBrowser(), null, 0, 0, d.width, d.height, poc.WINAPI_test.SWP_NOMOVE | poc.WINAPI_test.SWP_NOZORDER) );
                    WinForms.invokeLater(new Runnable() {
                        public void run() {
                            browser.setSize(new Size(d.width, d.height));
                        }
                    });

                    //browser.setUrl(new system.String("http://www.google.com/"));
                }
            }
        });
    }

    @Override
    public void removeNotify() {
        int style = User32.INSTANCE.GetWindowLong(getBrowser(), User32.GWL_STYLE);
        style &= (~WINAPI_test.WS_CHILD) & (~WINAPI_test.WS_VISIBLE);
        User32.INSTANCE.SetWindowLong(getBrowser(), User32.GWL_STYLE, style);
        WINAPI_test.INSTANCE.SetParent(getBrowser(), hwndOld);
        hwndOld = null;
        super.removeNotify();
        inited = false;
    }

    @Override
    public void paint(Graphics g) {
    }
}
