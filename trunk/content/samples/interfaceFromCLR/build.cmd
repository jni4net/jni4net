@echo off
mkdir work\java_\lang
javac -cp ../../lib/jni4net.j-0.8.6.0.jar -d work/ work/java_/lang/Thread_.java

copy ..\..\lib\*.* work
Csc.exe /nologo /warn:0 /reference:..\..\lib\jni4net.n-0.8.6.0.dll /out:work/InterfaceFromCLR.exe /target:exe Program.cs work\java\lang\Thread.generated.cs 