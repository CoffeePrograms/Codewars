using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    internal class Rot13_
    {
        public static string Rot13(string message)
        {
            StringBuilder res = new StringBuilder();
            foreach (var ch in message)
            {
                if ((ch >= 'a' && ch <= 'm') || (ch >= 'A' && ch <= 'M'))
                    res.Append(Convert.ToChar(ch + 13).ToString());
                else if ((ch >= 'n' && ch <= 'z') || (ch >= 'N' && ch <= 'Z'))
                    res.Append(Convert.ToChar(ch - 13).ToString());
                else if ((ch >= 'а' && ch <= 'п') || (ch >= 'А' && ch <= 'П'))
                    res.Append(Convert.ToChar(ch + 16).ToString());
                else if ((ch >= 'р' && ch <= 'я') || (ch >= 'Р' && ch <= 'Я'))
                    res.Append(Convert.ToChar(ch - 16).ToString());
                else res.Append(ch);
            }
            return res.ToString();
        }
    }
}
