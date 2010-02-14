/* Copyright (C) 2009 by Pavel Savara
This file is part of of jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

import system.windows.forms.Form;

/**
 * @author Pavel Savara (original)
 */
public class TestForm extends Form {
	private system.windows.forms.Button button1;
	
	int i=0;

	public void init(){
		this.button1 = new system.windows.forms.Button();
		this.SuspendLayout();
		//
		// button1
		//
		this.button1.setLocation(new system.drawing.Point(12, 12));
		this.button1.setName("button1");
		this.button1.setSize(new system.drawing.Size(130, 23));
		this.button1.setTabIndex(0);
		this.button1.setText("Huray");
		this.button1.addClick(new system.EventHandler(){
			  // this is implementation of .NET delegate by Java anonymous class
				public void Invoke(system.Object sender, system.EventArgs e){
					i++;
					button1.setText("Clicked " + i + "x times");
				}
			});
		//
		// TestForm
		//
		this.setAutoScaleDimensions (new system.drawing.SizeF(8F, 16F));
		this.setClientSize(new system.drawing.Size(292, 269));
		this.getControls().Add(this.button1);
		this.setName("TestForm");
		this.setText("This is Winforms Form");
		this.ResumeLayout(false);
		
	}
}
