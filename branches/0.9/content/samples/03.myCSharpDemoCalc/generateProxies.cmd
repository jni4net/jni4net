@echo off
IF [%JNI4NETHOME%] EQU [] set JNI4NETHOME="%~dp0\..\..\"
if NOT EXIST "%%~JNI4NETHOME\bin\proxygen.exe" set JNI4NETHOME="%~dp0\..\..\..\_target\0.9.0.0\"

REM change this to your JDK location
IF [%JAVA_HOME%] EQU [] set JAVA_HOME="c:\Program Files\Java\jdk1.7.0\"
if NOT EXIST "%~JAVA_HOME%\bin\javac.exe" set JAVA_HOME="c:\Program Files\Java\jdk1.7.0\"
if NOT EXIST "%~JAVA_HOME%\bin\javac.exe" set JAVA_HOME="c:\Program Files\Java\jdk1.6.0_22\"
if NOT EXIST "%~JAVA_HOME%\bin\javac.exe" echo 


REM copy "%~JNI4NETHOME%\runtime\*.*" "%~dp0\bin"
REM "%~JNI4NETHOME%\bin\proxygen.exe" "%~dp0\MyCSharpDemoCalc\MyCSharpDemoCalc-j4n.xml" -dll "%~dp0\bin\MyCSharpDemoCalc.dll"
REM call "%~dp0\MyCSharpDemoCalc\MyCSharpDemoCalc-j4n.cmd"
REM copy "%~dp0\MyCSharpDemoCalc\bin\MyCSharpDemoCalc-j4n.jar" "%~dp0\bin\"
REM copy "%~dp0\MyCSharpDemoCalc\bin\MyCSharpDemoCalc-j4n.dll" %~dp0\bin\"
