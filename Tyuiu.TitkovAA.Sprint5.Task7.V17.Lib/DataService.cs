using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;


namespace Tyuiu.TitkovAA.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                /*
                char v= ' ';
                bool fl = false;
                */
                

                while ((line = reader.ReadLine()) != null)
                {
                    /*
                    for (int i = 0; i < line.Length; i++)
                    {
                        foreach (char n in line)
                        {

                            if (fl)
                            {
                                if (v == 'н' && n == 'н')
                                {

                                }
                            }
                            else
                            {
                                fl = true;

                            }
                            v = n;
                        }


                    }*/
                    strLine += line.Replace("нн", "");




                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
