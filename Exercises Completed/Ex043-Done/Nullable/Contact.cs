namespace Nullable
{
    using System;
    using System.Linq;

    public class Contact
    {
        public Contact(string lastName)
        {
            LastName = lastName;
        }

        public string LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Email { get; set; }

        public void Reset(string lastName)
        {
            LastName = lastName;
            FirstName = null;
            Email = null;
        }

        public void SetFullName(string fullName)
        {
            string[] names = fullName.Split(' ');

            if (names.Length < 2)
            {
                throw new Exception("Must supply a first and a last name");
            }

            FirstName = names.First();
            LastName = names.Last();
        }
    }
}
