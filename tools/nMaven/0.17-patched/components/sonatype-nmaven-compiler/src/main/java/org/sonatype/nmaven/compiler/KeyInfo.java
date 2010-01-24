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

import java.net.URI;

/**
 * Provides services for obtaining information about the key file.
 */
public interface KeyInfo
{
    /**
     * Returns the path of the key
     *
     * @return the path of the key
     */
    URI getKeyFileUri();

    /**
     * Sets the path of the key
     *
     * @param keyFileUri the path of the key
     */
    void setKeyFileUri( URI keyFileUri );

    String getKeyContainerName();

    void setKeyContainerName( String keyContainerName );

    public static class Factory
    {
        /**
         * Constructor
         */
        private Factory()
        {
        }

        /**
         * Returns a default instance of key info.
         *
         * @return a default instance of key info
         */
        public static KeyInfo createDefaultKeyInfo()
        {
            return new KeyInfo()
            {
                private URI keyFileUri;

                private String keyContainerName;

                public URI getKeyFileUri()
                {
                    return keyFileUri;
                }

                public void setKeyFileUri( URI keyFileUri )
                {
                    this.keyFileUri = keyFileUri;
                }

                public String getKeyContainerName()
                {
                    return keyContainerName;
                }

                public void setKeyContainerName( String keyContainerName )
                {
                    this.keyContainerName = keyContainerName;
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

                    final KeyInfo that = (KeyInfo) o;

                    if ( keyContainerName != null ? !keyContainerName.equals( that.getKeyContainerName() )
                        : that.getKeyContainerName() != null )
                    {
                        return false;
                    }
                    if ( keyFileUri != null ? !keyFileUri.equals( that.getKeyFileUri() ) : that.getKeyFileUri() != null )
                    {
                        return false;
                    }

                    return true;
                }

                public int hashCode()
                {
                    int result;
                    result = ( keyFileUri != null ? keyFileUri.hashCode() : 0 );
                    result = 29 * result + ( keyContainerName != null ? keyContainerName.hashCode() : 0 );
                    return result;
                }
            };
        }
    }

}
