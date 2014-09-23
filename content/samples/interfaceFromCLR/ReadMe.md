How to implement Java interface in CLR and pass it to JVM
---

1) Make sure you have environment prepared properly. See `ReadMe.md` file in root.
2) Start `generateProxies.cmd`
3) Start `build.cmd`
4) Start `run.cmd`
5) In Visual Studio open, compile `interfaceFromCLR.csproj`
	It will produce and copy following files
```
samples\interfaceFromCLR\work\interfaceFromCLR.exe
samples\interfaceFromCLR\work\jni4net.n-0.x.0.0.dll
samples\interfaceFromCLR\work\jni4net.j-0.x.0.0.jar
```
6) Start and step-by-step debug Program.cs
