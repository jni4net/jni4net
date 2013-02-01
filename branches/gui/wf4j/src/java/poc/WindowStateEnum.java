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

import system.windows.WindowState;

/**
 * Created by Daniel Leping.
 * Date: Feb 25, 2010
 * Time: 4:25:48 PM
 */
public class WindowStateEnum extends WindowState {
    public static WindowState Maximized = (WindowState)Parse(typeof(), "Maximized");
    public static WindowState Minimized = (WindowState)Parse(typeof(), "Minimized");
    public static WindowState Normal = (WindowState)Parse(typeof(), "Normal");
}
