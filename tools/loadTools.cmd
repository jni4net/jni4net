@echo off
mkdir %~dp0\lib
java -cp %~dp0/loader Loader http://jni4net.github.io/tools/libs/ %~dp0/lib/ ant.jar ant-launcher.jar jacobe.jar junit.jar classworlds-1.1.jar maven-2.0.9-uber.jar nunit.framework-2.5.8.10295.dll
java -cp %~dp0/loader Loader http://jni4net.github.io/mvnrepo/net/sf/jni4net/selvin.exportdll/0.2.5.0/ %~dp0/lib/ selvin.exportdll-0.2.5.0.exe
java -cp %~dp0/loader Loader http://jni4net.github.io/mvnrepo/net/sf/jni4net/selvin.exportdllattribute/0.2.5.0/ %~dp0/lib/ selvin.exportdllattribute-0.2.5.0.dll
copy /y %~dp0\lib\nunit.framework-2.5.8.10295.dll %~dp0\lib\nunit.framework.dll
