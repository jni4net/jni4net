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
 * Enumeration of build directory names. 
 */
public enum BuildDirectories
{
    BUILD_SOURCES("build-sources"),
    BUILD_SOURCES_MAIN("build-sources/main-sources"),
    BUILD_SOURCES_GENERATED("build-sources/generated-sources"),
    TEST_ASSEMBLIES("test-assemblies"),
    TEST_BUILD_SOURCES("test-build-sources"),
    TEST_BUILD_SOURCES_MAIN("test-build-sources/test-sources"),
    TEST_BUILD_SOURCES_GENERATED("test-build-sources/generated-sources"),
    ASSEMBLY_RESOURCES("assembly-resources");

    private String buildDirectoryName;

    BuildDirectories(String buildDirectoryName)
    {
        this.buildDirectoryName = buildDirectoryName;
    }

   public String getBuildDirectoryName()
    {
        return buildDirectoryName;
    }
}
