@echo off
copy ..\..\..\lib\*.* .
copy ..\domain\*.dll .
..\..\..\bin\proxygen.exe domain.dll -wd .
call build.cmd

