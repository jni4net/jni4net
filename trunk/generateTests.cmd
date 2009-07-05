@echo off

cd jni4net.tested.j
echo jni4net.tested.j
..\tools\lastproxygen\proxygen.exe src\tested.proxygen.xml
cd ..

cd jni4net.tested.n
echo jni4net.tested.n
if not exist target\build-sources\generated-sources\META-INF mkdir target\build-sources\generated-sources\META-INF\
..\tools\lastproxygen\proxygen.exe src\tested.proxygen.xml
echo [assembly: System.Reflection.AssemblyVersion("0.2.0.0")] > target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 
cd ..

cd jni4net.test.n
if not exist target\build-sources\generated-sources\META-INF mkdir target\build-sources\generated-sources\META-INF\
echo [assembly: System.Reflection.AssemblyVersion("0.2.0.0")] > target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 
cd ..
