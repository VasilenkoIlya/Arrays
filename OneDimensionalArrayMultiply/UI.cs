using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArrayMultiply
{
    class UI
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

        public static void PrintElements(int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("{0} \t", source[i]);
            }
        }
    }
}