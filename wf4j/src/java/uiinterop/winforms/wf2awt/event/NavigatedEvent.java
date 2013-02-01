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

import system.Uri;
import system.windows.forms.WebBrowserNavigatedEventArgs;

import java.awt.*;

/**
 * Created by Daniel Leping.
 * Date: May 21, 2010
 * Time: 4:02:16 AM
 */
public class NavigatedEvent extends NavigationEvent<WebBrowserNavigatedEventArgs> {
    public NavigatedEvent(Event event, system.Object nativeSender, WebBrowserNavigatedEventArgs webBrowserNavigatingEventArgs) {
        super(event, nativeSender, webBrowserNavigatingEventArgs);
    }

    public NavigatedEvent(Object source, int id, system.Object nativeSender, WebBrowserNavigatedEventArgs webBrowserNavigatingEventArgs) {
        super(source, id, nativeSender, webBrowserNavigatingEventArgs);
    }

    @Override
    public Uri getUrl() {
        return getEventArgs().getUrl();
    }
}