﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint2.Task2.V9.Lib;

namespace Tyuiu.kkhalid.sprint2.Task2.V9
{

    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                      *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine(" точка находиться в заштрихованной области ");
            }
            else
            {
                Console.WriteLine("точка не  находиться в заштрихованной области ");
            }

            Console.ReadKey();      

        }
    }
}
