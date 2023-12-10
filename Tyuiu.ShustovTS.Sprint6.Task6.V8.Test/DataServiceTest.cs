using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ShustovTS.Sprint6.Task6.V8.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\MSi\source\repos\Tyuiu.ShustovTS.Sprint6\Tyuiu.ShustovTS.Sprint6.Task6.V8\bin\Debug\InPutFileTask6V8.txt";
            string result = ds.CollectTextFromFile(path);
            string wait = "RizdogMOZpCb GqzgGQOdWpd ztMvvn ";
            Assert.AreEqual(wait, result);
        }
    }
}
