using System;
using System.Collections.Generic;
using System.Text;

namespace YouSource.Strategy
{
    public class MergeSortStrategy : ISortStrategy
    {
        public string sort(string input)
        {
            string result = "";
            var characters = input.ToCharArray();

            //arrangeArray(array);
            merge(characters, 0, characters.Length - 1);
            for (int i = 0; i < characters.Length; i++)
                result += characters[i];

            return result;
        }

        private void merge(char[] characters, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                merge(characters, left, mid);
                merge(characters, (mid + 1), right);
                mainMerge(characters, left, (mid + 1), right);
            }
        }

        private void mainMerge(char[] characters, int left, int mid, int right)
        {
            char[] temp = new char[characters.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (characters[left] <= characters[mid])
                    temp[pos++] = characters[left++];
                else
                    temp[pos++] = characters[mid++];
            }
            while (left <= eol)
                temp[pos++] = characters[left++];
            while (mid <= right)
                temp[pos++] = characters[mid++];
            for (i = 0; i < num; i++)
            {
                characters[right] = temp[right];
                right--;
            }
        }

       
    }
    
}
