This is very basic sample for calling from C# to Java.
---

1) Make sure you have environment prepared properly. See `ReadMe.md` file in root.
2) Start `build.cmd` - you may need to tweak paths inside to match your setup.
3) Start `run.cmd` - you may need to tweak paths inside to match your setup.
4) In Visual Studio open, compile `helloWorldFromCLR.csproj`
	It will produce and copy following files
    `samples\helloWorldFromCLR\work\helloWorldFromCLR.exe`
    `samples\helloWorldFromCLR\work\jni4net.n-0.x.0.0.dll`
    `samples\helloWorldFromCLR\work\jni4net.j-0.x.0.0.jar`
5) Start and step-by-step debug `Program.cs`