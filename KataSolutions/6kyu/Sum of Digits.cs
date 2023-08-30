using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Sum_of_Digits
    {
        public int DigitalRoot(long n)
        {
            while (n > 9)
            {
                long m = n;
                n = 0;
                while (m > 0)
                {
                    n += m % 10;
                    m /= 10;
                }
            }
            return (int)n;
        }
    }
}
