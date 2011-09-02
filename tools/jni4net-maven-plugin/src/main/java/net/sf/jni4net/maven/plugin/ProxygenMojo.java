/*
 *  Copyright (C) 2011 by Eric Kolotyluk
 *  
 *  This file is part of jni4net project - bridge between Java and .NET http://jni4net.sourceforge.net/
 *  
 *  This program is free software: you can redistribute it and/or modify it under the terms of the
 *  GNU Lesser General Public License as published by the Free Software Foundation, either version 3
 *  of the License, or (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU Lesser General Public License for more details. You should have received a copy
 *  of the GNU Lesser General Public License along with this program.  If not, see
 *  <http://www.gnu.org/licenses/>.
 */

package net.sf.jni4net.maven.plugin;

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

import net.sf.jni4net.annotation.DotNet;

import org.apache.commons.io.IOUtils;
import org.apache.maven.artifact.Artifact;
import org.apache.maven.plugin.AbstractMojo;
import org.apache.maven.plugin.MojoExecutionException;
import org.apache.maven.project.MavenProject;
import org.codehaus.plexus.util.FileUtils;

import edu.emory.mathcs.backport.java.util.Collections;

import java.io.DataInputStream;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.List;
import java.util.Set;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.jar.JarEntry;
import java.util.jar.JarFile;

import javassist.bytecode.AnnotationsAttribute;
import javassist.bytecode.ClassFile;

/**
 * <strong>Goal which runs proxygen to create proxies for Java and C#</strong>
 * 
 * @author Eric Kolotyluk
 * @see <a href="http://jni4net.sourceforge.net">jni4net</a>
 *
 * @goal proxygen
 * 
 * @phase process-sources
 */
public class ProxygenMojo extends AbstractMojo
{
    /**
     * @parameter expression="${proxygen.exe}"
     * @required
     */
    private File exe;
    
    /** @parameter expression="${proxygen.xml}" default-value="proxygen.xml" */
    private File xml;
    
    /**
     * @parameter
     */
    private List<String> artifacts;
    
    /**
     * @parameter expression="${proxygen.targetDirJvm}" default-value="<TargetDirJvm>java</TargetDirJvm>"
     */
    String targetDirJvm;
    
    /**
     * @parameter expression="${proxygen.targetDirClr}" default-value="<TargetDirClr>csharp</TargetDirClr>"
     */
    String targetDirClr;
        
    /** @parameter default-value="${project}" */
    MavenProject project;

