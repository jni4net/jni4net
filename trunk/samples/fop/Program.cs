﻿using System.IO;
using java.io;
using javax.xml.transform;
using javax.xml.transform.sax;
using javax.xml.transform.stream;
using net.sf.jni4net;
using org.apache.fop.apps;
using File=java.io.File;

namespace fop
{
    internal class Program
    {
        /// <summary>
        /// Start this from directory \samples\fop\
        /// </summary>
        private static void Main(string[] args)
        {
            BridgeSetup setup= new BridgeSetup();
            setup.BindStatic = false;
            setup.AddBridgeClassPath();
            setup.AddAllJarsClassPath("../../lib");
            Bridge.CreateJVM(setup);

            Bridge.RegisterAssembly(typeof(Program).Assembly);

            string inFileName = "../../data/jni4net.fo";
            string outFileName = "../../data/jni4net.pdf";

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
                //Clean-up
                if (output != null)
                {
                    output.close();
                }
            }
        }
    }
}
