using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Roman_Numerals_Decoder
    {
        static Dictionary<char, int> pairs = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int Solution(string roman)
        {
            int res = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                int val = pairs[roman[i]];
                if ((i != (roman.Length - 1)) && (val < pairs[roman[i + 1]]))
                    res -= val;
                else
                    res += val;
            }
            return res;
        }
    }
}
