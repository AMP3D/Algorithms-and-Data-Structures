using System;
namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 122, 2, 56, 92, 1, 3, 400, 199, -45 };

            // Call merge-sort on the unsorted array
            array = MergeSort(array);

            Console.WriteLine("Merge Sort { 122, 2, 56, 92, 1, 3, 400, 199, -45 }: \n");

            // Display output of each sorted element
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        public static int[] MergeSort(int[] array)
        {
            // Return if the array has 1 or less elements
            if (array.Length < 2)
            {
                return array;
            }

            // Find the middle of the array by dividing the list in two. The int type will round down any left-over decimals.
            // E.g. An array with 4 elements (length of 5) will equate to middle = 5 / 2 = 2.5. Rounded down, middle = 2;
            int middle = array.Length / 2;

            // Create a left array with the length equaling that of the middle (up to the first half)
            int[] leftArray = new int[middle];

            // Create a right array with the length equaling the initial array length minus the middle (from the second half onwards)            
            int[] rightArray = new int[array.Length - middle];

            // Split the list into two parts
            for (var i = 0; i < array.Length; i++)
            {                
                if(i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[i - middle] = array[i];
                }
            }
            
            // Recursively break each array down until there's only one element
            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            // Merge the two arrays back together
            array = Merge(leftArray, rightArray);

            return array;
        }

        public static int[] Merge(int[] leftArray, int[] rightArray)
        {
            // Initialize a new array with the combined size of the left and right
            int[] sortedArray = new int[leftArray.Length + rightArray.Length];

            // Initialize loop index variables
            int leftIndex = 0;
            int rightIndex = 0;
            int arrayIndex = 0;

            // Loop through each array and merge them into the new one until one of the arrays is completely merged
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                // Take the smaller item and merge it to the list, then increment the corresponding index to indicate it was merged
                if(leftArray[leftIndex] < rightArray[rightIndex])
                {
                    sortedArray[arrayIndex] = leftArray[leftIndex];                    
                    leftIndex++;
                }
                else
                {
                    sortedArray[arrayIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                // An item from the left OR right was merged, so increment the sorted array index to add the next item
                arrayIndex++;
            }

            // Loop through the left-over items in the array that was not completely merged. Only one of the while loops below should get hit.
            // If leftIndex is still smaller than the left array length, it wasn't completed. Merge the rest
            while(leftIndex < leftArray.Length)
            {
                sortedArray[arrayIndex] = leftArray[leftIndex];

                leftIndex++;
                arrayIndex++;
            }

            // If rightIndex is still smaller than the right array length, it wasn't completed. Merge the rest
            while (rightIndex < rightArray.Length)
            {
                sortedArray[arrayIndex] = rightArray[rightIndex];

                rightIndex++;
                arrayIndex++;
            }

            return sortedArray;
        }
    }
}
