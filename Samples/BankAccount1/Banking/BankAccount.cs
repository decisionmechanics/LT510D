namespace Banking
{
    public class BankAccount
    {
        private decimal balance;
        private readonly ulong acctnum;

        public BankAccount(ulong initnum)
        {
            acctnum = initnum;
            balance = 0.0m;
        }

        public BankAccount(ulong initnum, decimal initbal)
        {
            acctnum = initnum;
            balance = initbal;
        }

        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
            }
            else throw new ArgumentException("NSF");
        }
    }
}