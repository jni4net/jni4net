package org.sonatype.nmaven.integrationtests;

import java.io.File;

import org.apache.maven.it.AbstractMavenIntegrationTestCase;
import org.apache.maven.it.Verifier;
import org.apache.maven.it.util.ResourceExtractor;
import org.sonatype.nmaven.BuildDirectories;

public class MavenITmng0021IkvmCompile extends AbstractMavenIntegrationTestCase
{
    public void testit0021()
        throws Exception
    {
        File testDir = ResourceExtractor.simpleExtractResources( getClass(), "/MavenITmng-0021-IkvmCompile" );
        Verifier verifier = new Verifier( testDir.getAbsolutePath() );
        verifier.executeGoal( "install" );
        verifier.assertFilePresent( "target/MavenITmng-0021-IkvmCompile-0.0.1-SNAPSHOT.dll" );
        verifier.assertFilePresent( "target/MavenITmng-0021-IkvmCompile-0.0.1-SNAPSHOT.jar" );       
        verifier.resetStreams();
    }

}
