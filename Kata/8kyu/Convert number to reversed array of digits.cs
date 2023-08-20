using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._8kyu
{
    internal class Convert_number_to_reversed_array_of_digits
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(l => Convert.ToInt64(l.ToString())).ToArray();
        }
    }
}
