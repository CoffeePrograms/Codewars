using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._4kyu
{
    internal class How_many_numbers_III
    {
        public static List<long> FindAll(int sumDigits, int numDigits)
        {
            List<long> res = new List<long>();
            int count, iAffected;
            long max, digit, tempDigit;
            long? first, last;
            byte sum, nextDigit, currDigit;

            count = 0;
            first = last = null;

            max = 100;
            digit = 11;
            tempDigit = numDigits - 2;
            for (int i = 0; i < tempDigit; i++)
            {
                max *= 10;
                digit = digit * 10 + 1;
            }

            while (digit < max)
            {
                tempDigit = digit;
                sum = 0;
                nextDigit = 9;
                iAffected = 1;
                while (tempDigit > 0)
                {
                    currDigit = (byte)(tempDigit % 10);
                    if (nextDigit < currDigit)
                    {
                        for (int i = 1; i != iAffected; i++)
                        {
                            tempDigit *= 10;
                            tempDigit += currDigit;
                        }
                        digit = tempDigit - 1;
                        tempDigit = sum = 0;
                    }
                    else
                    {
                        sum += currDigit;
                        tempDigit /= 10;
                        nextDigit = currDigit;
                        iAffected++;
                    }
                }

                if (sum == sumDigits)
                {
                    count++;
                    if (first == null)
                        first = digit;
                    last = digit;
                }
                digit++;
            }


            if (count != 0)
            {
                res.Add(count);
                res.Add(first.Value);
                res.Add(last.Value);
            }
            return res;
        }
    }
}
