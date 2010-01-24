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

import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.ArtifactType;

import java.io.File;

/**
 * Provides configuration Information for the .NET compiler environment.
 */
public interface CompilerConfig
{
    /**
     * The target artifact for the compile: library, module, exe, winexe or nar.
     *
     * @return target artifact for the compile
     */
    ArtifactType getArtifactType();

    /**
     * Returns true if the compiler plugin should compile the test classes, otherwise returns false.
     *
     * @return true if the compiler plugin should compile the test classes, otherwise returns false.
     */
    boolean isTestCompile();

    /**
     * Returns local repository
     *
     * @return local repository
     */
    File getLocalRepository();

    /**
     * Sets the artifact type for the compiler plugin: library, module, exe, winexe or nar
     *
     * @param artifactType the artifact type for the compiler plugin: library, module, exe, winexe or nar
     */
    void setArtifactType( ArtifactType artifactType );

    /**
     * If true, tells the compiler to compile the test classes, otherwise tells the compiler to compile the main classes.
     *
     * @param testCompile
     */
    void setTestCompile( boolean testCompile );

    /**
     * Sets local repository
     *
     * @param localRepository
     */
    void setLocalRepository( File localRepository );

    void setCompilerSourceDirectory( File sourceDirectory );

    /**
     * Returns the source directory (or test source directory) path of the class files. These are defined in the pom.xml
     * by the properties ${build.sourceDirectory} or ${build.testSourceDirectory}.
     *
     * @return the source directory (or test source directory) path of the class files.
     */
    File getCompilerDirectory();

    void setTargetDirectory( File targetDirectory );

    /**
     * Returns build directory.
     *
     * @return the build directory.
     */
    File getTargetDirectory();

    /**
     * Returns the programming language that the compiler should use.
     *
     * @return the programming language that the compiler should use
     */
    ProgrammingLanguage getProgrammingLanguage();

    void setProgrammingLanguage( ProgrammingLanguage programLanguage );

    void setVendor(Vendor vendor);

    Vendor getVendor();

    String getArtifactFileName();

    void setArtifactFileName(String artifactFileName);

    /**
     * Verifies that the necessary parameters exist within the config exist and are valid.
     *
     * @throws IllegalArgumentException if the necessary parameters do not exist or are are invalid.
     */
    void verifyCompilerConfig() throws IllegalArgumentException;


}
