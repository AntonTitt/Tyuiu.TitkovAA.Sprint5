using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Tyuiu.TitkovAA.Sprint5.Task3.V18.Lib;
namespace Tyuiu.TitkovAA.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\123\source\repos\AntonTitt\Tyuiu.TitkovAA.Sprint5\Tyuiu.TitkovAA.Sprint5.Task3.V18\bin\Debug\OutPutFileTask3.bin";
            FileInfo fl = new FileInfo(path);
            DataService dt = new DataService();
            dt.SaveToFileTextData(2);
            

            Assert.AreEqual(fl.Exists,true);
        }
    }
}
