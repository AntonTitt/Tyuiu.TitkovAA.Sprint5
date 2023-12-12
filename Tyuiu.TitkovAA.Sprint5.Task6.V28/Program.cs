using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint5.Task6.V28.Lib;
using System.IO;
namespace Tyuiu.TitkovAA.Sprint5.Task6.V28
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask6V28.txt (файл взять из        *");
            Console.WriteLine(@"* архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.Найти  *");
            Console.WriteLine("* количество четырехзначных чисел в заданной строке.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask6V28.txt";

            Console.WriteLine("В файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(dt.LoadFromDataFile(path));



        }
    }
}
