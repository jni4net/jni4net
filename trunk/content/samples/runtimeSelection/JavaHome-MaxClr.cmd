@echo off

if NOT "%JAVA_HOME%"=="" GOTO java
echo this asumes that you have JAVA_HOME set
goto end

:java
if EXIST "%JAVA_HOME%\bin\java.exe" GOTO run
echo and have %JAVA_HOME%\ installed
goto end

:run
"%JAVA_HOME%\bin\java.exe" -cp ../../lib/jni4net.j-0.8.6.0.jar;target/classes Program

:end