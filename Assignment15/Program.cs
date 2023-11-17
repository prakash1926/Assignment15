using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            int noSwap = 0;


            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)

                {

                    if (arr[j] < arr[j + 1])

                    {

                        int temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;

                        swapped = true;

                    }
                    noSwap++;
                }

                if (!swapped)
                {
                    break;
                }
            }

        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                    return false;
            }
            return true;
        }
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                   

               else if (arr[mid] > target)
                {
                    left = mid + 1; 
                }

                else
                {  
                    right = mid - 1;
                }
                    
            }

            return -1;

        }
            static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Print Array without Sort");

            print(arr);

            BubbleSort(arr);

            Console.WriteLine("After  Bubble Sort");

            print(arr);

            bool isSorted = IsSorted(arr);
            Console.WriteLine($"\nIs the array sorted correctly? {isSorted}");

            Console.Write("\nEnter the element to search: ");
            int searchElement = int.Parse(Console.ReadLine());
            int index = BinarySearch(arr, searchElement);

            if (index != -1)
            {
                Console.WriteLine($"\nElement {searchElement} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"\nElement {searchElement} not found in the array.");
            }
               

            Console.ReadKey();
        }
    }
}
