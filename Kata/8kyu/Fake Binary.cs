using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._8kyu
{
    internal class Fake_Binary
    {
        public static string FakeBin(string x)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in x)
                sb.Append(ch < '5' ? '0' : '1');
            return sb.ToString();
        }
    }
}
