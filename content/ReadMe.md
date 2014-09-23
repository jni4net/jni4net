To get started
----------------
Visit and read [jni4net.sf.net](http://jni4net.sf.net)

Make sure you understand GPLv3 and MIT licenses.
- runtime is licensed under MIT.
- proxygen and tools under GPLv3.

Talk back at [jni4net](jni4net@googlegroups.com) or [Pavel Savara](pavel.savara@gmail.com)


To use this bridge at runtime you need
----------------
- Windows 32 or 64 bit (unixes and Mono are not supported yet)
- .NET Runtime 2.0 or later
- JRE 1.5 or later
- JAVA_HOME environment set properly, 
- On 64bit system: 64bit Java installation, PATH leads to 64bit (server) version
- on console run: `java -version` to check it

How to use
----------------
- Download [binary](http://sourceforge.net/projects/jni4net/files/0.8.7/jni4net-0.8.7.0-bin.zip/download) package.
- study samples inside of the package, read `samples\ReadMe.md` play along.
- Try `samples\helloWorldFromCLR` there is ReadMe.md inside.
- Try `samples\helloWorldFromJVM` there is ReadMe.md inside. 
- [How calling from Java to .NET works](http://zamboch.blogspot.cz/2009/11/how-calling-from-java-to-net-works-in.html)
- [How calling from .NET to Java works](http://zamboch.blogspot.cz/2009/10/how-calling-from-net-to-java-works.html)
- [Troubleshooter](http://jni4net.sourceforge.net/troubleshoot.shtml)
- [Email group](https://groups.google.com/forum/?hl=en#!forum/jni4net)

To use this jni4net bridge for development you need as well
----------------
- JDK 1.5 or above
- .NET SDK 3.5 or above
- Visual Studio 2012
- Ant build tool
- Eclipse or any other Java IDE
- csc.exe and javac.exe on PATH

Folder structure of binary package
----------------

```
bin\     - contains proxygen tool, it's development tool for jni4net
lib\     - contains .NET DLLs and Java .jar files of jni4net. 
           If you redeploy jni4net lib directory is all you need.
           The DLLs and .jar file should reside in same directory 
           (as well as rest of your .NET DLLs)
   \jni4net.n-0.x.0.0.dll      - .NET side of the bridge
   \jni4net.j-0.x.0.0.jar      - Java side of the bridge
   \jni4net.n.w32-0.x.0.0.dll  - Native helper for initial call from 32bit Java on Windows
   \jni4net.n.w64-0.x.0.0.dll  - Native helper for initial call from 64bit Java on Windows
   \jni4net-MIT-3.0.txt        - License for redistributable runtime files, all files in lib\ folder
samples\ - contains sample applications and tutorials, see `ReadMe.md`.txt in there for details
```