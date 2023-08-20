using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._4kyu
{
    internal class Range_Extraction
    {
        private static void Add(List<int> list, ref StringBuilder sb)
        {
            if (list.Count() == 1)
                sb.Append(list[0]);
            else if (list.Count() == 2)
                sb.Append(list[0] + "," + list[1]);
            else
                sb.Append(list.First() + "-" + list.Last());
        }

        public static string Extract(int[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>
            {
                args[0]
            };
            for (int i = 1; i < args.Count(); i++)
            {
                if (((args[i] > 0) && (args[i] - list.Last() == 1))
                    || ((args[i] <= 0) && (list.Last() - args[i] == -1)))
                {
                    list.Add(args[i]);
                }
                else
                {
                    Add(list, ref sb);
                    sb.Append(",");
                    list.Clear();
                    list.Add(args[i]);
                }
            }

            if (list != null)
            {
                Add(list, ref sb);
            }

            return sb.ToString();
        }
    }
}
