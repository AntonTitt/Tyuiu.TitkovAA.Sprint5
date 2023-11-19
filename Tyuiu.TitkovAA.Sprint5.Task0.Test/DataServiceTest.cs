using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint5.Task0.Lib;
using System.IO;
namespace Tyuiu.TitkovAA.Sprint5.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vipta\source\repos\Tyuiu.TitkovAA.Sprint5\Tyuiu.TitkovAA.Sprint5.Task0\bin\Debug\OutPutFileTask0.txt";
            FileInfo fi = new FileInfo(path);
            bool fileexists = fi.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}
