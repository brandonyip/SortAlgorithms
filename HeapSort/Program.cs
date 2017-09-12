using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        /// <summary>
        /// The heapsort functionality
        /// It has a worst case running time of O(n log n)
        /// </summary>
        /// <param name="args"></param>
        public static void Heapsort(int[] array)
        {
            int n = array.Length;

            //build the heap
            for(int i = n / 2 - 1; i >= 0; i--)
                heapify(array, n, i);

            //One by one "extract" element from heap 
            //Basically means to move it to where index i is, which is the last visited index
            for(int i = n-1; i >= 0; i--)
            {
                Swap(array, i, 0);

                heapify(array, i, 0);
            }

        }

        private static void heapify(int[] array, int n, int root)
        {
            int largest = root;
            int l = 2 * root + 1;
            int r = 2 * root + 2;

            //if the left child is larger than root, replace largest with l
            if(l < n && array[l] > array[largest])
                largest = l;
            //if right child is larger than largest than replace largest with r
            if (r < n && array[r] > array[largest])
                largest = r;

            //if largest is not the root anymore
            if(largest != root)
            {
                Swap(array, largest, root);

                heapify(array, n, largest);
            }


        }

        private static void Swap(int[] array, int left, int right)
        {
            int temp = array[right];
            array[right] = array[left];
            array[left] = temp;
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[] { 9, 3, 11, 5, 3, 6, 2 };

            Heapsort(array);
            Heapsort(array2);


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
