using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO:
using Tyuiu.NasyrovaVR.Sprint6.Task7.V20.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"L:\Проги\DataSprint6\InPutFileTask7V20.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
