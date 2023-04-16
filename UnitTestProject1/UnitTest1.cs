using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = { { 2, 3, 5 }, { 7, 2, 1 } };
            

            int[,] actual = Program.Method(array, 5);
            int[,] expected = { { 0, 0, 5 }, { 0, 0, 0 } };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
