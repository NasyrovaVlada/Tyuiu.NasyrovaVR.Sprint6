using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasyrovaVR.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
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
                y = Math.Round((Math.Cos(x) + (Math.Sin(x)/(2-2*x)) - 4*x), 2);
                
                
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
