@echo off
copy ..\..\lib\*.* work
..\..\bin\proxygen.exe work\MyCSharpDemoCalc.dll -wd work
cd work
call build.cmd
cd ..

echo compiling usage
javac -d work\ -cp work\jni4net.j-0.8.6.0.jar;work\MyCSharpDemoCalc.j4n.jar MyCalcUsageInJava.java
