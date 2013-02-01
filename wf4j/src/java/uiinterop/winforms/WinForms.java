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

import com.sun.jna.Native;
import com.sun.jna.Pointer;
import com.sun.jna.examples.win32.Kernel32;
import com.sun.jna.examples.win32.W32API;
import net.sf.jni4net.Bridge;
import net.sf.jni4net.Ref;
import poc.WINAPI_test;
import system.EventArgs;
import system.EventHandler;
import system.drawing.Point;
import system.windows.forms.*;
import uiinterop.winforms.awt2wf.AWTControl;

import javax.swing.*;
import java.io.File;
import java.lang.reflect.InvocationTargetException;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.Set;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 4:53:14 AM
 */
public class WinForms implements Runnable, IMessageFilter {
    private static final int WM_INVOKELATER = WINAPI_test.WM_USER + 0x0100;

    private static WinForms INSTANCE;
    private static Thread THREAD;
    private static final LinkedList<Runnable> INVOKE_QUEUE = new LinkedList<Runnable>();

    private static EventHandler resizeHandler = new EventHandler() {
        @Override
        public void Invoke(final system.Object sender, EventArgs e) {
            if (sender instanceof Control) {
                registerControlForm((Control) sender);
            }
            INSTANCE.processInvokeLaters();
        }
    };

    public static void registerControl(AWTControl control) {
        control.addClientSizeChanged(resizeHandler);
        registerControlForm(control);
    }

    private static final Set<Integer> controlsRegistered = new HashSet<Integer>();
    private static final Set<Integer> formsRegistered = new HashSet<Integer>();

    private static void registerControlForm(Control control) {
        if (controlsRegistered.contains(control.hashCode())) {
            return;
        }
        Form form = null;
        Control c = control;
        System.out.println(c.hashCode());
        Set<Integer> controlsRegistered = new HashSet<Integer>();
        while (form == null && c != null) {
            if (c instanceof Form) {
                form = (Form) c;
            } else if (c instanceof ContainerControl) {
                ContainerControl cc = (ContainerControl) c;
                form = cc.getParentForm();
            }
            controlsRegistered.add(c.hashCode());
            c = c.getParent();
        }
        registerForm(form, controlsRegistered);
    }

    private static void registerForm(Form form, Set<Integer> controlsRegistered) {
        if (form != null) {
            WinForms.controlsRegistered.addAll(controlsRegistered);
            registerForm(form);
        }
    }

    private static void registerForm(Form form) {
        if (!formsRegistered.contains(form.hashCode())) {
            formsRegistered.add(form.hashCode());
            form.addResizeEnd(new EventHandler() {
                @Override
                public void Invoke(system.Object sender, EventArgs e) {
                    INSTANCE.processInvokeLaters();
                }
            });
        }
    }

    private static W32API.DWORD THREAD_ID = null;

