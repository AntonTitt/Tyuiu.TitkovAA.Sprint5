using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint5.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vipTa\source\repos\Tyuiu.TitkovAA.Sprint5\Tyuiu.TitkovAA.Sprint5.Task7.V17\bin\Debug\OutPutDataFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}
