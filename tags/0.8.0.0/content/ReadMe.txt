Visit and read http://jni4net.sf.net
Make sure you understand GPL and LGPL licenses.
Talk back at jni4net@googlegroups.com or pavel.savara@gmail.com


----------------
To use this bridge at runtime you need:
- Windows 32 or 64 bit (unixes and Mono are not supported yet)
- .NET Runtime 2.0 or later
- JRE 1.5 or later
- JAVA_HOME environment set properly, 


----------------
On 64bit system, make sure that you use 64bit Java installation. 
On console run:
java -version
and verify that your PATH leads to 64bit (server) version of Java


----------------
To use this bridge for development you need as well:
- JDK 1.5 or above
- .NET SDK 3.5 or above

Good to have (for samples)
- Visual Studio 2008 (Express edition works as well)
- Ant build tool
- Eclipse or any other Java IDE
- csc.exe and javac.exe on PATH


----------------
Folder structure

bin\     - contains proxygen tool, it's development tool for jni4net
lib\     - contains .NET DLLs and Java .jar files of jni4net. 
           If you redeploy jni4net lib directory is all you need.
           The DLLs and .jar file should reside in same directory 
           (as well as rest of your .NET DLLs)
   \jni4net.n-0.x.0.0.dll      - .NET side of the bridge
   \jni4net.j-0.x.0.0.jar      - Java side of the bridge
   \jni4net.n.w32-0.x.0.0.dll  - Native helper for initial call from 32bit Java on Windows
   \jni4net.n.w64-0.x.0.0.dll  - Native helper for initial call from 64bit Java on Windows
   \jni4net-LGPL-3.0.txt       - License for redistributable files, all files in lib\ folder
samples\ - contains sample applications and tutorials, see Read.Me.txt in there for details