    public static void init() {
        if (INSTANCE == null) {
            //It is actually essential, if not - some .net controls will be flickering
            System.setProperty("sun.java2d.d3d", "false");//-Dsun.java2d.d3d=false
            Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.corlib.dll"));
            Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.dll"));
            Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.Drawing.dll"));
            Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.Windows.Forms.dll"));
            INSTANCE = new WinForms();
            THREAD = new Thread(INSTANCE);
            THREAD.setName("WinForms");
            THREAD.setDaemon(false);
            THREAD.start();
            synchronized (INVOKE_QUEUE) {
                try {
                    INVOKE_QUEUE.wait();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
    }

    public static void invokeLater(Runnable runnable) {
        synchronized (INVOKE_QUEUE) {
            try {
                if (THREAD_ID == null) {
                    INVOKE_QUEUE.wait();
                }
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            INVOKE_QUEUE.addLast(runnable);
            INVOKE_QUEUE.notify();
        }
        if (THREAD_ID != null) {
            if (WINAPI_test.INSTANCE.PostThreadMessage(THREAD_ID,
                    WM_INVOKELATER,
                    new W32API.WPARAM(0),
                    new W32API.LPARAM(0)) == 0) {
                throw new RuntimeException("Unable to Post Thread Message");
            }
        }
    }

    public static void invokeAndWait(final Runnable runnable) throws InterruptedException {
        System.out.println("BEFORE - 1");
        synchronized (runnable) {
            System.out.println("AFTER - 1");
            invokeLater(new Runnable() {
                public void run() {
                    System.out.println("BEFORE - 2");
                    synchronized (runnable) {
                        System.out.println("AFTER - 2");
                        runnable.run();
                        System.out.println("BEFORE - INVOKE_QUEUE.notify();");
                        runnable.notify();
                        System.out.println("AFTER - INVOKE_QUEUE.notify();");
                    }
                }
            });
            System.out.println("BEFORE - INVOKE_QUEUE.wait();");
            runnable.wait();
            System.out.println("AFTER - INVOKE_QUEUE.wait();");
        }
    }

    static void registerForeignWindow(W32API.HWND window) {
        W32API.DWORD windowThread = WINAPI_test.INSTANCE.GetWindowThreadProcessId(window, null);
        INSTANCE.attachThread(windowThread);
    }

    static void unregisterForeignWindow(W32API.HWND window) {
        //nothing for now, but could be useful later
    }

    private Set<Long> threadsAttached = new HashSet<Long>();

    private void attachThread(W32API.DWORD id) {
        if(threadsAttached.contains(id.longValue())) {
            return;
        }
        attachThreadWrapped(id);
        threadsAttached.add(id.longValue());
    }

    private void attachThreadWrapped(W32API.DWORD id, boolean attach) {
        if(THREAD_ID.longValue() == id.longValue()) {
            return;
        }
        if( WINAPI_test.INSTANCE.AttachThreadInput(THREAD_ID, id, attach ? 1 : 0) == 0 ) {
            throw new RuntimeException("Unable to " +
                    (attach ? "attach" : "detach") +
                    " thread " + id +
                    (attach ? " to " : " from ") +
                    THREAD_ID +
                    "\tError Code: " + Native.getLastError());
        }
    }

    private void attachThreadWrapped(W32API.DWORD id) {
        attachThreadWrapped(id, true);
    }

    private void detachThreadWrapped(W32API.DWORD id) {
        attachThreadWrapped(id, false);
    }

    public void run() {
        synchronized (INVOKE_QUEUE) {
            Application.AddMessageFilter(this);
            THREAD_ID = new W32API.DWORD(Kernel32.INSTANCE.GetCurrentThreadId());
            processInvokeLaters();
            INVOKE_QUEUE.notifyAll();
        }
        Application.Run();
        /*for (; ;) {
            Application.DoEvents();
            Runnable runnable = null;
            boolean hasEvents;
            synchronized (INVOKE_QUEUE) {
                hasEvents = INVOKE_QUEUE.size() > 0;
            }
            while (hasEvents) {
                synchronized (INVOKE_QUEUE) {
                    runnable = INVOKE_QUEUE.removeFirst();
                }
                if (runnable != null) {
                    runnable.run();
                }
                synchronized (INVOKE_QUEUE) {
                    hasEvents = INVOKE_QUEUE.size() > 0; 
                }
            }
        }       */

        //Application.DoEvents();
        //SwingUtilities.invokeLater(INSTANCE);
    }

    public boolean PreFilterMessage(Ref<Message> m) {
        boolean result;
        int msg = -1;
        //long hwnd = -1;
        try {
            //cool hack, seems that we should not invoke getValue on Ref...
            msg = (Integer) m.getClass().getMethod("getMsg").invoke(m);
            //hwnd = (Long) m.getClass().getMethod("getHWnd").invoke(m);
        } catch (IllegalAccessException e) {
            e.printStackTrace();
        } catch (InvocationTargetException e) {
            e.printStackTrace();
        } catch (NoSuchMethodException e) {
            //e.printStackTrace();
            return false;
        }
        //System.out.println("Message: " + Integer.toHexString(msg) + "\tWindow: " + Long.toHexString(hwnd));
        if (result = (msg == WM_INVOKELATER)) {
            processInvokeLaters();
        }
        return result;
    }

    private void processInvokeLaters() {
        boolean hasEvents;
        Runnable runnable;
        synchronized (INVOKE_QUEUE) {
            hasEvents = INVOKE_QUEUE.size() > 0;
        }
        while (hasEvents) {
            synchronized (INVOKE_QUEUE) {
                runnable = INVOKE_QUEUE.removeFirst();
            }
            if (runnable != null) {
                runnable.run();
            }
            synchronized (INVOKE_QUEUE) {
                hasEvents = INVOKE_QUEUE.size() > 0;
            }
        }
    }
}
