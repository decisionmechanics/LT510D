namespace Substring
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string productID = "ALA1554-D";
            string revision = productID.Substring(8, 1);

            Console.WriteLine("Revision = " + revision);
        }
    }
}