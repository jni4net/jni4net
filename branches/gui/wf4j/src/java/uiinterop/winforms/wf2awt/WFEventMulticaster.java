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
package uiinterop.winforms.wf2awt;

import uiinterop.winforms.wf2awt.event.*;

import java.awt.*;
import java.util.EventListener;

/**
 * Created by Daniel Leping.
 * Date: May 21, 2010
 * Time: 4:43:46 AM
 */
public class WFEventMulticaster extends AWTEventMulticaster implements NavigationListener, HistoryChangeListener, DocumentCompletionListener {
    protected WFEventMulticaster(EventListener a, EventListener b) {
        super(a, b);
    }

    protected static EventListener addInternal(EventListener a, EventListener b) {
        if (a == null) return b;
        if (b == null) return a;
        return new WFEventMulticaster(a, b);
    }

    public static NavigationListener add(NavigationListener a, NavigationListener b) {
        return (NavigationListener) addInternal(a, b);
    }

    public static HistoryChangeListener add(HistoryChangeListener a, HistoryChangeListener b) {
        return (HistoryChangeListener) addInternal(a, b);
    }

    public static DocumentCompletionListener add(DocumentCompletionListener a, DocumentCompletionListener b) {
        return (DocumentCompletionListener) addInternal(a, b);
    }

    public static NavigationListener remove(NavigationListener l, NavigationListener oldl) {
        return (NavigationListener) removeInternal(l, oldl);
    }

    public static HistoryChangeListener remove(HistoryChangeListener l, HistoryChangeListener oldl) {
        return (HistoryChangeListener) removeInternal(l, oldl);
    }

    public static DocumentCompletionListener remove(DocumentCompletionListener l, DocumentCompletionListener oldl) {
        return (DocumentCompletionListener) removeInternal(l, oldl);
    }

    public void navigating(NavigatingEvent e) {
        ((NavigationListener) a).navigating(e);
        ((NavigationListener) b).navigating(e);
    }

    public void navigated(NavigatedEvent e) {
        ((NavigationListener) a).navigated(e);
        ((NavigationListener) b).navigated(e);
    }

    public void changedGoBack(HistoryChangedEvent e) {
        ((HistoryChangeListener) a).changedGoBack(e);
        ((HistoryChangeListener) b).changedGoBack(e);
    }

    public void changedGoForward(HistoryChangedEvent e) {
        ((HistoryChangeListener) a).changedGoForward(e);
        ((HistoryChangeListener) b).changedGoForward(e);
    }

    public void documentCompleted(DocumentCompletedEvent e) {
        ((DocumentCompletionListener) a).documentCompleted(e);
        ((DocumentCompletionListener) b).documentCompleted(e);
    }
}
