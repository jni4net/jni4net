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
package org.sonatype.nmaven.extensions.compiler;

import java.io.File;
import java.util.*;

import org.apache.maven.artifact.Artifact;
import org.sonatype.nmaven.ArtifactScope;
import org.sonatype.nmaven.ProgrammingLanguage;
import org.sonatype.nmaven.Vendor;
import org.sonatype.nmaven.compiler.CommandExecutor;
import org.sonatype.nmaven.compiler.CompilerAnnotation;
import org.sonatype.nmaven.compiler.CompilerContext;
import org.sonatype.nmaven.compiler.CompilerException;
import org.sonatype.nmaven.compiler.DotnetCompilerConfig;
import org.sonatype.nmaven.compiler.DotnetCompilerContext;
import org.sonatype.nmaven.compiler.DotnetCompilerPlatformVersion;
import org.sonatype.nmaven.compiler.InvalidArtifactException;

@CompilerAnnotation(programmingLanguaqe = ProgrammingLanguage.C_SHARP,
                    vendors = {Vendor.MICROSOFT, Vendor.NOVELL, Vendor.ANY},
                    dotnetCompilerPlatformVersions = {DotnetCompilerPlatformVersion.VERSION_2_0_50727, DotnetCompilerPlatformVersion.VERSION_3_0, DotnetCompilerPlatformVersion.VERSION_3_5, DotnetCompilerPlatformVersion.VERSION_4_0_30319})
