@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes


echo compile classes
javac -nowarn -d target\classes -sourcepath jvm -cp "..\..\..\lib\jni4net.j-0.8.6.0.jar;..\lib\drools-api-5.1.1.jar;..\lib\jaxb-xjc-2.2.1.1.jar;..\lib\jaxb-api-2.2.1.jar" @files.lst
IF %ERRORLEVEL% NEQ 0 goto end


echo drools-api-5.1.1.j4n.jar 
jar cvf drools-api-5.1.1.j4n.jar  -C target\classes .  > nul 
IF %ERRORLEVEL% NEQ 0 goto end


echo drools-api-5.1.1.j4n.dll 
csc /nologo /warn:0 /t:library /out:drools-api-5.1.1.j4n.dll /recurse:clr\*.cs  /reference:"c:\Data\Sf\jni4net\trunk\content\lib\jni4net.n-0.8.6.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
