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

import org.junit.Test;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.ArtifactType;

import java.io.File;

public class NetCompilerConfigTest
{
    @Test
    public void verifyCompilerConfig()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullArtifactType()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setArtifactType( null );
        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullCompilerPlatformVersion()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setCompilerPlatformVersion( null);

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullLocalRepository()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setLocalRepository( null);

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullProgrammingLanguage()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setProgrammingLanguage( null);

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullSourceDirectory()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setCompilerSourceDirectory( null);

        config.verifyCompilerConfig();
    }

    @Test
    public void verifyCompilerConfig_WithMissingSourceDirectory()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setCompilerSourceDirectory( new File("/" + Math.random()));

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullTargetDirectory()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setTargetDirectory( null);

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithMissingTargetDirectory()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setTargetDirectory( new File("/" + Math.random()));

        config.verifyCompilerConfig();
    }

    @Test(expected = IllegalArgumentException.class)
    public void verifyCompilerConfig_WithNullVendor()
        throws IllegalArgumentException
    {
        DotnetCompilerConfig config = getDefaultDotnetCompilerConfig();
        config.setVendor( null);

        config.verifyCompilerConfig();
    }

    private static DotnetCompilerConfig getDefaultDotnetCompilerConfig()
    {
        DotnetCompilerConfig config = DotnetCompilerConfig.Factory.createDefaultCompilerConfig();
        config.setArtifactType( ArtifactType.LIBRARY );
        config.setCompilerPlatformVersion( DotnetCompilerPlatformVersion.VERSION_2_0_50727 );
        config.setLocalRepository( new File( "." ) );
        config.setProgrammingLanguage( ProgrammingLanguage.C_SHARP );
        config.setCompilerSourceDirectory( new File( "." ) );
        config.setTargetDirectory( new File( "." ) );
        config.setTestCompile( false );
        config.setVendor( Vendor.MICROSOFT );

        return config;
    }
}
