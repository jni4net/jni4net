using System.IO;
using java.lang;
using net.sf.jni4net.core;

namespace net.sf.jni4net.utils
{
    internal static class ClassUtils
    {
        public static string ClassLocation(IClass jvmApi)
        {
            var j4nLocation = Registry.JvmCoreHooks.GetLocation(jvmApi);
            var startIndex = "jar:file:/".Length;
            var endIndex = j4nLocation.IndexOf('!');
            var j4NJarLocation = Path.GetFullPath(j4nLocation.Substring(startIndex, endIndex - startIndex));
            return j4NJarLocation;
        }
    }
}
