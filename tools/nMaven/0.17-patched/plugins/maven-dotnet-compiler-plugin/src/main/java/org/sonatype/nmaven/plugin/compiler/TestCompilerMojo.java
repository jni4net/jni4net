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
package org.sonatype.nmaven.plugin.compiler;

import java.io.File;
import java.io.IOException;
import java.util.Set;

import org.sonatype.nmaven.ArtifactType;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.InitializationException;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.ArtifactScope;
import org.sonatype.nmaven.compiler.DotnetCompilerConfig;
import org.sonatype.nmaven.compiler.DotnetCompilerContext;
import org.sonatype.nmaven.compiler.DotnetCompilerPlatformVersion;
import org.sonatype.nmaven.compiler.InvalidArtifactException;
import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.plugin.MojoFailureException;
import org.apache.maven.project.MavenProject;
import org.apache.maven.artifact.Artifact;
import org.codehaus.plexus.util.FileUtils;

/**
 * Maven Mojo for compiling Class files to the .NET Intermediate Language.
 *
 * @goal test-compile
 * @phase test-compile
 * @requiresDependencyResolution test
 * @description Maven Mojo for compiling class files to the .NET Intermediate Language
 */
public class TestCompilerMojo
    extends AbstractMojo
{
    /**
     * The maven project.
     *
     * @parameter expression="${project}"
     * @required
     */
    private MavenProject project;

    /**
     * The location of the local Maven repository.
     *
     * @parameter expression="${settings.localRepository}"
     */
    private File localRepository;

    /**
     * The framework version to compile under: 1.1, 2.0, 3.0
     *
     * @parameter expression = "${frameworkVersion}" default-value="2.0.50727"
     */
    private String frameworkVersion;

    /**
     * .NET Language. The default value is <code>C_SHARP</code>. Not case or white-space sensitive.
     *
     * @parameter expression="${language}" default-value = "C_SHARP"
     * @required
     */
    private String language;

    /**
     * The Vendor for the Compiler. Not case or white-space sensitive.
     *
     * @parameter expression="${vendor}"
     */
    private String vendorName;

    /**
     * @component
     */
    private DotnetCompilerContext compilerContext;


    public void execute()
        throws MojoExecutionException, MojoFailureException
    {

        String skipTest = System.getProperty( "maven.test.skip" );
        if ( "TRUE".equalsIgnoreCase( skipTest ) )
        {
            getLog().info( "Skipping Test compilation" );
            return;
        }

        File sourceDir =
            new File( project.getBuild().getDirectory(), BuildDirectories.TEST_BUILD_SOURCES.getBuildDirectoryName() );

        // No test source to process
        if ( !sourceDir.exists() )
        {
            return;
        }

        Vendor vendor;
        if ( vendorName != null )
        {
            vendor = Vendor.valueOf( vendorName.toUpperCase() );
        }
        else
        {
            vendor = Vendor.getDefaultVendorForOS();
        }

        getLog().info( ".NET Vendor: " + vendor );
        DotnetCompilerConfig compilerConfig = DotnetCompilerConfig.Factory.createDefaultCompilerConfig();
        compilerConfig.setArtifactType( ArtifactType.LIBRARY );
        compilerConfig.setCompilerPlatformVersion( DotnetCompilerPlatformVersion.valueFromVersion( frameworkVersion ) );

        compilerConfig.setLocalRepository( localRepository );
        compilerConfig.setProgrammingLanguage( ProgrammingLanguage.C_SHARP );
        compilerConfig.setTestCompile( true );
        compilerConfig.setCompilerSourceDirectory( sourceDir );
        compilerConfig.setVendor( vendor );
        compilerConfig.setTargetDirectory( new File( project.getBuild().getDirectory() ) );
        compilerConfig.setArtifactFileName(
            project.getBuild().getFinalName() + "-test" + "." + compilerConfig.getArtifactType().getExtension() );

        try
        {
            compilerContext.init( project, compilerConfig );
        }
        catch ( InitializationException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }
        catch ( IOException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }

        File testAssembly;
        try
        {
            testAssembly = compilerContext.getClassCompiler().compile();
        }
        catch ( InvalidArtifactException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }

        //Copy test references to target
        File testAssemblies =
            new File( project.getBuild().getDirectory(), BuildDirectories.TEST_ASSEMBLIES.getBuildDirectoryName() );

        if ( !testAssemblies.exists() && !testAssemblies.mkdirs() )
        {
            throw new MojoExecutionException( "Unable to create test assemblies directory: " + testAssemblies );
        }

       Set<Artifact> testDependencies = compilerContext.getLibraryDependenciesFor( ArtifactScope.TEST );

        try
        {
            for ( Artifact testDependency : testDependencies )
            {
                File testDependencyFile = testDependency.getFile();
                File testAssembliesFile = new File( testAssemblies, testDependencyFile.getName() );
                FileUtils.copyFile( testDependencyFile, testAssembliesFile );
            }

            File copiedTestAssembly = new File( testAssemblies, testAssembly.getName() );
            FileUtils.copyFile( testAssembly, copiedTestAssembly );
        }
        catch ( IOException e )
        {
            throw new MojoExecutionException( "Unable to copy all test assemblies to execution directory" );
        }
    }
}
