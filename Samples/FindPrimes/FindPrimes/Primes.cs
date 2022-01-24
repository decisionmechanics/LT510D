namespace FindPrimes
{
    public static class Primes
    {
        public static IEnumerable<int> FindPrimes(int limit) => Enumerable.Range(2, limit - 1).Where(IsPrime).ToList();

        private static bool IsPrime(int n)
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
