@echo off

cd jni4net.j
..\tools\lastproxygen\proxygen.exe src\standard.proxygen.xml
cd ..

cd jni4net.n
if not exist target\build-sources\generated-sources\META-INF mkdir target\build-sources\generated-sources\META-INF\
..\tools\lastproxygen\proxygen.exe src\standard.proxygen.xml
echo [assembly: System.Reflection.AssemblyVersion("0.2.0.0")] > target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 
cd ..

