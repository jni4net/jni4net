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

import java.io.File;
import java.util.List;

public interface ClassCompiler
{

    /**
     * Returns true to fail the build if the compiler writes anything to the error stream, otherwise return false.
     *
     * @return true to fail the build if the compiler writes anything to the error stream, otherwise return false
     */
    boolean failOnErrorOutput();

    /**
     * Returns the commands that this compiler will use to compile the application. This list is unmodifiable.
     *
     * @return the commands that this compiler will use to compile the application
     */
    List<String> getCommands();

    /**
     * Resets the commands to be used by the executable. This should only be used if the executable is being reused with
     * different commands from the one that it was initialized with.
     *
     * @param commands
     */
    void resetCommands( List<String> commands );

    /**
     * Compiles class files.
     * @return a file pointing to the compiled artifact
     */
    File compile() throws InvalidArtifactException;

    /**
     * Returns the executable file name that this compiler will use to compile the application.
     *
     * @return the executable file name that this compiler will use to compile the application
     */
    String getCompilerFileName();

    void init(CompilerContext compilerContext);

}
