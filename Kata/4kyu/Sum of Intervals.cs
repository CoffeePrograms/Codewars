using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._4kyu
{
    internal class Sum_of_Intervals
    {
        private static (int, int)[] Merge((int, int)[] input)
        {
            // Сортировка по начальным границам интвералов
            var intervals = input.OrderBy(x => x.Item1).ToList();

            for (int i = 0; i < intervals.Count() - 1; i++)
            {
                for (int j = i + 1; j < intervals.Count(); j++)
                {
                    // Пример работы:
                    // (1, 6), (1, 10) => (1, 10)
                    // (1, 6), (2, 8) => (1, 8)
                    // (1, 6), (2, 4) => (1, 6)

                    // Словесный алгоритм:
                    // Если правая граница А больше или равна правой границе В
                    // и левая граница А меньше или равна левой границы В,
                    // то создаем новый интервал (левая граница А, большая из правых границ А и В)
                    // на месте старого, чтобы не сбить сортировку по левой границе,
                    // удаляем интервалы А и В,
                    // возвращаемся в родительский цикл для проверки нового интвервала на возможность объединения

                    if ((intervals[i].Item2 >= intervals[j].Item1) && (intervals[i].Item1 <= intervals[j].Item1))
                    {
                        intervals[i] = (intervals[i].Item1, Math.Max(intervals[i].Item2, intervals[j].Item2));
                        intervals.Remove(intervals[j]);
                        i--;
                        break;
                    }
                }
            }
            return intervals.ToArray();
        }

        public static int SumIntervals((int, int)[] intervals)
        {
            int sum = 0;
            if (intervals.Length != 0)
            {
                intervals = Merge(intervals);
                for (int i = 0; i < intervals.Length; i++)
                {
                    sum += Math.Abs(intervals[i].Item2 - intervals[i].Item1);
                }
            }
            return sum;
        }
    }
}
