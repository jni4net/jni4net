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
package org.sonatype.nmaven.compiler;

import org.apache.maven.project.MavenProject;
import org.sonatype.nmaven.InitializationException;
import org.codehaus.plexus.logging.Logger;

import java.io.IOException;

/**
 * Interface defining compiler services.
 */
public interface CompilerContext
{

    /**
     * Returns the user provided configuration associated to this context. This is a live copy, so any changes to the
     * config will be reflected during compilation.
     *
     * @return the user provided configuration associated to this context
     */
    CompilerConfig getCompilerConfig();

    /**
     * Returns an instance of the compiler appropriate for this context.
     *
     * @return an instance of the compiler appropriate for this context
     */
    ClassCompiler getClassCompiler();

    /**
     * Returns the maven project used to initialize this context.
     *
     * @return the maven project used to initialize this context
     */
    MavenProject getMavenProject();
    
    Logger getPlexusLogger();

    /**
     * Initializes the compiler context.
     *
     * @param project the maven project
     * @param compilerConfig
     * @throws InitializationException
     * @throws IOException
     */
    void init( MavenProject project, CompilerConfig compilerConfig )
        throws InitializationException, IOException;

}
