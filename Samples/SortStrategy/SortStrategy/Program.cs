namespace SortStrategy
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Jasper", "Pete", "Sean", "Al", "Michael", "Xavier", "Amy", "Rumplestiltskin", "Sally", "Gracie",
                "Kathleen"
            };

            //names.Sort();						// Sort IComparable<string> objects
            //names.Sort(new LengthSorter());	// Sort by IComparer<string> strategy
            //names.Sort(ByLength);				// Sort by delegate strategy
            //names.Sort((x,y) => x.Length - y.Length); // Sort by lambda (same as delegate)
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.ReadLine();
        }

        private static int ByLength(string x, string y)
        {
            return x.Length - y.Length;
        }
    }

    class LengthSorter : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }
}
