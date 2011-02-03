mkdir target
mkdir target\classes
copy ..\..\..\lib\*.* target\

Csc.exe /warn:0 /reference:..\..\..\lib\jni4net.n-0.8.3.0.dll /out:jre.j4n.dll /target:library csharp\java\util\Date.generated.cs

javac -nowarn -d target\classes -sourcepath java -cp "target\jni4net.j-0.8.3.0.jar" "java/java_/util/Date_.java"
jar cvf jre.j4n.jar  -C target\classes "java_/util/Date_.class" > nul 

