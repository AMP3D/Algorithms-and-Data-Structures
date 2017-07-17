using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchKey = 92;
            int[] sortedArray = { -45, 1, 2, 56, 92, 199 };

            // Calculate the middle of the array
            int middle = sortedArray.Length / 2;

            // If the search key is greater than or equal to the middle, start search at the middle. Otherwise start at the beginning of the array
            int startIndex = searchKey >= middle ? middle : 0;

            // If the search starts at the middle, loop until the end of the array. Otherwise stop at the middle
            int endIndex = startIndex == middle ? sortedArray.Length : middle;

            Console.WriteLine("Using Binary Search to find {0} in {{ -45, 1, 2, 56, 92, 199 }}.", searchKey);            
            Console.WriteLine("Start Index: {0}, Middle Index: {1}, End Index {2}. \n", startIndex, middle, endIndex);

            for (var i = startIndex; i < endIndex; i++)
            {
                if (sortedArray[i] == searchKey)
                {
                    Console.WriteLine("{0} equals {1} at array index {2}.\n", sortedArray[i], searchKey, i);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} does not equal {1} at array index {2}.\n", sortedArray[i], searchKey, i);
                }
            }

            Console.ReadKey();
        }
    }
}
