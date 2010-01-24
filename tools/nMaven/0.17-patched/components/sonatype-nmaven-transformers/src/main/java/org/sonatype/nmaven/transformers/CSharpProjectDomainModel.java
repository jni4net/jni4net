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
import java.io.InputStream;
import java.util.ArrayList;
import java.util.List;

import org.apache.maven.shared.model.DomainModel;
import org.apache.maven.shared.model.ModelProperty;
import org.apache.maven.shared.model.ModelMarshaller;

public class CSharpProjectDomainModel implements DomainModel {

	private String eventHistory;
	
	private final List<ModelProperty> modelProperties;
	/*
	public CSharpProjectDomainModel(InputStream inputStream) throws IOException {
		if(inputStream == null) {
			throw new IllegalArgumentException("inputStream: null");
		}
		
		modelProperties = ModelMarshaller.marshallXmlToModelProperties(inputStream, MsProjectUri.baseUri, null);		
	}
	*/
	public CSharpProjectDomainModel(List<ModelProperty> modelProperties) {
		this.modelProperties = new ArrayList<ModelProperty>(modelProperties);
	}

	public String getEventHistory() {
		return eventHistory == null ? "" : eventHistory;
	}

	public List<ModelProperty> getModelProperties() throws IOException {
		return modelProperties;
	}

	public void setEventHistory(String eventHistory) {
		this.eventHistory = eventHistory;
	}

}
