@echo off
mkdir work
copy ..\..\lib\*.* work
Csc.exe /nologo /warn:0 /reference:..\..\lib\jni4net.n-0.5.0.0.dll /out:work/helloWorldFromCLR.exe /target:exe Program.cs