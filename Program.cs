using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sravnenie_dat_cherez_ticki
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] s = new string[N];
            DateTime[] d = new DateTime[N];
            for (int i = 0; i < N; i++)
            {
                s[i] = Console.ReadLine();
                d[i] = DateTime.Parse(Console.ReadLine());
            }
            TimeSpan f = d[0].Subtract(d[1]).Duration();
            int index = 0;
            int index2 = 1;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    TimeSpan k = d[i].Subtract(d[j]).Duration();
                    if (k.Ticks < f.Ticks)
                    {
                        f = k;
                        index = i;
                        index2 = j;
                    }
                }
            }
            Console.WriteLine("{0} {1}", s[index], s[index2]);
        }
    }
}
