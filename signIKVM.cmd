"%ProgramFiles%\Microsoft SDKs\Windows\v7.0A\Bin\ildasm.exe" _lib\IKVM.Reflection.dll /out:_target/IKVM.Reflection.il
move _lib\IKVM.Reflection.dll _lib\IKVM.Reflection.dll.orig
"%windir%\Microsoft.NET\Framework\v2.0.50727\ilasm.exe" _target/IKVM.Reflection.il /dll /key=_tools\keys\jni4net.snk /OUTPUT=_lib\IKVM.Reflection.dll