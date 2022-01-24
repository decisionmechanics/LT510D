namespace MoneyLib
{
    public class Currency
    {
        public string Code { get; private set; }
        public char Symbol { get; private set; }
        public string Country { get; private set; }
        public string Name { get; private set; }
        public double Rate { get; set; }

        public Currency(string country, string name, string code, double exchangeRate, char symbol)
        {
            Code = code;
            Name = name;
            Country = country;
            Symbol = symbol;
            Rate = exchangeRate;
        }
	}
}