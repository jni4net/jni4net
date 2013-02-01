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
import com.sun.jna.examples.win32.GDI32;
import com.sun.jna.examples.win32.W32API;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 3:46:39 AM
 */
public interface WINAPI_test extends W32API {
    public WINAPI_test INSTANCE = (WINAPI_test) Native.loadLibrary("user32", WINAPI_test.class, DEFAULT_OPTIONS);

    HWND SetParent(HWND hWndChild, HWND hWndNewParent);
    int SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

    int WS_OVERLAPPED = 0x00000000;
    int WS_CHILD = 0x40000000;
    int WS_VISIBLE = 0x10000000;
    int WS_CLIPSIBLINGS = 0x04000000;
    int WS_CLIPCHILDREN = 0x02000000;
    int WS_THICKFRAME = 0x00040000;
    int WS_MINIMIZEBOX = 0x00020000;
    int WS_MAXIMIZEBOX = 0x00010000;
    int WS_BORDER = 0x00800000;
    int WS_DLGFRAME = 0x00400000;
    int WS_CAPTION = WS_BORDER | WS_DLGFRAME;
    int WS_SYSMENU = 0x00080000;
    int WS_POPUP = 0x80000000;
    
    int WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);

    int SWP_NOMOVE = 0x0002;
    int SWP_NOZORDER = 0x0004;

    public int WM_USER = 0x0400;
    public int WM_CREATE = 0x0001;
    public int WM_DESTROY = 0x0002;

    public int PostThreadMessage(DWORD idThread, int Msg, WPARAM wParam, LPARAM lParam);
    public LRESULT SendMessage(HWND hWnd, int Msg, WPARAM wParam, LPARAM lParam);
    public LRESULT DefWindowProc(HWND hWnd, int Msg, WPARAM wParam, LPARAM lParam);
    public int InvalidateRect(HWND hWnd, GDI32.RECT lpRect, int bErase);
    public int AttachThreadInput(DWORD idAttach, DWORD idAttachTo, int fAttach);
    public DWORD GetWindowThreadProcessId(HWND hWnd, Pointer lpdwProcessId);
}
