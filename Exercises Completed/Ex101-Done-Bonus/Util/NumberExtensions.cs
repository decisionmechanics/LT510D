namespace Util
{
    public static class NumberExtensions
    {
        public static string ToText(this int number)
        {
            if (number < 0)
            {
                number = -number;

                return "minus " + number.ToText();
            }

            if (number == 0)
            {
                return "zero";
            }

            if (number < 20)
            {
                string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

                return numbers[number];
            }

            if (number < 100)
            {
                string[] decades = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

                int unit = number % 10;
                int dix = (number - 20) / 10;

                if (unit == 0)
                {
                    return decades[dix];
                }

                return decades[dix] + " " + unit.ToText();
            }

            return string.Empty;
        }
    }
}
