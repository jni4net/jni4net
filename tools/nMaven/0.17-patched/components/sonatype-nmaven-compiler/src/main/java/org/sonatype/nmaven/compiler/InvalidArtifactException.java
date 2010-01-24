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

/**
 * Exception thrown when the framework either does not recognize the target artifact (module, library, exe, winexe) or
 * the target artifact is not valid for the compiler.
 */
public class InvalidArtifactException extends Exception
{
    static final long serialVersionUID = -3214341783478731432L;

    /**
     * Constructs an <code>InvalidArtifactException</code>  with no exception message.
     */
    public InvalidArtifactException()
    {
        super();
    }

    /**
     * Constructs an <code>InvalidArtifactException</code> with the specified exception message.
     *
     * @param message the exception message
     */
    public InvalidArtifactException( String message )
    {
        super( message );
    }

    /**
     * Constructs an <code>InvalidArtifactException</code> with the specified exception message and cause of the exception.
     *
     * @param message the exception message
     * @param cause   the cause of the exception
     */
    public InvalidArtifactException( String message, Throwable cause )
    {
        super( message, cause );
    }

    /**
     * Constructs an <code>InvalidArtifactException</code> with the cause of the exception.
     *
     * @param cause the cause of the exception
     */
    public InvalidArtifactException( Throwable cause )
    {
        super( cause );
    }
}
