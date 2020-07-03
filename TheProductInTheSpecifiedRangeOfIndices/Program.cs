using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheProductInTheSpecifiedRangeOfIndices
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

        public static void PrintElements(int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("{0} \t", source[i]);
            }
        }

        public static int MultiplyOfElements(int[] source)
        {
            int result = 1;

            for (int i = 0; i < source.Length; i++)
            {
                
                result *= source[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the count of elements in the array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];

            
            Console.WriteLine();
            InputElementsOfArray(arr);
            Console.WriteLine();

            Console.WriteLine("Multiplication of array elements = {0}", MultiplyOfElements(arr));
            Console.WriteLine();
            PrintElements(arr);

            Console.ReadKey();
        }
    }
}
