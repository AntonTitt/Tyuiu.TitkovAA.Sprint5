using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint5.Task4.V19.Lib;

namespace Tyuiu.TitkovAA.Sprint5.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #5 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и    *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение.           *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле .           *");
            Console.WriteLine("* Вычислить значение по формуле(Полученное значение округлить до трёх     *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask4V19.txt";
            Console.WriteLine("В файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dt.LoadFromDataFile(path));


            
        }
    }
}