    @SuppressWarnings("unchecked")
	public void execute() throws MojoExecutionException
    {
    	if (artifacts == null) artifacts = Collections.emptyList();

    	getLog().info("exe = " + exe.getPath());
    	getLog().info("xml = " + xml.getPath());
    	
    	// Use the Javassist API to scan our class files for the @DotNet annotation
    	// This will be used later to generate the proxygen.xml file
    	
    	String jarPath;
    	ArrayList<String> classPathList = null;
    	ArrayList<String> classList = null;
    	
    	Set<Artifact> artifactSet = project.getDependencyArtifacts();
    	
    	for (Artifact artifact : artifactSet)
    	{
    		jarPath = null;

    		getLog().info("artifact " + artifact.getFile().getPath());
    	  
    		for (String artifactParam : artifacts)
    		{
    			if (artifact.getArtifactId().equals(artifactParam))
    			{
    	    		try
    	    		{
    	    			JarFile jarFile = new JarFile(artifact.getFile());
    	    			Enumeration<JarEntry> jarEntries = jarFile.entries();
    	    			while (jarEntries.hasMoreElements())
    	    			{
    	    				JarEntry jarEntry = jarEntries.nextElement();
    	    				if (!jarEntry.isDirectory() && jarEntry.getName().endsWith(".class"))
    	    				{
        	    				// getLog().info("jarEntry.getName() = " + jarEntry.getName());
        	    				
        	    				DataInputStream dataInputStream = new DataInputStream(jarFile.getInputStream(jarEntry));
        	    				ClassFile classFile =  new ClassFile(dataInputStream);
        	    				
        	    				// getLog().info("classFile.getName() = " + classFile.getName());
        	    				
        	    				AnnotationsAttribute visible = (AnnotationsAttribute) classFile.getAttribute(AnnotationsAttribute.visibleTag);
        	    				if (visible != null)
        	    				{
        	    					javassist.bytecode.annotation.Annotation annotation = visible.getAnnotation(DotNet.class.getName());
 
            	    				if (annotation != null)
            	    				{
            	    					String className = jarEntry.getName().replace(".class", "").replace('/', '.');
            	    					getLog().info("@DotNet " + className);
            	    					if (jarPath == null)
            	    					{
            	    						jarPath = artifact.getFile().getPath();
            	    						if (classPathList == null) classPathList = new ArrayList<String>();
            	    						classPathList.add(jarPath);
            	    					}
            	    					if (classList == null) classList = new ArrayList<String>();
            	    					classList.add(className);
            	    				}	    				
        	    				}
//        	    				AnnotationsAttribute invisible = (AnnotationsAttribute) classFile.getAttribute(AnnotationsAttribute.invisibleTag);
//        	    				if (invisible != null)
//        	    				{
//	        	    				for (javassist.bytecode.annotation.Annotation annotation : invisible.getAnnotations())
//	        	    				{
//	        	    				     System.out.println("~@" + annotation.getTypeName());
//	        	    				}
//        	    				}	
    	    				}
    	    			}
    	    		}
    	    		catch (IOException e)
    	    		{
						getLog().error(e.getMessage(), e);
					}

    				break;
    			}
    		}
    	}
    	
    	// Generate a suitable proxygen.xml file which descripts the classes we want proxied - EK
    	
    	StringBuilder xmlBuilder = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
    	xmlBuilder.append("\n<jni4net-proxygen xmlns=\"http://jni4net.sf.net/0.8.5.0/toolConfig.xsd\">\n");
    	xmlBuilder.append("\n<TargetDirJvm>").append(targetDirJvm).append("</TargetDirJvm>");
    	xmlBuilder.append("\n<TargetDirClr>").append(targetDirClr).append("</TargetDirClr>\n");
    	
    	if (classPathList == null)
    	{
    		getLog().warn("no artifacts found with @DotNet annotations in them");
    	}
    	else
    	{
	    	for (String artifact : classPathList)
	    	{
	    		xmlBuilder.append("\n<ClassPath Path=\"" + artifact + "\"/>");
	    	}
	    	xmlBuilder.append('\n');
    	}
    	
    	if (classList == null)
    	{
    		getLog().warn("no classes found with @DotNet annotations on them");
    	}
    	else
    	{
        	for (String className : classList)
        	{
        		xmlBuilder.append("\n<JavaClass TypeName=\"" + className + "\"/>");
        	}
    	}
		xmlBuilder.append("\n\n</jni4net-proxygen>\n");
		
		getLog().info(xmlBuilder.toString());
		
		try
		{
			FileUtils.fileWrite(xml.getPath(), xmlBuilder.toString());
		}
		catch (IOException e)
		{
			getLog().error(e.getMessage(), e);
		}

        // Run the ever famous proxygen

        ProcessBuilder processBuilder = new ProcessBuilder(exe.getPath(), xml.getName());
        processBuilder.directory(xml.getParentFile());

        try
        {
        	final Process process = processBuilder.start();
        	
        	// Copy the output of proxygen to our console - EK

        	ExecutorService executorService = Executors.newCachedThreadPool();
			executorService.execute(
				new Runnable()
				{
					public void run()
					{
						InputStream errorStream = process.getErrorStream();
						try
						{
							IOUtils.copy(errorStream, System.err);
						}
						catch (IOException e)
						{
							getLog().error(e.getMessage(), e);
						}
					}
				}
			);
				
			executorService.execute(
				new Runnable()
				{
					public void run()
					{
						InputStream inputStream = process.getInputStream();
						try
						{
							IOUtils.copy(inputStream, System.out);
						}
						catch (IOException e)
						{
							getLog().error(e.getMessage(), e);
						}
					}
				}
			);
        	
			// Wait for proxygen to finish
			
        	process.waitFor();
		}
        catch (IOException e)
        {
        	throw new MojoExecutionException("Error running " + exe.getPath(), e);
        }
        catch (InterruptedException e)
        {
        	throw new MojoExecutionException(e.getMessage(), e);
		}
    }
}
