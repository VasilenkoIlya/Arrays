using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        public static void InputElementsOfArray(int[] source)
        {
            Console.WriteLine("Enter elements of array:");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                source[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the count of elements in the array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];
            Console.WriteLine();

            InputElementsOfArray(arr);
            Console.WriteLine();

            int minValue = arr[0], indexOfMin = 0;
            int maxValue = arr[0], indexOfMax = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    indexOfMin = i;
                }

                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    indexOfMax = i;
                }
            }

            Console.WriteLine("Min value = {0}, index of min value = {1}",minValue, indexOfMin);
            Console.WriteLine("Max value = {0}, index of max value = {1}", maxValue, indexOfMax);

            Console.ReadKey();
        }
    }
}
