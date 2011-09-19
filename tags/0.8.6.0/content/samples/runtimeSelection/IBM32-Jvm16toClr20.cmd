@echo off

if %PROCESSOR_ARCHITECTURE%==AMD64 GOTO java
if %PROCESSOR_ARCHITEW6432%==AMD64 GOTO java
echo this asumes that you are running 64bit windows 
goto end

:java
if EXIST "c:\Program Files (x86)\Java\ibm_sdk60\bin\java.exe" GOTO run
echo and have c:\Program Files (x86)\Java\ibm_sdk60\ installed
goto end

:run
"c:\Program Files (x86)\Java\ibm_sdk60\bin\java.exe" -cp ../../lib/jni4net.j-0.8.6.0.jar;target/classes Program v20

:end