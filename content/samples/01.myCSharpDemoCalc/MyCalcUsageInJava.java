import mycsharpdemocalc.DemoCalc;
import mycsharpdemocalc.ICalc;
import net.sf.jni4net.BridgeSetup;
import net.sf.jni4net.J4NBridge;
import net.sf.jni4net.LogLevel;

public class MyCalcUsageInJava {
    public static void main(String arsg[]) {
        BridgeSetup initialSetup = new BridgeSetup();
        initialSetup.setLogLevel(LogLevel.INFO);
        J4NBridge.CreateCLR(initialSetup);
    		
        ICalc calc = new DemoCalc();
        final int result = calc.MySuperSmartFunctionIDontHaveInJava("Answer to the Ultimate Question of Life, the Universe, and Everything");

        System.out.printf("Answer to the Ultimate Question is : " + result);
    }
}
