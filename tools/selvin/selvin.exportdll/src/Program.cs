using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using selvin.exportdllattribute;

namespace selvin.exportdll
{
    internal enum ParserState
    {
        Normal,
        ClassDeclaration,
        Class,
        DeleteExportDependency,
        MethodDeclaration,
        MethodProperties,
        Method,
        DeleteExportAttribute,
    }

    public class Program
    {
        private static bool FindWithAttribute(MemberInfo mi, object obj)
        {
            object[] attrs = mi.GetCustomAttributes(typeof (ExportDllAttribute), false);
            return attrs.Length > 0;
        }

        public static int Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    Console.WriteLine("Parameter error!");
                    return -1;
                }
                Console.WriteLine(Environment.CurrentDirectory);

                string ildasmpath = @"C:\Program Files\Microsoft SDKs\Windows\v6.1\Bin\ildasm.exe";
                string ilasmpath = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\ilasm.exe";
                if (!File.Exists(ildasmpath))
                {
                    ildasmpath = @"C:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\ildasm.exe";
                }
                string keypath = null;
                bool debug = false;
                bool x64 = false;
                if (args.Length > 1 && args[1] != ".")
                {
                    ildasmpath = args[1];
                }
                if (args.Length > 2 && args[2] != ".")
                {
                    ilasmpath = args[2];
                }
                if (args.Length > 3)
                {
                    keypath = Path.GetFullPath(args[3]);
                }
                if (args.Length > 4)
                {
                    if (args[4] == "/Debug")
                        debug = true;
                }
                if (args.Length > 5)
                {
                    if (args[5] == "/x64")
                        x64 = true;
                }
                if (keypath != null && !File.Exists(keypath))
                {
                    Console.WriteLine("keyFile missing " + Path.GetFullPath(keypath));
                    return -5;
                }
                string filepath = Path.GetFullPath(args[0]);
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("keyFile missing " + Path.GetFullPath(filepath));
                    return -5;
                }
                string ext = Path.GetExtension(filepath);
                if (ext != ".dll")
                {
                    Console.WriteLine("Target should be dll!");
                    return 1;
                }
                string path = Path.GetDirectoryName(Path.GetFullPath(filepath));
                string noExtension = Path.Combine(path, Path.GetFileNameWithoutExtension(filepath));
                var dic = new Dictionary<string, Dictionary<string, KeyValuePair<string, string>>>();
                int exportscount = FindExports(dic, noExtension);
                if (exportscount == 0)
                {
                    Console.WriteLine("No exports found!");
                    return -1;
                }
                Directory.SetCurrentDirectory(path);
                if (DumpIL(noExtension, debug, ildasmpath) != 0)
                    return -2;
                List<string> lines = ParseIL(noExtension, dic, exportscount, x64);
                WriteIL(noExtension, path, lines);
                if (Compile(keypath, noExtension, debug, x64, ilasmpath) != 0)
                    return -20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        private static List<string> ParseIL(string noExtension, Dictionary<string, Dictionary<string, KeyValuePair<string, string>>> dic, int exportscount, bool x64)
        {
            var lines = new List<string>();
            int exportpos = 1;
            string methoddeclaration = "";
            string methodname = "";
            string classdeclaration = "";
            string methodbefore = "";
            string methodafter = "";
            int methodpos = 0;
            var classnames = new Stack<string>();
            ParserState state = ParserState.Normal;
            string bits = x64 ? "64" : "32";
            using (StreamReader sr = File.OpenText(noExtension + ".il"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string trimedline = line.Trim();
                    bool addilne = true;
                    switch (state)
                    {
                        case ParserState.Normal:
                            if (trimedline.StartsWith(".corflags"))
                            {
                                if (x64)
                                {
                                    lines.Add(".corflags 0x00000008");
                                }
                                else
                                {
                                    lines.Add(".corflags 0x00000002");
                                }
                                lines.Add(string.Format(".vtfixup [{0}] int" + bits + " fromunmanaged at VT_01",
                                                        exportscount));
                                lines.Add(string.Format(".data VT_01 = int" + bits + "[{0}]", exportscount));
                                Console.WriteLine("Adding vtfixup.");
                                addilne = false;
                            }
                            else if (trimedline.StartsWith(".class"))
                            {
                                state = ParserState.ClassDeclaration;
                                addilne = false;
                                classdeclaration = trimedline;
                            }
                            else if (trimedline.StartsWith(".assembly extern selvin.exportdllattribute")
                                     || trimedline.StartsWith(".assembly extern 'selvin.exportdllattribute")
                                )
                            {
                                addilne = false;
                                state = ParserState.DeleteExportDependency;
                                Console.WriteLine("Deleting ExportDllAttribute dependency.");
                            }
                            break;
                        case ParserState.DeleteExportDependency:
                            if (trimedline.StartsWith("}"))
                            {
                                state = ParserState.Normal;
                            }
                            addilne = false;
                            break;
                        case ParserState.ClassDeclaration:
                            if (trimedline.StartsWith("{"))
                            {
                                state = ParserState.Class;
                                string classname = "";
                                var reg = new Regex(@".+\s+([^\s]+) extends \[.*");
                                Match m = reg.Match(classdeclaration);
                                if (m.Groups.Count > 1)
                                    classname = m.Groups[1].Value;
                                classname = classname.Replace("'", "");
                                if (classnames.Count > 0)
                                    classname = classnames.Peek() + "+" + classname;
                                classnames.Push(classname);
                                //Console.WriteLine("Found class: " + classname);
                                lines.Add(classdeclaration);
                            }
                            else
                            {
                                classdeclaration += " " + trimedline;
                                addilne = false;
                            }
                            break;
                        case ParserState.Class:
                            if (trimedline.StartsWith(".class"))
                            {
                                state = ParserState.ClassDeclaration;
                                addilne = false;
                                classdeclaration = trimedline;
                            }
                            else if (trimedline.StartsWith(".method"))
                            {
                                if (dic.ContainsKey(classnames.Peek()))
                                {
                                    methoddeclaration = trimedline;
                                    addilne = false;
                                    state = ParserState.MethodDeclaration;
                                }
                            }
                            else if (trimedline.StartsWith("} // end of class"))
                            {
                                classnames.Pop();
                                if (classnames.Count > 0)
                                    state = ParserState.Class;
                                else
                                    state = ParserState.Normal;
                            }
                            break;
                        case ParserState.MethodDeclaration:
                            if (trimedline.StartsWith("{"))
                            {
                                var reg =
                                    new Regex(@"(?<before>[^\(]+(\(\s[^\)]+\))*\s)(?<method>[^\(]+)(?<after>\(.*)");
                                Match m = reg.Match(methoddeclaration);
                                if (m.Groups.Count > 3)
                                {
                                    methodbefore = m.Groups["before"].Value;
                                    methodafter = m.Groups["after"].Value;
                                    methodname = m.Groups["method"].Value;
                                }
                                //Console.WriteLine("Found method: " + methodname);
                                if (dic[classnames.Peek()].ContainsKey(methodname))
                                {
                                    methodpos = lines.Count;
                                    state = ParserState.MethodProperties;
                                }
                                else
                                {
                                    lines.Add(methoddeclaration);
                                    state = ParserState.Method;
                                    methodpos = 0;
                                }
                            }
                            else
                            {
                                methoddeclaration += " " + trimedline;
                                addilne = false;
                            }
                            break;
                        case ParserState.Method:
                            if (trimedline.StartsWith("} // end of method"))
                            {
                                state = ParserState.Class;
                            }
                            break;
                        case ParserState.MethodProperties:
                            if (trimedline.StartsWith(".custom instance void [selvin.exportdllattribute")
                                || trimedline.StartsWith(".custom instance void ['selvin.exportdllattribute")
                                )
                            {
                                addilne = false;
                                state = ParserState.DeleteExportAttribute;
                            }
                            else if (trimedline.StartsWith("// Code"))
                            {
                                state = ParserState.Method;
                                if (methodpos != 0)
                                    lines.Insert(methodpos, methoddeclaration);
                            }
                            break;
                        case ParserState.DeleteExportAttribute:
                            if (trimedline.StartsWith(".custom") || trimedline.StartsWith("// Code"))
                            {
                                KeyValuePair<string, string> attr = dic[classnames.Peek()][methodname];
                                if (methodbefore.Contains("marshal( "))
                                {
                                    int pos = methodbefore.IndexOf("marshal( ");
                                    methodbefore = methodbefore.Insert(pos, "modopt([mscorlib]" + attr.Value + ") ");
                                    methoddeclaration = methodbefore + methodname + methodafter;
                                }
                                else
                                    methoddeclaration = methodbefore + "modopt([mscorlib]" + attr.Value + ") " +
                                                        methodname + methodafter;
                                Console.WriteLine("\tChanging calling convention: " + attr.Value);
                                if (methodpos != 0)
                                    lines.Insert(methodpos, methoddeclaration);
                                if (methodname == "DllMain")
                                    lines.Add(" .entrypoint");
                                lines.Add(".vtentry 1 : " + exportpos);
                                lines.Add(string.Format(".export [{0}] as {1}", exportpos,
                                                        dic[classnames.Peek()][methodname].Key));
                                Console.WriteLine("\tAdding .vtentry:{0} .export:{1}", exportpos,
                                                  dic[classnames.Peek()][methodname].Key);
                                exportpos++;
                                state = ParserState.Method;
                            }
                            else
                                addilne = false;
                            break;
                    }
                    if (addilne)
                        lines.Add(line);
                }
            }
            return lines;
        }

        private static void WriteIL(string noExtension, string path, List<string> wholeilfile)
        {
            using(StreamWriter sw = File.CreateText(Path.Combine(path, noExtension + ".il")))
            {
                foreach (string line in wholeilfile)
                {
                    sw.WriteLine(line);
                }
            }
        }

        private static int FindExports(Dictionary<string, Dictionary<string, KeyValuePair<string, string>>> dic, string noExtension)
        {
            string copy = noExtension + ".old.dll";
            string file = noExtension + ".dll";
            if (File.Exists(copy))
            {
                File.Delete(copy);
            }
            File.Copy(file, copy);

            Assembly assembly = Assembly.LoadFrom(copy);
            Type[] types = assembly.GetTypes();
            int exportscount = 0;
            foreach (Type type in types)
            {
                MemberInfo[] mis = type.FindMembers(MemberTypes.All,
                                                    BindingFlags.NonPublic | BindingFlags.Public |
                                                    BindingFlags.Static, FindWithAttribute, null);
                {
                    foreach (MemberInfo mi in mis)
                    {
                        object[] attrs = mi.GetCustomAttributes(typeof (ExportDllAttribute), false);
                        if (attrs.Length > 0)
                        {
                            var attr = attrs[0] as ExportDllAttribute;
                            if (!dic.ContainsKey(type.FullName))
                                dic[type.FullName] = new Dictionary<string, KeyValuePair<string, string>>();
                            dic[type.FullName][mi.Name] = new KeyValuePair<string, string>(attr.ExportName,
                                                                                           attr.CallingConvention);
                            exportscount++;
                        }
                    }
                }
            }
            return exportscount;
        }

        private static int Compile(string keypath, string noExtension, bool debug, bool x64, string ilasmpath)
        {
            string res = noExtension + ".res";
            if (File.Exists(noExtension + ".res"))
                res = " /resource=" + res;
            else
                res = "";
            Process proc = new Process();
            string arguments = string.Format("/nologo /quiet /out:{0}.dll {0}.il /DLL{1} {2}", noExtension, res,
                                             debug ? "/debug" : "/optimize");
            if (keypath != null)
            {
                arguments += " /KEY=" + keypath;
            }
            if (x64)
            {
                arguments = "/X64 " + arguments;
            }
            Console.WriteLine("Compiling file with arguments '{0}'", arguments);
            ProcessStartInfo info = new ProcessStartInfo(ilasmpath, arguments);
            info.UseShellExecute = false;
            info.CreateNoWindow = false;
            info.RedirectStandardOutput = true;
            proc.StartInfo = info;
            proc.Start();
            proc.WaitForExit();
            Console.WriteLine(proc.StandardOutput.ReadToEnd());
            return proc.ExitCode;
        }

        private static int DumpIL(string noExtension, bool debug, string ildasmpath)
        {
            var proc = new Process();
            string arguments = string.Format("/nobar{1}/out:{0}.il {0}.dll", noExtension,
                                             debug ? " /linenum " : " ");
            Console.WriteLine("Deassembly file with arguments '{0}'", arguments);
            var info = new ProcessStartInfo(ildasmpath, arguments);
            info.UseShellExecute = false;
            info.CreateNoWindow = false;
            info.RedirectStandardOutput = true;
            proc.StartInfo = info;
            proc.Start();
            proc.WaitForExit();
            Console.WriteLine(proc.StandardOutput.ReadToEnd());
            return proc.ExitCode;
        }
    }
}