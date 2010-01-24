package org.sonatype.ikvmc.plugin;

/*
 * Copyright 2001-2005 The Apache Software Foundation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

import java.util.ArrayList;
import java.util.List;
import java.io.File;

import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.plugin.MojoFailureException;
import org.apache.maven.project.MavenProject;
import org.sonatype.nmaven.compiler.CommandExecutor;
import org.sonatype.nmaven.compiler.CompilerException;

/**
 * Generates a .NET assembly from a jar
 *
 * @goal compile
 * @phase verify
 * @description Generates a .NET assembly from a jar
 */
public class IkvmcMojo
    extends AbstractMojo
{
    /**
     * The maven project.
     *
     * @parameter expression="${project}"
     * @required
     */
    protected MavenProject project;
    
	public void execute() throws MojoExecutionException, MojoFailureException {
        CommandExecutor commandExecutor = CommandExecutor.Factory.createDefaultCommmandExecutor();
        List<String> commands = new ArrayList<String>();
        commands.add("-out:" + new File(project.getBuild().getDirectory(), project.getBuild().getFinalName() + ".dll").getAbsolutePath());
        commands.add(new File(project.getBuild().getDirectory(), project.getBuild().getFinalName() + "." 
        		+ project.getPackaging()).getAbsolutePath());

        try
        {
            commandExecutor.executeCommand( "ikvmc", commands, false );
        }
        catch ( CompilerException e )
        {
            throw new MojoExecutionException( e.getMessage() );
        }		
	}
	
}
