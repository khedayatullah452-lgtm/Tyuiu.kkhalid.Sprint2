using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task6.V3.Lib;

namespace Tyuiu.kkhalid.sprint2.Task6.V3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня недели  ");
            int DayName = Convert.ToInt32(Console.ReadLine());

            string res;

            if (DayName == 0 || (DayName == 9))
            {
                res = "Введите реверное значение!";
            }
            else
            {
                res = " это дня недели: " + ds.FindDayName(DayName);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadLine();



        }
    }
}
