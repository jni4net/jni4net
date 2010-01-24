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
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.sonatype.nmaven.ProgrammingLanguage;
import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.project.MavenProject;
import org.codehaus.plexus.util.DirectoryScanner;
import org.codehaus.plexus.util.FileUtils;

public abstract class AbstractSourceProcessorMojo
    extends AbstractMojo
{
    /**
     * The maven project.
     *
     * @parameter expression="${project}"
     * @required
     */
    protected MavenProject project;

    /**
     * @parameter expression = "${includes}"
     */
    private String[] includes;

    /**
     * @parameter expression = "${excludes}"
     */
    private String[] excludes;

    /**
     * .NET Language. The default value is <code>C_SHARP</code>. Not case or white-space sensitive.
     *
     * @parameter expression="${language}" default-value = "C_SHARP"
     * @required
     */
    private String language;
    
    /**
     * @return <code>File</code> The source directory to process
     */
    protected abstract File getSourceDirectory();
    
    /**
     * @return <code>File</code> The output directory where the processed source
     * will be placed
     */
    protected abstract File getOutputDirectory();
    
    /**
     * @return <code>String</code> The key used to set the source up to date flag
     * on the plugin context
     */
    protected abstract String getSourceUpToDateKey();

    protected abstract List<String> getExcludesList();

    protected abstract List<String> getIncludesList( String classExtension );

    protected void processSources()
        throws MojoExecutionException
    {
        File sourceDirectory = getSourceDirectory();

        if ( !sourceDirectory.exists() )
        {
            getLog().info( "NMAVEN-904-001: No source files to copy" );
            return;
        }
        if(!getOutputDirectory().exists())
        {
            getOutputDirectory().mkdirs();
        }
        DirectoryScanner directoryScanner = new DirectoryScanner();
        directoryScanner.setBasedir( sourceDirectory );

        List<String> excludeList = new ArrayList<String>(Arrays.asList(excludes));
        //target files
        excludeList.add( "obj/**" );
        excludeList.add( "bin/**" );
        excludeList.add( "target/**" );

        //Misc
        excludeList.add( "*.suo" );
        excludeList.add( "*.csproj" );
        excludeList.add( "*.sln" );
        excludeList.add( "Resources/**" );
        excludeList.addAll( getExcludesList());

        List<String> includeList = new ArrayList<String>(Arrays.asList(includes));
        includeList.addAll( getIncludesList(ProgrammingLanguage.valueOf( language ).getClassFileExtension()) );

        directoryScanner.setIncludes( includeList.toArray( includes ) );
        directoryScanner.setExcludes( excludeList.toArray( excludes ) );
        directoryScanner.addDefaultExcludes();

        File outputDirectory = getOutputDirectory();
        directoryScanner.scan();
        String[] files = directoryScanner.getIncludedFiles();
        getLog().info( "NMAVEN-904-002: Copying source files: From = " + sourceDirectory + ",  To = " +
            outputDirectory + ", File Count = " + files.length );

        super.getPluginContext().put( getSourceUpToDateKey(), Boolean.TRUE );
        for ( String file : files )
        {
            try
            {
                File sourceFile = new File( sourceDirectory, file );
                File targetFile = new File( outputDirectory, file );
                if ( sourceFile.lastModified() > targetFile.lastModified() )
                {
                    super.getPluginContext().put( getSourceUpToDateKey(), Boolean.FALSE );
                    FileUtils.copyFile( sourceFile, targetFile );
                    targetFile.setLastModified( System.currentTimeMillis() );
                }
            }
            catch ( IOException e )
            {
                throw new MojoExecutionException( "NMAVEN-904-000: Unable to process sources", e );
            }
        }
        
        directoryScanner.setBasedir( outputDirectory );
        directoryScanner.scan();
        
        // Synchronize the target folder with the source.  Specifically delete the targetFile if
        // the source file no longer exists
        for ( String file : directoryScanner.getIncludedFiles() )
        {
        	File sourceFile = new File( sourceDirectory, file );
        	File targetFile = new File( outputDirectory, file );
             
            if ( !sourceFile.exists() && targetFile.exists() )
            {
            	if ( !targetFile.delete() ) 
            	{
            		getLog().warn( "Unable to delete stale target file " + targetFile.getPath() );
            	}
            }
        }
    }
}
