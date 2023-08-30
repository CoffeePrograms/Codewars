using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Create_Phone_Number
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
