namespace Util
{
    public static class NumberExtensions
    {
        public static string ToText(this byte number)
        {
            return ToText((long) number);
        }

        public static string ToText(this short number)
        {
            return ToText((long) number);
        }

        public static string ToText(this int number)
        {
            return ToText((long) number);
        }

        public static string ToText(this long number)
        {
            if (number < 0)
            {
                if (number == long.MinValue)
                {
                    return LongMinSpecialCase();
                }

                number = -number;

                return "minus " + number.ToText();
            }

            if (number == 0)
            {
                return "zero";
            }

            if (number < 20)
            {
                string[] numbers =
                {
                    "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                    "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
                };

                return numbers[number];
            }

            if (number < 100)
            {
                string[] decades = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

                long unit = number % 10;
                long dix = (number - 20) / 10;

                if (unit == 0)
                {
                    return decades[dix];
                }

                return decades[dix] + " " + unit.ToText();
            }

            if (number < 1000)
            {
                int hundredUnits = (int) number / 100;
                int hundreds = hundredUnits * 100;
                int tens = (int) number - hundreds;

                string temp = hundredUnits.ToText() + " hundred";

                if (tens == 0)
                {
                    return temp;
                }

                return temp + " " + tens.ToText();
            }

            if (number < 1000000)
            {
                return Encode(number, 1000, "thousand");
            }

            if (number < 1000000000)
            {
                return Encode(number, 1000000, "million");
            }

            if (number < 1000000000000L)
            {
                return Encode(number, 1000000000L, "billion");
            }

            if (number < 1000000000000000L)
            {
                return Encode(number, 1000000000000L, "trillion");
            }

            if (number < 1000000000000000000L)
            {
                return Encode(number, 1000000000000000L, "quadrillion");
            }

            if (number <= long.MaxValue)
            {
                return Encode(number, 1000000000000000000L, "quintillion");
            }

            return string.Empty;
        }

        private static string Encode(long number, long divisor, string rangeName)
        {
            long units = number / divisor;
            long range = units * divisor;
            long subRange = number - range;
            
            string temp = units.ToText() + " " + rangeName;

            if (subRange == 0)
            {
                return temp;
            }

            return temp + " " + subRange.ToText();
        }

        private static string LongMinSpecialCase()
        {
            // cannot fall through to positive because of 2's complement arithmetic.
            string text = "minus nine quintillion ";

            text += "two hundred twenty three quadrillion ";
            text += "three hundred seventy two trillion ";
            text += "thirty six billion ";
            text += "eight hundred fifty four million ";
            text += "seven hundred seventy five thousand ";
            text += "eight hundred eight";

            return text;
        }

    }
}
