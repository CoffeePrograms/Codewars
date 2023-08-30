using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._3kyu
{
    internal class Help_the_general_decode_secret_enemy_messages
    {
        public static string Decode(string p_what)
        {
            string alphabet = "bdhpF,82QsLirJejtNmzZKgnB3SwTyXG ?.6YIcflxVC5WE94UA1OoD70MkvRuPqHa";

            StringBuilder sb = new StringBuilder();
            char ch;
            int index;
            for (int i = 0; i < p_what.Length; i++)
            {
                ch = p_what[i];
                if (!alphabet.Contains(ch))
                {
                    sb.Append(ch);
                }
                else
                {
                    index = (alphabet.IndexOf(ch) - (i + 1)) % alphabet.Length;
                    if (index < 0)
                        index = alphabet.Length + index;
                    sb.Append(alphabet[index]);
                }
            }
            return sb.ToString();
        }
    }
}
