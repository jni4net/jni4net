using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[assembly: AssemblyTitle("jni4net")]
[assembly: AssemblyCompany("jni4net.sf.net")]
[assembly: ComVisible(false)]

[assembly: SecurityPermission(SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.Assertion | SecurityPermissionFlag.Execution)]
[assembly: ReflectionPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: EnvironmentPermission(SecurityAction.RequestMinimum, Read = "JAVA_HOME")]

