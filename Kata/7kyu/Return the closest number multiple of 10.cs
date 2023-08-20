using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._7kyu
{
    internal class Return_the_closest_number_multiple_of_10
    {
        public int ClosestMultiple10(int num)
        {
            var temp = (int)(num / 10) * 10;
            return num % 10 < 5 ? temp : temp + 10;
        }
    }
}
