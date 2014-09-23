Warning: This is not newbie topic and the sample may be obsolete.

1) Make sure you have environment prepared properly. See `ReadMe.md` file in root.

2) You need to download Apache FOP and copy files below to lib directory
For example this [FOP](http://archive.apache.org/dist/xmlgraphics/fop/binaries/fop-0.95-bin.zip)

3) Extract zip file and copy jar files from `fop-0.95\build\` and `fop-0.95\lib\` into `samples\fop\lib\` directory
```
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
```

4) Copy jni4net libraries to `samples\fop\lib\` directory
```
jni4net.n-0.x.0.0.dll
jni4net.j-0.x.0.0.jar
```

5) Look at the `samples\fop\fop.proxygen.xml` file. It defines what proxies will be generated.

6) Then run `samples\fop\generateProxies.cmd`, it will generate C# proxies for Java classes

7) Open the project in Visual Studio 2008 compile it and run it in this `samples\fop\` directory.

8) It will load JVM, load FOP, run FOP on file `samples\fop\data\jni4net.fo` and produce `samples\fop\data\jni4net.pdf`

Enjoy