using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._7kyu
{
    internal class Rotate_for_a_Max
    {
        public static long MaxRot(long n)
        {
            long max = n;
            string s = n.ToString();
            for (int i = 0; i < s.Length - 1; i++)
            {
                s = s.Substring(0, i) + s.Substring(i + 1) + s.Substring(i, 1);
                long l = long.Parse(s);
                if (max < l) max = l;
            }
            return max;
        }
    }
}
