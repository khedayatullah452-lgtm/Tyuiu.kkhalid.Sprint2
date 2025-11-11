using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.kkhalid.sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {

        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;

            switch (m, n)
            {

                case (1,31):
                    res = "Январь";
                 
                    break;

                case (2,28):
                    res = "Февраль";
                  
                    break;

                case (3,31):
                    res = " Март";
                    
                    break;

                case(4,30):
                    res = " Апрель";
                    break;

                case (5,31):
                    res = " Май ";
                    break;

                case (6,30):
                    res = " Июнь ";
                    break;

                case (7,31):
                    res = "Июль ";
                    break;

                case (8,31):
                    res = " Август";
                    break;

                case (9,30):
                    res = "  Сентябрь";
                    break;

                case (10,31):
                    res = " Октябрь";
                    break;

                case (11,30):
                    res = " Ноябрь";
                    break;

                case (12,31):
                    res = "Декабрь";
                    break;
                default:
                    throw new ArgumentException(" All of Mounth is Betwin (1 ,12) . more than (12) is roung ");
            }
            return res;
        }  


    }
}

          