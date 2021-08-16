using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class WarmupsTests
    {
        [TestMethod]
        public void TestLastDigits()
        {
            var warmups = new WarmUps();
            Assert.AreEqual(warmups.LastDigit(17, 7), true);
            Assert.AreNotEqual(warmups.LastDigit(6, 17), true);
            Assert.AreEqual(warmups.LastDigit(3, 113), true);
        }

        [TestMethod]
        public void TestDoubleChar() 
        {
            var warmups = new WarmUps();
            Assert.AreEqual(warmups.DoubleChar("The"), "TThhee");
            Assert.AreEqual(warmups.DoubleChar("AAbb"), "AAAAbbbb");
            Assert.AreEqual(warmups.DoubleChar("Hi-There"), "HHii--TThheerree");
        }
    }
}
