namespace AssignmentAndEquality
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int i = 5;
            int j;
            j = i;
            if (j == i) Console.WriteLine("i and j are equal");
            else Console.WriteLine("i and j are not equal");

            var a1 = new Account();
            Account a2;
            a2 = a1;
            if (a1 == a2) Console.WriteLine("a1 and a2 are equal");
            else Console.WriteLine("a1 and a2 are not equal");

            var a3 = new Account(125);
            var a4 = new Account(125);

            if (a3 == a4) Console.WriteLine("a3 and a4 are equal");
            else Console.WriteLine("a3 and a4 are not equal");
		}
    }

    public class Account
    {
        public int number;
        public Account() { number = 0; }
        public Account(int number) { this.number = number; }
    }
}
