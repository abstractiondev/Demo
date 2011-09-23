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
            var okResult = SortNumbersEvensBeforeOdds.Execute(
                new SortNumbersEvensBeforeOddsParameters() {AscendingOrder = false,
                    DataArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                });
            int[] okData = okResult.SortedArray;

            var supposedToFailPerfReq = SortNumbersEvensBeforeOdds.Execute(
                new SortNumbersEvensBeforeOddsParameters() {AscendingOrder = false,
                    DataArray = new int[5000000]
                });
            int[] notSupposedToGetHere = supposedToFailPerfReq.SortedArray;
        }
    }
}
