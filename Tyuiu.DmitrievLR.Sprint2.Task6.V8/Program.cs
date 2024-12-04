﻿using Tyuiu.DmitrievLR.Sprint2.Task6.V8.Lib;
namespace Tyuiu.DmitrievLR.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
             
            Console.WriteLine("*                                                                         *");
              
            Console.WriteLine("Введите порядковый номер месяца (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день месяца (1-31):");
            int day = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.FindDateOfPreviousDay(month,day);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}