using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.kkhalid.sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y; // false
            res[1] = x != y; // True
            res[2] = x > y * 40; // True
            res[3] = y < 100; // True 
            res[4] = x >= 3105; // True
            res[5] = y <= 76; // False
            
            return res;
        }
    }
}
