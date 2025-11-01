using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.kkhalid.sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 4) && (x <= 11) && (y >= 4) && (y <= 11))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;


        }
    }
}
