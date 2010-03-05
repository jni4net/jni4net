using System;
using net.sf.jni4net.inj;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config();
            config.CLRGenPath = "clr";
            config.JVMGenPath = "jvm";
            Repository repository = new Repository(config);
            MAssembly assembly = new MAssembly(typeof(object).Assembly);
            //repository.AddOrResolve(assembly);
            repository.AddOrResolve(typeof (IClrProxy));
            repository.AddOrResolve(new MType(typeof(object)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(string)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(Boolean)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(Exception)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(Type)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(IComparable)) { IsGenJvm = true });
            repository.AddOrResolve(new MType(typeof(Environment)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(Environment.SpecialFolder)) { IsGenJvm = false });
            repository.AddOrResolve(new MType(typeof(DateTime)) { IsGenJvm = false });

            repository.Tour(new CLRLoader());
            repository.Tour(new Resolver());
            repository.Tour(new Namer());
            repository.Tour(new MethodProcessor());
            repository.Tour(new Generator());
            repository.Tour(new Writer());
            repository.Tour(new Finisher());
        }
    }
}


