using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint5.Task2.Lib
{
    public class DataService : ISprint5Task2V23
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            string str = "";
            if (fileexist)
            {
                File.Delete(path);
            }
            /*
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            */
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(1))
                    {
                        str += matrix[i, j];
                    }
                    else
                    {
                        str += matrix[i, j];
                    }

                }
                if (i != matrix.GetLength(0))
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }

            return path;
        }
    }
}
