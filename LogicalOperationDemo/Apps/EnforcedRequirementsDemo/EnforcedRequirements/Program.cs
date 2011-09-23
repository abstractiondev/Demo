using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Operations;

namespace EnforcedRequirements
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SortNumbersEvensBeforeOdds.Execute(
                new SortNumbersEvensBeforeOddsParameters() {AscendingOrder = false,
                    DataArray = new int[] { 1, 2, 3, 4, 5 }
                });
            int[] finalData = result.SortedArray;
        }
    }
}
