using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint5.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint5.Task7.V17
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V17.txt (файл взять из архива *");
            Console.WriteLine(@"* согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Удалить  *");
            Console.WriteLine("* все удвоенные буквы \"нн\" из файла.Полученный результат сохранить в    *");
            Console.WriteLine("* файл OutPutDataFileTask7V17.txt.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask7V17.txt";

            Console.WriteLine("В файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("В файле: " + path);
            Console.WriteLine(dt.LoadDataAndSave(path));
        }
    }
}
