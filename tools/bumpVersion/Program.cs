using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace bumpVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory;
            var prev = args[0];
            var next = args[1];

            List<Tuple<Predicate<string>, Replace>> patterns = new List<Tuple<Predicate<string>, Replace>>();

            patterns.Add(new Tuple<Predicate<string>, Replace>(file => Path.GetFileName(file) == "pom.xml"
                                                               , sb =>
                                                                     {
                                                                         sb.Replace("<version>" + prev + "</version>",
                                                                                    "<version>" + next + "</version>");
                                                                         sb.Replace("version=\"" + prev + "\"",
                                                                                    "version=\"" + next + "\"");
                                                                     }
                             ));


            patterns.Add(new Tuple<Predicate<string>, Replace>(file => Path.GetExtension(file) == ".cmd" 
                || Path.GetExtension(file) == ".csproj"
                || Path.GetExtension(file) == ".xsd"
                || Path.GetFileName(file) == "profiles.xml"
                || file.EndsWith(".proxygen.xml")
                                                               , sb => sb.Replace(prev,next)));

            foreach (var file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
            {
                if (!File.Exists(file))
                {
                    continue;
                }
                foreach (var pattern in patterns)
                {
                    if (pattern.Item1(file))
                    {
                        FileReplace(file, pattern.Item2);
                    }
                }
            }
        }

        

        private delegate void Replace(StringBuilder sb);

        private static void FileReplace(string file, Replace action)
        {
            using(FileStream fs=new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {
                using(var sr = new StreamReader(fs))
                {
                    var sb = new StringBuilder(sr.ReadToEnd());
                    action(sb);
                    fs.SetLength(0);
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.Write(sb.ToString());
                    }
                }
            }
        }
    }
}
