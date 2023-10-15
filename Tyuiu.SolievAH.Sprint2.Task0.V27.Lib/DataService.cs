using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений,
// которая вернет логическую последовательность(массив): (True, False, True, False, False, True), при x = 1305, y = 275

namespace Tyuiu.SolievAH.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool [] res = new bool[6];
            res[0] = x - 1030 == y;
            res[1] = x == y;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
