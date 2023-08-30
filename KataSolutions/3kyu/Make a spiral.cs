using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._3kyu
{
    internal class Make_a_spiral
    {
        public static int[,] Spiralize(int size)
        {
            int[,] res = new int[size, size];
            int i, j, y, x;

            // верхний треугольник
            int n = size / 2 + (size % 2 == 0 ? 0 : 1);
            y = x = 0;
            for (i = 0; i < n; i += 2)
            {
                for (j = x; j < size - y; j++)
                {
                    res[i, j] = 1;
                }
                y += 2;
                x = y - 1;
            }

            // нижний треугольник
            y = x = 0;
            for (i = size - 1 - x; i > size / 2; i -= 2)
            {
                for (j = y; j < size - y; j++)
                {
                    res[i, j] = 1;
                }
                y += 2;
                x++;
            }

            // правый треугольник
            x = 0;
            for (j = size - 1; j > 0; j -= 2)
            {
                for (i = x; i < size - x; i++)
                {
                    res[i, j] = 1;
                }
                x += 2;
            }

            // левый треугольник
            x = 2;
            for (j = 0; j < size - x; j += 2)
            {
                for (i = size - x; i > x - 1; i--)
                {
                    res[i, j] = 1;
                }
                x += 2;
            }

            return res;
        }
    }
}
