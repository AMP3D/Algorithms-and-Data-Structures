using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 122, 2, 56, 92, 1, 3, 400, 199, -45 };

            // Call sort on the unsorted array
            InsertionSort(array);

            Console.WriteLine("Insertion Sort { 122, 2, 56, 92, 1, 3, 400, 199, -45 }: \n");

            // Display output of each sorted element
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        static void InsertionSort(int[] array)
        {
            // Return if only one element
            if (array.Length < 2)
            {
                return;
            }

            int j;

            // Start at index 1 and set to j to zero (i - 1) for the initial comparison
            for (var i = 1; i < array.Length; i++)
            {
                // Set j to i so we can decrement j to work backwards in the array
                j = i;

                // Work backwards from j. Stop when the value in previous position is smaller than the value in the current position
                while(j > 0 && array[j-1] > array[j])
                {
                    // Swap spaces
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;                    

                    j--;
                }                
            }
        }
    }
}
