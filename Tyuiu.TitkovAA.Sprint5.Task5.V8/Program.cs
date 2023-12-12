using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint5.Task5.V8.Lib;

namespace Tyuiu.TitkovAA.Sprint5.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.WriteLine("*                                                                         *");
                //Console.WriteLine("***************************************************************************");
                //75симв->

                Console.Title = "Спринт #5 | Выполнил: Титков А. А. | РПСб-23-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #5                                                               *");
                Console.WriteLine("* Тема: решение задания                                                   *");
                Console.WriteLine("* Задание #5                                                              *");
                Console.WriteLine("* Вариант #8                                                              *");
                Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask5V8.txt.                        *");
                Console.WriteLine("*  в котором есть набор значений.Найти минимальное вещественное число в   *");
                Console.WriteLine("* файле. Полученный результат вывести на консоль.У вещественных значений  *");
                Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                DataService dt = new DataService();

                string path = $@"C:\DataSprint5\InPutDataFileTask5V8.txt";

                Console.WriteLine("В файле: " + path);


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine(dt.LoadFromDataFile(path));
            }
        }
    }
}