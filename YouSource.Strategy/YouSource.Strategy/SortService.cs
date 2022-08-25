using System;
using System.Collections.Generic;
using System.Text;

namespace YouSource.Strategy
{
    public class SortService
    {
        private readonly ISortStrategy strategy;

        public SortService(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string executeSortingMethod(string input)
        {
            return strategy.sort(input);
        }
    }
}
