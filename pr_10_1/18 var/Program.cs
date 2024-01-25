using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_var
{
    class Program
    {
        static Random srt = new Random();
        static void Main (string[] args)
        {
            try
            {
                int count = 0,sum=0;
                Console.WriteLine("Введите число К");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число К1");
                int k1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число К2");
                int k2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во строк ");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                int p = int.Parse(Console.ReadLine());
                int[,] m = new int[h, p];
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    count = 0;
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        m[i, j] = srt.Next(1, 30);
                        Console.Write($"{m[i, j]}\t");
                        if(m[i,j]>0&& m[i, j] % k == 0){ count++; }
                        if(i >=k1-1&&i<=k2-1) { sum += m[i, j]; }
                    }

                    Console.WriteLine();
                    if (i >= k1 - 1 && i <= k2 - 1)
                    { Console.WriteLine($"Сумма элементов в строке {i + 1}"); }
                    Console.WriteLine($"Кол-во положитльных элементов,кратных {k}, в строке {i+1}= {count}");
                }
              
                
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("ОШИБКА");
                Console.ReadKey();
            }
}
    }
}
