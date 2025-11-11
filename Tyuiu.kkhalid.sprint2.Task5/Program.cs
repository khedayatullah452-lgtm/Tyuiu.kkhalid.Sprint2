using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task5.V8.Lib;

namespace Tyuiu.kkhalid.sprint2.Task5.V8
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Showe me just the number of the day");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
                string res;
            if (m == 1 && n == 1)
            {
                res = " roung number";
            }
            else
            {
                res = " 1 , 12 : " + ds.FindDateOfPreviousDay(m,n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadLine();


        }

    }
}