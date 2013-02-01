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
import system.Environment;
import system.windows.forms.Form;
import uiinterop.winforms.WinForms;

import java.io.File;
import java.io.IOException;

/**
 * Created by Daniel Leping.
 * Date: Feb 10, 2010
 * Time: 3:03:15 PM
 */
public class FormTest {
    public static void main(String[] args) throws IOException, InterruptedException {
        Bridge.setVerbose(true);
        Bridge.setDebug(true);
        Bridge.init(new File("."));
        system.Console.WriteLine(Environment.getOSVersion());
        system.Console.WriteLine("Fuck!");
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.Drawing.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("Proxies.System.Windows.Forms.dll"));
        WinForms.init();
        WinForms.invokeAndWait(new Runnable() {
            public void run() {
                Form form = new Form();
                form.setVisible(true);
            }
        });
    }
}
