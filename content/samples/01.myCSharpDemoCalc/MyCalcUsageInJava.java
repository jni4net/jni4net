import mycsharpdemocalc.DemoCalc;
import mycsharpdemocalc.ICalc;

public class MyCalcUsageInJava {
    public static void main(String arsg[]) {
    		J4NBridge.CreateCLR();
    		
        ICalc calc = new DemoCalc();
        final int result = calc.MySuperSmartFunctionIDontHaveInJava("Answer to the Ultimate Question of Life, the Universe, and Everything");

        System.out.printf("Answer to the Ultimate Question is : " + result);
    }
}
