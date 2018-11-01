using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Policy.Instance, Policy.Instance);
        }
    }
}
