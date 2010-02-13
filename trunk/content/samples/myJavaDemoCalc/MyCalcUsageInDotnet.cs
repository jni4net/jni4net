using System;
using democalc;
using net.sf.jni4net;

public class MyCalcUsageInDotnet
{
    public static void Main(string[] arsg)
    {
        var bridgeSetup = new BridgeSetup();
        bridgeSetup.AddAllJarsClassPath(".");
        Bridge.CreateJVM(bridgeSetup);
        Bridge.RegisterAssembly(typeof(DemoCalc).Assembly);

        ICalc calc = new DemoCalc();
        int result = calc.MySuperSmartFunctionIDontHaveInJava("Answer to the Ultimate Question of Life, the Universe, and Everything");

        Console.WriteLine("Answer to the Ultimate Question is : " + result);
    }
}
