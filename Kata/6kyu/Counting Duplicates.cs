using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Counting_Duplicates
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(l => l).Where(l => l.Count() != 1).Count();
        }
    }
}
