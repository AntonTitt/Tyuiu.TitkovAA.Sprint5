using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint5.Task5.V8.Lib;
using System.IO;
namespace Tyuiu.TitkovAA.Sprint5.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            FileInfo fl = new FileInfo(@"C:\DataSprint5\InPutDataFileTask5V8.txt");
            bool e = fl.Exists;
            Assert.AreEqual(true,e);
        }
    }
}
