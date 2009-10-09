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
using System.IO;
using java.io;
using javax.xml.transform;
using javax.xml.transform.sax;
using javax.xml.transform.stream;
using net.sf.jni4net;
using org.apache.fop.apps;
using File=java.io.File;

namespace fop
{
    public class Program
    {
        /// <summary>
        /// Start this from directory \samples\samples\fop\
        /// with \samples\lib populated with jni4net.j.jar and jni4net.n.dll
        /// and with \samples\samples\fop\lib populated with FOP jar files.
        /// </summary>
        private static void Main()
        {
            FixStartupDirectory();

            // automaticaly setup Java classpath to find jni4net.j
            var setup = new BridgeSetup(true);

            // setup Java classpath to find FOP libraries
            setup.AddAllJarsClassPath("lib");

            // we don't need to call back from Java
            setup.BindStatic = false;

            // now we create JVM and bind jni4net core
            Bridge.CreateJVM(setup);

            // now we bind all proxies of FOP objects
            // which are compiled in this assembly
            Bridge.RegisterAssembly(typeof (Program).Assembly);

            const string inFileName = "data/jni4net.fo";
            const string outFileName = "data/jni4net.pdf";


            //Below is just plain Copy&Paste of FOP basic sample java code
            OutputStream output = null;
            try
            {
                // Step 1: Construct a FopFactory
                // (reuse if you plan to render multiple documents!)
                FopFactory fopFactory = FopFactory.newInstance();

                // Step 2: Set up output stream.
                output = new BufferedOutputStream(new FileOutputStream(new File(outFileName)));

                // Step 3: Construct fop with desired output format
                Fop fop = fopFactory.newFop(MimeConstants_.MIME_PDF, output);

                // Step 4: Setup JAXP using identity transformer
                TransformerFactory factory = TransformerFactory.newInstance();
                Transformer transformer = factory.newTransformer(); // identity transformer

                // Step 5: Setup input and output for XSLT transformation
                // Setup input stream
                Source src = new StreamSource(new File(inFileName));

                // Resulting SAX events (the generated FO) must be piped through to FOP
                Result res = new SAXResult(fop.getDefaultHandler());

                // Step 6: Start XSLT transformation and FOP processing
                transformer.transform(src, res);
            }
            finally
            {
                // Clean-up
                if (output != null)
                {
                    output.close();
                }
            }
        }

        private static void FixStartupDirectory()
        {
            if (Environment.CurrentDirectory.ToLowerInvariant().EndsWith(@"target"))
            {
                // to be able to find all files, we step up two levels
                Environment.CurrentDirectory = Path.GetFullPath(Environment.CurrentDirectory + @"\..");
            }
        }
    }
}
