namespace CurrencyConverter
{
    using System;

    using MoneyLib;

    internal class Program
    {
        static void Main()
        {
            double inAmt, outAmt;                               // Define variables
            string inCur = "GBP";                               // Convert US dollars to...
            string outCur = "USD";                              //   Euros
            inAmt = GetAmount("Input amount of " + inCur + " to convert to " + outCur + "? ");
            outAmt = Convert(inCur, outCur, inAmt);                     // Do the conversion
            Console.Write("{0}{1:N2} {2} is ", EuroTable.SymbolFor(inCur), inAmt, inCur);
            Console.WriteLine("{0}{1:N2} {2} ", EuroTable.SymbolFor(outCur), outAmt, outCur);
        }

        static double GetAmount(string prompt)                  // Ask for a numeric amount.
        {
            double data = 0.00;                                 // Amount to convert.
            bool no_data = true;                                // Set control flag.
            while (no_data)                                     // Loop until input is good.
            {
                Console.Write(prompt);                           // Prompt for input
                string input = Console.In.ReadLine();            // Read a string.
                data = double.Parse(input);                     // Convert to a numeric.
                if (data > 0.0) no_data = false;                // We got the data.
            }
            return data;
        }

        static double Convert(string ic, string oc, double amt) // Convert any to any
        {
            double outRate = EuroTable.ExchangeRate(oc);
            double inRate = EuroTable.ExchangeRate(ic);
            double convRate = inRate / outRate;                 // Any to any exchange rate
            return amt * convRate;
        }
	}
}
