namespace MoneyLib
{
    public class EuroTable
    {
        private readonly Dictionary<string, Currency> _currencyTable;

        public EuroTable()
        {
            var currencies = new List<Currency>
            {
                new("European Union", "Euro", "EUR", 1.0, (char) 0x3B5),
                new("Canada", "Dollar", "CAD", 0.7730, '$'),
                new("Japan", "Yen", "JPY", 0.0097, (char) 0xA5),
                new("Sweden", "Krona", "SEK", 0.1167, 'K'),
                new("United Kingdom", "Pound", "GBP", 1.2295, (char) 0xA3),
                new("United States", "Dollar", "USD", 0.7679, '$')
            };

            _currencyTable = new Dictionary<string, Currency>();

            foreach (Currency currency in currencies)
            {
                _currencyTable.Add(currency.Code, currency);
            }
        }

        public static double ExchangeRate(string key)
        {
            var euroTable = new EuroTable();
            Currency currency = euroTable._currencyTable[key.Trim().ToUpper()];
            return currency.Rate;
        }

        public static char SymbolFor(string key)
        {
            var euroTable = new EuroTable();
            Currency currency = euroTable._currencyTable[key.Trim().ToUpper()];
            
            return currency.Symbol;
        }
	}
}