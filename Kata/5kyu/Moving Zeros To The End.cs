using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    internal class Moving_Zeros_To_The_End
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int n = arr.Where(l => l == 0).Count();
            return arr.Where(l => l != 0).Concat(Enumerable.Repeat(0, n)).ToArray();
        }
    }
}
