using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint6.Task2.V3.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task2.V3.Test
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

            valueWaitArray[0] = -10.92;
            valueWaitArray[1] = 17.31;
            valueWaitArray[2] = 20.04;
            valueWaitArray[3] = 5.48;
            valueWaitArray[4] = -3.74;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 3.82;
            valueWaitArray[7] = -6.17;
            valueWaitArray[8] = -21.54;
            valueWaitArray[9] = -19.29;
            valueWaitArray[10] = 8.94;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
