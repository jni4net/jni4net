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

import java.io.File;

/**
 * Provides the information to be included within the assembly. Class can be extended to add additional assembly info
 * parameters.
 */
public class AssemblyInfo
{
    /**
     * Is CLS Compliant Assembly?
     */
    private boolean clsCompliant = false;

    /**
     * Artifact version
     */
    private String version;

    /**
     * Informational version (used for snapshot)
     */
    private String informationalVersion;

    /**
     * Artifact description
     */
    private String description;

    /**
     * Artifact title
     */
    private String title;

    /**
     * Artifact company
     */
    private String company;

    /**
     * Artifact company
     */
    private String product;

    /**
     * Artifact copyright
     */
    private String copyright;

    /**
     * Artifact trademark
     */
    private String trademark;

    /**
     * Artifact culture
     */
    private String culture;

    /**
     * Artifact configuration
     */
    private String configuration;

    private String keyName;

    private File keyFile;

    /**
     * Default constructor
     */
    public AssemblyInfo()
    {
    }

    public boolean isClsCompliant()
    {
        return clsCompliant;
    }

    public void setClsCompliant( boolean clsCompliant )
    {
        this.clsCompliant = clsCompliant;
    }

    public String toString()
    {
        StringBuffer sb = new StringBuffer();
        sb.append( "CLSCompilant: " ).append( clsCompliant )
            .append( "Version: " ).append( version )
            .append( "\r\nInformationalVersion: " ).append( informationalVersion )
            .append( "\r\nDescription: " ).append( description )
            .append( "\r\nTitle: " ).append( title )
            .append( "\r\nCompany; " ).append( company )
            .append( "\r\nProduct: " ).append( product )
            .append( "\r\nCopyright: " ).append( copyright )
            .append( "\r\nTrademark: " ).append( trademark )
            .append( "\r\nCulture: " ).append( culture )
            .append( "\r\nConfiguration: " ).append( configuration );
        return sb.toString();
    }

    /**
     * Returns the key name.
     *
     * @return the key name
     */
    public String getKeyName()
    {
        return keyName;
    }

    public void setKeyName( String keyName )
    {
        this.keyName = keyName;
    }

    public File getKeyFile()
    {
        return keyFile;
    }

    public void setKeyFile( File keyFile )
    {
        this.keyFile = keyFile;
    }

    public String getVersion()
    {
        return ( version != null ) ? version : "";
    }

    public void setVersion( String version )
    {
        this.version = version;
    }

    public String getInformationalVersion()
    {
        return ( informationalVersion != null ) ? informationalVersion : "";
    }

    public void setInformationalVersion( String informationalVersion )
    {
        this.informationalVersion = informationalVersion;
    }

    public String getDescription()
    {
        return ( description != null ) ? description : "";
    }

    public void setDescription( String description )
    {
        this.description = description;
    }

    public String getTitle()
    {
        return ( title != null ) ? title : "";
    }

    public void setTitle( String title )
    {
        this.title = title;
    }

    public String getCompany()
    {
        return ( company != null ) ? company : "";
    }

    public void setCompany( String company )
    {
        this.company = company;
    }

    public String getProduct()
    {
        return ( product != null ) ? product : "";
    }

    public void setProduct( String product )
    {
        this.product = product;
    }

    public String getCopyright()
    {
        return ( copyright != null ) ? copyright : "";
    }

    public void setCopyright( String copyright )
    {
        this.copyright = copyright;
    }

    public String getTrademark()
    {
        return ( trademark != null ) ? trademark : "";
    }

    public void setTrademark( String trademark )
    {
        this.trademark = trademark;
    }

    public String getCulture()
    {
        return ( culture != null ) ? culture : "";
    }

    public void setCulture( String culture )
    {
        this.culture = culture;
    }

    public String getConfiguration()
    {
        return ( configuration != null ) ? configuration : "";
    }

    public void setConfiguration( String configuration )
    {
        this.configuration = configuration;
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

        final AssemblyInfo that = (AssemblyInfo) o;

        if ( company != null ? !company.equals( that.company ) : that.company != null )
        {
            return false;
        }
        if ( configuration != null ? !configuration.equals( that.configuration ) : that.configuration != null )
        {
            return false;
        }
        if ( copyright != null ? !copyright.equals( that.copyright ) : that.copyright != null )
        {
            return false;
        }
        if ( culture != null ? !culture.equals( that.culture ) : that.culture != null )
        {
            return false;
        }
        if ( description != null ? !description.equals( that.description ) : that.description != null )
        {
            return false;
        }
        if ( product != null ? !product.equals( that.product ) : that.product != null )
        {
            return false;
        }
        if ( title != null ? !title.equals( that.title ) : that.title != null )
        {
            return false;
        }
        if ( trademark != null ? !trademark.equals( that.trademark ) : that.trademark != null )
        {
            return false;
        }
        if ( version != null ? !version.equals( that.version ) : that.version != null )
        {
            return false;
        }

        return true;
    }

    public int hashCode()
    {
        int result;
        result = ( version != null ? version.hashCode() : 0 );
        result = 29 * result + ( informationalVersion != null ? informationalVersion.hashCode() : 0 );
        result = 29 * result + ( description != null ? description.hashCode() : 0 );
        result = 29 * result + ( title != null ? title.hashCode() : 0 );
        result = 29 * result + ( company != null ? company.hashCode() : 0 );
        result = 29 * result + ( product != null ? product.hashCode() : 0 );
        result = 29 * result + ( copyright != null ? copyright.hashCode() : 0 );
        result = 29 * result + ( trademark != null ? trademark.hashCode() : 0 );
        result = 29 * result + ( culture != null ? culture.hashCode() : 0 );
        result = 29 * result + ( configuration != null ? configuration.hashCode() : 0 );
        return result;
    }

}
