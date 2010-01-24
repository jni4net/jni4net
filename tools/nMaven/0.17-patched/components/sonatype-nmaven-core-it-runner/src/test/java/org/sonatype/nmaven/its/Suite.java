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
package org.sonatype.nmaven.its;

import org.sonatype.nmaven.integrationtests.IntegrationTestSuite;
import org.apache.maven.it.VerificationException;
import junit.framework.TestCase;
import junit.framework.Test;

public class Suite
    extends TestCase
{
    public static Test suite()
        throws VerificationException
    {
        return IntegrationTestSuite.suite();
    }
}