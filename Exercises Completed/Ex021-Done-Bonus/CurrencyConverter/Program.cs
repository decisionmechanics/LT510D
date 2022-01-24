namespace CurrencyConverter
{
    using System;

    using MoneyLib;

    internal class Program
    {
		static void Main(string[] args)
		{
			decimal inAmt, outAmt;                          // Define variables
			string inCur = "GBP";                           // Convert US dollars to...
			string outCur = "EUR";
			//inAmt = GetAmount("Input amount of " + inCur + " to convert to " + outCur + "? ");
			int[] nums = { 100, 256, 500, 1281 };
			string[] inCurs = { "JPY", "CAD", "USD", "SEK", "GBP" };
			foreach (string s in inCurs)
			{
				inCur = s;
				foreach (int n in nums)
				{
					inAmt = n;
					outAmt = Convert(inCur, outCur, inAmt);         // Do the conversion
					Console.Write("{0}{1:N2} {2} is ", EuroTable.SymbolFor(inCur), inAmt, inCur);
					Console.WriteLine("{0}{1:N2} {2} ", EuroTable.SymbolFor(outCur), outAmt, outCur);
				}
			}
		}

		static decimal GetAmount(string prompt)             // Ask for a numeric amount.
		{
			decimal data = 0.00m;                           // Amount to convert.
			bool no_data = true;                            // Set control flag.
			while (no_data)                                 // Loop until input is good.
			{
				Console.Write(prompt);                      // Prompt for input
				string input = Console.In.ReadLine();       // Read a string.
				data = decimal.Parse(input);                // Convert to a numeric.
				if (data > 0.0m) no_data = false;           // We got the data.
			}
			return data;
		}

		static decimal Convert(string ic, string oc, decimal amt)   // No longer euro-centric
		{
			decimal outRate = (decimal)EuroTable.ExchangeRate(oc);
			decimal inRate = (decimal)EuroTable.ExchangeRate(ic);
			decimal convRate = inRate / outRate;            // Any to any exchange rate
			return amt * convRate;
		}
	}
}
