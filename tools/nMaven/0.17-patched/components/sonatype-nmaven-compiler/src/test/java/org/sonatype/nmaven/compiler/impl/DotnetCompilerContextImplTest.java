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

import java.util.HashSet;
import java.util.Set;
import java.io.File;
import java.io.IOException;

import org.apache.maven.project.MavenProject;
import org.apache.maven.artifact.Artifact;
import org.apache.maven.artifact.DefaultArtifact;
import org.apache.maven.artifact.handler.DefaultArtifactHandler;
import org.apache.maven.artifact.versioning.VersionRange;
import org.apache.maven.model.Build;

import org.sonatype.nmaven.compiler.DotnetCompilerConfig;
import org.sonatype.nmaven.ArtifactType;
import org.sonatype.nmaven.compiler.DotnetCompilerPlatformVersion;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.InitializationException;
import org.sonatype.nmaven.ArtifactScope;
import org.sonatype.nmaven.compiler.ClassCompiler;

import org.junit.Test;
import static org.hamcrest.CoreMatchers.equalTo;
import org.hamcrest.BaseMatcher;
import org.hamcrest.CoreMatchers;
import static org.junit.Assert.*;

public class DotnetCompilerContextImplTest
{
    @Test(expected = IllegalArgumentException.class)
    public void init_WithNullProject()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        DotnetCompilerConfig compilerConfig = DotnetCompilerConfig.Factory.createDefaultCompilerConfig();

        ctx.init( null, compilerConfig );

    }

    @Test(expected = IllegalArgumentException.class)
    public void init_WithNullCompilerConfig()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        ctx.init( new MavenProject(), null );
    }

    @Test
    public void testInit_WithModule()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setDependencyArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:module", null,
                                                 new DefaultArtifactHandler( "dotnet:module" ), false );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> modules = ctx.getDirectModuleDependencies();
        assertThat( modules.size(), equalTo( 1 ) );
    }

    @Test
    public void testInit_WithLibrary()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:library", null,
                                                 new DefaultArtifactHandler( "dotnet:library" ), false );
        artifact.setArtifactHandler( new DummyArtifactHandler() );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
    }

    @Test
    public void testInit_WithExe()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:exe", null,
                                                 new DefaultArtifactHandler( "dotnet:exe" ), false );
        artifact.setArtifactHandler( new DummyArtifactHandler() );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
    }

    @Test
    public void testInit_WithProvidedDependency()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "provided", "dotnet:library", null,
                                                 new DefaultArtifactHandler( "dotnet:library" ), false );
        artifact.setArtifactHandler( new DummyArtifactHandler() );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
    }

    @Test
    public void testInit_WithSystemGacDependency()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "system", "dotnet:gac_msil", null,
                                                 new DefaultArtifactHandler( "dotnet:gac_msil" ), false );
        artifact.setArtifactHandler( new DummyArtifactHandler() );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
    }

    //@Test
    public void testInit_WithGacGenericAndMicrosoft()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:gac_generic", "dsfajkdsfajdfs",
                                                 new DefaultArtifactHandler( "library" ), false );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffAssemblyExistsCheck();
        ctx.turnOffCompilerExistsCheck();

        ctx.init( project, getDefaultDotnetCompilerConfig() );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
        assertThat( ( (Artifact) libraries.toArray()[0] ).getFile().getAbsolutePath(),
                    CoreMatchers.allOf( new BaseMatcher()
                    {
                        private String containsString = "assembly" + File.separator + "GAC_MSIL" + File.separator +
                            "artifactId" + File.separator + "1.0__dsfajkdsfajdfs" + File.separator + "artifactId.dll";

                        public boolean matches( Object object )
                        {
                            return ( (String) object ).contains( containsString );
                        }

                        public void describeTo( org.hamcrest.Description description )
                        {
                            description.appendText( "Contains = " + containsString );
                        }
                    } ) );
    }

    // @Test
    public void testInit_WithGacGenericAndNovellAndPath()
        throws InitializationException, IOException
    {
        String monoRoot = Vendor.getDefaultVendorForOS().equals( Vendor.NOVELL ) ? "/Mono" : "C:\\Program Files\\Mono";

        System.setProperty( "PATH", monoRoot + File.separator + "bin" );
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:gac_generic", "dsfajkdsfajdfs",
                                                 new DefaultArtifactHandler( "library" ), false );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffAssemblyExistsCheck();
        DotnetCompilerConfig compilerConfig = getDefaultDotnetCompilerConfig();
        compilerConfig.setVendor( Vendor.NOVELL );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, compilerConfig );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
        assertThat( ( (Artifact) libraries.toArray()[0] ).getFile().getAbsolutePath(), equalTo(
            monoRoot + replaceFileSeparator( "\\lib\\mono\\gac\\artifactId\\1.0__dsfajkdsfajdfs\\artifactId.dll" ) ) );
    }

    // @Test
    public void testInit_WithGacGenericAndNovellAndMonoRoot()
        throws InitializationException, IOException
    {
        String monoRoot = Vendor.getDefaultVendorForOS().equals( Vendor.NOVELL ) ? "/Mono" : "C:\\Program Files\\Mono";
        System.setProperty( "MONO_ROOT", monoRoot );
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Set<Artifact> dependencyArtifacts = new HashSet<Artifact>();
        project.setArtifacts( dependencyArtifacts );
        Artifact artifact = new DefaultArtifact( "groupId", "artifactId", VersionRange.createFromVersion( "1.0" ),
                                                 "compile", "dotnet:gac_generic", "dsfajkdsfajdfs",
                                                 new DefaultArtifactHandler( "library" ), false );
        dependencyArtifacts.add( artifact );

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        ctx.turnOffAssemblyExistsCheck();
        DotnetCompilerConfig compilerConfig = getDefaultDotnetCompilerConfig();
        compilerConfig.setVendor( Vendor.NOVELL );

        ctx.turnOffCompilerExistsCheck();
        ctx.init( project, compilerConfig );

        Set<Artifact> libraries = ctx.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        assertThat( libraries.size(), equalTo( 1 ) );
        assertThat( ( (Artifact) libraries.toArray()[0] ).getFile().getAbsolutePath(), equalTo(
            monoRoot + replaceFileSeparator( "\\lib\\mono\\gac\\artifactId\\1.0__dsfajkdsfajdfs\\artifactId.dll" ) ) );
    }

