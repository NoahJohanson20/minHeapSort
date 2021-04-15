using System;

namespace Assignment3_NJ
{
    class Program
    {

        public static void Main()
        {
            int[] a = { 40, 28, 1, 11, 100, 69, 80, 27, 9, 25};
            int L = a.Length;

            Console.WriteLine("This is the Original array:");
            printArray(a, L);
            Console.WriteLine();

            heapSort(a, L);

            Console.WriteLine("This is the array after a minHeap sort:");
            printArray(a, L);
        }

        static void heapify(int[] a, int L, int i)
        {
            int small = i; 
            int left = 2 * i + 1; 
            int right = 2 * i + 2; 

            
            if (left < L && a[left] < a[small])
                small = left;

           
            if (right < L && a[right] < a[small])
                small = right;

           
            if (small != i)
            {
                int temp = a[i];
                a[i] = a[small];
                a[small] = temp;

               
                heapify(a, L, small);
            }
        }
       
        static void heapSort(int[] a, int L)
        {
            for (int i = L / 2 - 1; i >= 0; i--)
            { 
                heapify(a, L, i); 
            }

            for (int i = L - 1; i >= 0; i--)
            {
                int temp = a[0];
                a[0] = a[i];
                a[i] = temp;

                heapify(a, i, 0);
            }
        }

        static void printArray(int[] a, int L)
        {
            for (int i = 0; i < L; ++i)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        } 
    }
}
