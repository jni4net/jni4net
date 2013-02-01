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
import com.sun.jna.Pointer;
import com.sun.jna.examples.win32.User32;
import com.sun.jna.examples.win32.W32API;
import net.sf.jni4net.Bridge;
import system.Console;
import system.Environment;
import system.drawing.Size;
import system.windows.forms.WebBrowser;
import uiinterop.winforms.WinForms;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.io.File;
import java.io.IOException;

/**
 * Created by Daniel Leping.
 * Date: Feb 8, 2010
 * Time: 9:55:37 PM
 */
public class Test3 {
    private static WebBrowser browser;

    public static void main(String[] args) throws IOException {
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));
        Console.WriteLine(Environment.getOSVersion());
        Console.WriteLine("Fuck!");
        Bridge.LoadAndRegisterAssemblyFrom(new File("winforms_proxies.dll"));
        Console.WriteLine("Loaded!");
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                //final Control browser = new system.windows.forms.Button();
                //browser.setText("lalala");
//                WinForms.invokeLater(new Runnable() {
//                    public void run() {
//                        browser = new WebBrowser();
//                        browser.Navigate("http://www.google.com/");
//                    }
//                });
                try {
                    Thread.sleep(5000);
                } catch (InterruptedException e) {
                    e.printStackTrace();  //To change body of catch statement use File | Settings | File Templates.
                }
                //browser.setUrl(new system.String("http://www.google.com/"));
                JFrame frame = new JFrame("Browser");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

                TestCanvas canvas = new TestCanvas();

                JPanel contentPane = new JPanel(new BorderLayout());
                //contentPane.add(new JButton("AAAAA"), BorderLayout.CENTER);

                contentPane.add(canvas, BorderLayout.CENTER);
                //contentPane.add(canvas);
                frame.setContentPane(contentPane);
                frame.setBounds(100, 100, 500, 500);
                frame.setVisible(true);
            }
        });
    }
}