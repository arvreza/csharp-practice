using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

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

        [TestMethod]
        public void TestZipZap() 
        {
            var warmups = new WarmUps();
            Assert.AreEqual(warmups.ZipZap("zipXzap"), "zpXzp");
            Assert.AreEqual(warmups.ZipZap("zopzop"), "zpzp");
            Assert.AreEqual(warmups.ZipZap("zzzopzop"), "zzzpzp");
        }

        [TestMethod]
        public void TestSubstring() 
        {
            var warmups = new WarmUps();
            Assert.AreEqual(warmups.subString("zipXzap", "zap"), true);
            Assert.AreEqual(warmups.subString("zopzop", "zip"), false);
            Assert.AreEqual(warmups.subString("RezaArbabi", "eza"), true);
        }


    }
}
