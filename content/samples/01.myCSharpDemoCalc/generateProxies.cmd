@echo off
set JNI4NETHOME=%~dp0\..\..\
if NOT EXIST %~dp0\..\..\bin\proxygen.exe set JNI4NETHOME=%~dp0\..\..\..\_target\0.9.0.0\

REM change this to your JDK location
set JAVA_HOME="c:\Program Files\Java\jdk1.5.0_22\"

copy %JNI4NETHOME%\runtime\*.* %~dp0\bin
%JNI4NETHOME%\bin\proxygen.exe %~dp0\MyCSharpDemoCalc\MyCSharpDemoCalc-j4n.xml -dll %~dp0\bin\MyCSharpDemoCalc.dll
call %~dp0\MyCSharpDemoCalc\MyCSharpDemoCalc.cmd
copy %~dp0\MyCSharpDemoCalc\bin\MyCSharpDemoCalc-j4n.jar %~dp0\bin\
copy %~dp0\MyCSharpDemoCalc\bin\MyCSharpDemoCalc-j4n.dll %~dp0\bin\

echo compiling usage
mkdir bin\classes
%JAVA_HOME%\bin\javac -d bin\classes -cp %~dp0\bin\jni4net.jar;%~dp0\bin\mscorlib-micro-j4n.jar;%~dp0\bin\MyCSharpDemoCalc.j4n.jar MyCalcUsageInJava.java
