using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace net.sf.jni4net
{
    [Serializable]
    public class BridgeSetup
    {
        private bool bindNative;
        private bool bindStatic;
        private readonly List<string> jvmOptions;
        private readonly List<string> jvmCLassPath;

        public bool BindCLRTypes { get; set; }
        public bool Verbose { get; set; }
        public bool Debug { get; set; }
        public bool BindNative
        {
            get { return bindNative; }
            set { bindNative = value; }
        }

        public bool BindStatic
        {
            get { return bindStatic; }
            set
            {
                if (!value && bindNative)
                {
                    BindNative = false;
                }
                bindStatic = value;
            }
        }

        public string[] JVMOptions
        {
            get
            {
                List<string> res = new List<string>(jvmOptions);
                if(JVMCLassPath.Length>0)
                {
                    StringBuilder sb = new StringBuilder("-Djava.class.path=");
                    foreach (string path in JVMCLassPath)
                    {
                        sb.Append(path);
                        sb.Append(";");
                    }
                    sb.Length--;
                    res.Add(sb.ToString());
                }
                return res.ToArray();
            }
        }

        public string[] JVMCLassPath
        {
            get { return jvmCLassPath.ToArray(); }
        }

        public void AddBridgeClassPath()
        {
            string bridgeJar = Bridge.FindJar();
            jvmCLassPath.Add(bridgeJar);
            if (Verbose)
            {
                Console.WriteLine("Adding " + Path.GetFullPath(bridgeJar));
            }
        }

        public void AddClassPath(string jarOrClassRoot)
        {
            jvmCLassPath.Add(jarOrClassRoot);
            if ((Debug || Verbose) && !Directory.Exists(jarOrClassRoot) && !File.Exists(jarOrClassRoot))
            {
                Console.Error.WriteLine("Can't find " + Path.GetFullPath(jarOrClassRoot));
            }
            else if (Verbose)
            {
                Console.WriteLine("Adding " + Path.GetFullPath(jarOrClassRoot));
            }
        }

        public void AddJVMOption(string name, string value)
        {
            jvmOptions.Add(name+"="+value);
        }

        public void AddAllJarsClassPath(string directory)
        {
            foreach (string jar in Directory.GetFiles(directory, "*.jar"))
            {
                jvmCLassPath.Add(jar);
                if (Verbose)
                {
                    Console.WriteLine("Adding " + Path.GetFullPath(jar));
                }
            }
        }

        public BridgeSetup()
            : this(true)
        {
        }

        public BridgeSetup(bool autoAddBridgeClassPath)
        {
            BindStatic = true;
            BindNative = true;
            BindCLRTypes = true;
            jvmCLassPath = new List<string>();
            jvmOptions = new List<string>();
            if (autoAddBridgeClassPath)
            {
                AddBridgeClassPath();
            }
        }

        public BridgeSetup(params string[] jvmOptions)
        {
            BindStatic = true;
            BindNative = true;
            BindCLRTypes = true;
            this.jvmOptions = new List<string>(jvmOptions);
            jvmCLassPath = new List<string>();
        }
    }
}
