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

import org.apache.maven.it.AbstractMavenIntegrationTestCase;
import org.apache.maven.it.Verifier;
import org.apache.maven.it.util.ResourceExtractor;
import org.sonatype.nmaven.BuildDirectories;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;

public class MavenITmng0018CSharpSynchronizeTargetWithSource
    extends AbstractMavenIntegrationTestCase
{

    private static final String CS_GEN_FILENAME = "It0018Gen.cs";

    private static final String CS_GEN_SOURCE = "namespace NMaven.IT {\n" + "public class It0018Gen {\n" +
        "    public static void Main () {\n" + "    }\n" + "}" + "}";

    public void testit0018()
        throws Exception
    {
        File testDir = ResourceExtractor.simpleExtractResources( getClass(),
                                                                 "/MavenITmng-0018-CSharpSynchronizeTargetWithSource" );

        // Generate a new CS source file
        File generatedCSSourceFile = new File( testDir, "src/" + CS_GEN_FILENAME );
        BufferedWriter fileWriter = new BufferedWriter( new FileWriter( generatedCSSourceFile ) );
        fileWriter.write( CS_GEN_SOURCE );
        fileWriter.close();

        // Generate a new CS test file
        File generatedCSTargetFile = new File( testDir, "test/" + CS_GEN_FILENAME );
        fileWriter = new BufferedWriter( new FileWriter( generatedCSTargetFile ) );
        fileWriter.write( CS_GEN_SOURCE );
        fileWriter.close();

        Verifier verifier = new Verifier( testDir.getAbsolutePath() );
        verifier.executeGoal( "install" );
        verifier.assertFilePresent(
            "target/" + BuildDirectories.BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0018.cs" );
        verifier.assertFilePresent(
            "target/" + BuildDirectories.BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0018Gen.cs" );
        verifier.assertFilePresent(
            "target/" + BuildDirectories.TEST_BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0018.cs" );
        verifier.assertFilePresent(
            "target/" + BuildDirectories.TEST_BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0018Gen.cs" );
        verifier.verifyErrorFreeLog();
        verifier.resetStreams();

        // Delete the generated file
        assertTrue( "Unable to delete generated source file", generatedCSSourceFile.delete() );
        assertTrue( "Unable to delete generated test file", generatedCSTargetFile.delete() );

        verifier.executeGoal( "install" );

        // Verify that the deleted file is purged from the staging compilation directory
        verifier.assertFileNotPresent(
            "target/" + BuildDirectories.BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0018Gen.cs" );
        verifier.assertFileNotPresent(
            "target/" + BuildDirectories.TEST_BUILD_SOURCES_GENERATED.getBuildDirectoryName() + "/It0018Gen.cs" );
        verifier.verifyErrorFreeLog();
        verifier.resetStreams();
    }
}
