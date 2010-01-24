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

/**
 * Exception thrown when there is a problem processing the assembly info.
 */
public class AssemblyInfoException
    extends Exception
{

    static final long serialVersionUID = 720673423890L;

    /**
     * Constructs a <code>AssemblyInfoException</code>  with no exception message.
     */
    public AssemblyInfoException()
    {
        super();
    }

    /**
     * Constructs an <code>AssemblyInfoException</code> with the specified exception message.
     *
     * @param message the exception message
     */
    public AssemblyInfoException( String message )
    {
        super( message );
    }

    /**
     * Constructs an <code>AssmeblyInfoException</code> with the specified exception message and cause of the exception.
     *
     * @param message the exception message
     * @param cause   the cause of the exception
     */
    public AssemblyInfoException( String message, Throwable cause )
    {
        super( message, cause );
    }

    /**
     * Constructs an <code>AssemblyInfoException</code> with the cause of the exception.
     *
     * @param cause the cause of the exception
     */
    public AssemblyInfoException( Throwable cause )
    {
        super( cause );
    }
}
