using java.io;
using java.lang;
using java.util;
using net.sf.jni4net;

namespace helloWorldFromCLR
{
    public class Program
    {
        private static void Main()
        {
            // create bridge, with default setup
            // it will lookup jni4net.j.jar next to jni4net.n.dll
            Bridge.CreateJVM(new BridgeSetup());

            // here you go!
            java.lang.System.@out.println("Hello Java world!");

            // OK, simple hello is boring, let's play with Java properties
            // they are Hashtable realy
            Properties javaSystemProperties = java.lang.System.getProperties();

            // let's enumerate all keys
            Enumeration enumeration = javaSystemProperties.keys();
            while (enumeration.hasMoreElements())
            {
                // there hash table is not generic and returns java.lang.Object
                // but we know is should be java.lang.String, so we could cast
                var key = (java.lang.String) enumeration.nextElement();
                java.lang.System.@out.print(key);

                // this is automatic conversion of CLR string to java.lang.String
                java.lang.System.@out.print(" : ");

                // we use the hashtable
                Object value = javaSystemProperties.get(key);

                // and this is CLR ToString() redirected to Java toString() method
                string valueToString = value.ToString();
                java.lang.System.@out.println(valueToString);
            }

            // Java output is really Stream
            PrintStream stream = java.lang.System.@out;

            // it implements java.io.Flushable interface
            Flushable flushable = stream;
            flushable.flush();
        }
    }
}
