namespace UtilTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Util;

    [TestClass]
    public class NumberExtensionsTests
    {
        [TestMethod]
        public void ZeroTest()
        {
            Assert.AreEqual("zero", 0.ToText());
        }

        [TestMethod]
        public void OneToNineteenTest()
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            for (int n = 1; n <= 19; n++)
            {
                Assert.AreEqual(numbers[n], n.ToText());
            }
        }

        [TestMethod]
        public void MinusTest()
        {
            Assert.AreEqual("minus one", (-1).ToText());
            Assert.AreEqual("minus seven", (-7).ToText());
            Assert.AreEqual("minus twelve", (-12).ToText());
            Assert.AreEqual("minus nineteen", (-19).ToText());
        }
    }
}