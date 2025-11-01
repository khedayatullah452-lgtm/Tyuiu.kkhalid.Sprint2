using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task1.V29.Lib;

namespace Tyuiu.kkhalid.sprint2.Task1.V29
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" a =" + a);
            Console.WriteLine(" b =" + b);
            Console.WriteLine(" c =" + c);
            Console.WriteLine(" d =" + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ : True , True ,True ,False ,True ,True                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(res[i]);

                Console.ReadKey();


            }
        }

    }

}
