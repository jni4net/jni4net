using System.IO;
using System.Text;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.finishers
{
    class CLRFinisher : IFinisher
    {
        public void Finish(GFile file, Repository repository)
        {
            string dir = Path.Combine(repository.Config.CLRGenPath, file.Path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string csFile = Path.Combine(dir, file.File);

            PatchText(file);

            string newFile = file.DText.ToString();

            using (var sw = new StreamWriter(csFile))
            {
                sw.Write(newFile);
            }

        }

        private static void PatchText(GFile file)
        {
            StringBuilder sb = file.DText;
            sb.Replace("// __event__\r\n        public global::", "public event global::");
            sb.Replace("get {\r\n                // __add__", "add {");
            sb.Replace("set {\r\n                // __remove__", "remove {");
            sb.Replace("__event_add__ = global", " += global");
            sb.Replace("__event_remove__ = global", " -= global");
            sb.Replace("#region " + Known.cdcComment, "//");
            sb.Replace("public sealed abstract partial class", "public static partial class");

            /*TODO ?
             * if (file.MainType.IsRootType)
            {
                sb.Replace("internal sealed class ContructionHelper", "new internal sealed class ContructionHelper");
            }*/
        }
    }
}
