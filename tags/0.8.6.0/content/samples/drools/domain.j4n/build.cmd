@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes


echo compile classes
javac -nowarn -d target\classes -sourcepath jvm -cp "..\..\..\lib\jni4net.j-0.8.6.0.jar"; "jvm\org/drools/tutorials/banking\*.java"
IF %ERRORLEVEL% NEQ 0 goto end


echo domain.j4n.jar 
jar cvf domain.j4n.jar  -C target\classes .  > nul 
IF %ERRORLEVEL% NEQ 0 goto end


echo domain.j4n.dll 
csc /nologo /warn:0 /t:library /out:domain.j4n.dll /recurse:clr\*.cs  /reference:"c:\Data\Sf\jni4net\trunk\content\samples\drools\domain\domain.dll" /reference:"c:\Data\Sf\jni4net\trunk\content\lib\jni4net.n-0.8.6.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
