using System;

namespace YouSource.Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Sort Strategy (bubblesort, quicksort, mergesort). Defaults to bubblesort:");
       
            var input = Console.ReadLine();
            input = input.ToLower();

            SortService service = new SortService(mappedStrategy(input));

            Console.WriteLine("Enter String to Sort:");
            var value = Console.ReadLine();

            string result = service.executeSortingMethod(value);

            Console.Write($"The sorted string is: " + result);

            Console.ReadKey();
        }

        private static ISortStrategy mappedStrategy(string input)
        {
            ISortStrategy strategy;

            switch (input)
            {
                case "bubblesort":
                    strategy = new BubbleSortStrategy();
                    break;
                case "quicksort":
                    strategy = new QuickSortStrategy();
                    break;
                case "mergesort":
                    strategy = new MergeSortStrategy();
                    break;
                default:
                    strategy = new BubbleSortStrategy();
                    break;
            };

            return strategy;
        }
    }
}
