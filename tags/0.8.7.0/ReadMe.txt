Visit and read http://jni4net.sf.net
Make sure you understand GPLv3 and LGPLv3 licenses.
Talk back at jni4net@googlegroups.com

----------------
To build this solution on Windows:
make sure you have 
- .NET SDK 3.5 installed at usual places
- .NET SDK 4.0 installed at usual places
- Java JDK 1.5
- JAVA_HOME set properly
- PATH to csc.exe in c:\Windows\Microsoft.NET\Framework\v3.5\
- PATH to sn.exe
- NUnit installed at C:\Program Files\NUnit-2.5.8.10295
- internet access to download components from maven repository
- make sure that you build it and run from (.NET) trusted location. Not shared drive.

run tools\loadTools.cmd
run tools\keys\gennetkey.cmd

In root directory run
mvnassembly.cmd

This should generate results into target directory in root of project.

----------------
To build this solution on Linux and Mono:
let me know that you need it and why
