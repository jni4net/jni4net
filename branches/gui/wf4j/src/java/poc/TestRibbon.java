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
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import microsoft.windows.controls.ribbon.RibbonWindow;
import net.sf.jni4net.Bridge;
import system.*;
import system.drawing.Color;
import system.drawing.Point;
import system.drawing.Rectangle;
import system.drawing.Size;
import system.reflection.BindingFlags;
import system.windows.Window;
import system.windows.controls.Dock;
import system.windows.controls.DockPanel;
import system.windows.forms.*;
import uiinterop.winforms.WinForms;
import uiinterop.winforms.awt2wf.AbstractAWTFrame;
import uiinterop.winforms.ribbon.GenericCollectionHelper;
import uiinterop.winforms.swing2wf.SwingFrame;

import javax.swing.*;
import java.io.File;
import java.io.IOException;
import java.lang.String;

/**
 * Created by Daniel Leping.
 * Date: Feb 17, 2010
 * Time: 9:06:28 PM
 */
public class TestRibbon {
    static AbstractAWTFrame frame;
    static Form form;

    static interface LowLevelKeyboardProc extends com.sun.jna.examples.win32.User32.HOOKPROC {
        W32API.LRESULT callback(W32API.HWND hWnd, W32API.DWORD message, W32API.WPARAM wParam, W32API.LPARAM lParam);
    }

    public static void main(String[] args) throws IOException, InterruptedException {
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));
        //System.setProperty("sun.java2d.d3d", "false");//-Dsun.java2d.d3d=false -Dsun.java2d.trace=log
        WinForms.init();

        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.Windows.Forms.Ribbon.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.PresentationFramework.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.RibbonControlsLibrary.dll"));

        WinForms.invokeAndWait(new Runnable() {
            public void run() {
                frame = new SwingFrame();
                //Native.getWindowID(frame.getFrame())
                //User32.INSTANCE.GetWindowLong()
                //frame = new AWTFrame();
                //frame.setSize(new Size(500, 500));
                //frame.setDock((DockStyle) DockStyle.Parse(DockStyle.typeof(), "Fill"));
                //JPanel cp = new JPanel();
                //cp.setBackground(java.awt.Color.GREEN);
                //JButton cp = new JButton("BZZZZZZ");
                //frame.setContentPane(cp);
                //frame.getFrame().setBackground(java.awt.Color.GREEN);
            }
        });

        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                frame.setContentPane(TestFinal.createContentPane());
                WinForms.invokeLater(new Runnable() {
                    public void run() {
                        final RibbonForm form = new RibbonForm();
                        form.addClosed(new EventHandler() {
                            @Override
                            public void Invoke(system.Object sender, EventArgs e) {
                                Application.Exit();
                                SwingUtilities.invokeLater(new Runnable() {
                                    public void run() {
                                        System.exit(0);
                                    }
                                });
                            }
                        });

                        Type type = form.GetType();
                        BindingFlags bindingFlags = (BindingFlags) BindingFlags.Parse(BindingFlags.typeof(), "NonPublic, Instance");
                        system.Object bool = Type.GetType("System.Boolean").GetMethod("Parse").Invoke(null, new system.Object[]{Bridge.convert("false")});
                        system.reflection.MethodInfo methodInfo = type.GetMethod("SetStyle", bindingFlags);

//                        methodInfo.Invoke(form, new system.Object[]{ControlStyles.Parse(ControlStyles.typeof(), "ResizeRedraw"), bool});
//                        methodInfo.Invoke(form, new system.Object[]{ControlStyles.Parse(ControlStyles.typeof(), "Opaque"), bool});
//                        methodInfo.Invoke(form, new system.Object[]{ControlStyles.Parse(ControlStyles.typeof(), "AllPaintingInWmPaint"), bool});
                        //final Form form = new Form();
                        final Ribbon ribbon = new Ribbon();
                        form.addLayout(new LayoutEventHandler() {
                            private int margin = 8;

                            @Override
                            public void Invoke(system.Object sender, LayoutEventArgs e) {
                                if ("Bounds".equals(e.getAffectedProperty())) {
                                    Rectangle ribbonBounds = ribbon.getBounds();
                                    Size formSize = form.getClientSize();
                                    Rectangle frameBounds = new Rectangle(margin,
                                            ribbonBounds.getBottom(),
                                            formSize.getWidth() - 2 * margin,
                                            formSize.getHeight() - ribbonBounds.getBottom() - margin);
                                    form.SuspendLayout();
                                    frame.setBounds(frameBounds);
                                    form.ResumeLayout(false);
                                }
                            }
                        });


                        form.SuspendLayout();
                        ribbon.getOrbDropDown().setBorderRoundness(8);
                        ribbon.getOrbDropDown().setLocation(new system.drawing.Point(0, 0));
                        ribbon.getOrbDropDown().setSize(new system.drawing.Size(527, 474));
                        ribbon.getOrbDropDown().setTabIndex(0);
                        ribbon.setOrbImage(null);
                        //ribbon.setDock((DockStyle) DockStyle.Parse(DockStyle.typeof(), "Top"));
                        form.getControls().Add(ribbon);

                        RibbonTab ribbonTab = new RibbonTab();
                        ribbonTab.setText("Tab One");

                        RibbonTab ribbonTab2 = new RibbonTab();
                        ribbonTab2.setText("Tab Two");

                        RibbonTab ribbonTab3 = new RibbonTab();
                        ribbonTab3.setText("Tab Three");

                        //this is a replacement for ribbon.getTabs().Add(ribbonTab); while jni4net is in development early phase
                        GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab);
                        GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab2);
                        GenericCollectionHelper.add(ribbon.getTabs(), ribbonTab3);

                        //frame.setDock((DockStyle) DockStyle.Parse(DockStyle.typeof(), "Fill"));
                        form.getControls().Add(frame);

                        Button b = new Button();
                        b.setText("Fuck");
                        b.setLocation(new Point(8, 30));
                        //form.getControls().Add(b);
                        //frame.setLocation(new Point(0, 0));
                        //frame.setLocation(new Point(100, 100));
                        //frame.setSize(new Size(100, 100));

                        form.ResumeLayout(true);
                        form.setVisible(true);
                    }
                });
                //Frame frame = new Frame();
                //frame.addNotify();
                //System.out.println(Native.getWindowID(frame));
                //WFForm form = new WFForm();
                //form.setVisible(true);
            }
        });
    }
}