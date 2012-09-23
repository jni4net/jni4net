@echo off
if NOT EXIST %JNI4NETHOME%\bin\proxygen.exe set JNI4NETHOME="%~dp0\..\..\"
if NOT EXIST %JNI4NETHOME%\bin\proxygen.exe set JNI4NETHOME="%~dp0\..\..\..\_target\0.9.0.0\"

REM change this to your JDK location
if NOT EXIST "%JAVA_HOME%\bin\javac.exe" set JAVA_HOME="c:\Program Files\Java\jdk1.7.0\"

echo compiling usage
mkdir bin\classes
%JAVA_HOME%\bin\javac.exe -d bin\classes -cp "%~dp0\bin\jni4net.jar;%~dp0\bin\mscorlib-micro-j4n.jar;%~dp0\bin\MyCSharpDemoCalc-j4n.jar" MyCalcUsageInJava.java
