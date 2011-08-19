@echo off
copy %~dp0\..\target\jni4net-0.8.5.1-win32\bin\proxygen.exe %~dp0\bin
copy %~dp0\..\target\jni4net-0.8.5.1-win32\bin\proxygen.exe %~dp0\bin
copy %~dp0\..\jni4net.j\target\jni4net.j-0.8.5.1.jar %~dp0\lib
copy %~dp0\..\jni4net.n\target\jni4net.n-0.8.5.1.dll %~dp0\lib
copy %~dp0\..\jni4net.proxygen\target\proxygen.exe %~dp0\bin

