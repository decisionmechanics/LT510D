﻿namespace CurrencyConverter
{
    using System;

    using MoneyLib;

    internal class Program
    {
        static void Main()
        {
            decimal inAmt, outAmt;                               // Define variables
            string inCur = "GBP";                               // Convert US dollars to...
            string outCur = "USD";                              //   Euros
            inAmt = GetAmount("Input amount of " + inCur + " to convert to " + outCur + "? ");
            outAmt = Convert(inCur, outCur, inAmt);                     // Do the conversion
            Console.Write("{0}{1:N2} {2} is ", EuroTable.SymbolFor(inCur), inAmt, inCur);
            Console.WriteLine("{0}{1:N2} {2} ", EuroTable.SymbolFor(outCur), outAmt, outCur);
        }

        static decimal GetAmount(string prompt)                 // Ask for a numeric amount.
        {
            decimal data = 0.00m;                               // Amount to convert.
            bool no_data = true;                                // Set control flag.
            while (no_data)                                     // Loop until input is good.
            {
                try
                {
                    Console.Write(prompt);                          // Prompt for input
                    string input = Console.In.ReadLine();           // Read a string.
                    data = decimal.Parse(input);                        // Convert to a numeric.
                    if (data > 0.0m) no_data = false;               // We got the data.
                }
                catch (FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            return data;
        }

        static decimal Convert(string ic, string oc, decimal amt) // Convert any to any
        {
            decimal outRate = (decimal)EuroTable.ExchangeRate(oc);
            decimal inRate = (decimal)EuroTable.ExchangeRate(ic);
            decimal convRate = inRate / outRate;                 // Any to any exchange rate
            return amt * convRate;
        }
	}
}
