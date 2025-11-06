using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.kkhalid.sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
              double numerator = Math.Cos(Math.Pow(x, 2));
                double denominator = (x - 1);
                double fraction= numerator / denominator;
                double power = Math.Pow(fraction, x + 3 );
                y = x + power;
            }
            else
            {
                y = 0;
            }
            return Math.Round(y, 3);
            

        }
    }
}

     
     
