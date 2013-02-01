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

import com.sun.jna.examples.win32.W32API;
import sun.misc.Regexp;
import system.Console;
import system.EventArgs;
import system.EventHandler;
import system.drawing.Size;
import system.windows.forms.Control;
import uiinterop.JITCreatedHwndCanvas;
import uiinterop.Utils;
import uiinterop.winforms.WinForms;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import java.util.EventListener;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 4:08:44 PM
 */
public abstract class WFControl<TControl extends Control> extends JITCreatedHwndCanvas implements ComponentListener {
    static {
        WinForms.init();
    }

    private TControl control;
    private ActionListener actionListener = null;

    /**
     * Use this method in every implementation of createControl methods
     *
     * @param actualClazz your actual class (don't obtain it by this.getClass)
     */
    protected void checkIsActualClass(Class actualClazz) {
        if(!this.getClass().equals(actualClazz)) {
            throw new RuntimeException("You must override \"createControl\" method in every non-abstract subclass");
        }
    }

    protected static void postEvent(AWTEvent event) {
        Toolkit.getDefaultToolkit().getSystemEventQueue().postEvent(event);
    }

    @Override
    protected W32API.HWND createChild() {
        try {
            WinForms.invokeAndWait(new Runnable() {
                public void run() {
                    control = createControl();
                    control.CreateControl();
                }
            });
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return Utils.longToHWND(control.getHandle());
    }

    @Override
    protected W32API.HWND getChildHwnd() {
        if (childHwnd == null) {
            return super.getChildHwnd();
        }
        return Utils.longToHWND(control.getHandle());
    }

    protected abstract TControl createControl();

    protected TControl getControl() {
        if (childHwnd == null) {
            childHwnd = createChild();
        }
        return control;
    }

    @Override
    public void addNotify() {
        super.addNotify();
        adviseEvents();
        addComponentListener(this);
    }

    @Override
    public void removeNotify() {
        removeComponentListener(this);
        unadviseEvents();
        super.removeNotify();
    }

    public void componentResized(final ComponentEvent e) {
        final Dimension d = getSize();
        //Console.WriteLine(control);
        WinForms.invokeLater(new Runnable() {
            public void run() {
                //System.out.print(e.paramString());
                //System.out.println(d.getSize());
                Pattern pattern = Pattern.compile("COMPONENT_RESIZED \\(\\d,\\d+ (\\d+?)x(\\d+?)\\)");
                Matcher matcher = pattern.matcher(e.paramString());
                if(matcher.find()) {
                    control.setSize(new Size(
                            Integer.valueOf(matcher.group(1)),
                            Integer.valueOf(matcher.group(2))));
                }
            }
        });
    }

    public void componentMoved(ComponentEvent e) {
    }

    public void componentShown(ComponentEvent e) {
    }

    public void componentHidden(ComponentEvent e) {
    }

    protected void adviseEvents() {
        control.addClick(clickEventHandler);
    }

    protected void unadviseEvents() {
        control.removeClick(clickEventHandler);
    }

    private EventHandler clickEventHandler = new EventHandler() {
        @Override
        public void Invoke(system.Object sender, EventArgs e) {
            if ((sender instanceof Control) &&
                    ((Control) sender).getHandle() == getControl().getHandle()) {
                //will add command and id later
                processActionEvent(new ActionEvent(this, 0, null));
            }
        }
    };

    public synchronized void addActionListener(ActionListener l) {
        if (l == null) {
            return;
        }
        actionListener = AWTEventMulticaster.add(actionListener, l);
    }

    public synchronized void removeActionListener(ActionListener l) {
        if (l == null) {
            return;
        }
        actionListener = AWTEventMulticaster.remove(actionListener, l);
    }

    public synchronized ActionListener[] getActionListeners() {
        return getListeners(ActionListener.class);
    }

    public <T extends EventListener> T[] getListeners(Class<T> listenerType) {
        EventListener l = null;
        if (listenerType == ActionListener.class) {
            l = actionListener;
        } else {
            return super.getListeners(listenerType);
        }
        return AWTEventMulticaster.getListeners(l, listenerType);
    }

    protected void processEvent(AWTEvent e) {
        if (e instanceof ActionEvent) {
            processActionEvent((ActionEvent) e);
            return;
        }
        super.processEvent(e);
    }

    protected void processActionEvent(ActionEvent e) {
        ActionListener listener = actionListener;
        if (listener != null) {
            listener.actionPerformed(e);
        }
    }
}
