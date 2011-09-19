@echo off
mkdir target\
copy ..\..\..\lib\*.* target
Csc.exe /nologo /warn:0 /reference:..\..\..\lib\jni4net.n-0.8.6.0.dll /out:target/circular.dll /target:library src6\j4n\IA.generated.cs src6\j4n\IB.generated.cs src6\j4n\B.generated.cs src6\j4n\A.generated.cs src7\j4n\B.cs 
javac -cp ../../../lib/jni4net.j-0.8.6.0.jar -d target/ src6/j4n/IA_.java src6/j4n/IB_.java src6/j4n/B.java src5/j4n/A.java src/j4n/IA.java src/j4n/IB.java src6/j4n/A_.java
jar cvf target/circular.jar -C target j4n/A.class -C target j4n/A_.class -C target j4n/__IA.class -C target j4n/__IB.class -C target j4n/B.class -C target j4n/IA.class -C target j4n/IA_.class -C target j4n/IB.class -C target j4n/IB_.class
rmdir /q /s target\j4n