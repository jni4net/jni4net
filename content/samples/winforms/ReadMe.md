WinForms from Java sample
---

This is most complex sample, because you need to generate proxies and compile both C# and Java side.

1) Make sure you have environment prepared properly. See `ReadMe.md` file in root.

2) Look at the `samples\winforms\winforms.proxygen.xml` file. It defines what proxies will be generated.

3) Run `samples\winforms\generateProxies.cmd`, it will generate 
- Java proxies of .NET classes 
- and C# codebe-hind classes

4) Now you need to compile codebe-hind classes into assembly. 
- Start Visual Studio, 
- open `samples\winforms\winforms.csproj`
- compile it
- verify that files exist `samples\winforms\target\winforms.dll`

5) copy all jni4net DLLs next to your winforms.dll
- start `samples\winforms\deploy.cmd`

6) now compile Java part, proxies and Program.java
- start `samples\winforms\build.cmd`
- or run ant
- or build it in your Java IDE

7) run the test
- start `samples\winforms\run.cmd`
- or debug it step-by-step in Java IDE