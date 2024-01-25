using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_var
{
    class Program
    {
        static Random srt = new Random();
        static void Main (string[] args)
        {
            try
            {
                int count = 0;
                Console.WriteLine("Введите число К");
                int k = int.Parse(Console.ReadLine());
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
                        if (m[i, j] % k == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"кол-во чисел кратных a в {i + 1} строчке= {count}");
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
