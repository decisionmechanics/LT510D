using Banking;

BankAccount a1 = new BankAccount(503, 121.55m);
BankAccount a2 = new BankAccount(604, 121.32m);
// BankAccount a3 = new BankAccount(); // Will not compile

a1.Deposit(100.00m);
a2.Deposit(500.00m);

a2.Withdraw(50.00m);
a1.Deposit(50.00m);

