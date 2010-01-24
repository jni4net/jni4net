/*
 *  Copyright 2006-2008 NMaven Project 
 *  
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  you may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at 
 *  
 *  	http://www.apache.org/licenses/LICENSE-2.0 
 *  
 *  Unless required by applicable law or agreed to in writing, software 
 *  distributed under the License is distributed on an "AS IS" BASIS, 
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
 *  See the License for the specific language governing permissions and 
 *  limitations under the License. 
 */
package org.sonatype.nmaven.compiler.impl;

import java.io.File;
import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;
import java.util.Enumeration;
import java.util.Map;
import java.util.List;
import java.util.HashMap;
import java.net.URL;

import org.apache.maven.artifact.Artifact;
import org.sonatype.nmaven.compiler.ClassCompiler;
import org.sonatype.nmaven.compiler.CompilerConfig;
import org.sonatype.nmaven.compiler.DotnetCompilerConfig;
import org.sonatype.nmaven.compiler.DotnetCompilerContext;
import org.sonatype.nmaven.InitializationException;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.ArtifactType;
import org.sonatype.nmaven.ArtifactScope;
import org.sonatype.nmaven.compiler.CompilerAnnotation;
import org.apache.maven.project.MavenProject;
import org.codehaus.plexus.logging.Logger;
import org.codehaus.plexus.logging.LogEnabled;

public final class DotnetCompilerContextImpl
    implements DotnetCompilerContext, LogEnabled

