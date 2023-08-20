using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6kyu
{
    internal class Who_likes_it
    {
        public static string Likes(string[] name)
        {
            switch (name.Count())
            {
                case 0:
                    {
                        return "no one likes this";
                    }
                case 1:
                    {
                        return string.Format("{0} likes this", name[0]);
                    }
                case 2:
                    {
                        return string.Format("{0} and {1} like this", name[0], name[1]);
                    }
                case 3:
                    {
                        return string.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
                    }
                default:
                    {
                        return string.Format("{0}, {1} and {2} others like this", name[0], name[1], name.Count() - 2);
                    }
            }
        }
    }
}
