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

import system.EventArgs;
import system.EventHandler;

import javax.swing.*;

/**
 * Created by Daniel Leping.
 * Date: Feb 15, 2010
 * Time: 3:48:17 PM
 *
 * This thing is requered to handle events that are got from winforms.
 * If not use this - application will hang up on access to instance members sometimes.
 */
public abstract class AbstractWinFormsEventHandler extends EventHandler {
    @Override
    public void Invoke(final system.Object sender, final EventArgs e) {
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                HandleEvent(sender, e);
            }
        });
    }

    protected abstract void HandleEvent(system.Object sender, EventArgs e);
}
