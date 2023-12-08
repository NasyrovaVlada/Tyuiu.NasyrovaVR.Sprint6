using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasyrovaVR.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2*x-3)/(Math.Cos(x)+x) + 5), 2);
                
                if (y == double.NaN || y == double.PositiveInfinity || y == double.NegativeInfinity)
                {
                    y = 0;
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
