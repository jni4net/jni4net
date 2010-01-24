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
package org.sonatype.nmaven.assembler;

import org.apache.maven.project.MavenProject;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.InitializationException;

import java.io.IOException;

/**
 * Provides services for generating of AssemblyInfo.* file.
 */
public interface AssemblerContext
{

    /**
     * Role used to register component implementations with the container.
     */
    String ROLE = AssemblerContext.class.getName();

    /**
     * Returns the assembly info associated with this context.
     *
     * @return the assembly info associated with this context.
     */
    AssemblyInfo getAssemblyInfo();

    /**
     * Returns the marshaller for the given language
     *
     * @param programmingLanguage the .NET language
     * @return the marshaller for the specified language
     * @throws AssemblyInfoException if no marshaller can be found for the specified language
     */
    AssemblyInfoMarshaller getAssemblyInfoMarshallerFor( ProgrammingLanguage programmingLanguage )
        throws AssemblyInfoException;

    /**
     * Initializes the context
     *
     * @param mavenProject the maven project
     */
    void init( MavenProject mavenProject )
        throws InitializationException, IOException;

}
