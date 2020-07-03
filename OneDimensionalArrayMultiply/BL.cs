using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArrayMultiply
{
    class BL
    {
        public static int MultiplyOfElements(int[] source)
        {
            int result = 1;

            for (int i = 0; i < source.Length; i++)
            {
                result *= source[i];
            }

            return result;
        }
    }
}