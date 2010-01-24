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

public class MsProjectUri {
	public static final String baseUri = "http://schemas.microsoft.com/developer/msbuild/2003";
	
	public static final String xUri = baseUri + "/Project";
		
	public static final String defaultTargets = MsProjectUri.xUri + "#property/DefaultTargets";
	
	public static final String xmlns = MsProjectUri.xUri + "#property/xmnls";
	
	public static class ItemGroup {
		public static final String  xUri = MsProjectUri.xUri + "/ItemGroup";
		
		public static final class Reference {
			public static final String xUri = ItemGroup.xUri +  "/Reference";
			
			public static final String include = Reference.xUri + "#property/Include";
			
			public static final String specificVersion = Reference.xUri + "/SpecificVersion";
			
			public static final String hintPath = Reference.xUri + "/HintPath";
		}
	}
	
	public static class Import {
		public static final String xUri = MsProjectUri.xUri + "/Import";	
		
		public static final String project = Import.xUri + "#property/Project";
	}
	
	public static class PropertyGroup {
		public static final String xUri = MsProjectUri.xUri + "/PropertyGroup";
		
		public static class Configuration {
			public static final String xUri = PropertyGroup.xUri + "/Configuration";
			
			public static final String condition = Configuration.xUri + "#property/Condition";
		}
		
		public static class Platform {
			public static final String xUri = PropertyGroup.xUri + "/Platform";
			
			public static final String condition = Platform.xUri + "#property/Condition";
		}
		
        public static final String productVersion = PropertyGroup.xUri + "/ProductVersion";	
		
	    public static final String projectGuid = PropertyGroup.xUri + "/ProjectGuid";

		public static final String outputType = PropertyGroup.xUri + "/OutputType";

		public static final String assemblyName = PropertyGroup.xUri + "/AssemblyName";
	
		public static final String schemaVersion = PropertyGroup.xUri + "/SchemaVersion";
		
		public static final String debugSymbols = PropertyGroup.xUri + "/Debug";
		
		public static final String debugType = PropertyGroup.xUri + "/DebugType";
		
		public static final String optimize = PropertyGroup.xUri + "/Optimize";
		
		public static final String outputPath = PropertyGroup.xUri + "/OutputPath";
		
		public static final String DefineConstants = PropertyGroup.xUri + "/DefineConstants";
		
		public static final String ErrorReport = PropertyGroup.xUri + "/ErrorReport";
		
		public static final String WarningLevel = PropertyGroup.xUri + "/WarningLevel";
		
		public static final String ConsolePause = PropertyGroup.xUri + "/ConsolePause";

	}
}
