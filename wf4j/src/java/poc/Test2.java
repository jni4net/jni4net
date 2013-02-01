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

import net.sf.jni4net.Bridge;
import uiinterop.winforms.wf2awt.WFButton;

import javax.swing.*;
import java.awt.*;
import java.io.File;
import java.io.IOException;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 4:36:09 PM
 */
public class Test2 {
    public static void main(String[] args) throws IOException, InterruptedException {
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));
                
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                //WFWebBrowser browser = new WFWebBrowser();
                WFButton browser = new WFButton();
                browser.setText("lalala");
                //browser.navigate("http://yahoo.com/");
                JFrame frame = new JFrame("Browser");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                JPanel contentPane = new JPanel(new BorderLayout());
                //contentPane.add(new JButton("AAAAA"), BorderLayout.CENTER);

                contentPane.add(browser, BorderLayout.CENTER);
                //contentPane.add(canvas);
                frame.setContentPane(contentPane);
                frame.setBounds(100, 100, 500, 500);
                frame.setVisible(true);
            }
        });
    }
}