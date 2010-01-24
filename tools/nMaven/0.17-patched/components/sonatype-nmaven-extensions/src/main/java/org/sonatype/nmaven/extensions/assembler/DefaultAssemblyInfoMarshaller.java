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
package org.sonatype.nmaven.extensions.assembler;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;

import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.assembler.AssemblyInfo;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshaller;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshallerAnnotation;

/**
 * Provides services for writing out the AssemblyInfo entries using the bracket convention [assembly:
 */
@AssemblyInfoMarshallerAnnotation(programmingLanguages = {ProgrammingLanguage.C_SHARP})
public final class DefaultAssemblyInfoMarshaller
    implements AssemblyInfoMarshaller
{
    private ProgrammingLanguage programmingLanguage;

    private File buildSourcesDirectory;

    public void marshal( AssemblyInfo assemblyInfo, OutputStream outputStream )
        throws IOException
    {
        StringBuffer sb = new StringBuffer();
        sb.append( "using System;\r\n" )
            .append( "using System.Reflection;\r\n" )
            .append( "using System.Runtime.CompilerServices;\r\n" )
            .append( "[assembly: " ).append( "CLSCompliant" ).append( "(" ).append(
            ( ( assemblyInfo.isClsCompliant() ) ? "true" : "false" ) ).append( ")]" ).append( "\r\n" )
            .append( createEntry( "Description", assemblyInfo.getDescription() ) )
            .append( createEntry( "Title", assemblyInfo.getTitle() ) )
            .append( createEntry( "Company", assemblyInfo.getCompany() ) )
            .append( createEntry( "Product", assemblyInfo.getProduct() ) )
            .append( createEntry( "Copyright", assemblyInfo.getCopyright().replace( "\"", "\\" ) ) )
            .append( createEntry( "Trademark", assemblyInfo.getTrademark() ) )
            .append( createEntry( "Culture", assemblyInfo.getCulture() ) )
            .append( createEntry( "Version", assemblyInfo.getVersion() ) )
            .append( createEntry( "InformationalVersion", assemblyInfo.getInformationalVersion() ) )
            .append( createEntry( "Configuration", assemblyInfo.getConfiguration() ) );
        if ( assemblyInfo.getKeyName() != null )
        {
            sb.append( createEntry( "KeyName", assemblyInfo.getKeyName() ) );
        }
        if ( assemblyInfo.getKeyFile() != null )
        {
            sb.append( createEntry( "KeyFile", assemblyInfo.getKeyFile().getAbsolutePath().replace( "\\", "\\\\" ) ) );
        }
        FileOutputStream assemblyInfoFileStream = null;
        try
        {
            File metaInfoDir = new File( buildSourcesDirectory, "META-INF" );
            metaInfoDir.mkdirs();
            assemblyInfoFileStream = new FileOutputStream(
                metaInfoDir + File.separator + "AssemblyInfo." + programmingLanguage.getClassFileExtension() );
            assemblyInfoFileStream.write( sb.toString().getBytes() );
        }
        catch ( IOException e )
        {
            e.printStackTrace();
            throw new IOException( "NMAVEN-022-000: Failed to generate AssemblyInfo" );
        }
        finally
        {
            if ( assemblyInfoFileStream != null )
            {
                assemblyInfoFileStream.close();
            }
            if ( outputStream != null )
            {
                outputStream.close();
            }
        }
    }

    /**
     * @see AssemblyInfoMarshaller#unmarshall(java.io.InputStream)
     */
    public AssemblyInfo unmarshall( InputStream inputStream )
        throws IOException
    {
        AssemblyInfo assemblyInfo = new AssemblyInfo();
        BufferedReader reader = new BufferedReader( new InputStreamReader( inputStream ) );
        String line;
        while ( ( line = reader.readLine() ) != null )
        {
            String[] tokens = line.split( "[:]" );

            if ( tokens.length == 2 )
            {
                String[] assemblyTokens = tokens[1].split( "[(]" );
                String name = assemblyTokens[0].trim();
                String value = assemblyTokens[1].trim().split( "[\"]" )[1].trim();
                setAssemblyInfo( assemblyInfo, name, value );
            }
        }
        return assemblyInfo;
    }

    public void init( ProgrammingLanguage programmingLanguage, File buildSourcesDirectory )
    {
        this.programmingLanguage = programmingLanguage;
        this.buildSourcesDirectory = buildSourcesDirectory;
    }

    public ProgrammingLanguage getProgrammingLanguageForMarshaller()
    {
        return programmingLanguage;
    }

    /**
     * Sets the specified value within the specified assembly info
     *
     * @param assemblyInfo the assembly info to set information on
     * @param name         the name of the assembly info field: AssemblyTitle, AssemblyDescription, ...
     * @param value        the value associated with the specified name
     * @throws IOException if the assembly info is invalid
     */
    private static void setAssemblyInfo( AssemblyInfo assemblyInfo, String name, String value )
        throws IOException
    {
        if ( !name.startsWith( "Assembly" ) )
        {
            throw new IOException(
                "NMAVEN-022-001: Invalid assembly info parameter: Name = " + name + ", Value = " + value );
        }
        if ( name.equals( "AssemblyDescription" ) )
        {
            assemblyInfo.setDescription( value );
        }
        else if ( name.equals( "AssemblyInformationalVersion" ) )
        {
            assemblyInfo.setInformationalVersion( value );
        }
        else if ( name.equals( "AssemblyTitle" ) )
        {
            assemblyInfo.setTitle( value );
        }
        else if ( name.equals( "AssemblyCompany" ) )
        {
            assemblyInfo.setCompany( value );
        }
        else if ( name.equals( "AssemblyProduct" ) )
        {
            assemblyInfo.setProduct( value );
        }
        else if ( name.equals( "AssemblyCopyright" ) )
        {
            assemblyInfo.setCopyright( value );
        }
        else if ( name.equals( "AssemblyTrademark" ) )
        {
            assemblyInfo.setTrademark( value );
        }
        else if ( name.equals( "AssemblyCulture" ) )
        {
            assemblyInfo.setCulture( value );
        }
        else if ( name.equals( "AssemblyVersion" ) )
        {
            assemblyInfo.setVersion( value );
        }
        else if ( name.equals( "AssemblyConfiguration" ) )
        {
            assemblyInfo.setConfiguration( value );
        }
        else if ( name.equals( "AssemblyKeyFile" ) )
        {
            assemblyInfo.setConfiguration( value );
        }
        else if ( name.equals( "AssemblyKeyName" ) )
        {
            assemblyInfo.setConfiguration( value );
        }
    }

    /**
     * Returns an assembly entry with a name-value pair surrounded by brackets.
     *
     * @param name  the name of the assembly entry
     * @param value the value of the assembly entry
     * @return an assembly entry with a name-value pair surrounded by brackets
     */
    private static String createEntry( String name, String value )
    {
        StringBuffer sb = new StringBuffer();
        sb.append( "[assembly: Assembly" ).append( name ).append( "(\"" ).append( value ).append( "\")]" ).append(
            "\r\n" );
        return sb.toString();
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

        final DefaultAssemblyInfoMarshaller that = (DefaultAssemblyInfoMarshaller) o;

        if ( programmingLanguage != that.programmingLanguage )
        {
            return false;
        }

        return true;
    }

    public int hashCode()
    {
        return programmingLanguage.hashCode();
    }
}
