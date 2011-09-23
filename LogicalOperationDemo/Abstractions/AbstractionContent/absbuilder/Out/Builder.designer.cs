 

using System;

	namespace AbstractionBuilder {
	partial class Builder {
        public void Build()
        {
			CleanUp();
            Tuple<string, string>[] generatorFiles = null;
				FetchTransformationSources("OperationToDocumentation", "Operation");
        generatorFiles = ExecuteAssemblyGenerator("OperationToDocumentation", "TRANS", "Transformer");
        WriteGeneratorFiles(generatorFiles, "OperationToDocumentation", "TRANS");
		PushTransformationTargets("OperationToDocumentation", "Documentation");
				FetchTransformationSources("OperationToStatusTracking", "Operation");
        generatorFiles = ExecuteAssemblyGenerator("OperationToStatusTracking", "TRANS", "Transformer");
        WriteGeneratorFiles(generatorFiles, "OperationToStatusTracking", "TRANS");
		PushTransformationTargets("OperationToStatusTracking", "StatusTracking");
				FetchTransformationSources("StatusTrackingToDocumentation", "StatusTracking");
        generatorFiles = ExecuteAssemblyGenerator("StatusTrackingToDocumentation", "TRANS", "Transformer");
        WriteGeneratorFiles(generatorFiles, "StatusTrackingToDocumentation", "TRANS");
		PushTransformationTargets("StatusTrackingToDocumentation", "Documentation");
			        generatorFiles = ExecuteAssemblyGenerator("Documentation", "ABS", "DesignDocumentation_v1_0");
	        WriteGeneratorFiles(generatorFiles, "Documentation", "ABS");
			        generatorFiles = ExecuteAssemblyGenerator("Operation", "ABS", "CSharpCode_v1_0");
	        WriteGeneratorFiles(generatorFiles, "Operation", "ABS");
		        }
		
		private void CleanUp()
		{
		            CleanUpTransformationInputAndOutput("OperationToDocumentation", "Documentation");
				            CleanUpTransformationInputAndOutput("OperationToStatusTracking", "StatusTracking");
				            CleanUpTransformationInputAndOutput("StatusTrackingToDocumentation", "Documentation");
				            CleanUpAbstractionOutput("Documentation");
				            CleanUpAbstractionOutput("Operation");
						}
	}
}
		