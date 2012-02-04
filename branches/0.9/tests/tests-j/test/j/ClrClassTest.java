/* Copyright (C) 2012 by Pavel Savara
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

package test.j;

import dummy.clr.ITested;
import dummy.clr.InterfacesFactory;
import dummy.clr.Tested;
import net.sf.jni4net.J4NBridge;
import org.junit.Assert;
import org.junit.Test;

public class ClrClassTest extends TestBase {
    @Test
    public void TestIfcFactory(){
        System.out.println(J4NBridge.getSetup().getCLRCoreLib());

        ITested tested = InterfacesFactory.createITested();
        System.out.println(((system.Object)tested).GetType());

        Assert.assertEquals("a", tested.getItem(1));
    }

    @Test
    public void TestIfcFactory2(){
        Tested tested = InterfacesFactory.createTested();
        int inf = tested.intField();
        tested.intField(654);
        Assert.assertEquals("a", tested.getItem(1));

        Assert.assertEquals(42, tested.test1(1,"",null));
    }
}
