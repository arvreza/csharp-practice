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
           
        }
    }
}
