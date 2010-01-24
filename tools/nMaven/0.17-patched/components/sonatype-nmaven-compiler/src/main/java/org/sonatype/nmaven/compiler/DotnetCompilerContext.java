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

import org.apache.maven.artifact.Artifact;
import org.sonatype.nmaven.ArtifactScope;

import java.io.File;
import java.util.Set;

public interface DotnetCompilerContext
    extends CompilerContext
{
    /**
     * Role used to register component implementations with the container.
     */
    String ROLE = DotnetCompilerContext.class.getName();

    /**
     * Returns assembly names that should be referenced by the compiler. If the List is emtpy, then all core assemblies
     * should be includes. These are assemblies that are not standard
     * dependencies, but are system assemblies that replace the core .NET framework assemblies (used to create profiles)
     *
     * @return assembly names that should be referenced by the compiler.
     */
    Set<String> getCoreAssemblyNames();

    /**
     * Returns a list of module (netmodule) dependencies that exist directly within the invoking projects pom
     * (no transitive module dependencies).
     *
     * @return a list of module (netmodule) dependencies of the class files.
     */
    Set<Artifact> getDirectModuleDependencies();

    /**
     * Returns a list of library (dll) dependencies of the class files.
     *
     * @return a list of library (dll) dependencies of the class files.
     */
    Set<Artifact> getLibraryDependenciesFor( ArtifactScope artifactScope );

    /**
     * Returns a list of resources that the compiler should link to the compiled assembly
     *
     * @return a list of resources that the compiler should link to the compiled assembly
     */
    Set<File> getLinkedResources();

    /**
     * Returns a list of resources that the compiler should embed in the compiled assembly. These may of any mime-type
     * or it may be a generated .resource file.
     *
     * @return a list of resources that the compiler should embed in the compiled assembly.
     */
    Set<File> getEmbeddedResources();

    /**
     * Returns the icon that the assembly should display when viewed. Should not be used in conjunction with win32res.
     *
     * @return the icon that the assembly should display when viewed.
     */
    File getWin32Icon();

    /**
     * Returns a list of win32 resources. Should not be used in conjunction with win32icon.
     *
     * @return a list of win32 resources.
     */
    Set<File> getWin32Resources();

}
