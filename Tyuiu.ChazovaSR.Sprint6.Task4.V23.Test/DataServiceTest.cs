using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChazovaSR.Sprint6.Task4.V23.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 13.81;
            valueWaitArray[1] = 11.87;
            valueWaitArray[2] = 9.87;
            valueWaitArray[3] = 7.74;
            valueWaitArray[4] = 5.36;
            valueWaitArray[5] = 2.50;
            valueWaitArray[6] = 0.00;
            valueWaitArray[7] = 0.79;
            valueWaitArray[8] = -1.75;
            valueWaitArray[9] = -3.78;
            valueWaitArray[10] = -5.71;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
