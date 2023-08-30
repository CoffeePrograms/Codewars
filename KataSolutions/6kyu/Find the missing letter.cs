using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Find_the_missing_letter
    {
        public static char FindMissingLetter(char[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] != 1)
                    return (char)(array[i] - 1);
            }
            return ' ';
        }
    }
}
