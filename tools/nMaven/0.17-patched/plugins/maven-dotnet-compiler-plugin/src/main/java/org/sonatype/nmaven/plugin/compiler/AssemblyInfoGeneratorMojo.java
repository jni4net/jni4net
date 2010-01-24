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
import org.apache.maven.project.MavenProject;
import org.sonatype.nmaven.assembler.AssemblerContext;
import org.sonatype.nmaven.assembler.AssemblyInfo;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshaller;
import org.sonatype.nmaven.assembler.AssemblyInfoException;
import org.sonatype.nmaven.ArtifactType;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.InitializationException;
import org.codehaus.plexus.util.FileUtils;

import java.io.File;
import java.io.IOException;
import java.io.FileOutputStream;
import java.util.List;

/**
 * Generates an AssemblyInfo.* class based on information within the pom file.
 *
 * @goal generate-assembly-info
 * @phase generate-sources
 * @description Generates an AssemblyInfo.* class based on information within the pom file.
 */
public class AssemblyInfoGeneratorMojo
    extends AbstractMojo
{
    /**
     * The maven project.
     *
     * @parameter expression="${project}"
     * @required
     * @readonly
     */
    private MavenProject project;

    /**
     * .NET Language. The default value is <code>C_SHARP</code>. Not case or white-space sensitive.
     *
     * @parameter expression="${language}" default-value = "C_SHARP"
     * @required
     */
    private String language;

    /**
     * Source directory containing the copied class files.
     *
     * @parameter expression = "${sourceDirectory}" default-value="${project.build.sourceDirectory}"
     * @required
     */
    private String sourceDirectory;

    /**
     * @parameter expression = "${CLSCompliant}" default-value="false"
     */
    private boolean isCLSCompliant;

    /**
     * @component
     */
    private AssemblerContext assemblerContext;


    /**
     * If an AssemblyInfo file exists in the source directory, then this method will not generate an AssemblyInfo.
     *
     * @throws org.apache.maven.plugin.MojoExecutionException
     *
     */
    public void execute()
        throws MojoExecutionException
    {
        if ( ArtifactType.MODULE.isMatchByString( project.getArtifact().getType() ) )
        {
            return;
        }

        File srcFile = new File( sourceDirectory );
        if ( srcFile.exists() )
        {
            try
            {
                List files = FileUtils.getFiles( srcFile, "**/AssemblyInfo.*", null );
                if ( files.size() != 0 )
                {
                    getLog().info( "NMAVEN-902-001: Found AssemblyInfo file(s), so will not generate one" );
                    return;
                }
            }
            catch ( IOException e )
            {
                throw new MojoExecutionException(
                    "NMAVEN-902-004: Could not determine whether an AssemblyInfo file exists", e );
            }
        }
        getLog().info( "NMAVEN-902-000: Generating Assembly Info: Language = " + language.trim() );

        try
        {
            assemblerContext.init( project );
        }
        catch ( InitializationException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }
        catch ( IOException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }

        AssemblyInfo assemblyInfo = assemblerContext.getAssemblyInfo();
        assemblyInfo.setClsCompliant( isCLSCompliant );
        //assemblyInfo.setKeyFile( keyfile );
        //assemblyInfo.setKeyName( keycontainer );

        try
        {
            File file = new File( project.getBuild().getDirectory(), BuildDirectories
                .BUILD_SOURCES_GENERATED.getBuildDirectoryName() + File.separator + "META-INF" + File.separator +
                "AssemblyInfo.cs" );
            FileUtils.mkdir( file.getParent() );

            FileOutputStream fos = new FileOutputStream( file );
            AssemblyInfoMarshaller marshaller =
                assemblerContext.getAssemblyInfoMarshallerFor( ProgrammingLanguage.C_SHARP );
            marshaller.marshal( assemblyInfo, fos );
        }
        catch ( IOException e )
        {
            throw new MojoExecutionException( "NMAVEN-902-002: Problem generating assembly info class", e );
        }
        catch ( AssemblyInfoException e )
        {
            throw new MojoExecutionException( "NMAVEN-902-005: Problem generating assembly info class", e );
        }
    }
}
