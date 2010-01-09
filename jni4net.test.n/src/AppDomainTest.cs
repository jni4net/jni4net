using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;
using java.nio;
using net.sf.jni4net.nio;
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
        [Explicit]
        public void createDomains()
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(createDomain);
                t.Start();
                threads.Add(t);
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
            GC.Collect(3, GCCollectionMode.Forced);
            java.lang.System.gc();
            GC.WaitForPendingFinalizers();
        }

        [Test]
        public void createDomain()
        {
            try
            {
                var trustAssemblies = new[] {Reflection.GetStrongName(typeof (Bridge).Assembly)};
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

                Console.WriteLine("AAA");
                AppDomain domain = AppDomain.CreateDomain("ddd", securityInfo, domainSetup, permissionSet, trustAssemblies);
                Console.WriteLine("bbb");
                Console.WriteLine("ccc");
                domain.DoCallBack(testBB);
                Console.WriteLine("ddd");

                GC.Collect(0, GCCollectionMode.Forced);
                java.lang.System.gc();
                GC.WaitForPendingFinalizers();

                Console.WriteLine("eee");
                AppDomain.Unload(domain);
                Console.WriteLine("fff");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        

        public static void Load(string[] args)
        {
            try
            {
                //domain = AppDomain.CurrentDomain;

                var setup = new BridgeSetup(false);
                setup.Verbose = true;
                setup.Debug = true;
                setup.BindNative = false;
                setup.BindStatic = false;
                Bridge.CreateJVM(setup);
                Bridge.LoadAndRegisterAssembly(typeof(AppDomainTest).Assembly.Location);

                testBB();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static void testBB()
        {
            ByteBuffer byteBuffer = xx();
            GC.Collect(0, GCCollectionMode.Forced);
            java.lang.System.gc();
            GC.Collect(3, GCCollectionMode.Forced);
            java.lang.System.gc();
            GC.WaitForPendingFinalizers();
            java.lang.System.gc();
            byteBuffer.capacity();

            for (int j = 0; j < 10; j++)
            {
                List<object> l = new List<object>();
                if (j == 0)
                {
                    l.Add(byteBuffer);
                    byteBuffer = null;
                }
                for (int i = 0; i < 100; i++)
                {
                    l.Add("Test" + i);
                    l.Add(new byte[10*1000*10]);
                    l.Add((java.lang.String) "ssss" + i);
                }
                l = null;
            }
        }

        private static ByteBuffer xx()
        {
            byte[] myLovelyData = new byte[1000*1000*10];

            DirectByteBuffer buffer = new DirectByteBuffer(myLovelyData);

            buffer.position(myLovelyData.Length - 1);
            buffer.put(0xEE);

            return Bridge.Cast<ByteBuffer>(buffer);
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
