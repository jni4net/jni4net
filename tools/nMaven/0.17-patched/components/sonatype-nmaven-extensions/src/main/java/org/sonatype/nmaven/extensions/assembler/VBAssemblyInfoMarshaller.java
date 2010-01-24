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

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.assembler.AssemblyInfo;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshaller;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshallerAnnotation;

/**
 * Provides services for writing out the AssemblyInfo entries for VB using the angle bracket convention.
 */
@AssemblyInfoMarshallerAnnotation(programmingLanguages = {ProgrammingLanguage.VISUAL_BASIC})
public final class VBAssemblyInfoMarshaller
    implements AssemblyInfoMarshaller
{
    private ProgrammingLanguage programmingLanguage;

    private File buildSourcesDirectory;

    public void marshal( AssemblyInfo assemblyInfo, OutputStream outputStream )
        throws IOException
    {
        StringBuffer sb = new StringBuffer();
        sb.append( "Imports System.Reflection\r\n" )
            .append( "Imports System.Runtime.InteropServices\r\n" )
            .append( createEntry( "Description", assemblyInfo.getDescription() ) )
            .append( createEntry( "Title", assemblyInfo.getTitle() ) )
            .append( createEntry( "Company", assemblyInfo.getCompany() ) )
            .append( createEntry( "Product", assemblyInfo.getProduct() ) )
            .append( createEntry( "Copyright", assemblyInfo.getCopyright().replace( "\"", "\\" ) ) )
            .append( createEntry( "Trademark", assemblyInfo.getTrademark() ) )
            .append( createEntry( "Culture", assemblyInfo.getCulture() ) )
            .append( createEntry( "Version", assemblyInfo.getVersion() ) );

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
        }
    }

    /**
     * @see AssemblyInfoMarshaller#unmarshall(java.io.InputStream)
     */
    public AssemblyInfo unmarshall( InputStream inputStream )
        throws IOException
    {
        throw new IOException( "This method is not implemented" );
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
     * Returns an assembly entry with a name-value pair surrounded by angle brackets.
     *
     * @param name  the name of the assembly entry
     * @param value the value of the assembly entry
     * @return an assembly entry with a name-value pair surrounded by angle brackets
     */
    private String createEntry( String name, String value )
    {
        StringBuffer sb = new StringBuffer();
        sb.append( "<Assembly: Assembly" ).append( name ).append( "(\"" ).append( value ).append( "\")>" ).append(
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

        final VBAssemblyInfoMarshaller that = (VBAssemblyInfoMarshaller) o;

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
