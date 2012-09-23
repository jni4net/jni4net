@echo off
REM change this to your JDK location
set JAVA_HOME="c:\Program Files\Java\jdk1.5.0_22\"

PUSHD %~dp0\
mkdir bin\classes
echo compile java
%JAVA_HOME%\bin\javac -d bin\classes -encoding UTF-8 -g:none @jni4net.javac

echo create jar
%JAVA_HOME%\bin\jar -cf bin\jni4net-j4n.jar -C bin\classes .

echo create dll
c:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe /verbosity:m /nologo jni4net.csproj

POPD
