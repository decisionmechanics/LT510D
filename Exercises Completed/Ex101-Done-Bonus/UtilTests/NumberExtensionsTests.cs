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

        [TestMethod]
        public void TwentyToNintyNineTest()
        {
            string[] decades = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            for (int decade = 20; decade <= 90; decade += 10)
            {
                int dix = (decade - 20) / 10; Assert.AreEqual(decades[dix], decade.ToText());
            }

            Assert.AreEqual("twenty one", 21.ToText());
            Assert.AreEqual("thirty five", 35.ToText());
            Assert.AreEqual("eighty two", 82.ToText());
            Assert.AreEqual("ninety nine", 99.ToText());
            Assert.AreEqual("minus seventy seven", (-77).ToText());
        }
    }
}