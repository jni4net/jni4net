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

import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.plugin.MojoFailureException;
import org.sonatype.nmaven.compiler.DotnetCompilerContext;
import org.sonatype.nmaven.compiler.DotnetCompilerConfig;
import org.sonatype.nmaven.compiler.DotnetCompilerPlatformVersion;
import org.sonatype.nmaven.compiler.KeyInfo;
import org.sonatype.nmaven.compiler.InvalidArtifactException;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.ArtifactType;
import org.sonatype.nmaven.InitializationException;
import org.apache.maven.project.MavenProject;

import java.io.File;
import java.io.IOException;

/**
 * Maven Mojo for compiling Class files to the .NET Intermediate Language.
 *
 * @goal compile
 * @phase compile
 * @requiresDependencyResolution compile
 * @description Maven Mojo for compiling class files to the .NET Intermediate Language
 */
public class CompilerMojo
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
     * Specify a strong name key file.
     *
     * @parameter expression = "${keyfile}"
     */
    private File keyfile;

	/**
	 * More compiler options
	 *
	 * @parameter expression = "${aditionalOptions}"
	 */
	private String aditionalOptions;

    /**
     * Specifies a strong name key container.
     *
     * @parameter expression = "${keycontainer}"
     */
    private String keycontainer;

    /**
     * The framework version to compile under: 1.1, 2.0, 3.0
     *
     * @parameter expression = "${frameworkVersion}" default-value="2.0.50727"
     */
    private String frameworkVersion;

    /**
     * .NET Language. The default value is <code>C_SHARP</code>.
     *
     * @parameter expression="${language}" default-value = "C_SHARP"
     * @required
     */
    private String language;

    /**
     * The Vendor for the Compiler.
     *
     * @parameter expression="${vendor}"
     */
    private String vendorName;

    /**
     * @component
     */
    private DotnetCompilerContext dotnetCompilerContext;

    public void execute()
        throws MojoExecutionException, MojoFailureException
    {

        File sourceDir =
            new File( project.getBuild().getDirectory(), BuildDirectories.BUILD_SOURCES.getBuildDirectoryName() );

        // No source to process
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

        String packaging = project.getPackaging();
        
        // If this is a nmaven type, remove the "nmaven:" portion
        if ( packaging.contains( ":" ) )
        {
            packaging = packaging.split( "[:]" )[1];
        }

        compilerConfig.setArtifactType( ArtifactType.valueOf( packaging.toUpperCase() ) );
        compilerConfig.setCompilerPlatformVersion( DotnetCompilerPlatformVersion.valueFromVersion( frameworkVersion ) );

        KeyInfo keyInfo = KeyInfo.Factory.createDefaultKeyInfo();
        if ( keyfile != null )
        {
            keyInfo.setKeyFileUri( keyfile.toURI() );
        }

		if (aditionalOptions!=null){
			compilerConfig.setAditionalCompilerOptions(aditionalOptions);
		}

        keyInfo.setKeyContainerName( keycontainer );
        compilerConfig.setKeyInfo( keyInfo );

        compilerConfig.setLocalRepository( localRepository );
        compilerConfig.setProgrammingLanguage( ProgrammingLanguage.C_SHARP );
        compilerConfig.setCompilerSourceDirectory( sourceDir );
        compilerConfig.setVendor( vendor );
        compilerConfig.setTargetDirectory( new File( project.getBuild().getDirectory() ) );
        compilerConfig.setArtifactFileName(
            project.getBuild().getFinalName() + "." + compilerConfig.getArtifactType().getExtension() );

        try
        {
            dotnetCompilerContext.init( project, compilerConfig );
        }
        catch ( InitializationException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }
        catch ( IOException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }
        try
        {
            project.getArtifact().setFile( dotnetCompilerContext.getClassCompiler().compile() );
        }
        catch ( InvalidArtifactException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }
    }
}
