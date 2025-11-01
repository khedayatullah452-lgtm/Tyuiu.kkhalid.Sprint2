using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.kkhalid.sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (b < c);
            res[1] = (a == c) && (c > b);
            res[2] = (b > d) || ( c == a);
            res[3] = (a >= b) & (d == b);
            res[4] = !(res[3]);
            res[5] = (b > a) ^ (d == c);
            return res;
        }
    }
}
