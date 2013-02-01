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
import system.drawing.Size;
import system.windows.forms.Application;
import system.windows.forms.DockStyle;
import system.windows.forms.Form;
import uiinterop.winforms.WinForms;
import uiinterop.winforms.awt2wf.AWTFrame;
import uiinterop.winforms.awt2wf.AbstractAWTFrame;
import uiinterop.winforms.wf2awt.WFButton;
import uiinterop.winforms.wf2awt.WFWebBrowser;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;

/**
 * Created by Daniel Leping.
 * Date: Feb 9, 2010
 * Time: 6:12:46 PM
 */
public class TestFinal {
    static AbstractAWTFrame frame;
    static Form form;

    public static Container createContentPane() {
        final WFWebBrowser browser = new WFWebBrowser();
        WFButton goButton = new WFButton();
        final JTextField addressField = new JTextField();
        //final TextField addressField = new TextField();

        goButton.setText("Go!");

        goButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                String url = addressField.getText();
                browser.navigate(url);
            }
        });

        Dimension goButtonSize = new Dimension(100, 25);
        goButton.setMaximumSize(goButtonSize);
        goButton.setMinimumSize(goButtonSize);
        goButton.setPreferredSize(goButtonSize);

        JPanel contentPane = new JPanel(new BorderLayout());
        JPanel addressPane = new JPanel(new BorderLayout());
        //Panel addressPane = new Panel(new BorderLayout());
        //Panel contentPane = new Panel(new BorderLayout());
        contentPane.add(browser, BorderLayout.CENTER);
        contentPane.add(addressPane, BorderLayout.NORTH);
        addressPane.add(goButton, BorderLayout.EAST);
        addressPane.add(addressField, BorderLayout.CENTER);
        return contentPane;
    }

    public static void main(String[] args) throws IOException, InterruptedException {
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));

        WinForms.init();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        WinForms.invokeAndWait(new Runnable() {
            public void run() {
                //frame = new SwingFrame();
                frame = new AWTFrame();
                frame.setSize(new Size(500, 500));
                frame.setDock((DockStyle) DockStyle.Parse(DockStyle.typeof(), "Fill"));
            }
        });

        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                frame.setContentPane(createContentPane());
                WinForms.invokeLater(new Runnable() {
                    public void run() {
                        form = new Form();
                        form.getControls().Add(frame);
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

        /*SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                final WFWebBrowser browser = new WFWebBrowser();
                WFButton goButton = new WFButton();
                final JTextField addressField = new JTextField();
                
                goButton.setText("Go!");


                goButton.addActionListener(new ActionListener() {
                    public void actionPerformed(ActionEvent e) {
                        String url = addressField.getText();
                        browser.navigate(url);
                    }
                });

                Dimension goButtonSize = new Dimension(100, 25);
                goButton.setMaximumSize(goButtonSize);
                goButton.setMinimumSize(goButtonSize);
                goButton.setPreferredSize(goButtonSize);

                JFrame frame = new JFrame("Browser");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

                JPanel contentPane = new JPanel(new BorderLayout());
                JPanel addressPane = new JPanel(new BorderLayout());
                contentPane.add(browser, BorderLayout.CENTER);
                contentPane.add(addressPane, BorderLayout.NORTH);
                addressPane.add(goButton, BorderLayout.EAST);
                addressPane.add(addressField, BorderLayout.CENTER);
                //contentPane.add(canvas);
                frame.setContentPane(contentPane);
                frame.setBounds(100, 100, 500, 500);
                frame.setVisible(true);
            }
        });   */
    }
}
