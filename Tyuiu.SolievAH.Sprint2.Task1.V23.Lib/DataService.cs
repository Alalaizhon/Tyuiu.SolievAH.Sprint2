using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), 
//а также арифметических выражений, которая вернет логическую последовательность(массив): 
//(False, False, False, True, True, True), при a = 242, b = 571, c = 325, d = 155

namespace Tyuiu.SolievAH.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] bolean = new bool[6];
            bolean[0] = (a == b) | (b <= c); // False
            bolean[1] = (c >= b) & (b < c); //False
            bolean[2] = (a == b) || (d > c); //False
            bolean[3] = (a != b) && (c >= d); //True
            bolean[4] = !(a < d); //True
            bolean[5] = (a > b) ^ (c > d); //True

            return bolean;
        }
    }
}
