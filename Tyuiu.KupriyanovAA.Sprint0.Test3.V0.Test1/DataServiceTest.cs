using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint0.Test3.V0.Lib1;

namespace Tyuiu.KupriyanovAA.Sprint0.Test3.V0.Test1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService1.Sum(5, 5));
        }
    }
}
