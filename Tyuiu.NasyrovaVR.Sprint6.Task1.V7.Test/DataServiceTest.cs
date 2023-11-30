using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint6.Task1.V7.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 7.76;
            valueWaitArray[1] = 7.36;
            valueWaitArray[2] = 7.26;
            valueWaitArray[3] = 7.90;
            valueWaitArray[4] = 15.88;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 5.63;
            valueWaitArray[8] = 6.49;
            valueWaitArray[9] = 6.49;
            valueWaitArray[10] = 6.32;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
