@echo off
mkdir target\
copy ..\..\..\lib\*.* target
Csc.exe /nologo /warn:0 /reference:..\..\..\lib\jni4net.n-0.8.6.0.dll /out:target/circular.dll /target:library src2\j4n\IA.generated.cs src2\j4n\IB.generated.cs src3\j4n\B.cs