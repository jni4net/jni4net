@echo off
REM change this to your JDK location
if NOT EXIST %JAVA_HOME%\bin\javac.exe set JAVA_HOME="c:\Program Files\Java\jdk1.7.0\"

%JAVA_HOME%\bin\java -cp %~dp0\bin\jni4net.jar;%~dp0\bin\jre-micro-j4n.jar;%~dp0\bin\mscorlib-micro-j4n.jar;%~dp0\bin\MyCSharpDemoCalc-j4n.jar;%~dp0\bin\classes MyCalcUsageInJava
