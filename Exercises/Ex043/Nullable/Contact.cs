namespace Nullable
{
    using System;
    using System.Linq;

    public class Contact
    {
        private string _lastName;

        public Contact(string lastName)
        {
            _lastName = lastName ?? throw new Exception("Last name is required");
        }

        public string LastName
        {
            get => _lastName;

            set => _lastName = value ?? throw new Exception("Last name is required");
        }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public void Reset(string lastName)
        {
            LastName = lastName ?? throw new Exception("Last name is required");
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
