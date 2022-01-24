namespace Nullable
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            var contact = new Contact(string.Empty);

            contact.SetFullName("Jane Doe");

            string lastName = contact.LastName.ToUpper();
            string firstName = contact.FirstName?.ToUpper();

            Console.WriteLine($"{lastName}, {firstName}");

            contact.Reset(string.Empty);
        }
    }
}
