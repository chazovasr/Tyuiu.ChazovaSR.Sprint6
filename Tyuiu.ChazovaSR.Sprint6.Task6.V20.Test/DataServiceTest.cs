using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChazovaSR.Sprint6.Task6.V20.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint6\Tyuiu.ChazovaSR.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
