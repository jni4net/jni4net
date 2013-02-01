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

import system.EventArgs;
import system.EventHandler;
import system.Uri;
import system.Version;
import system.io.Stream;
import system.windows.forms.*;
import uiinterop.winforms.wf2awt.event.*;

import java.awt.*;
import java.util.EventListener;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 4:24:57 PM
 */
public class WFWebBrowser<TWebBrowser extends WebBrowser> extends WFWebBrowserBase<TWebBrowser> {
    @Override
    protected TWebBrowser createControl() {
        checkIsActualClass(WFWebBrowser.class);
        WebBrowser webBrowser = new WebBrowser();
        webBrowser.addNavigating(new WebBrowserNavigatingEventHandler() {
            @Override
            public void Invoke(system.Object sender, WebBrowserNavigatingEventArgs e) {
                postEvent(new NavigatingEvent(
                        WFWebBrowser.this,
                        NavigatingEvent.NAVIGATION_NAVIGATING,
                        sender, e));
            }
        });
        webBrowser.addNavigated(new WebBrowserNavigatedEventHandler() {
            @Override
            public void Invoke(system.Object sender, WebBrowserNavigatedEventArgs e) {
                postEvent(new NavigatedEvent(
                        WFWebBrowser.this,
                        NavigatedEvent.NAVIGATION_NAVIGATED,
                        sender, e));
            }
        });
        webBrowser.addCanGoBackChanged(new EventHandler() {
            @Override
            public void Invoke(system.Object sender, EventArgs e) {
                postEvent(new HistoryChangedEvent(
                        WFWebBrowser.this,
                        HistoryChangedEvent.HISTORY_CHANGED_GO_BACK,
                        sender, e));
            }
        });
        webBrowser.addCanGoForwardChanged(new EventHandler() {
            @Override
            public void Invoke(system.Object sender, EventArgs e) {
                postEvent(new HistoryChangedEvent(
                        WFWebBrowser.this,
                        HistoryChangedEvent.HISTORY_CHANGED_GO_FORWARD,
                        sender, e));
            }
        });
        webBrowser.addDocumentCompleted(new WebBrowserDocumentCompletedEventHandler() {
            @Override
            public void Invoke(system.Object sender, WebBrowserDocumentCompletedEventArgs e) {
                postEvent(new DocumentCompletedEvent(
                        WFWebBrowser.this,
                        DocumentCompletedEvent.DOCUMENT_COMPLETED_EVENT,
                        sender, e));
            }
        });
        //noinspection unchecked
        return (TWebBrowser) webBrowser;
    }

    //process events
    //TODO: implement events:
    //TODO: DocumentTitleChanged, EncryptionLevelChanged, FileDownload, NewWindow
    //TODO: ProgressChanged, StatusTextChanged

    private NavigationListener navigationListener;
    private HistoryChangeListener historyChangeListener;
    private DocumentCompletionListener documentCompletionListener;

    public synchronized void addNavigationListener(NavigationListener l) {
        if (l == null) {
            return;
        }
        navigationListener = WFEventMulticaster.add(navigationListener, l);
    }

    public synchronized void removeNavigationListener(NavigationListener l) {
        if (l == null) {
            return;
        }
        navigationListener = WFEventMulticaster.remove(navigationListener, l);
    }

    public synchronized NavigationListener[] getNavigationListeners() {
        return getListeners(NavigationListener.class);
    }

    public synchronized void addHistoryChangeListener(HistoryChangeListener l) {
        if (l == null) {
            return;
        }
        historyChangeListener = WFEventMulticaster.add(historyChangeListener, l);
    }

    public synchronized void removeHistoryChangeListener(HistoryChangeListener l) {
        if (l == null) {
            return;
        }
        historyChangeListener = WFEventMulticaster.remove(historyChangeListener, l);
    }

    public synchronized HistoryChangeListener[] getHistoryChangeListeners() {
        return getListeners(HistoryChangeListener.class);
    }

    public synchronized void addDocumentCompletionListener(DocumentCompletionListener l) {
        if (l == null) {
            return;
        }
        documentCompletionListener = WFEventMulticaster.add(documentCompletionListener, l);
    }

    public synchronized void removeDocumentCompletionListener(DocumentCompletionListener l) {
        if (l == null) {
            return;
        }
        documentCompletionListener = WFEventMulticaster.remove(documentCompletionListener, l);
    }

    public synchronized DocumentCompletionListener[] getDocumentCompletionListeners() {
        return getListeners(DocumentCompletionListener.class);
    }

    public <T extends EventListener> T[] getListeners(Class<T> listenerType) {
        EventListener l = null;
        if (listenerType == NavigationListener.class) {
            l = navigationListener;
        } else if (listenerType == HistoryChangeListener.class) {
            l = historyChangeListener;
        } else {
            return super.getListeners(listenerType);
        }
        return WFEventMulticaster.getListeners(l, listenerType);
    }

    protected void processEvent(AWTEvent e) {
        if (e instanceof NavigatingEvent) {
            processNavigatingEvent((NavigatingEvent) e);
        } else if (e instanceof NavigatedEvent) {
            processNavigatedEvent((NavigatedEvent) e);
        } else if (e instanceof HistoryChangedEvent) {
            processHistoryChangedEvent((HistoryChangedEvent) e);
        } else if (e instanceof DocumentCompletedEvent) {
            processDocumentCompletedEvent((DocumentCompletedEvent) e);
        } else {
            super.processEvent(e);
        }
    }

