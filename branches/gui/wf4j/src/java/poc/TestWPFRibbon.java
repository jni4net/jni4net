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

import com.jacob.com.ComThread;
import com.sun.jna.Native;
import com.sun.jna.Pointer;
import com.sun.jna.Proxy;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import microsoft.windows.controls.ribbon.*;
import net.sf.jni4net.Bridge;
import system.runtime.interopservices.HandleRef;
import system.windows.Application;
import system.windows.Window;
import system.windows.controls.Dock;
import system.windows.controls.DockPanel;
import system.windows.interop.IWindowFactory;
import system.windows.interop.TargetedHwndHost;
import uiinterop.Utils;
import uiinterop.winforms.ribbon.GenericCollectionHelper;

import javax.swing.*;
import java.awt.*;
import java.io.File;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;

/**
 * Created by Daniel Leping.
 * Date: Feb 24, 2010
 * Time: 8:54:18 PM
 */
public class TestWPFRibbon {
    //static AWTFrame frame = null;
    //static JFrame jFrame = null;

    public static class AWTWPFControl extends TargetedHwndHost {
        JFrame frame;
        //Frame frame;
        IWindowFactory factory;

        public AWTWPFControl() {
            factory = new IWindowFactory() {
                Utils.ParentChangeDTO parentChangeDTO;

                public HandleRef CreateWindow(HandleRef hwndParent) {
//                    frame = new Frame();
//                    frame.addNotify();
//                    frame.setLayout(new BorderLayout());
//                    frame.add(new TextField("AAAAAAA"), BorderLayout.NORTH);
//                    frame.add(new Button("AAAAAAA"), BorderLayout.CENTER);
                    try {
                        SwingUtilities.invokeAndWait(new Runnable() {
                            public void run() {
                                frame = new JFrame();
                                frame.addNotify();
                                WNDPROC proc = (WNDPROC)Proxy.p2c(WNDPROC.class,
                                        Pointer.createConstant(
                                                User32.INSTANCE.GetWindowLongPtr(
                                                        new W32API.HWND(Pointer.createConstant(Native.getWindowID(frame))),
                                                        User32.GWL_WNDPROC).longValue()));
                                User32.INSTANCE.SetWindowLong(new W32API.HWND(Pointer.createConstant(Native.getWindowID(frame))), User32.GWL_WNDPROC, Proxy.c2p(new WndProcImpl(proc, frame)));
                                JPanel contentPane = new JPanel(new BorderLayout());
                                contentPane.add(new JTextField("AAAAAAA"), BorderLayout.NORTH);
                                contentPane.add(new JButton("AAAAAAA"), BorderLayout.CENTER);
                                frame.setContentPane(contentPane);
                            }
                        });
                    } catch (InterruptedException e) {
                        e.printStackTrace();  //To change body of catch statement use File | Settings | File Templates.
                    } catch (InvocationTargetException e) {
                        e.printStackTrace();  //To change body of catch statement use File | Settings | File Templates.
                    }
                    parentChangeDTO = Utils.attachChild(new W32API.HWND(Pointer.createConstant(hwndParent.getHandle())),
                            new W32API.HWND(Pointer.createConstant(Native.getWindowID(frame))));
                    //Utils.applyChildStyles(new W32API.HWND(Pointer.createConstant(Native.getWindowID(frame))));
                    return new HandleRef(AWTWPFControl.this, Native.getWindowID(frame));
                }

                public void DestroyWindow(HandleRef hwnd) {
                    Utils.detachChild(new W32API.HWND(Pointer.createConstant(Native.getWindowID(frame))), parentChangeDTO);
                    frame.removeNotify();
                    frame = null;
                }
            };
            setWindowFactory(factory);
        }
    }

    public static void main(String[] args) throws IOException, InvocationTargetException, InterruptedException {
        //System.setProperty("sun.java2d.d3d", "false");//-Dsun.java2d.d3d=false
        System.setProperty("sun.java2d.opengl", "true");
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));

        //System.setProperty("sun.java2d.d3d", "false");//-Dsun.java2d.d3d=false -Dsun.java2d.trace=log

        //WinForms.init();

        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.corlib.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.PresentationFramework.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.RibbonControlsLibrary.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.wpf4java.dll"));

//        SwingUtilities.invokeAndWait(new Runnable() {
//                        public void run() {
//                            frame = new AWTFrame();
//                            jFrame = new JFrame();
//                            //frame.setContentPane(TestFinal.createContentPane());
//                        }
//                    });

        new Thread() {
            public void run() {
                ComThread.InitSTA();
                //a hack ;) to run RibbonWindow - try without it and enjoy Microsoft's code quality 
                new Window();
                RibbonWindow window = new RibbonWindow();
                //Window window = new Window();
                //window.setResources(PopularApplicationSkins.getOffice2007Silver());
                //window.setResources(PopularApplicationSkins.getOffice2007Black());
                window.setResources(PopularApplicationSkins.getOffice2007Blue());
                DockPanel content = new DockPanel();
                Ribbon ribbon = new Ribbon();
                //window.setIconVisibility(VisibilityEnum.Collapsed);
                //ribbon.setWindowIconVisibility(VisibilityEnum.Visible);
                window.setContent(content);
                GenericCollectionHelper.add(content.getChildren(), ribbon);
                DockPanel.SetDock(ribbon, (Dock) Dock.Parse(Dock.typeof(), "Top"));

                //WindowsFormsHost host = new WindowsFormsHost();
                //host.setChild(frame);

                AWTWPFControl host = new AWTWPFControl();

                GenericCollectionHelper.add(content.getChildren(), host);
                DockPanel.SetDock(host, (Dock) Dock.Parse(Dock.typeof(), "Bottom"));


                RibbonTab ribbonTab1 = new RibbonTab();
                ribbonTab1.setLabel("Tab 1");
                RibbonTab ribbonTab2 = new RibbonTab();
                ribbonTab2.setLabel("Tab 2");
                RibbonTab ribbonTab3 = new RibbonTab();
                ribbonTab3.setLabel("Tab 3");

                GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab1);
                GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab2);
                GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab3);

                RibbonGroup ribbonGroup1 = new RibbonGroup();
                GenericCollectionHelper.add(ribbonGroup1.getControls(), new RibbonButton());
                GenericCollectionHelper.add(ribbonTab1.getGroups(), ribbonGroup1);

                RibbonGroup ribbonGroup2 = new RibbonGroup();
                GenericCollectionHelper.add(ribbonGroup2.getControls(), new RibbonButton());
                GenericCollectionHelper.add(ribbonTab2.getGroups(), ribbonGroup2);

                RibbonGroup ribbonGroup3 = new RibbonGroup();
                GenericCollectionHelper.add(ribbonGroup3.getControls(), new RibbonButton());
                GenericCollectionHelper.add(ribbonTab3.getGroups(), ribbonGroup3);

                Application app = new Application();
                app.Run(window);
            }
        }.start();
    }
}
