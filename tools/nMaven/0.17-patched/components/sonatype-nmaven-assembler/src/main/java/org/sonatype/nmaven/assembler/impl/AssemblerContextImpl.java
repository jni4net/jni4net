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
package org.sonatype.nmaven.assembler.impl;

import org.sonatype.nmaven.assembler.AssemblerContext;
import org.sonatype.nmaven.assembler.AssemblyInfo;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshaller;
import org.sonatype.nmaven.assembler.AssemblyInfoException;
import org.sonatype.nmaven.assembler.AssemblyInfoMarshallerAnnotation;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.InitializationException;
import org.apache.maven.project.MavenProject;
import org.apache.maven.model.Organization;

import org.codehaus.plexus.util.IOUtil;

import java.io.*;
import java.util.Enumeration;
import java.util.List;
import java.util.ArrayList;
import java.util.logging.Logger;
import java.util.logging.Level;
import java.net.URL;

/**
 * Provides an implementation of the <code>AssemblerContext</code>.
 *
 * @author Shane Isbell
 */
public final class AssemblerContextImpl
    implements AssemblerContext
{

    /**
     * The maven project
     */
    private MavenProject mavenProject;

    /**
     * A logger for writing log messages
     */
    private static Logger logger = Logger.getAnonymousLogger();

    private List<AssemblyInfoMarshaller> marshallers;

    /**
     * Constructor. This method is intended to by invoked by the plexus-container, not by the application developer.
     */
    public AssemblerContextImpl()
    {
    }

    /**
     * @see org.sonatype.nmaven.assembler.AssemblerContext#getAssemblyInfo()
     */
    public AssemblyInfo getAssemblyInfo()
    {
        AssemblyInfo assemblyInfo = new AssemblyInfo();
        String description = mavenProject.getDescription();
        String version = mavenProject.getVersion();
        String name = mavenProject.getName();
        Organization organization = mavenProject.getOrganization();
        String company = ( organization != null ) ? organization.getName() : "";
        String copyright = null;
        String informationalVersion = "";
        String configuration = "";

        String basedir = mavenProject.getBasedir().toString();
        File file = new File( basedir + "/COPYRIGHT.txt" );
        if ( file.exists() )
        {
            logger.log( Level.INFO, "NMAVEN-020-000: Found Copyright: " + file.getAbsolutePath() );
            FileInputStream fis = null;
            try
            {
                fis = new FileInputStream( file );
                copyright = IOUtil.toString( fis ).replace( "\r", " " ).replace( "\n", " " ).replace( "\"", "'" );
            }
            catch ( IOException e )
            {
                logger.warning( "NMAVEN-020-001: Could not get copyright: File = " + file.getAbsolutePath() );
            }
            finally
            {
                if ( fis != null )
                {
                    IOUtil.close( fis );
                }
            }
        }
        informationalVersion = version;
        if ( version.contains( "-" ) )
        {
            version = version.split( "-" )[0];
        }
        assemblyInfo.setCompany( company );
        assemblyInfo.setCopyright( copyright );
        assemblyInfo.setCulture( "" );
        assemblyInfo.setDescription( description );
        assemblyInfo.setProduct( company + "-" + name );
        assemblyInfo.setTitle( name );
        assemblyInfo.setTrademark( "" );
        assemblyInfo.setInformationalVersion( informationalVersion );
        assemblyInfo.setVersion( version );
        assemblyInfo.setConfiguration( configuration );

        return assemblyInfo;
    }

    /**
     * @see AssemblerContext#getAssemblyInfoMarshallerFor(ProgrammingLanguage)
     */
    public AssemblyInfoMarshaller getAssemblyInfoMarshallerFor( ProgrammingLanguage programmingLanguage )
        throws AssemblyInfoException
    {

        for ( AssemblyInfoMarshaller m : marshallers )
        {
            if ( m.getProgrammingLanguageForMarshaller().equals( programmingLanguage ) )
            {
                return m;
            }
        }
        throw new AssemblyInfoException( "Could not find assembly info marshaller." );
    }

    /**
     * @see AssemblerContext#init(org.apache.maven.project.MavenProject)
     */
    public void init( MavenProject mavenProject )
        throws InitializationException, IOException
    {
        this.mavenProject = mavenProject;
        marshallers = new ArrayList<AssemblyInfoMarshaller>();

        Enumeration<URL> resources =
            this.getClass().getClassLoader().getResources( "/META-INF/nmaven/annotation-resources.txt" );

        while ( resources.hasMoreElements() )
        {
            URL url = resources.nextElement();
            BufferedReader reader = new BufferedReader( new InputStreamReader( url.openStream() ) );
            String annotatedClass;
            while ( ( annotatedClass = reader.readLine() ) != null )
            {
                String className = null;
                try
                {
                    Class c = Class.forName( annotatedClass );
                    className = c.getName();
                    AssemblyInfoMarshallerAnnotation annotation =
                        (AssemblyInfoMarshallerAnnotation) c.getAnnotation( AssemblyInfoMarshallerAnnotation.class );
                    if ( annotation != null )
                    {
                        for ( ProgrammingLanguage programmingLanguage : annotation.programmingLanguages() )
                        {
                            AssemblyInfoMarshaller marshaller = (AssemblyInfoMarshaller) c.newInstance();
                            marshaller.init( programmingLanguage, new File( mavenProject.getBuild().getDirectory(),
                                                                            BuildDirectories.BUILD_SOURCES_GENERATED.getBuildDirectoryName() ) );
                            marshallers.add( marshaller );
                        }
                    }
                }
                catch ( ClassNotFoundException e )
                {
                    throw new InitializationException(
                        "NMAVEN-061-007: Unable to create AssemblyInfoMarshaller: Class Name = " + className, e );
                }
                catch ( InstantiationException e )
                {
                    throw new InitializationException(
                        "NMAVEN-020-003: Unable to create AssemblyInfoMarshaller: Class Name = " + className, e );
                }
                catch ( IllegalAccessException e )
                {
                    throw new InitializationException(
                        "NMAVEN-020-004: Unable to create AssemblyInfoMarshaller: Class Name = " + className, e );
                }
            }
        }
    }
}
