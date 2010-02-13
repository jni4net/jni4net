#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
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

#endregion

using System;
using java.lang;
using net.sf.jni4net;

namespace interfaceFromCLR
{
    public class Program
    {
        private class CLRRunnable : Runnable
        {
            public string Message { private get; set; }
            public void run()
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("That's from CLR : " + Message);
            }
        }

        private static void Main()
        {
            Init();

            // that's CLR implementation of Java interface
            // java.lang.Runnable have it's proxy in jni4net
            // you could wrap any interface same way
            CLRRunnable clrRunnable = new CLRRunnable {Message = "I'm callback"};

            // we generated CLR proxy for java.lang.Thread as part of this demo, because it could accept Runnable
            // generate proxy for your own class/method which could accept Runnable interface
            Thread javaThread = new Thread(clrRunnable);
            javaThread.start();
            javaThread.join();
        }

        private static void Init()
        {
            BridgeSetup bridgeSetup = new BridgeSetup(true);
            bridgeSetup.AddClassPath(".");
            bridgeSetup.AddClassPath("work");
            Bridge.CreateJVM(bridgeSetup);
            Bridge.RegisterAssembly(typeof(Thread).Assembly);
        }
    }
}
