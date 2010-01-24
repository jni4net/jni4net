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

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.apache.maven.project.builder.ArtifactModelContainerFactory;
import org.apache.maven.project.builder.ProjectUri;
import org.apache.maven.shared.model.DomainModel;
import org.apache.maven.shared.model.InterpolatorProperty;
import org.apache.maven.shared.model.ModelContainer;
import org.apache.maven.shared.model.ModelDataSource;
import org.apache.maven.shared.model.ModelEventListener;
import org.apache.maven.shared.model.ModelProperty;
import org.apache.maven.shared.model.ModelTransformer;
import org.apache.maven.shared.model.impl.DefaultModelDataSource;

public class CSharpProjectTransformer implements ModelTransformer {

	public String getBaseUri() {
		return MsProjectUri.baseUri;
	}

	public void interpolateModelProperties(List<ModelProperty> modelProperties,
			List<InterpolatorProperty> interpolatorProperties, DomainModel domainModel)
			throws IOException {		
	}

	public List<ModelProperty> preprocessModelProperties(
			List<ModelProperty> modelProperties) {
		return new ArrayList<ModelProperty>(modelProperties);
	}

	public DomainModel transformToDomainModel(List<ModelProperty> modelProperties,
			List<? extends ModelEventListener> eventListeners) throws IOException {
		List<ModelProperty> mps = new ArrayList<ModelProperty>();
		for(ModelProperty mp : modelProperties) {
			if(mp.getUri().equals(ProjectUri.xUri)) {
				mps.add(new ModelProperty(MsProjectUri.xUri, null));
				mps.add(new ModelProperty(MsProjectUri.xmlns, MsProjectUri.baseUri));
				mps.add(new ModelProperty(MsProjectUri.defaultTargets, "Build"));
			} 
		}
		//DEBUG Configuration
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.xUri, null));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.Configuration.xUri, "Debug"));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.Configuration.condition, " '$(Configuration)' == '' "));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.Platform.xUri, "AnyCPU"));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.Platform.condition, " '$(Platform)' == '' "));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.productVersion, "8.0.50727"));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.projectGuid, "{E10455C7-4D36-4930-9D26-CDB9DEC0BF99}"));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.assemblyName, 
				getValueOfUriFromList(ProjectUri.artifactId, modelProperties)));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.schemaVersion, "2.0"));
		mps.add(new ModelProperty(MsProjectUri.PropertyGroup.outputType, "Exe"));//TODO
		
		//Dependencies
		ModelDataSource dataSource = new DefaultModelDataSource();
		dataSource.init(modelProperties, Arrays.asList(new ArtifactModelContainerFactory() )) ;
		List<ModelContainer> modelContainers = dataSource.queryFor(ProjectUri.Dependencies.Dependency.xUri);
		if(!modelContainers.isEmpty()) {
			mps.add(new ModelProperty(MsProjectUri.ItemGroup.xUri, null));
			for(ModelContainer mc : modelContainers) {
				mps.add(new ModelProperty(MsProjectUri.ItemGroup.Reference.xUri, ""));
				
				List<ModelProperty> containerProperties = mc.getProperties();
				StringBuffer sb = new StringBuffer();
		        sb.append(getValueOfUriFromList(ProjectUri.Dependencies.Dependency.artifactId, containerProperties));
		        sb.append(", Version=");
		        sb.append(getValueOfUriFromList(ProjectUri.Dependencies.Dependency.version, containerProperties));
		        sb.append(", Culture=neutral, PublicKeyToken=null");
		        
		        mps.add(new ModelProperty(MsProjectUri.ItemGroup.Reference.include, sb.toString()));
			}
		}

		//Include C# Targets
		mps.add(new ModelProperty(MsProjectUri.Import.xUri, ""));
		mps.add(new ModelProperty(MsProjectUri.Import.project, "$(MSBuildBinPath)\\Microsoft.CSharp.targets"));

		return new CSharpProjectDomainModel(mps);
	}
	
	private static String getValueOfUriFromList(String uri, List<ModelProperty> modelProperties) {
		for(ModelProperty mp : modelProperties) {
			if(mp.getUri().equals(uri)) {
				return mp.getResolvedValue();
			}
		}
		return null;
	}

	public List<ModelProperty> transformToModelProperties(
			List<? extends DomainModel> domainModels) throws IOException {
		throw new UnsupportedOperationException("transformToModelProperties: unsupported");
	}
}
