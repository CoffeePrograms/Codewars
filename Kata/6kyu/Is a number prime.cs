using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Is_a_number_prime
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
