using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "2.545";
            string pattern = ".";
            string replacement = ",";
            
            Console.WriteLine(Regex.Replace(a, pattern, replacement));
        }
    }
}
