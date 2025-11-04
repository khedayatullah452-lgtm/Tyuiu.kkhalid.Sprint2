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
                y = ((x * x) + (Math.Cos(x * x) / (x - 1))) * Math.Pow(x, 3);
            }
            else
            {

                if (x == 0)
                {
                    y =( ((x * x) + Math.Cos(x * x) - 11) /( (x * x) - Math.Sin(x * x) + 2));
                }
                else
                {

                    return Math.Round(y, 3);
                }

            }

        }


    }

}



        
   

