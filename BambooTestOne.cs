using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BambooDotNetTests
{
    [TestClass]
    public class BambooTestOne
    {
        [TestMethod]
        public void AlwaysTrue()
        {
            Assert.AreEqual("asdf", "asdf");
        }

        [TestMethod]
        public void NeverTrue()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SometimesTrue()
        {
            Random random = new Random();
            int v = random.Next(10);
            if (v == 0)
            {
                Assert.Inconclusive();
            } else
            {
                Assert.IsTrue(v < 3);
            }
        }
    }
}