{
    /**
     * The maven project
     */
    private MavenProject project;

    private DotnetCompilerConfig netCompilerConfig;

    private Map<ArtifactScope, Set<Artifact>> libraryArtifactDependencyMap;

    private Set<Artifact> moduleDependencies;

    private ClassCompiler classCompiler;

    /**
     * A logger for writing log messages
     */
    private Logger logger;

    private Set<File> linkedResources;

    private Set<File> embeddedResources;

    private File win32icon;

    private Set<File> win32resources;

    private boolean assemblyExistsCheck = true;

    private boolean compilerExistsCheck = true;

    public Set<String> getCoreAssemblyNames()
    {
        return null;
    }

    public Set<Artifact> getDirectModuleDependencies()
    {
        return moduleDependencies;
    }

    public Set<Artifact> getLibraryDependenciesFor( ArtifactScope artifactScope )
    {
        return libraryArtifactDependencyMap.get( artifactScope );
    }

    public Set<File> getLinkedResources()
    {
        return linkedResources;
    }

    public Set<File> getEmbeddedResources()
    {
        return embeddedResources;
    }

    public File getWin32Icon()
    {
        return win32icon;
    }

    public Set<File> getWin32Resources()
    {
        return win32resources;
    }

    public CompilerConfig getCompilerConfig()
    {
        return netCompilerConfig;
    }

    public ClassCompiler getClassCompiler()
    {
        return classCompiler;
    }

    public MavenProject getMavenProject()
    {
        return project;
    }

    public Logger getPlexusLogger()
    {
        return logger;
    }

    public void enableLogging( Logger logger )
    {
        this.logger = logger;
        logger.info( "Logging enabled." );
    }

    public void init( MavenProject project, CompilerConfig compilerConfig )
        throws InitializationException, IOException
    {
        if ( project == null )
        {
            throw new IllegalArgumentException( "NMAVEN-061-000: mavenProject" );
        }

        if ( compilerConfig == null )
        {
            throw new IllegalArgumentException( "NMAVEN-061-001: compilerConfig" );
        }

        this.project = project;
        this.netCompilerConfig = (DotnetCompilerConfig) compilerConfig;
        netCompilerConfig.verifyCompilerConfig();

        HashSet<Artifact> compileLibraryDependencies = new HashSet<Artifact>();
        HashSet<Artifact> systemLibraryDependencies = new HashSet<Artifact>();
        HashSet<Artifact>  providedLibraryDependencies = new HashSet<Artifact>();
        HashSet<Artifact> testLibraryDependencies = new HashSet<Artifact>();
        HashSet<Artifact> runtimeLibraryDependencies = new HashSet<Artifact>();

        libraryArtifactDependencyMap = new HashMap<ArtifactScope, Set<Artifact>>();
        libraryArtifactDependencyMap.put( ArtifactScope.COMPILE, compileLibraryDependencies );
        libraryArtifactDependencyMap.put( ArtifactScope.SYSTEM, systemLibraryDependencies );
        libraryArtifactDependencyMap.put( ArtifactScope.PROVIDED, providedLibraryDependencies );
        libraryArtifactDependencyMap.put( ArtifactScope.TEST, testLibraryDependencies );
        libraryArtifactDependencyMap.put( ArtifactScope.RUNTIME, runtimeLibraryDependencies );

        moduleDependencies = new HashSet<Artifact>();

        //Module dependencies non-transitive
        Set<Artifact> directDependentArtifacts = project.getDependencyArtifacts();
        if ( directDependentArtifacts != null )
        {
            for ( Artifact artifact : directDependentArtifacts )
            {
                String type = artifact.getType();
                String scope = artifact.getScope();
                if ( type.equals( ArtifactType.MODULE.getPackagingType() ) )
                {
                    if ( !ArtifactScope.COMPILE.isMatchByString( scope ) )
                    {
                        throw new InitializationException( "Module must be of compile scope: Scope = " + scope );
                    }
                    moduleDependencies.add( artifact );
                }
            }
        }

        addLibraryArtifactsToTarget( project.getCompileArtifacts(), compileLibraryDependencies );
        addLibraryArtifactsToTarget( project.getTestArtifacts(), testLibraryDependencies );
        addLibraryArtifactsToTarget( project.getRuntimeArtifacts(), runtimeLibraryDependencies );

        Enumeration<URL> resources =
            this.getClass().getClassLoader().getResources( "/META-INF/nmaven/annotation-resources.txt" );

        while ( resources.hasMoreElements() )
        {
            URL url = resources.nextElement();
            BufferedReader reader = new BufferedReader( new InputStreamReader( url.openStream() ) );
            String annotatedClass;
            while ( ( annotatedClass = reader.readLine() ) != null )
            {
                String className = null;
                try
                {
                    Class c = Class.forName( annotatedClass );
                    className = c.getName();
                    CompilerAnnotation annotation = (CompilerAnnotation) c.getAnnotation( CompilerAnnotation.class );
                    if ( annotation != null && isMatchBetween( (DotnetCompilerConfig) compilerConfig, annotation ) )
                    {
                        classCompiler = (ClassCompiler) c.newInstance();
                        classCompiler.init( this );
                    }
                }
                catch ( ClassNotFoundException e )
                {
                    throw new InitializationException(
                        "NMAVEN-061-007: Unable to create NetCompiler: Class Name = " + className, e );
                }
                catch ( InstantiationException e )
                {
                    throw new InitializationException(
                        "NMAVEN-061-005: Unable to create NetCompiler: Class Name = " + className, e );
                }
                catch ( IllegalAccessException e )
                {
                    throw new InitializationException(
                        "NMAVEN-061-006: Unable to create NetCompiler: Class Name = " + className, e );
                }
            }
        }

        if ( classCompiler == null && compilerExistsCheck )
        {
            throw new InitializationException( "Could not find compiler" );
        }
        String basedir =
            project.getBuild().getDirectory() + File.separator + BuildDirectories.ASSEMBLY_RESOURCES + File.separator;
        linkedResources = new File( basedir, "linkresource" ).exists() ? new HashSet<File>(
            Arrays.asList( new File( basedir, "linkresource" ).listFiles() ) ) : new HashSet<File>();

        embeddedResources = new File( basedir, "resource" ).exists() ? new HashSet<File>(
            Arrays.asList( new File( basedir, "resource" ).listFiles() ) ) : new HashSet<File>();
        win32resources = new File( basedir, "win32res" ).exists() ? new HashSet<File>(
            Arrays.asList( new File( basedir, "win32res" ).listFiles() ) ) : new HashSet<File>();
        File win32IconDir = new File( basedir, "win32icon" );
        if ( win32IconDir.exists() )
        {
            File[] icons = win32IconDir.listFiles();
            if ( icons.length > 1 )
            {
                throw new InitializationException(
                    "NMAVEN-061-002: There is more than one win32icon in resource directory: Number = " + icons
                        .length );
            }
            if ( icons.length == 1 )
            {
                win32icon = icons[0];
            }
        }
    }

    private void addLibraryArtifactsToTarget( List<Artifact> sourceArtifacts, Set<Artifact> targetArtifacts )
        throws InitializationException
    {
        if ( sourceArtifacts == null )
        {
            return;
        }

        for ( Artifact artifact : sourceArtifacts )
        {
            String type = artifact.getType();
            if ( ArtifactType.LIBRARY.isMatchByString( type ) || ArtifactType.EXE.isMatchByString( type ) ||
                ArtifactType.WINEXE.isMatchByString( type ) || type.startsWith( "dotnet:gac" ) ||
                ArtifactType.LIBRARY_LEGACY.isMatchByString( type ))
            {
                targetArtifacts.add( artifact );
            }
            else if ( type.startsWith( "dotnet:gac" ) &&
                !( artifact.getScope().equals( "provided" ) || artifact.getScope().equals( "system" ) ) )
            {
                throw new InitializationException( "Gac dependency scope must be specified as provided or system" );
            }
        }
    }

    protected void turnOffAssemblyExistsCheck()
    {
        this.assemblyExistsCheck = false;
    }

    protected void turnOnAssemblyExistsCheck()
    {
        this.assemblyExistsCheck = true;
    }

    protected void turnOffCompilerExistsCheck()
    {
        this.compilerExistsCheck = false;
    }

    protected void turnOnCompilerExistsCheck()
    {
        this.compilerExistsCheck = true;
    }

    private static boolean isMatchBetween( DotnetCompilerConfig compilerConfig, CompilerAnnotation compilerAnnotation )
    {
        return Arrays.asList( compilerAnnotation.vendors() ).contains( compilerConfig.getVendor() ) &&
            Arrays.asList( compilerAnnotation.dotnetCompilerPlatformVersions() ).contains(
                compilerConfig.getCompilerPlatformVersion() ) &&
            compilerAnnotation.programmingLanguaqe().equals( compilerConfig.getProgrammingLanguage() );
    }

    /**
     * Returns mono GAC root. First checks path for Mono, then checks MONO_ROOT property, then checks MONO_ROOT
     * environmental variable.
     *
     * @return mono GAC root
     * @throws InitializationException
     */
    private String getGacRootForMono()
        throws InitializationException
    {
        String path = System.getProperty( "PATH" ) != null ? System.getProperty( "PATH" ) : System.getenv( "PATH" );
        if ( path != null )
        {
            String[] tokens = path.split( System.getProperty( "path.separator" ) );
            for ( String token : tokens )
            {
                File gacRoot = new File( new File( token ).getParentFile(), "lib/mono/gac/" );
                if ( !assemblyExistsCheck || gacRoot.exists() )
                {
                    return gacRoot.getAbsolutePath();
                }
            }
        }
        String monoRoot = System.getProperty( "MONO_ROOT" ) != null ? System.getProperty( "MONO_ROOT" )
            : System.getenv( "MONO_ROOT" );
        if ( monoRoot != null && !new File( monoRoot ).exists() )
        {
            logger.warn( "MONO_ROOT has been incorrectly set. Trying /usr : MONO_ROOT = " + monoRoot );
        }
        else if ( monoRoot != null )
        {
            return ( !monoRoot.endsWith( File.separator ) ) ? monoRoot + File.separator : monoRoot;
        }

        if ( new File( "/usr/lib/mono/gac/" ).exists() )
        {
            return new File( "/usr/lib/mono/gac/" ).getAbsolutePath();
        }
        else
        {
            throw new InitializationException(
                "NMAVEN-061-003: Could not locate Global Assembly Cache for Mono. Try setting the MONO_ROOT environmental variable." );
        }
    }

    private void setArtifactGacFile( String gacRoot, Artifact artifact )
        throws InitializationException
    {
        File gacFile = new File( gacRoot, artifact.getArtifactId() + File.separator + artifact.getVersion() + "__" +
            artifact.getClassifier() + File.separator + artifact.getArtifactId() + ".dll" );

        if ( assemblyExistsCheck && !gacFile.exists() )
        {
            throw new InitializationException(
                "NMAVEN-061-004: Could not find GAC dependency: File = " + gacFile.getAbsolutePath() );
        }
        artifact.setFile( gacFile );
    }

    private static String replaceFileSeparator( String value )
    {
        return value.replaceAll( "[/\\\\]+", "\\" + File.separator );
    }
}
