using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Find_the_odd_int
    {
        public static int find_it(int[] seq)
        {
            var distinct = seq.Distinct();
            foreach (var item in distinct)
            {
                int count = seq.Where(l => l == item).Count();
                if (count % 2 != 0)
                    return item;
            }
            return -1;
        }
    }
}
