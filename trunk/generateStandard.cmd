@echo off

rem set JAVA_HOME=C:\Program Files\Java\jdk1.5.0_20

if not exist jni4net.n\target\build-sources\generated-sources\META-INF\ mkdir jni4net.n\target\build-sources\generated-sources\META-INF\
echo [assembly: System.Reflection.AssemblyVersion("0.8.5.1")] > jni4net.n\target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 

move jni4net.proxygen\target\proxygen.exe.config jni4net.proxygen\target\proxygen.exe.config.no
jni4net.proxygen\target\proxygen.exe tools\proxygen\jni4net.proxygen.xml 
move jni4net.proxygen\target\proxygen.exe.config.no jni4net.proxygen\target\proxygen.exe.config 
