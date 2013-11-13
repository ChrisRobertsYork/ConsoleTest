using System;
using ConsoleTest;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class BusinessLogicTests
    {
        [Test]
        public void BusinessLogic_Add()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Add(3, 3) == 6);
        }

        [Test]
        public void BusinessLogic_Subtract()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Subtract(3, 3) == 0);
        }

        [Test]
        public void BusinessLogic_Multiply()
        {
            var businessLogic = new BusinessLogic();
            Assert.IsTrue(businessLogic.Multiply(3, 3) == 9);
        }
    }
}
