@echo off
set ANT_PATH=C:\Installers\apache-ant-1.8.4\bin
set CSC_PATH=C:\Windows\Microsoft.NET\Framework64\v4.0.30319
set JAVAC_PATH=%JAVA_HOME%\bin
set PATH=%ANT_PATH%;%CSC_PATH%;%JAVAC_PATH%;%PATH%
if exist "%~dp0\tools\lib\maven-2.0.9-uber.jar" goto mvn
call "%~dp0\tools\loadTools.cmd"

:mvn
@call "%~dp0tools\bin\mvn.bat" install assembly:assembly %*