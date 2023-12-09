using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChazovaSR.Sprint6.Task5.V18.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint6\Tyuiu.ChazovaSR.Sprint6.Task5.V18\bin\Debug\InPutDataFileTask5V18.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 13.83,
                12.76, 8.86, -1.49 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFileExist()
        {
            string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint6\Tyuiu.ChazovaSR.Sprint6.Task5.V18\bin\Debug\InPutDataFileTask5V18.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
