@echo off
set JNI4NETHOME=..\..\
if NOT EXIST ..\..\bin\proxygen.exe set JNI4NETHOME=..\..\..\_target\0.9.0.0\

copy %JNI4NETHOME%\runtime\*.* work
%JNI4NETHOME%\bin\proxygen.exe work\MyCSharpDemoCalc-j4n.xml -dll work\MyCSharpDemoCalc.dll
rem cd work
rem call build.cmd
rem cd ..

rem echo compiling usage
rem javac -d work\ -cp work\jni4net.j-0.8.7.0.jar;work\MyCSharpDemoCalc.j4n.jar MyCalcUsageInJava.java
