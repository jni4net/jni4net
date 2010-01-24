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
 * Enumeration of all the valid target types (module, library, winexe, exe, nar) for the .NET platform.
 */
public enum ArtifactType
{
    EXE( "dotnet:exe", "exe", "exe" ),
    GAC( "dotnet:gac", "library", "dll" ),
    GAC_32( "dotnet:gac_32", "library", "dll" ),
    GAC_GENERIC( "dotnet:gac_generic", "library", "dll" ),
    GAC_MSIL( "dotnet:gac_msil", "library", "dll" ),
    LIBRARY( "dotnet:library", "library", "dll" ),
    LIBRARY_LEGACY( "library", "library", "dll" ),
    MODULE( "dotnet:module", "module", "netmodule" ),
    WINEXE( "dotnet:winexe", "winexe", "exe" ),
    NULL( "null", "null", "null" );

    /**
     * The extension used for the artifact(netmodule, dll, exe)
     */
    private String extension;

    /**
     * The packaging type (as given in the package tag within the pom.xml) of the artifact.
     */
    private String packagingType;

    /**
     * The target types (module, library, winexe, exe) for the .NET platform.
     */
    private String targetCompileType;

    /**
     * Constructor
     */
    ArtifactType( String packagingType, String targetCompileType, String extension )
    {
        this.packagingType = packagingType;
        this.targetCompileType = targetCompileType;
        this.extension = extension;
    }

    /**
     * Returns extension used for the artifact(netmodule, dll, exe).
     *
     * @return Extension used for the artifact(netmodule, dll, exe).
     */
    public String getExtension()
    {
        return extension;
    }

    /**
     * Returns the packaging type (as given in the package tag within the pom.xml) of the artifact.
     *
     * @return the packaging type (as given in the package tag within the pom.xml) of the artifact.
     */
    public String getPackagingType()
    {
        return packagingType;
    }

    /**
     * Returns target types (module, library, winexe, exe) for the .NET platform.
     *
     * @return target types (module, library, winexe, exe) for the .NET platform.
     */
    public String getTargetCompileType()
    {
        return targetCompileType;
    }

    public boolean isMatchByString( String packaging )
    {
        if ( packaging == null )
        {
            throw new IllegalArgumentException( "packaging" );
        }
        return packaging.equals( packagingType );
    }

    /**
     * Returns artifact type for the specified packaging name
     *
     * @param packagingName the package name (as given in the package tag within the pom.xml) of the artifact.
     * @return the artifact type for the specified packaging name
     */
    public static synchronized ArtifactType getArtifactTypeForPackagingName( String packagingName )
    {
        if(packagingName == null)
        {
            throw new IllegalArgumentException("packagingName");
        }
        String[] packagingNameTokens = packagingName.split( "[:]");
        if(packagingNameTokens.length != 2 || !packagingNameTokens[0].equals( "nmaven"))
        {
            throw new IllegalArgumentException("packagingName");
        }

        return ArtifactType.valueOf( packagingNameTokens[1].toUpperCase());
    }
}
