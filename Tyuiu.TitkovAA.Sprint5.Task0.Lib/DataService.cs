using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TitkovAA.Sprint5.Task0.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            double t = (double)x;
            double y = (1 + t * t * t) / (t * t);

            return Convert.ToString(Math.Round(y,3));
        }
    }
}
