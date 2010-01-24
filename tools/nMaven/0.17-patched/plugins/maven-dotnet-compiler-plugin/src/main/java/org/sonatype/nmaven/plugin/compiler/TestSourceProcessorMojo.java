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
import java.util.List;
import java.util.ArrayList;

import org.sonatype.nmaven.BuildDirectories;
import org.apache.maven.plugin.MojoExecutionException;

/**
 * Copies test source files to target directory.
 *
 * @goal process-test-sources
 * @phase process-test-sources
 * @description Copies source files to target directory.
 */
public class TestSourceProcessorMojo
    extends AbstractSourceProcessorMojo
{
    
    public void execute()
        throws MojoExecutionException
    {
        String skipTest = System.getProperty( "maven.test.skip" );
        if ( "TRUE".equalsIgnoreCase( skipTest ) )
        {
            getLog().info( "Skipping Test source processing " );
            return;
        }
        
        processSources();
    }

    @Override
    protected File getOutputDirectory()
    {
        return new File( project.getBuild().getDirectory(), 
                         BuildDirectories.TEST_BUILD_SOURCES_MAIN.getBuildDirectoryName() );
    }

    @Override
    protected File getSourceDirectory()
    {
        return new File( project.getBuild().getTestSourceDirectory() );
    }
    
    @Override
    protected String getSourceUpToDateKey()
    {
        return "TEST_SOURCE_FILES_UP_TO_DATE";
    }

    protected List<String> getExcludesList()
    {
        return new ArrayList<String>();
    }

    protected List<String> getIncludesList( String classExtension )
    {
        List<String> includeList = new ArrayList<String>();
        includeList.add( "**/*." + classExtension );
        return includeList;
    }
}