//    @Test

    public void testInit_ForCorrectCompiler()
        throws InitializationException, IOException
    {
        DotnetCompilerContextImpl ctx = new DotnetCompilerContextImpl();
        MavenProject project = new MavenProject();

        Build build = new Build();
        build.setDirectory( "" );
        project.setBuild( build );

        System.setProperty( "java.class.path", new File( "src/test/resources",
                                                         "nmaven-compiler-ext-0.14-incubating-SNAPSHOT.jar" ).getAbsolutePath() );

        ctx.init( project, getDefaultDotnetCompilerConfig() );

        ClassCompiler compiler = ctx.getClassCompiler();
    }

    private static DotnetCompilerConfig getDefaultDotnetCompilerConfig()
    {
        DotnetCompilerConfig config = DotnetCompilerConfig.Factory.createDefaultCompilerConfig();
        config.setArtifactType( ArtifactType.LIBRARY );
        config.setCompilerPlatformVersion( DotnetCompilerPlatformVersion.VERSION_2_0_50727 );
        config.setLocalRepository( new File( "." ) );
        config.setProgrammingLanguage( ProgrammingLanguage.C_SHARP );
        config.setCompilerSourceDirectory( new File( "." ) );
        config.setTargetDirectory( new File( "." ) );
        config.setTestCompile( false );
        config.setVendor( Vendor.MICROSOFT );

        return config;
    }

    private static String replaceFileSeparator( String value )
    {
        return value.replaceAll( "[/\\\\]+", "\\" + File.separator );
    }
}
