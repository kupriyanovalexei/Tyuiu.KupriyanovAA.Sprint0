using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KupriyanovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алексей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алексей", res);
        }
    }
}
