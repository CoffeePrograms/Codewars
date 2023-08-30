using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._5kyu
{
    internal class Human_Readable_Time
    {
        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}
