using java.io;
using org.eclipse.jdt.core.compiler.batch;

namespace com.jni4net.proxygen.Services._5000.Compilation
{
    public class ProjectsCompiler
    {
        public void Compile()
        {
            BatchCompiler.compile("-help", new PrintWriter(java.lang.System.@out), new PrintWriter(java.lang.System.err), null);
        }
    }
}
