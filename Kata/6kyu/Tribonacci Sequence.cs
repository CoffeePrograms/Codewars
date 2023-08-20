using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Tribonacci_Sequence
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            double[] res = new double[n];
            if (n < 1)
            {
                return res;
            }
            else
            {
                int nSmall = n >= 3 ? 3 : n;
                for (int i = 0; i < nSmall; i++)
                {
                    res[i] = signature[i];
                }

                for (int i = nSmall; i < n; i++)
                {
                    res[i] = res[i - 3] + res[i - 2] + res[i - 1];
                }
                return res;
            }
        }
    }
}
