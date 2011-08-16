@echo off

cd helloWorldFromCLR
call build.cmd
call run.cmd
cd ..

cd helloWorldFromJVM
call build.cmd
call run.cmd
cd ..


cd myCSharpDemoCalc
call generateProxies.cmd
call run.cmd
cd ..

cd myJavaDemoCalc
call generateProxies.cmd
call run.cmd
cd ..

cd winforms
call generateProxies.cmd
call build.cmd
call run.cmd
cd ..

cd interfaceFromCLR
call generateProxies.cmd
call build.cmd
call run.cmd
cd ..

cd circular\circular7
call build1.cmd
call build2.cmd
call build3.cmd
call build4.cmd
call build5.cmd
call build6.cmd
call build7.cmd
call run.cmd
cd ..\..


REM cd fop
REM call generateProxies.cmd
REM call build.cmd
REM call run.cmd
REM cd ..
