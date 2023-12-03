using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint6.Task3.V20.Lib;

namespace Tyuiu.ChazovaSR.Sprint6.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { -14,17,-19,3,2},
                                           { -4,-14,19,-9,-1},
                                           { 1,0,13,14,8 },
                                           { 13,7,8,-3,-15 },
                                           { 2,-20,12,-14,4 } };

            int[,] waitarray = new int[5, 5] { { -14,17,-19,3,2},
                                           { -4,-14,19,-9,-1},
                                           { 1,0,13,14,8 },
                                           { 13,7,8,-3,-15 },
                                           { 0,0,0,0,0 } };

            int[,] resarray = ds.Calculate(array);
            CollectionAssert.AreEqual(waitarray, resarray);
        }
    }
}
