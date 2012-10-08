using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services
{
    public class Explorer : IExplorer
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

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
            foreach (var projectRegistration in config.Project)
            {
                ExploreConfigJvm(projectRegistration);
                ExploreConfigClr(projectRegistration);
            }
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

        private void ExploreConfigClr(ProjectRegistration projectRegistration)
        {
            var configParent = new MType(null) {Registration = new TypeRegistration {Parent = projectRegistration,Name = "Config parent", Generate = false,Exclude = true}};
            configParent.Parent = configParent;
            
            foreach (var assembly in projectRegistration.Assembly)
            {
                if (assembly.Generate && assembly.ClrType.Count == 0)
                {
                    var models = string.IsNullOrEmpty(assembly.AssemblyName)
                                     ? ClrResolver.GenerateAs(projectRegistration.MakeAbsolutePath(assembly.File), configParent)
                                     : ClrResolver.GenerateAs(assembly.AssemblyName, configParent);
                    foreach (var model in models)
                    {
                        model.Registration = new TypeRegistration{Generate = true, IsSyntetic = true, Parent = projectRegistration};
                        model.IsGenerate = true;
                        model.IsExplore = true;
                        model.IsClr = true;
                        KnownTypes.Register(model);
                    }
                }
                foreach (var registration in assembly.ClrType)
                {
                    registration.Parent = projectRegistration;
                    var models = string.IsNullOrEmpty(assembly.AssemblyName)
                                     ? ClrResolver.GenerateAs(projectRegistration.MakeAbsolutePath(assembly.File), configParent, registration.Name)
                                     : ClrResolver.GenerateAs(assembly.AssemblyName, configParent, registration.Name);
                    if (models.Count == 0)
                    {
                        Logger.LogMessage("Can't find type " + registration.Name);
                    }
                    foreach (var model in models)
                    {
                        model.Registration = registration;
                        model.IsGenerate = registration.Generate && !registration.Exclude;
                        model.IsExplore = !registration.Exclude;
                        model.IsVerbose = registration.Verbose;
                        model.IsClr = true;
                        KnownTypes.Register(model);
                    }
                }
            }
        }

        private void ExploreConfigJvm(ProjectRegistration projectRegistration)
        {
            var configParent = new MType(null) { Registration = new TypeRegistration { Parent = projectRegistration, Name = "Config parent", Generate = false, Exclude = true } };
            configParent.Parent = configParent;

            foreach (var classPath in projectRegistration.ClassPath)
            {
                if (classPath.Generate && classPath.JavaClass.Count == 0)
                {
                    var models = string.IsNullOrEmpty(classPath.ClassPathDirectory)
                                     ? JvmResolver.GenerateCp(projectRegistration.MakeAbsolutePath(classPath.JarFile), configParent)
                                     : JvmResolver.GenerateCp(projectRegistration.MakeAbsolutePath(classPath.ClassPathDirectory), configParent);
                    foreach (var model in models)
                    {
                        model.Registration = new TypeRegistration { Generate = true, IsSyntetic = true,Parent = projectRegistration};
                        model.IsGenerate = true;
                        model.IsExplore = true;
                        model.IsClr = false;
                        KnownTypes.Register(model);
                    }
                }
                foreach (var registration in classPath.JavaClass)
                {
                    registration.Parent = projectRegistration;
                    var models = string.IsNullOrEmpty(classPath.ClassPathDirectory)
                                     ? JvmResolver.GenerateCp(projectRegistration.MakeAbsolutePath(classPath.JarFile), configParent, registration.Name)
                                     : JvmResolver.GenerateCp(projectRegistration.MakeAbsolutePath(classPath.ClassPathDirectory), configParent, registration.Name);
                    if (models.Count == 0)
                    {
                        Logger.LogMessage("Can't find class " + registration.Name);
                    }
                    foreach (var model in models)
                    {
                        model.Registration = registration;
                        model.IsGenerate = registration.Generate && !registration.Exclude;
                        model.IsExplore = !registration.Exclude;
                        model.IsVerbose = registration.Verbose;
                        model.IsClr = false;
                        KnownTypes.Register(model);
                    }
                }
            }
        }
    }
}
