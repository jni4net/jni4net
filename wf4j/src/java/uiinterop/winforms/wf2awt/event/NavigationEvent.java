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
package uiinterop.winforms.wf2awt.event;

import system.EventArgs;
import system.Uri;

import java.awt.*;

/**
 * Created by Daniel Leping.
 * Date: May 21, 2010
 * Time: 4:02:16 AM
 */
public abstract class NavigationEvent<TEventArgs extends EventArgs> extends WFEvent<TEventArgs> {
    /**
     * The first number in the range of ids used for navigation events.
     */
    public static final int NAVIGATION_FIRST        = 0x10001;

    /**
     * The last number in the range of ids used for navigation events.
     */
    public static final int NAVIGATION_LAST         = 0x10002;

    /**
     * This event id indicates that a navigation will start.
     */
    public static final int NAVIGATION_NAVIGATING   = NAVIGATION_FIRST;

    /**
     * This event id indicates that a navigation is done.
     */
    public static final int NAVIGATION_NAVIGATED    = NAVIGATION_NAVIGATING + 1;

    private Uri url;

    public NavigationEvent(Event event, system.Object nativeSender, TEventArgs eventArgs) {
        super(event, nativeSender, eventArgs);
        this.url = url;
    }

    public NavigationEvent(Object source, int id, system.Object nativeSender, TEventArgs eventArgs) {
        super(source, id, nativeSender, eventArgs);
    }

    public abstract Uri getUrl();
}
