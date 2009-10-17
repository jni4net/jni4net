In this directory are sample applications which should help you to learn how to 
use jni4net. Starters should play with them in following order. Each folder 
contains Read.Me file.

1) helloWorldFromCLR - Easiest way to start using jni4net for .NET people.
   This sample uses jni4net bridge to demostrate calls from C# into Java.
   Uses proxies embedded in jni4net itself, so you don't need to worry about it.
   
2) helloWorldFromJVM - Easiest way to start using jni4net for Java people.
   This sample uses jni4net bridge to demostrate calls from Java into .NET
   Uses proxies embedded in jni4net itself, so you don't need to worry about it.

3) fop - this is bit more complex sample of Java library used by C# program.
   Currently, there is no good xsl:fo library for .NET. 
   We demostrate how jni4net could solve such situation.
   
4) winforms - this example shows, how Java program could create WinForms dialog.