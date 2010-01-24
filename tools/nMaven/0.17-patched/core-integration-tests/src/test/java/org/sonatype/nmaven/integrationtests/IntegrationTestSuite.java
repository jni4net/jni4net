/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
package org.sonatype.nmaven.integrationtests;

import junit.framework.Test;
import junit.framework.TestSuite;
import org.apache.maven.it.VerificationException;
import org.apache.maven.it.Verifier;

import org.apache.maven.it.AbstractMavenIntegrationTestCase;

public class IntegrationTestSuite
    extends AbstractMavenIntegrationTestCase
{
    public static Test suite()
        throws VerificationException
    {
        Verifier verifier = null;
        try
        {
            verifier = new Verifier( "" );
            String mavenVersion = verifier.getMavenVersion();

            String executable = verifier.getExecutable();

            System.out.println( "Running integration tests for Maven " + mavenVersion + "\n\tusing Maven executable: " +
                executable );

            System.setProperty( "maven.version", mavenVersion );
        }
        finally
        {
            if ( verifier != null )
            {
                verifier.resetStreams();
            }
        }

        TestSuite suite = new TestSuite();
        suite.addTestSuite( MavenITmng0021IkvmCompile.class );
        suite.addTestSuite( MavenITmng0000CSharpCompileLibrary.class );
        suite.addTestSuite( MavenITmng0001CSharpCompileExe.class );
        suite.addTestSuite( MavenITmng0002CSharpCompileModule.class );
        suite.addTestSuite( MavenITmng0003CSharpCompileWinexe.class );
        suite.addTestSuite( MavenITmng0004CSharpCompileWithDependency.class );
        suite.addTestSuite( MavenITmng0005CSharpCompileWithTransitiveDependency.class );
        
        //suite.addTestSuite( MavenITmng0006NUnitTestExecution.class );
        suite.addTestSuite( MavenITmng0007CSharpCompileTestLibrary.class );
        suite.addTestSuite( MavenITmng0008CSharpCompileWithProvidedDependency.class );
        //suite.addTestSuite( MavenITmng0009CSharpCompileWithProvidedGacDependency.class );
        suite.addTestSuite( MavenITmng0010DeployLibrary.class );
        suite.addTestSuite( MavenITmng0011DeployExe.class );
        suite.addTestSuite( MavenITmng0012DeployModule.class );
        suite.addTestSuite( MavenITmng0013DeployWinexe.class );
        //suite.addTestSuite( MavenITmng0014ResolveLibraryDependency.class );
        suite.addTestSuite( MavenITmng0015DeployLibraryAsSnapshot.class );
        suite.addTestSuite( MavenITmng0016CSharpAssemblyInfoGeneration.class );
        suite.addTestSuite( MavenITmng0017CSharpStrongNamedAssembly.class );
        suite.addTestSuite( MavenITmng0018CSharpSynchronizeTargetWithSource.class );
        suite.addTestSuite( MavenITmng0019BuildFailureOnNUnitFailure.class );
        return suite;
    }
}
