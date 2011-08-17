using System;
using java.lang;
using java.util;
using net.sf.jni4net;
using org.drools;
using org.drools.tutorials.banking;
using Exception = java.lang.Exception;
using Object = java.lang.Object;

namespace examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var bridgeSetup = new BridgeSetup();
                bridgeSetup.AddAllJarsClassPath(".");
                bridgeSetup.IgnoreJavaHome = true;
                //bridgeSetup.Verbose = true;
                Bridge.CreateJVM(bridgeSetup);
                Bridge.RegisterAssembly(typeof(Date).Assembly);
                Bridge.RegisterAssembly(typeof(KnowledgeBaseFactory).Assembly);
                Bridge.RegisterAssembly(typeof(TypedCashflow_).Assembly);

                Example1();
                Example2();
                Example3();
                Example4();
                Example5();
                Example6();
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Example1()
        {
            new RuleRunner().runRules(new[] {"Example1.drl"}, new Object[0]);
        }

        public static void Example2()
        {
            var numbers = new Number[] {wrap(3), wrap(1), wrap(4), wrap(1), wrap(5)};
            new RuleRunner().runRules(new[] {"Example2.drl"}, numbers);
        }

        public static void Example3()
        {
            var numbers = new Number[] {wrap(3), wrap(1), wrap(4), wrap(1), wrap(5)};
            new RuleRunner().runRules(new[] {"Example3.drl"}, numbers);
        }


        public static void Example4()
        {
            Object[] cashflows = {
                                     Bridge.WrapCLR(new Cashflow("01/01/2007", 300.00)),
                                     Bridge.WrapCLR(new Cashflow("05/01/2007", 100.00)),
                                     Bridge.WrapCLR(new Cashflow("11/01/2007", 500.00)),
                                     Bridge.WrapCLR(new Cashflow("07/01/2007", 800.00)),
                                     Bridge.WrapCLR(new Cashflow("02/01/2007", 400.00)),
                                 };

            new RuleRunner().runRules(new[] {"Example4.drl"}, cashflows);
        }


        public static void Example5()
        {
            Object[] cashflows = {
                                     Bridge.WrapCLR(new TypedCashflow(("01/01/2007"), TypedCashflow.CREDIT, 300.00)),
                                     Bridge.WrapCLR(new TypedCashflow(("05/01/2007"), TypedCashflow.CREDIT, 100.00)),
                                     Bridge.WrapCLR(new TypedCashflow(("11/01/2007"), TypedCashflow.CREDIT, 500.00)),
                                     Bridge.WrapCLR(new TypedCashflow(("07/01/2007"), TypedCashflow.DEBIT, 800.00)),
                                     Bridge.WrapCLR(new TypedCashflow(("02/01/2007"), TypedCashflow.DEBIT, 400.00)),
                                 };

            new RuleRunner().runRules(new[] {"Example5.drl"}, cashflows);
        }

        public static void Example6()
        {
            Account acc1 = new Account(1);
            Account acc2 = new Account(2);
           
            Object[] cashflows = {
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("01/01/2007"),TypedCashflow.CREDIT, 300.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("05/02/2007"),TypedCashflow.CREDIT, 100.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc2,("11/03/2007"),TypedCashflow.CREDIT, 500.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("07/02/2007"),TypedCashflow.DEBIT,  800.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc2,("02/03/2007"),TypedCashflow.DEBIT,  400.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("01/04/2007"),TypedCashflow.CREDIT, 200.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("05/04/2007"),TypedCashflow.CREDIT, 300.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc2,("11/05/2007"),TypedCashflow.CREDIT, 700.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc1,("07/05/2007"),TypedCashflow.DEBIT,  900.00)),
                Bridge.WrapCLR(new AllocatedCashflow(acc2,("02/05/2007"),TypedCashflow.DEBIT,  100.00))           
            };
        
            new RuleRunner().runRules( new string[] { "Example6.drl" },cashflows );
        }

        private static Integer wrap(int i)
        {
            return new Integer(i);
        }
    }
}
