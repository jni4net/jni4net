using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using NUnit.Framework;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class AppDomainTest : TestBase
    {
        [TestFixtureSetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void createDomain()
        {
            var trustAssemblies = new[] { Reflection.GetStrongName(typeof(Bridge).Assembly)};
            var domainSetup = new AppDomainSetup();
            var securityInfo = AppDomain.CurrentDomain.Evidence;
            //PermissionSet permissionSet = new PermissionSet(PermissionState.None);
            //permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            PermissionSet permissionSet = new PermissionSet(PermissionState.Unrestricted);

            domainSetup.ApplicationBase = Environment.CurrentDirectory;
            domainSetup.ApplicationName = "ddd";
            domainSetup.SandboxInterop = true;
            domainSetup.DisallowBindingRedirects = true;
            domainSetup.DisallowCodeDownload = true;
            domainSetup.DisallowPublisherPolicy = true;
            //domainSetup.DisallowApplicationBaseProbing = true;
            //domainSetup.PrivateBinPathProbe = "true";
            //domainSetup.PrivateBinPath = tempDir;

            domainSetup.AppDomainInitializer = Load;

            domain = AppDomain.CreateDomain("ddd", securityInfo, domainSetup, permissionSet, trustAssemblies);
        }

        protected static AppDomain domain;

        public static void Load(string[] args)
        {
            try
            {
                domain = AppDomain.CurrentDomain;

                var setup = new BridgeSetup(false);
                setup.Verbose = true;
                setup.Debug = true;
                setup.BindNative = false;
                setup.BindStatic = false;
                Bridge.CreateJVM(setup);
                Bridge.LoadAndRegisterAssembly(typeof(AppDomainTest).Assembly.Location);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }

    class Reflection
    {
        public static PermissionSet GetNamedPermissionSet(string name)
        {
            IEnumerator policyEnumerator = SecurityManager.PolicyHierarchy();

            // Move through the policy levels to the machine policy level.
            while (policyEnumerator.MoveNext())
            {
                PolicyLevel currentLevel = (PolicyLevel)policyEnumerator.Current;

                if (currentLevel.Label == "Machine")
                {
                    return currentLevel.GetNamedPermissionSet(name);
                }
            }
            return null;
        }

        public static StrongName GetStrongName(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException("assembly");

            AssemblyName assemblyName = assembly.GetName();
            Debug.Assert(assemblyName != null, "Could not get assembly name");

            // Get the public key blob.
            byte[] publicKey = assemblyName.GetPublicKey();
            if (publicKey == null || publicKey.Length == 0)
                throw new InvalidOperationException("Assembly is not strongly named");

            StrongNamePublicKeyBlob keyBlob = new StrongNamePublicKeyBlob(publicKey);

            // Return the strong name.
            return new StrongName(keyBlob, assemblyName.Name, assemblyName.Version);
        }

        private static bool checkMethodOverride(Type robotClass, Type knownBase, String name,
                                                params Type[] parameterTypes)
        {
            if (knownBase.IsAssignableFrom(robotClass))
            {
                MethodInfo getInteractiveEventListener;

                getInteractiveEventListener = robotClass.GetMethod(name, parameterTypes);
                if (getInteractiveEventListener == null)
                {
                    return false;
                }


                if (getInteractiveEventListener.DeclaringType.Equals(knownBase))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
