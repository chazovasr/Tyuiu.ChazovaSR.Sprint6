using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChazovaSR.Sprint6.Task7.V2.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint6\Tyuiu.ChazovaSR.Sprint6.Task7.V2\bin\Debug\InPutDataFileTask7V2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
