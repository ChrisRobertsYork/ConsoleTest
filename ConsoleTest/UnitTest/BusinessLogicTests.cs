using System;
using ConsoleTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void BusinessLogic_Add()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Add(3, 3) == 6);
        }

        [TestMethod]
        public void BusinessLogic_Subtract()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Subtract(3, 3) == 0);
        }

        [TestMethod]
        public void BusinessLogic_Multiply()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Multiply(3, 3) == 9);
        }
    }
}
