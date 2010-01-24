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
import org.apache.maven.it.util.ResourceExtractor;
import org.apache.maven.it.Verifier;
import org.sonatype.nmaven.BuildDirectories;

import java.io.File;

public class MavenITmng0014ResolveLibraryDependency
    extends AbstractMavenIntegrationTestCase
{
    public void testit0014()
        throws Exception
    {
        File testDir =
            ResourceExtractor.simpleExtractResources( getClass(), "/MavenITmng-0014-ResolveLibraryDependency" );
        Verifier verifier = new Verifier( testDir.getAbsolutePath() );

        verifier.deleteArtifact( "NMaven.Its", "NMaven.It.It0010", "1.0.0", "dll" );
        verifier.executeGoal( "install" );
        verifier.assertFilePresent( "target/" + BuildDirectories.BUILD_SOURCES_MAIN.getBuildDirectoryName() + "/It0014.cs" );
        verifier.assertFilePresent( "target/NMaven.It.It0014-1.0.0.dll" );
        verifier.verifyErrorFreeLog();
        verifier.resetStreams();
    }
}
