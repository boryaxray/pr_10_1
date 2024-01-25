using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _321321_Жеребцев_10._1
{
    class Program
    {
        static Random srt = new Random();
        static void Main (string[] args)
        {
            
            try
            {
                int o = 1, sum=0;
                Console.WriteLine("Введите кол-во строк ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                int p = int.Parse(Console.ReadLine());
                int [,] m= new int[k,p];
                for(int i=0;i<m.GetLength(0);i++)
                {
                    for (int j=0;j<m.GetLength(1);j++)
                    {
                        m[i, j] = srt.Next(1, 30);
                        Console.Write($"{m[i,j]}\t");
                        if (i + j == m.GetLength(0) - 1)
                            if (m[i, j] < 10)
                            {
                                o *= m[i, j];
                            }
                        if (i ==j)
                            if (m[i, j] < 7)
                            {
                                sum += m[i, j];
                            }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Произведение побочной диагонали меньших 10= {o}");
                Console.WriteLine($"Сумма главной диагонали меньших 7= {sum}");

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
