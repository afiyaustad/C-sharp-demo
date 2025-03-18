using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            string password = "Rajesh#123";
            int expected = 5;

            //act

            int actual = PasswordStrengthMeter.GetPasswordStrength(password);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
