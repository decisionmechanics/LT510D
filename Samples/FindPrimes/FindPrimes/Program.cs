using FindPrimes;

const int limit = 10000000;

IEnumerable<int> primes = Primes.FindPrimes(limit).ToList();

Console.WriteLine($"There are {primes.Count()} primes <= {limit}");
