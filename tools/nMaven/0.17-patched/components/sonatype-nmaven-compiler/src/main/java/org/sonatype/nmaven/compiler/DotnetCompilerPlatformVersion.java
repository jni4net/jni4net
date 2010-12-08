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
 * Enumeration of the supported .NET platform versions.
 */
public enum DotnetCompilerPlatformVersion
{
    VERSION_1_1_4322("1.1.4322"),
    VERSION_2_0_50727("2.0.50727"),
    VERSION_3_0("3.0"),
    VERSION_3_5("3.5"),
    VERSION_4_0_30319("4.0.30319");

    private String version;

    DotnetCompilerPlatformVersion(String version)
    {
        this.version = version;
    }

    public String getVersionAsString()
    {
        return version;
    }

    public static DotnetCompilerPlatformVersion valueFromVersion(String version)
    {
        return DotnetCompilerPlatformVersion.valueOf( "VERSION_" + version.replace( '.', '_'));
    }
}
