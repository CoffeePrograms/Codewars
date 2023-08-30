using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    internal class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
        }
    }
}
