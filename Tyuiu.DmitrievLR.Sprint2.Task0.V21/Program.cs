using Tyuiu.DmitrievLR.Sprint2.Task0.V21.Lib;
namespace Tyuiu.DmitrievLR.Sprint2.Task0.V21
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) *");
             
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());

              
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetCompareOperations(x,y);
            foreach ( bool item in result  )
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}