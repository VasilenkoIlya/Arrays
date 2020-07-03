using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArrayMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the count of elements in the array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];

            Console.WriteLine();
            UI.InputElementsOfArray(arr);
            Console.WriteLine();

            Console.WriteLine("Multiplication of array elements = {0}", BL.MultiplyOfElements(arr));
            Console.WriteLine();
            UI.PrintElements(arr);
            
            Console.ReadKey();
        }
    }
}
