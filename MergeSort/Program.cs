using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    /* Desc: A program that uses mergesort to sort an array in descending order
     * Author: Brandon Yip
     */ 
    class Program
    {
        //Given "two" sorted arrays, merge and compare the two to give one sorted array
        private static void Merge(int[] array, int[] aux, int left, int right)
        {
            //split the array into half for comparison
            int middleIndex = (left + right) / 2;
            int leftIndex = left;
            int rightIndex = middleIndex + 1;
            int auxIndex = left;

            //Traverse "both" arrays until they reach the end of their respective array
            while (leftIndex <= middleIndex && rightIndex <= right)
            {
                //Compare 
                if(array[leftIndex] >= array[rightIndex])
                {
                    aux[auxIndex] = array[leftIndex];
                    leftIndex++;
                } else
                {
                    aux[auxIndex] = array[rightIndex];
                    rightIndex++;
                }
                auxIndex++;
            }
            while(leftIndex <= middleIndex)
            {
                aux[auxIndex] = array[leftIndex];
                leftIndex++;
                auxIndex++;
            }
            while(rightIndex <= right)
            {
                aux[auxIndex] = array[rightIndex];
                rightIndex++;
                auxIndex++;
            }

        }

        public static void MergeSort(int[] array, int[] aux, int left, int right)
        {
            if (left == right) return;
            int middleIndex = (left + right) / 2;
            MergeSort(array, aux, left, middleIndex);
            MergeSort(array, aux, middleIndex + 1, right);
            Merge(array, aux, left, right);

            for (int i = left; i <= right; i++)
            {
                array[i] = aux[i];
            }
            //Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 4 , 5, 3, 6 };
            int[] aux = new int[6];
            int left = 0, right = array.Count() - 1;
            MergeSort(array, aux, left, right);


            Console.WriteLine("[{0}]", string.Join(", ", array));
            Console.ReadLine();
        }
    }
}
