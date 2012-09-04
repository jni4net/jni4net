@echo off
REM change this to your JDK location
set JAVA_HOME="c:\Program Files\Java\jdk1.5.0_22\"

mkdir bin\classes
echo compile java
%JAVA_HOME%\bin\javac -d bin/classes -encoding UTF-8 -g:none @ecj-j4n.javac

echo create jar
%JAVA_HOME%\bin\jar -cf bin\ecj-j4n.jar -C bin\classes .
