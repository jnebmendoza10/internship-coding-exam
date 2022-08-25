using System;
using System.Collections.Generic;
using System.Text;

namespace YouSource.Strategy
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public string sort(string input)
        {
            var result = "";
            var characters = input.ToCharArray();
            char temp;

            for (int write = 0; write < characters.Length; write++)
            {
                for (int sort = 0; sort < characters.Length - 1; sort++)
                {
                    if (characters[sort] > characters[sort + 1])
                    {
                        temp = characters[sort + 1];
                        characters[sort + 1] = characters[sort];
                        characters[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < characters.Length; i++)
                result += characters[i];

            return result;
        }
    }
}
