using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task3.V28.Lib;

namespace Tyuiu.kkhalid.sprint2.Task3.V28
{

    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите значение переменной X ");

            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Значение функции = " + res);
        }
    }
}
