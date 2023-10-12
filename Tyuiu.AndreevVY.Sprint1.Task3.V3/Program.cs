using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AndreevVY.Sprint1.Task3.V3.Lib;


namespace Tyuiu.AndreevVY.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Андреев В. Ю. | СмартБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Андреев Владимир Юрьевич | СмартБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления объема параллелепипеда                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = 9;
            double y = 7.5;
            double z = 5;
            Console.WriteLine("Длина (см) -> " + x);
            Console.WriteLine("Ширина (см) ->" + y);
            Console.WriteLine("Высота (см) -> 5" + z);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объем: " + ds.ParallelepipedVolume(x, y, z));
            Console.ReadKey();

        }
    }
}
