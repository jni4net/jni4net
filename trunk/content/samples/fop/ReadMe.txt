1) You need to download Apache FOP and copy files below to lib directory
For example this
http://public.picvi.com/apache/xmlgraphics/fop/binaries/fop-0.95-bin.zip

2) Extract zip file and copy jar files from fop-0.95\build\ and fop-0.95\lib\ into samples\fop\lib\ directory
avalon-framework-4.2.0.jar
batik-all-1.7.jar
commons-io-1.3.1.jar
commons-logging-1.0.4.jar
fop.jar
serializer-2.7.0.jar
xalan-2.7.0.jar
xercesImpl-2.7.1.jar
xml-apis-1.3.04.jar
xml-apis-ext-1.3.04.jar
xmlgraphics-commons-1.3.1.jar

3) Copy jni4net libraries to samples\fop\lib\ directory
jni4net.n-0.x.0.0.dll
jni4net.j-0.x.0.0.jar

4) Then run samples\fop\generateProxies.cmd, it ill generate C# wrappers for Java classes

5) open the project in Visual Studio 2008 compile it and run it in this (samples\fop\) directory.

6) It will load JVM, load FOP, run FOP on file samples\fop\data\jni4net.fo and produce samples\fop\data\jni4net.pdf

Enjoy