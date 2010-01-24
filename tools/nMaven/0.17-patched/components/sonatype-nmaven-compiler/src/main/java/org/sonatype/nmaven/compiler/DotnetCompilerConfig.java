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

public interface DotnetCompilerConfig
    extends CompilerConfig
{

    /**
     * Returns key info used for signing assemblies.
     *
     * @return key info used for signing assemblies
     */
    KeyInfo getKeyInfo();

    /**
     * Sets key info used for signing assemblies.
     *
     * @param keyInfo key info used for signing assemblies
     */
    void setKeyInfo( KeyInfo keyInfo );

    DotnetCompilerPlatformVersion getCompilerPlatformVersion();

    void setCompilerPlatformVersion( DotnetCompilerPlatformVersion compilerPlatformVersion );


	String getAditionalCompilerOptions();

	void setAditionalCompilerOptions(String options);

    public static class Factory
    {
        /**
         * Constructor
         */
        private Factory()
        {
        }

        /**
         * Returns a default instance of the executable config.
         *
         * @return a default instance of the executable config
         */
        public static DotnetCompilerConfig createDefaultCompilerConfig()
        {
            return new DotnetCompilerConfig()
            {
                private KeyInfo keyInfo;

                private DotnetCompilerPlatformVersion compilerPlatformVersion;

                private ArtifactType artifactType;

                private boolean isTestCompile;

                private File localRepository;

                private File compileSourceDirectory;

                private File targetDirectory;

                private ProgrammingLanguage programmingLanguage;

                private Vendor vendor;

                private String artifactFileName;
				
				private String aditionalCompilerOptions;

                public String getArtifactFileName()
                {
                    return artifactFileName;
                }

                public void setArtifactFileName( String artifactFileName )
                {
                    this.artifactFileName = artifactFileName;
                }

                public KeyInfo getKeyInfo()
                {
                    return keyInfo;
                }

                public void setKeyInfo( KeyInfo keyInfo )
                {
                    this.keyInfo = keyInfo;
                }

                public DotnetCompilerPlatformVersion getCompilerPlatformVersion()
                {
                    return compilerPlatformVersion;
                }

                public void setCompilerPlatformVersion( DotnetCompilerPlatformVersion compilerPlatformVersion )
                {
                    this.compilerPlatformVersion = compilerPlatformVersion;
                }

				public String getAditionalCompilerOptions() {
					return aditionalCompilerOptions;  //TODO ZAMO
				}

				public void setAditionalCompilerOptions(String options) {
					aditionalCompilerOptions=options;
				}

				public ArtifactType getArtifactType()
                {
                    return artifactType;
                }

                public void setArtifactType( ArtifactType artifactType )
                {
                    this.artifactType = artifactType;
                }

                public boolean isTestCompile()
                {
                    return isTestCompile;
                }

                public void setTestCompile( boolean testCompile )
                {
                    isTestCompile = testCompile;
                }

                public File getLocalRepository()
                {
                    return localRepository;
                }

                public void setLocalRepository( File localRepository )
                {
                    this.localRepository = localRepository;
                }

                public File getCompilerDirectory()
                {
                    return compileSourceDirectory;
                }

                public void setCompilerSourceDirectory( File sourceDirectory )
                {
                    this.compileSourceDirectory = sourceDirectory;
                }

                public File getTargetDirectory()
                {
                    return targetDirectory;
                }

                public void setTargetDirectory( File targetDirectory )
                {
                    this.targetDirectory = targetDirectory;
                }

                public ProgrammingLanguage getProgrammingLanguage()
                {
                    return programmingLanguage;
                }

                public void setProgrammingLanguage( ProgrammingLanguage programmingLanguage )
                {
                    this.programmingLanguage = programmingLanguage;
                }

                public Vendor getVendor()
                {
                    return vendor;
                }

                public void setVendor( Vendor vendor )
                {
                    this.vendor = vendor;
                }

                public void verifyCompilerConfig()
                    throws IllegalArgumentException
                {
                    if ( artifactType == null )
                    {
                        throw new IllegalArgumentException( "artifactType" );
                    }

                    if ( compilerPlatformVersion == null )
                    {
                        throw new IllegalArgumentException( "compilerPlatformVersion" );
                    }

                    if ( localRepository == null || !localRepository.exists() )
                    {
                        throw new IllegalArgumentException( "localRepository" );
                    }

                    if ( compileSourceDirectory == null)
                    {
                        throw new IllegalArgumentException( "sourceDirectory" );
                    }

                    if ( targetDirectory == null || !targetDirectory.exists() )
                    {
                        throw new IllegalArgumentException( "targetDirectory" );
                    }

                    if ( programmingLanguage == null )
                    {
                        throw new IllegalArgumentException( "programmingLanguage" );
                    }

                    if ( vendor == null )
                    {
                        throw new IllegalArgumentException( "vendor" );
                    }
                }

                public boolean equals( Object o )
                {
                    if ( this == o )
                    {
                        return true;
                    }
                    if ( o == null || getClass() != o.getClass() )
                    {
                        return false;
                    }

                    final DotnetCompilerConfig that = (DotnetCompilerConfig) o;

                    if ( isTestCompile != that.isTestCompile() )
                    {
                        return false;
                    }
                    if ( artifactType != that.getArtifactType() )
                    {
                        return false;
                    }
                    if ( compilerPlatformVersion != that.getCompilerPlatformVersion() )
                    {
                        return false;
                    }
                    if ( keyInfo != null ? !keyInfo.equals( that.getKeyInfo() ) : that.getKeyInfo() != null )
                    {
                        return false;
                    }
                    if ( !localRepository.equals( that.getLocalRepository() ) )
                    {
                        return false;
                    }
                    if ( programmingLanguage != that.getProgrammingLanguage() )
                    {
                        return false;
                    }
                    if ( !compileSourceDirectory.equals( that.getCompilerDirectory() ) )
                    {
                        return false;
                    }
                    if ( !targetDirectory.equals( that.getTargetDirectory() ) )
                    {
                        return false;
                    }
                    if ( vendor != that.getVendor() )
                    {
                        return false;
                    }

                    return true;
                }

                public int hashCode()
                {
                    int result;
                    result = ( keyInfo != null ? keyInfo.hashCode() : 0 );
                    result = 29 * result + compilerPlatformVersion.hashCode();
                    result = 29 * result + artifactType.hashCode();
                    result = 29 * result + ( isTestCompile ? 1 : 0 );
                    result = 29 * result + localRepository.hashCode();
                    result = 29 * result + compileSourceDirectory.hashCode();
                    result = 29 * result + targetDirectory.hashCode();
                    result = 29 * result + programmingLanguage.hashCode();
                    result = 29 * result + vendor.hashCode();
                    return result;
                }
            };
        }
    }
}
