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
 * Enumeration of vendors whose compilers and tools are supported by the framework.
 */
public enum Vendor
{
    MICROSOFT,
    NOVELL,
    ANY,
    NULL;

    /**
     * Returns the default vendor of the operating system on which the application is running:
     * Microsoft for windows and Mono for all others.
     *
     * @return the default vendor of the operating system on which the application is running
     */
    public static synchronized Vendor getDefaultVendorForOS()
    {
        return System.getProperty( "os.name" ).toLowerCase().trim().contains( "windows" ) ? Vendor.MICROSOFT
            : Vendor.NOVELL;
    }
}
