using System;
using System.Collections.Generic;
using System.Text;

namespace YouSource.Strategy
{
    public class QuickSortStrategy : ISortStrategy
    {
        
        public string sort(string input)
        {
            string result = "";
            var characters = input.ToCharArray();

            arrangeElements(characters, 0, characters.Length - 1);

            for (int i = 0; i < characters.Length; i++)
                result += characters[i];

            return result;
            
        }

        private void arrangeElements(char[] characters, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = partition(characters, low, high);

                arrangeElements(characters, low, partitionIndex - 1);
                arrangeElements(characters, partitionIndex + 1, high);
            }
        }

        private int partition(char[] characters, int low, int high)
        {
            char pivot = characters[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (characters[j] < pivot)
                {
                    i++;
                    swap(characters, i, j);
                }
            }
            swap(characters, i + 1, high);

            return (i + 1);
        }

        private void swap(char[] characters, int leftIndex, int rightIndex)
        {
            char temp = characters[leftIndex];
            characters[leftIndex] = characters[rightIndex];
            characters[rightIndex] = temp;
        }


    }
}
