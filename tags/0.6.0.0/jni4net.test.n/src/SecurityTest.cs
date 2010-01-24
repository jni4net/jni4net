using System.Security.Permissions;
using NUnit.Framework;

namespace net.sf.jni4net.test
{
    [SecurityPermission(SecurityAction.PermitOnly, Flags = SecurityPermissionFlag.Execution)]
    [ReflectionPermission(SecurityAction.Deny)]
    [FileIOPermission(SecurityAction.Deny)]
    [EnvironmentPermission(SecurityAction.Deny)]
    [TestFixture]
    public class SecurityBasicTest : BasicTests
    {
        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
        }
    }

    [SecurityPermission(SecurityAction.PermitOnly, Flags = SecurityPermissionFlag.Execution)]
    [ReflectionPermission(SecurityAction.Deny)]
    [FileIOPermission(SecurityAction.Deny)]
    [EnvironmentPermission(SecurityAction.Deny)]
    [TestFixture]
    public class SecurityCallBackTest : CallBackTest
    {
        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
        }
    }

    [SecurityPermission(SecurityAction.PermitOnly, Flags = SecurityPermissionFlag.Execution)]
    [ReflectionPermission(SecurityAction.Deny)]
    [FileIOPermission(SecurityAction.Deny)]
    [EnvironmentPermission(SecurityAction.Deny)]
    [TestFixture]
    public class SecurityExceptionsTest : ExceptionsTest
    {
        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
        }
    }
    
    
}
