import net.sf.jni4net.Bridge;

import java.io.IOException;

import mycsharpdemocalc.DemoCalc;
import mycsharpdemocalc.ICalc;

public class MyCalcUsageInJava {
    public static void main(String arsg[]) throws IOException {
        Bridge.init();
        Bridge.LoadAndRegisterAssembly("MyCSharpDemoCalc.j4n.dll");

        ICalc calc = new DemoCalc();
        final int result = calc.MySuperSmartFunctionIDontHaveInJava("Answer to the Ultimate Question of Life, the Universe, and Everything");

        System.out.printf("Answer to the Ultimate Question is : " + result);
    }
}
