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

import com.sun.jna.Pointer;
import com.sun.jna.Proxy;
import com.sun.jna.Structure;
import com.sun.jna.examples.win32.GDI32;
import com.sun.jna.examples.win32.W32API;

import java.awt.*;

/**
 * Created by Daniel Leping.
 * Date: Feb 20, 2010
 * Time: 11:39:48 AM
 */
public class WndProcImpl implements WNDPROC {
    public static final int WM_APP = 0x8000;
    public static final int WM_AWT_COMPONENT_CREATE = WM_APP + 0x1800;


    public static final int WM_AWT_END_VALIDATE = WM_AWT_COMPONENT_CREATE + 13;

    public static final int WM_AWT_GETDC = WM_AWT_COMPONENT_CREATE + 42;
    public static final int WM_AWT_RELEASEDC = WM_AWT_GETDC + 1;

    WNDPROC proc;
    Component frame;

    public WndProcImpl(WNDPROC proc, Component frame) {
        this.proc = proc;
        this.frame = frame;
    }

    public int WVR_HREDRAW = 0x0100;
    public int WVR_VREDRAW = 0x0200;
    public int WVR_REDRAW = WVR_HREDRAW | WVR_VREDRAW;

    public class NCCALCSIZE_PARAMS extends Structure {
        public GDI32.RECT rect0, rect1, rect2;                    // Can't use an array here so simulate one
        public Pointer lppos;
    }

    public W32API.LRESULT callback(W32API.HWND hWnd, W32API.DWORD message, W32API.WPARAM wParam, W32API.LPARAM lParam) {
        W32API.LRESULT lresult = new W32API.LRESULT(0);
        /*if(WINAPI_test.INSTANCE.DefWindowProc(hWnd, message.intValue(), wParam, lParam).longValue() == 0) {
            return new W32API.LRESULT(0);
        } else */
        if (DWM.INSTANCE.DwmDefWindowProc(hWnd, message.intValue(), wParam, lParam, lresult) != 0) {
            return lresult;
        }
        /*if (message.intValue() == 0x0005) {
            //System.out.println("Message: " + Integer.toHexString(message.intValue()));
            int b = WINAPI_test.INSTANCE.InvalidateRect(hWnd, null, 1);
            return WINAPI_test.INSTANCE.DefWindowProc(hWnd, message.intValue(), wParam, lParam);
        } else */if (message.intValue() >= WM_AWT_COMPONENT_CREATE && message.intValue() != WM_AWT_COMPONENT_CREATE + 0xa) {
            System.err.println("Message: " + Integer.toHexString(message.intValue() - WM_AWT_COMPONENT_CREATE));
            return new W32API.LRESULT(1);
        } else if (message.intValue() == WM_AWT_GETDC) {
            return new W32API.LRESULT(1);
        } else if (message.intValue() == WM_AWT_RELEASEDC) {
            return new W32API.LRESULT(1);
        } else if (message.intValue() == 0x83 && wParam.longValue() == 1) {//clacsiza
            return new W32API.LRESULT(WVR_REDRAW);
        } else if (message.intValue() == 0x84) {//hittest
            return new W32API.LRESULT(1);
        } else if (message.intValue() == 0x000F) {
            //synchronized (frame.getTreeLock()) {
                system.drawing.Graphics g = system.drawing.Graphics.FromHwnd(Proxy.pointerPeer(hWnd.getPointer()));
                g.Clear(system.drawing.Color.getAqua());
                //frame.paint(new GraphicsNET(g));
                g.Dispose();
            //}

            //frame.repaint(0, 0, 100, 100);
            //System.out.println("Message: " + Integer.toHexString(message.intValue()));
            //return WINAPI_test.INSTANCE.DefWindowProc(hWnd, message.intValue(), wParam, lParam);//return new W32API.LRESULT(0);
        }
        return proc.callback(hWnd, message, wParam, lParam);
        //return new W32API.LRESULT(0);
    }
}
