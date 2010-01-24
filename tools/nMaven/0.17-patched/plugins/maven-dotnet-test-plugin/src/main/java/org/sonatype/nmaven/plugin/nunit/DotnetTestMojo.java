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
package org.sonatype.nmaven.plugin.nunit;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.plugin.MojoFailureException;
import org.apache.maven.plugin.logging.Log;
import org.apache.maven.project.MavenProject;
import org.sonatype.nmaven.BuildDirectories;
import org.sonatype.nmaven.Vendor;
import org.codehaus.plexus.util.cli.CommandLineException;
import org.codehaus.plexus.util.cli.CommandLineUtils;
import org.codehaus.plexus.util.cli.Commandline;
import org.codehaus.plexus.util.cli.StreamConsumer;

/**
 * Maven Mojo for executing nunit tests
 *
 * @goal test
 * @phase test
 * @description Maven Mojo for executing nunit tests
 */
public class DotnetTestMojo
    extends AbstractMojo
{
    // Used to determine if nunit-console is not on the path
    // TODO: This probably only works on Windows machines
    private static final String COMMAND_NOT_FOUND_FRAGMENT = "is not recognized as an internal or external command";

    /**
     * The maven project.
     *
     * @parameter expression="${project}"
     * @required
     */
    private MavenProject project;

    /**
     * The arguments to pass to nunit
     *
     * @parameter
     */
    private List<String> arguments;

    /**
     * The Vendor.
     *
     * @parameter expression="${vendor}"
     */
    private String vendorName;

    /**
     * The Vendor.
     *
     * @parameter expression="${nunitHome}"
     */
    private String nunitHome;

    public void execute()
        throws MojoExecutionException, MojoFailureException
    {
        String skipTest = System.getProperty( "maven.test.skip" );
        if ( "TRUE".equalsIgnoreCase( skipTest ) )
        {
            getLog().info( "Skipping Test Execution" );
            return;
        }

        // Verify that we have tests to run
        File testAssembly = new File( project.getBuild().getDirectory(), getTestAssemblyName() );
        if ( !testAssembly.exists() )
        {
            return;
        }

        Vendor vendor;
        if ( vendorName != null )
        {
            vendor = Vendor.valueOf( vendorName.toUpperCase() );
        }
        else
        {
            vendor = Vendor.getDefaultVendorForOS();
        }

        // The directory where the test artifact exists
        File testAssemblies =
            new File( project.getBuild().getDirectory(), BuildDirectories.TEST_ASSEMBLIES.getBuildDirectoryName() );

        Commandline commandline = new Commandline();

        getLog().debug( "NMaven-test: workingDirectory(" + testAssemblies.getAbsolutePath() + ")" );
        getLog().debug( "NMaven-test: nunitHome(" + nunitHome + ")" );

        commandline.setWorkingDirectory( testAssemblies.getAbsolutePath() );
        if ( vendor.equals( Vendor.MICROSOFT ) )
        {
            commandline.setExecutable( nunitHome + "/bin/nunit-console" );
        }
        else if ( vendor.equals( Vendor.NOVELL ) )
        {
            commandline.setExecutable( "nunit-console2" );
        }
        else
        {
            throw new MojoExecutionException("Vendor not found.");
        }
        commandline.addArguments( getNUnitArguments() );

        NUnitStreamConsumer systemOut = new NUnitStreamConsumer( getLog() );
        NUnitStreamConsumer systemErr = new NUnitStreamConsumer( getLog() );

        int commandLineResult;

        try
        {
            // Execute the commandline
            commandLineResult = CommandLineUtils.executeCommandLine( commandline, systemOut, systemErr );

            getLog().info( "Executed command: " + commandline + ", Result = " + commandLineResult );

            // Check if nunit-console is not in the path
            if ( systemErr.isCommandNotFound() )
            {
                throw new MojoExecutionException( "Please add nunit-console to your path" );
            }
            else if ( commandLineResult != 0 )
            {
                throw new MojoFailureException( "There were NUnit test failure(s)" );
            }
        }
        catch ( CommandLineException e )
        {
            throw new MojoExecutionException( "Failure executing commandline, " + e.getMessage() );
        }

        getLog().info( "Done executing tests.." );
    }

    private String getTestAssemblyName()
    {
        File file = project.getArtifact().getFile();
        String pieces = file.getName().substring( 0, file.getName().lastIndexOf( '.' ) );
        String testAssemblyName = pieces + "-test.dll";

        return testAssemblyName;
    }

    private String[] getNUnitArguments()
    {
        List<String> nunitArgs = new ArrayList<String>();

        nunitArgs.add( getTestAssemblyName() );
        if ( arguments != null )
        {
            nunitArgs.addAll( arguments );
        }

        return nunitArgs.toArray( new String[0] );
    }

    private static class NUnitStreamConsumer
        implements StreamConsumer
    {

        private boolean commandNotFound;

        private StringBuilder consumedLines = new StringBuilder();

        private Log log;

        private NUnitStreamConsumer( Log log )
        {
            this.log = log;
        }

        public void consumeLine( String line )
        {
            consumedLines.append( line + "\n" );

            log.info( line );

            if ( line.contains( COMMAND_NOT_FOUND_FRAGMENT ) )
            {
                commandNotFound = true;
            }
        }

        public boolean isCommandNotFound()
        {
            return commandNotFound;
        }
    }
}
