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
package org.sonatype.nmaven.transformers;

//import static org.junit.Assert.*;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.apache.maven.project.builder.ArtifactModelContainerFactory;
import org.apache.maven.project.builder.IdModelContainerFactory;
import org.apache.maven.project.builder.PomTransformer;
import org.apache.maven.project.builder.ProjectUri;
import org.apache.maven.shared.model.DomainModel;
import org.apache.maven.shared.model.ModelMarshaller;
import org.apache.maven.shared.model.ModelProperty;
import org.apache.maven.shared.model.ModelTransformer;
import org.apache.maven.shared.model.ModelTransformerContext;

public class CSharpProjectDomainModelTest {
	
	@org.junit.Test
	public void testTransform() throws IOException {
		/*
        List<ModelProperty> mp2 = new ArrayList<ModelProperty>();
        mp2.add(new ModelProperty(ProjectUri.xUri, null));
        mp2.add(new ModelProperty(ProjectUri.version, "2.0"));
        mp2.add(new ModelProperty(ProjectUri.artifactId, "sample"));
        
        mp2.add(new ModelProperty(ProjectUri.Dependencies.xUri, null));
        mp2.add(new ModelProperty(ProjectUri.Dependencies.Dependency.xUri, null));
        mp2.add(new ModelProperty(ProjectUri.Dependencies.Dependency.groupId, "gid"));
        mp2.add(new ModelProperty(ProjectUri.Dependencies.Dependency.artifactId, "aid"));
        mp2.add(new ModelProperty(ProjectUri.Dependencies.Dependency.version, "1.0"));
        DomainModel childModel = new DefaultDomainModel(mp2);

        ModelTransformerContext ctx = new ModelTransformerContext(Arrays.asList(new ArtifactModelContainerFactory(),
                new IdModelContainerFactory()));

        ModelTransformer pomTransformer = new PomTransformer(new DefaultDomainModelFactory());
        ModelTransformer csprojTransformer = new CSharpProjectTransformer();
        DomainModel domainModel = ctx.transform( Arrays.asList(childModel), pomTransformer, csprojTransformer );	
        for(ModelProperty mp : domainModel.getModelProperties()) {
        	System.out.println(mp.toString());
        }
        System.out.println(ModelMarshaller.unmarshalModelPropertiesToXml(domainModel.getModelProperties(), MsProjectUri.baseUri));
        */
	}
}