public final class CSharpClassCompiler
    implements org.sonatype.nmaven.compiler.ClassCompiler
{
    private DotnetCompilerContext compilerContext;

    private File compiledArtifact;

    public boolean failOnErrorOutput()
    {
        // MONO writes warnings to standard error: this turns off failing builds on warnings for MONO
        return compilerContext.getCompilerConfig().getVendor().equals( Vendor.MICROSOFT );
    }

    public List<String> getCommands()
    {
        DotnetCompilerConfig config = (DotnetCompilerConfig) compilerContext.getCompilerConfig();

        Set<Artifact> references;
        if ( compilerContext.getCompilerConfig().isTestCompile() )
        {
            references = compilerContext.getLibraryDependenciesFor( ArtifactScope.TEST );
            references.add( compilerContext.getMavenProject().getArtifact() );
        }
        else
        {
            references = compilerContext.getLibraryDependenciesFor( ArtifactScope.COMPILE );
        }
        Set<Artifact> modules = compilerContext.getDirectModuleDependencies();

        File sourceDirectory = config.getCompilerDirectory();

        String targetArtifactType = config.getArtifactType().getTargetCompileType();

        List<String> commands = new ArrayList<String>();
        commands.add( "/out:" + compiledArtifact.getAbsolutePath() );
        commands.add( "/target:" + targetArtifactType );
        commands.add( "/recurse:" + sourceDirectory + File.separator + "**" );
		final String ad = config.getAditionalCompilerOptions();
		if (ad != null) {
			commands.addAll(Arrays.asList(ad.split(" ")));
		}
		if ( modules != null && !modules.isEmpty() )
        {
            StringBuffer sb = new StringBuffer();
            for ( Iterator<Artifact> i = modules.iterator(); i.hasNext(); )
            {
                Artifact artifact = (Artifact) i.next();
                String path = artifact.getFile().getAbsolutePath();
                sb.append( path );
                if ( i.hasNext() )
                {
                    sb.append( ";" );
                }
            }
            commands.add( "/addmodule:" + sb.toString() );
        }
        if ( !references.isEmpty() )
        {
            for ( Artifact artifact : references )
            {
                String path = artifact.getFile().getAbsolutePath();
                commands.add( "/reference:" + path );
            }
        }

        for ( File file : compilerContext.getEmbeddedResources() )
        {
            commands.add( "/resource:" + file.getAbsolutePath() );
        }
        for ( File file : compilerContext.getLinkedResources() )
        {
            commands.add( "/linkresource:" + file.getAbsolutePath() );
        }
        for ( File file : compilerContext.getWin32Resources() )
        {
            commands.add( "/win32res:" + file.getAbsolutePath() );
        }
        if ( compilerContext.getWin32Icon() != null )
        {
            commands.add( "/win32icon:" + compilerContext.getWin32Icon().getAbsolutePath() );
        }

        if ( config.getVendor().equals( Vendor.MICROSOFT ) )
        {
            commands.add( "/nologo" );
        }

        if ( config.getVendor().equals( Vendor.MICROSOFT ) &&
            config.getCompilerPlatformVersion().equals( DotnetCompilerPlatformVersion.VERSION_3_0 ) )
        {
            String wcfRef = "/reference:" + System.getenv( "SystemRoot" ) +
                "\\Microsoft.NET\\Framework\\v3.0\\Windows Communication Foundation\\";
            // TODO: This is a hard-coded path: Don't have a registry value either.
            commands.add( wcfRef + "System.ServiceModel.dll" );
            commands.add( wcfRef + "Microsoft.Transactions.Bridge.dll" );
            commands.add( wcfRef + "Microsoft.Transactions.Bridge.Dtc.dll" );
            commands.add( wcfRef + "System.ServiceModel.Install.dll" );
            commands.add( wcfRef + "System.ServiceModel.WasHosting.dll" );
            commands.add( wcfRef + "System.Runtime.Serialization.dll" );
            commands.add( wcfRef + "SMDiagnostics.dll" );
        }
        
        if ( config.getKeyInfo() != null )
        {
            if ( config.getKeyInfo().getKeyFileUri() != null )
            {
                commands.add( "/keyfile:" + new File( config.getKeyInfo().getKeyFileUri() ).getAbsolutePath() );
            }
            else if ( config.getKeyInfo().getKeyContainerName() != null )
            {
                commands.add( "/keycontainer:" + config.getKeyInfo().getKeyContainerName() );
            }
        }

        /*
         * if ( config.getCommands() != null ) { commands.addAll( config.getCommands() ); }
         */
        commands.add( "/warnaserror-" );
        if ( config.getVendor().equals( Vendor.NOVELL ) )
        {
            commands.add( "/reference:System.Drawing" );
            commands.add( "/reference:System.Windows.Forms" );
            commands.add( "/reference:System.Web.Services" );
        }
        if ( !config.isTestCompile() )
        {
            commands.add( "/doc:" + new File( config.getTargetDirectory(), "comments.xml" ).getAbsolutePath() );
        }
        return commands;
    }

    public void resetCommands( List<String> commands )
    {

    }

    public File compile()
        throws InvalidArtifactException
    {
        CommandExecutor commandExecutor = CommandExecutor.Factory.createDefaultCommmandExecutor();
        commandExecutor.setLogger( compilerContext.getPlexusLogger() );
        try
        {
            commandExecutor.executeCommand( getCompilerFileName(), getCommands(), failOnErrorOutput() );
        }
        catch ( CompilerException e )
        {
            throw new InvalidArtifactException( e );
        }
        if ( compiledArtifact == null || !compiledArtifact.exists() )
        {
            throw new InvalidArtifactException( "Could not find main artifact" );
        }
        return compiledArtifact;
    }

    public String getCompilerFileName()
    {
        DotnetCompilerConfig config = (DotnetCompilerConfig) compilerContext.getCompilerConfig();
        if ( config.getVendor().equals( Vendor.MICROSOFT ) )
        {
            return "%SystemRoot%/Microsoft.NET/Framework/v"+config.getCompilerPlatformVersion().getVersionAsString()+"/csc.exe";
        }
        else if ( config.getVendor().equals( Vendor.NOVELL ) )
        {
            return "gmcs";
        }
        else
        {
            return null;
        }
    }

    public void init( CompilerContext compilerContext )
    {
        if ( compilerContext == null || !( compilerContext instanceof DotnetCompilerContext ) )
        {
            throw new IllegalArgumentException( "compilerContext" );
        }
        this.compilerContext = (DotnetCompilerContext) compilerContext;
        compiledArtifact = new File( compilerContext.getCompilerConfig().getTargetDirectory(),
                                     compilerContext.getCompilerConfig().getArtifactFileName() );
    }
}
