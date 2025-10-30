using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task0.V22.Lib;

namespace Tyuiu.kkhalid.sprint2.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3105;
            int y = 77;
            bool[]res = new bool[6];
            res = ds.GetCompareOperations(x, y);    

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" X = " + x);
            Console.WriteLine(" Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ : False , True ,True ,True ,True ,False                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

                Console.ReadKey();
            }

        }
    }
}


        