using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class RecursionTests
    {
        Recursion recursion;

        [TestInitialize]
        public void Init() {
            recursion = new Recursion();
        }
        

        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(recursion.Factorial(0), 1);
            Assert.AreEqual(recursion.Factorial(5), 5*4*3*2);
        }

        [TestMethod]
        public void TestBunnyEars()
        {
            Assert.AreEqual(recursion.BunnyEars(0), 1);
            Assert.AreEqual(recursion.BunnyEars(1), 2);
            Assert.AreEqual(recursion.BunnyEars(2), 5);
            Assert.AreEqual(recursion.BunnyEars(5), 2+3+2+3+2);
        }

        [TestMethod]
        public void TestFib()
        {
            Assert.AreEqual(recursion.Fib(0), 0);
            Assert.AreEqual(recursion.Fib(1), 1);
            Assert.AreEqual(recursion.Fib(2), 1);
            Assert.AreEqual(recursion.Fib(3), 2);
            Assert.AreEqual(recursion.Fib(9), 34);
        }

        [TestMethod]
        public void TestGroupSum()
        {
            Assert.AreEqual(recursion.GroupSum(0, new int[] {2, 4, 8}, 10), true);
            Assert.AreEqual(recursion.GroupSum(0, new int[] {2, 4, 8}, 14), true);
            Assert.AreEqual(recursion.GroupSum(0, new int[] {2, 4, 8}, 9), false);
            Assert.AreEqual(recursion.GroupSum(0, new int[] {10, 2, 2, 5}, 17), true);
        }

    }
}