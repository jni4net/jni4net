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
package org.sonatype.nmaven;

/**
 * Enumeration of the programming languages supported within the framework.
 */
public enum ProgrammingLanguage
{
    JAVA("java"),
    C_SHARP("cs"),
    VISUAL_BASIC("vb");

    /**
     * Class file extension for the programming languqage
     */
    private String classFileExtension;

    /**
     * Constructor
     *
     * @param classFileExtension class file extension for the programming languqage: java, cs, vb
     */
    private ProgrammingLanguage(String classFileExtension)
    {
        this.classFileExtension = classFileExtension;
    }

    /**
     * Returns the class file extension for the programming languqage.
     *
     * @return class file extension for the programming languqage
     */
    public String getClassFileExtension()
    {
        return classFileExtension;
    }
}
