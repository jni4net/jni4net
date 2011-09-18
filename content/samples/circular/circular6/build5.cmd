@echo off
mkdir target\
copy ..\..\..\lib\*.* target
Csc.exe /nologo /warn:0 /reference:..\..\..\lib\jni4net.n-0.8.6.0.dll /out:target/circular.dll /target:library src4\j4n\IA.generated.cs src4\j4n\IB.generated.cs src4\j4n\B.generated.cs src3\j4n\B.cs 
javac -cp ../../../lib/jni4net.j-0.8.6.0.jar -d target/ src4/j4n/IA_.java src4/j4n/IB_.java src4/j4n/B.java src5/j4n/A.java src/j4n/IA.java src/j4n/IB.java