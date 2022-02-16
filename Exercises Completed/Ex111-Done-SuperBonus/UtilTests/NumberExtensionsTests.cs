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

        [TestMethod]
        public void OneHundredToNineHundredNinetyNineTest()
        {
            Assert.AreEqual("one hundred", 100.ToText());
            Assert.AreEqual("two hundred", 200.ToText());
            Assert.AreEqual("three hundred", 300.ToText());
            Assert.AreEqual("four hundred", 400.ToText());
            Assert.AreEqual("five hundred", 500.ToText());
            Assert.AreEqual("six hundred", 600.ToText());
            Assert.AreEqual("seven hundred", 700.ToText());
            Assert.AreEqual("eight hundred", 800.ToText());
            Assert.AreEqual("nine hundred", 900.ToText());
            Assert.AreEqual("nine hundred ninety nine", 999.ToText());
            Assert.AreEqual("seven hundred fifty five", 755.ToText());
            Assert.AreEqual("two hundred fifty six", 256.ToText());
            Assert.AreEqual("minus three hundred fifty", (-350).ToText());
            Assert.AreEqual("minus eight hundred sixteen", (-816).ToText());
        }

        [TestMethod]
        public void OneThousandTo999999Test()
        {
            Assert.AreEqual("one thousand", 1000.ToText());
            Assert.AreEqual("two thousand", 2000.ToText());
            Assert.AreEqual("nine thousand", 9000.ToText());
            Assert.AreEqual("nine hundred ninety nine thousand nine hundred ninety nine", 999999.ToText());
            Assert.AreEqual("three thousand four hundred twenty one", 3421.ToText());
            Assert.AreEqual("seventy thousand sixty six", 70066.ToText());
            Assert.AreEqual("five hundred thousand three hundred eighty nine", 500389.ToText());
            Assert.AreEqual("minus sixty thousand seventy seven", (-60077).ToText());
        }

        [TestMethod]
        public void RangeTest()
        {
            Assert.AreEqual("one million", 1000000L.ToText());
            Assert.AreEqual("one billion", 1000000000L.ToText());
            Assert.AreEqual("one trillion", 1000000000000L.ToText());
            Assert.AreEqual("one quadrillion", 1000000000000000L.ToText());
            Assert.AreEqual("one quintillion", 1000000000000000000L.ToText());
        }

        [TestMethod]
        public void QuadrillionTest()
        {
            string expected = "nine hundred ninety nine quadrillion ";
            
            expected += "nine hundred ninety nine trillion ";
            expected += "nine hundred ninety nine billion ";
            expected += "nine hundred ninety nine million ";
            expected += "nine hundred ninety nine thousand ";
            expected += "nine hundred ninety nine";
            
            Assert.AreEqual(expected, 999999999999999999L.ToText());
            
            expected = "minus " + expected;
            Assert.AreEqual(expected, (-999999999999999999L).ToText());
        }

        [TestMethod]
        public void LongMaxTest()
        {
            string expected = "nine quintillion ";
            
            expected += "two hundred twenty three quadrillion ";
            expected += "three hundred seventy two trillion ";
            expected += "thirty six billion ";
            expected += "eight hundred fifty four million ";
            expected += "seven hundred seventy five thousand ";
            expected += "eight hundred seven";
            
            Assert.AreEqual(expected, long.MaxValue.ToText());
        }

        [TestMethod]
        public void LongMinTest()
        {
            string expected = "minus nine quintillion ";

            expected += "two hundred twenty three quadrillion ";
            expected += "three hundred seventy two trillion ";
            expected += "thirty six billion ";
            expected += "eight hundred fifty four million ";
            expected += "seven hundred seventy five thousand ";
            expected += "eight hundred eight";

            Assert.AreEqual(expected, long.MinValue.ToText());
        }

        [TestMethod]
        public void LongMinPlus1Test()
        {
            string expected = "minus nine quintillion ";

            expected += "two hundred twenty three quadrillion ";
            expected += "three hundred seventy two trillion ";
            expected += "thirty six billion ";
            expected += "eight hundred fifty four million ";
            expected += "seven hundred seventy five thousand ";
            expected += "eight hundred seven";

            long number = long.MinValue + 1;
            
            Assert.AreEqual(expected, number.ToText());
        }
    }
}