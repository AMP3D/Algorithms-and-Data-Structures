using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {            
            int searchKey = 56;
            int[] array = { 122, 2, 56, 92, 1, 3, 400, 199, -45 };

            Console.WriteLine("Using Linear Search to find {0} in {{ 122, 2, 56, 92, 1, 3, 400, 199, -45 }}: \n", searchKey);

            for(var i = 0; i < array.Length; i++)
            {                
                if(array[i] == searchKey)
                {
                    Console.WriteLine("{0} equals {1} at array index {2}.\n", array[i], searchKey, i);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} does not equal {1} at array index {2}.\n", array[i], searchKey, i);
                }
            }

            Console.ReadKey();
        }        
    }
}
