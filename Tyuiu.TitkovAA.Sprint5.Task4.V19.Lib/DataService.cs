using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            
            double str = Convert.ToDouble((File.ReadAllText(path)));

            return Math.Round(Math.Pow((str / Math.Cos(str)), 2), 3);

        }

    }
}
