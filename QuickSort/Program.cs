using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        private static void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                //pi is partitioning index, array[p] is now in right place
                int piv = partition(array, low, high);
                
                //call recursively using divide and conquer
                quickSort(array, low, piv - 1);
                quickSort(array, piv + 1, high);

            }            
        }



        //This function takes last element as pivot, places it in correct position in sorted array,
        // and places all smaller objects to left of pivot, and all greater to the right
        private static int partition(int[] array, int low, int high)
        {
            //pivot (element to be placed
            int pivot = array[high];

            int i = low;
            for (int j = low; j < high; j++)
            {
                //if current element is smaller than or equal to pivot
                if(array[j] <= pivot)
                {
                    Swap(array, i, j);
                    i++;
                }
            }
            Swap(array, i, high);
            return i;
        }


        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[] { 9, 3, 11, 5, 3, 6, 2 };
            int n = array.Length - 1;

            quickSort(array, 0, array.Length-1);
            quickSort(array2, 0, array2.Length - 1);


            Console.WriteLine("Start of program, it will sort two arrays using heapsort algorithm.");
            Console.WriteLine("Result of 1st array: ");
            Console.WriteLine("[{0}]", string.Join(", ", array));

            Console.WriteLine("Result of 2nd array: ");
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("End of program, press any key to exit.");
            Console.ReadLine();

        }
    }
}
