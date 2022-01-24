namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            double inAmt, outAmt;                               // Define variables
            string inCur = "USD";                               // Convert US dollars to...
            string outCur = "EUR";                              //   Euros
            inAmt = GetAmount("Input amount of " + inCur + " to convert to " + outCur + "? ");
            outAmt = Convert(inCur, inAmt);                     // Do the conversion
            System.Console.Write("{0}{1:N2} {2} is ", SymbolFor(inCur), inAmt, inCur);
            System.Console.WriteLine("{0}{1:N2} {2} ", SymbolFor(outCur), outAmt, outCur);
        }

        static double GetAmount(string prompt)                  // Ask for a numeric amount.
        {
            double data = 0.00;                                 // Amount to convert.
            bool no_data = true;                                // Set control flag.
            while (no_data)                                     // Loop until input is good.
            {
                System.Console.Write(prompt);                   // Prompt for input
                string input = System.Console.In.ReadLine();    // Read a string.
                data = double.Parse(input);                     // Convert to a numeric.
                if (data > 0.0) no_data = false;                // We got the data.
            }
            return data;
        }

        static double Convert(string ic, double amt)            // Euro-centric conversion
        {
            const double convRate = 0.7879;                     // Conversion rate.
            double convValue;                                   // Result value.
            if (ic == "EUR") convValue = amt / convRate;        // Divide from EUR
            else convValue = amt * convRate;                    // Multiply to EUR
            return convValue;                                   // Return the result
        }

        static char SymbolFor(string currency)                  // Determine currency symbol
        {
            if (currency == "USD") return '$';                  // US dollars
            if (currency == "EUR") return '\u20AC';             // Euro (actually epsilon)
            return ' ';                                         // Unknown so return a space.
        }
	}
}