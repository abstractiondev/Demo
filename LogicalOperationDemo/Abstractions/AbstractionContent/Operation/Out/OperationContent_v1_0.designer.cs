 

using System;

		namespace Demo.Operations { 
				public class SortNumbersEvensBeforeOddsParameters 
		{
				public int[] DataArray ;
				public bool AscendingOrder ;
				}
		
		public class SortNumbersEvensBeforeOdds 
		{
				private static void PrepareParameters(SortNumbersEvensBeforeOddsParameters parameters)
		{
					SortNumbersEvensBeforeOddsImplementation.ParameterValidation_DataArrayNotNull_ThrowsException(parameters.DataArray);
				}
				public static SortNumbersEvensBeforeOddsReturnValue Execute(SortNumbersEvensBeforeOddsParameters parameters)
		{
				        DateTime perfMonitorTotalTimeMs_MaximumTimeAllowed_Start = DateTime.Now;
					PrepareParameters(parameters);
					int[] SortNumbersOutput = SortNumbersEvensBeforeOddsImplementation.ExecuteMethod_SortNumbers(parameters.DataArray, parameters.AscendingOrder);		
				int[] SortEvensBeforeOddsOutput = SortNumbersEvensBeforeOddsImplementation.ExecuteMethod_SortEvensBeforeOdds(SortNumbersOutput);		
					TimeSpan TotalTimeMs_MaximumTimeAllowed_duration = DateTime.Now - perfMonitorTotalTimeMs_MaximumTimeAllowed_Start;
            if(TotalTimeMs_MaximumTimeAllowed_duration.TotalMilliseconds > 1000)
            {
                throw new TimeoutException(String.Format("Performance not withing requirement: MaximumTimeAllowed requires 1000 ms, it took {0} ms", TotalTimeMs_MaximumTimeAllowed_duration.TotalMilliseconds));
            }
				SortNumbersEvensBeforeOddsReturnValue returnValue = SortNumbersEvensBeforeOddsImplementation.Get_ReturnValue(SortEvensBeforeOddsOutput);
		return returnValue;
				}
				}
				public class SortNumbersEvensBeforeOddsReturnValue 
		{
				public int[] SortedArray ;
				}
		 } 