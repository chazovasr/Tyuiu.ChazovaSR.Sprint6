using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChazovaSR.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) / x + 1.2 + Math.Cos(x) * 7 * x - 2, 2); 
                if (x == 0)
                {
                    valueArray[count] = 0.00;
                    count++;
                }
                else
                {
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
