using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint2.Task1.V23.Lib;

namespace Tyuiu.SolievAH.Sprint2.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 127;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(242, 571, 325, 155);

            Console.Title = "Спринт #2 | Выполнил: Солиев А. Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:2.1 Логические операции                                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Солиев Алижон Хотамжонович | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций(|, &, ||, &&, !, ^, последовательность      *");
            Console.WriteLine("* операций не должна нарушаться (False, False, False, True, True, True), *");
            Console.WriteLine("*  при a = 415, b = 616, c = 134, d = 127;                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" a = 242, b = 571, c = 325, d = 155");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
