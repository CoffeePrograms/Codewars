using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._4kyu
{
    internal class Human_readable_duration_format
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";

            string res = "";
            var dt = new DateTime().AddSeconds(seconds);
            if (dt.Year - 1 != 0)
                res += string.Format("{0} year" + (dt.Year - 1 != 1 ? "s" : ""), dt.Year - 1);
            if (seconds / 3600 >= 24)
            {
                if (res != "") res += ", ";
                res += string.Format("{0} day" + (seconds / 3600 > 24 ? "s" : ""), seconds / 3600 / 24 % 365);
            }
            if (dt.Hour != 0)
            {
                if (res != "") res += ", ";
                res += string.Format("{0} hour" + (dt.Hour != 1 ? "s" : ""), dt.Hour);
            }
            if (dt.Minute != 0)
            {
                if (res != "")
                    if (dt.Second != 0)
                        res += ", ";
                    else
                        res += " and ";
                res += string.Format("{0} minute" + (dt.Minute != 1 ? "s" : ""), dt.Minute);
            }
            if (dt.Second != 0)
            {
                if (res != "") res += " and ";
                res += string.Format("{0} second" + (dt.Second != 1 ? "s" : ""), dt.Second);
            }
            return res;
        }
    }
}
