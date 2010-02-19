using System.IO;
using System.Text;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.finishers
{
    public class JVMFinisher : IFinisher
    {
        public void Finish(GFile file, Repository repository)
        {
            string dir = Path.Combine(repository.Config.JVMGenPath, file.Path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string javaFile = Path.Combine(dir, file.File);
            string newFile = file.DText.ToString();

            //load if exists
            if (file.MainType.Config.MergeJavaSource && File.Exists(javaFile))
            {
                string oldFile;
                using (var srJavaFile = new StreamReader(javaFile))
                {
                    oldFile = srJavaFile.ReadToEnd();
                }
                newFile = PatchOldFile(oldFile, newFile);
            }

            // replace with merged or new text
            using (var sw = new StreamWriter(javaFile))
            {
                sw.Write(newFile);
            }

        }

        private static string PatchOldFile(string oldFile, string newFile)
        {
            // merge
            var sb = new StringBuilder(oldFile);
            bool replace = false;

            int ostart = oldFile.IndexOf(Known.sMagicIface);
            int oend = oldFile.IndexOf(Known.eMagicIface);
            int nstart = newFile.IndexOf(Known.sMagicIface);
            int nend = newFile.IndexOf(Known.eMagicIface);
            if (nstart != -1 && nend != -1)
            {
                if (ostart != -1 && oend != -1)
                {
                    sb.Remove(ostart, oend - ostart);
                    sb.Insert(ostart, newFile.Substring(nstart, nend - nstart));
                    oldFile = sb.ToString();
                }
                else
                {
                    replace = true;
                }
            }

            if (!replace)
            {
                int sostart = oldFile.IndexOf(Known.sMagicStatic);
                int soend = oldFile.IndexOf(Known.eMagicStatic);
                int snstart = newFile.IndexOf(Known.sMagicStatic);
                int snend = newFile.IndexOf(Known.eMagicStatic);

                if (snstart != -1 && snend != -1)
                {
                    if (sostart != -1 && soend != -1)
                    {
                        sb.Remove(sostart, soend - sostart);
                        sb.Insert(sostart, newFile.Substring(snstart, snend - snstart));
                    }
                    else
                    {
                        replace = true;
                    }
                }
            }

            if (!replace)
            {
                int postart = oldFile.IndexOf(Known.sMagicProxy);
                int poend = oldFile.IndexOf(Known.eMagicProxy);
                int pnstart = newFile.IndexOf(Known.sMagicProxy);
                int pnend = newFile.IndexOf(Known.eMagicProxy);

                if (pnstart != -1 && pnend != -1)
                {
                    if (postart != -1 && poend != -1)
                    {
                        sb.Remove(postart, poend - postart);
                        sb.Insert(postart, newFile.Substring(pnstart, pnend - pnstart));
                    }
                    else
                    {
                        replace = true;
                    }
                }
            }
            if (!replace)
            {
                newFile = sb.ToString();
            }
            return newFile;
        }
    }
}
