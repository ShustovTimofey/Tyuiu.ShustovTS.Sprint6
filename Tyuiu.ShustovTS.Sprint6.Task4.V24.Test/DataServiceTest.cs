using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint6.Task4.V24.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startStep = -5;
            int stopStep = 5;
            int len = (stopStep - startStep) + 1;
            double[] res = new double[len];
            res = ds.GetMassFunction(startStep, stopStep);
            double[] wait = new double[len];
            wait[0] = 7.83;
            wait[1] = 6.22;
            wait[2] = 6.36;
            wait[3] = 6.96;
            wait[4] = -0.52;
            wait[5] = 0;
            wait[6] = -3.3;
            wait[7] = -5.53;
            wait[8] = -6.25;
            wait[9] = -6.63;
            wait[10] = -8.24;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