    protected void processNavigatingEvent(NavigatingEvent event) {
        NavigationListener listener = navigationListener;
        if (listener != null) {
            listener.navigating(event);
        }
    }

    protected void processNavigatedEvent(NavigatedEvent event) {
        NavigationListener listener = navigationListener;
        if (listener != null) {
            listener.navigated(event);
        }
    }

    protected void processHistoryChangedEvent(HistoryChangedEvent event) {
        HistoryChangeListener listener = historyChangeListener;
        if (listener != null) {
            switch (event.getID()) {
                case HistoryChangedEvent.HISTORY_CHANGED_GO_BACK:
                    listener.changedGoBack(event);
                    break;
                case HistoryChangedEvent.HISTORY_CHANGED_GO_FORWARD:
                    listener.changedGoForward(event);
                    break;
            }
        }
    }

    protected void processDocumentCompletedEvent(DocumentCompletedEvent event) {
        DocumentCompletionListener listener = documentCompletionListener;
        if (listener != null) {
            listener.documentCompleted(event);
        }
    }

    //Web Browser Methods go here

    public boolean goBack() {
        return getControl().GoBack();
    }

    public boolean goForward() {
        return getControl().GoForward();
    }

    public void goHome() {
        getControl().GoHome();
    }

    public void goSearch() {
        getControl().GoSearch();
    }

    //TODO: implement other overloads on demand

    public void navigate(String url) {
        getControl().Navigate(url);
    }

    public void print() {
        getControl().Print();
    }

    public void refresh(WebBrowserRefreshOption opt) {
        getControl().Refresh(opt);
    }

    public void refresh() {
        getControl().Refresh();
    }

    public void showPageSetupDialog() {

        getControl().ShowPageSetupDialog();
    }

    public void showPrintDialog() {
        getControl().ShowPrintDialog();
    }

    public void showPrintPreviewDialog() {
        getControl().ShowPrintPreviewDialog();
    }

    public void showPropertiesDialog() {
        getControl().ShowPropertiesDialog();
    }

    public void showSaveAsDialog() {
        getControl().ShowSaveAsDialog();
    }

    public void stop() {
        getControl().Stop();
    }

    //Web Browser Properties go here

    public boolean isAllowNavigation() {
        return getControl().getAllowNavigation();
    }

    public void setAllowNavigation(boolean allowNavigation) {
        getControl().setAllowNavigation(allowNavigation);
    }

    public boolean isAllowWebBrowserDrop() {
        return getControl().getAllowWebBrowserDrop();
    }

    public void setAllowWebBrowserDrop(boolean allowWebBrowserDrop) {
        getControl().setAllowWebBrowserDrop(allowWebBrowserDrop);
    }

    public boolean isCanGoBack() {
        return getControl().getCanGoBack();
    }

    public boolean isCanGoForward() {
        return getControl().getCanGoForward();
    }

    public HtmlDocument getDocument() {
        return getControl().getDocument();
    }

    public Stream getDocumentStream() {
        return getControl().getDocumentStream();
    }

    public void setDocumentStream(Stream stream) {
        getControl().setDocumentStream(stream);
    }

    public String getDocumentText() {
        return getControl().getDocumentText();
    }

    public void setDocumentText(String text) {
        getControl().setDocumentText(text);
    }

    public String getDocumentTitle() {
        return getControl().getDocumentTitle();
    }

    public String getDocumentType() {
        return getControl().getDocumentType();
    }

    public WebBrowserEncryptionLevel getEncryptionLevel() {
        return getControl().getEncryptionLevel();
    }

    public boolean isFocused() {
        return getControl().getFocused();
    }

    public boolean isBusy() {
        return getControl().isBusy();
    }

    public boolean isWebBrowserContextMenuEnabled() {
        return getControl().isWebBrowserContextMenuEnabled();
    }

    public void setWebBrowserContextMenuEnabled(boolean enabled) {
        getControl().setIsWebBrowserContextMenuEnabled(enabled);
    }

    public system.Object getObjectForScripting() {
        return getControl().getObjectForScripting();
    }

    public void setObjectForScripting(system.Object object) {
        getControl().setObjectForScripting(object);
    }

    public WebBrowserReadyState getReadyState() {
        return getControl().getReadyState();
    }

    public boolean isScriptErrorsSuppressed() {
        return getControl().getScriptErrorsSuppressed();
    }

    public void setScriptErrorsSuppressed(boolean suppressed) {
        getControl().setScriptErrorsSuppressed(suppressed);
    }

    public boolean isScrollBarsEnabled() {
        return getControl().getScrollBarsEnabled();
    }

    public void setScrollBarsEnabled(boolean enabled) {
        getControl().setScrollBarsEnabled(enabled);
    }

    public String getStatusText() {
        return getControl().getStatusText();
    }

    public Uri getUrl() {
        return getControl().getUrl();
    }

    public void setUrl(Uri url) {
        getControl().setUrl(url);
    }

    public Version getVersion() {
        return getControl().getVersion();
    }

    public boolean isWebBrowserShortcutsEnabled() {
        return getControl().getWebBrowserShortcutsEnabled();
    }

    public void setWebBrowserShortcutsEnabled(boolean enabled) {
        getControl().setWebBrowserShortcutsEnabled(enabled);
    }
}
