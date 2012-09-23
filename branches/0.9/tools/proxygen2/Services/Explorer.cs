using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Services
{
    public class Explorer : IExplorer
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public ITypeRepository TypeRepository { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        public void Init(ProxygenConfig config)
        {
            foreach (var projectRegistration in config.Project)
            {
                InitJvm(projectRegistration);
                InitClr(projectRegistration);
            }

            ClrResolver.Init();
            JvmResolver.Init();
        }

        private void InitClr(ProjectRegistration projectRegistration)
        {
            if (projectRegistration.Assembly == null)
            {
                return;
            }
            foreach (var assembly in projectRegistration.Assembly)
            {
                if (!string.IsNullOrEmpty(assembly.AssemblyName))
                {
                    ClrResolver.AddName(assembly.AssemblyName);
                }
                else if (!string.IsNullOrEmpty(assembly.File))
                {
                    ClrResolver.AddPath(projectRegistration.MakeAbsolutePath(assembly.File));
                }
                else
                {
                    const string message = "ClassPathDirectory or JarFile missing";
                    Logger.LogError(message);
                    throw new ProxygenConfigException(message);
                }
            }
        }

        private void InitJvm(ProjectRegistration projectRegistration)
        {
            if (projectRegistration.ClassPath==null)
            {
                return;
            }
            foreach (var classPath in projectRegistration.ClassPath)
            {
                if (!string.IsNullOrEmpty(classPath.ClassPathDirectory))
                {
                    JvmResolver.AddDir(projectRegistration.MakeAbsolutePath(classPath.ClassPathDirectory));
                }
                else if (!string.IsNullOrEmpty(classPath.JarFile))
                {
                    JvmResolver.AddJar(projectRegistration.MakeAbsolutePath(classPath.JarFile));
                }
                else
                {
                    const string message = "ClassPathDirectory or JarFile missing";
                    Logger.LogError(message);
                    throw new ProxygenConfigException(message);
                }
            }
        }

        public void Explore(ProxygenConfig config)
        {
            foreach (var projectRegistration in config.Project)
            {
                ExploreJvm(projectRegistration);
                ExploreClr(projectRegistration);
            }
        }

        private void ExploreClr(ProjectRegistration projectRegistration)
        {
            foreach (var assembly in projectRegistration.Assembly)
            {
                if (assembly.Generate && (assembly.ClrType == null || assembly.ClrType.Count==0))
                {
                    var models = string.IsNullOrEmpty(assembly.AssemblyName)
                                     ? ClrResolver.GenerateAs(projectRegistration.MakeAbsolutePath(assembly.File))
                                     : ClrResolver.GenerateAs(assembly.AssemblyName);
                    foreach (var model in models)
                    {
                        model.IsGenerate = true;
                        model.IsExplore = true;
                        model.IsClr = true;
                        TypeRepository.Register(model);
                    }
                }
                if (assembly.ClrType!=null)
                {
                    foreach (var registration in assembly.ClrType)
                    {
                        var models = string.IsNullOrEmpty(assembly.AssemblyName)
                                         ? ClrResolver.GenerateAs(projectRegistration.MakeAbsolutePath(assembly.File),
                                             registration.Name)
                                         : ClrResolver.GenerateAs(assembly.AssemblyName, registration.Name);
                        if (models.Count == 0)
                        {
                            Logger.LogMessage("Can't find type " + registration.Name);
                        }
                        foreach (var model in models)
                        {
                            model.Registration = registration;
                            model.IsGenerate = registration.Generate && !registration.Exclude;
                            model.IsExplore = registration.Exclude;
                            model.IsClr = true;
                            TypeRepository.Register(model);
                        }
                    }
                }
            }
        }

        private void ExploreJvm(ProjectRegistration projectRegistration)
        {
            foreach (var classPath in projectRegistration.ClassPath)
            {
                if (classPath.Generate && (classPath.JavaClass==null || classPath.JavaClass.Count == 0))
                {
                    var models = string.IsNullOrEmpty(classPath.ClassPathDirectory)
                                     ? JvmResolver.GenerateCp(projectRegistration.MakeAbsolutePath(classPath.JarFile))
                                     : JvmResolver.GenerateCp(
                                         projectRegistration.MakeAbsolutePath(classPath.ClassPathDirectory));
                    foreach (var model in models)
                    {
                        model.IsGenerate = true;
                        model.IsExplore = true;
                        model.IsClr = false;
                        TypeRepository.Register(model);
                    }
                }
                if (classPath.JavaClass != null)
                {
                    foreach (var registration in classPath.JavaClass)
                    {
                        var models = string.IsNullOrEmpty(classPath.ClassPathDirectory)
                                         ? JvmResolver.GenerateCp(
                                             projectRegistration.MakeAbsolutePath(classPath.JarFile), registration.Name)
                                         : JvmResolver.GenerateCp(
                                             projectRegistration.MakeAbsolutePath(classPath.ClassPathDirectory),
                                             registration.Name);
                        if (models.Count == 0)
                        {
                            Logger.LogMessage("Can't find class " + registration.Name);
                        }
                        foreach (var model in models)
                        {
                            model.Registration = registration;
                            model.IsGenerate = registration.Generate && !registration.Exclude;
                            model.IsExplore = !registration.Exclude;
                            model.IsClr = false;
                            TypeRepository.Register(model);
                        }
                    }
                }
            }
        }
    }
}
