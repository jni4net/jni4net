1) You need to download Apache FOP and copy files below to lib directory

avalon-framework-4.2.0.jar
batik-all-1.7.jar
commons-io-1.3.1.jar
commons-logging-1.0.4.jar
fop.jar
ReadMe.txt
serializer-2.7.0.jar
xalan-2.7.0.jar
xercesImpl-2.7.1.jar
xml-apis-1.3.04.jar
xml-apis-ext-1.3.04.jar
xmlgraphics-commons-1.3.1.jar
List is the same as FOP lib directory plus fop.jar
I tried it with version 0.95 but later will probably work as well.

2) Copy jni4net libraries to lib directory
jni4net.n-0.2.0.0.dll
jni4net.j-0.2.0.0.jar

3) Then run generateProxies.cmd

4) open the project in Visual Studio 2008 compile it and run it in this directory.

5) It will load JVM, load FOP, run FOP on finle data\jni4net.fo and produce data\jni4net.pdf

Enjoy