namespace SwitchStatement
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int cpu = GetProcessorType();

            switch (cpu)
            {
                case 8086:
                    Console.WriteLine("Sell it on ebay?");
                    break;
                case 386:
                case 486:
                    Console.WriteLine("Too old for Windows XP");
                    break;
                default:
                    RunWindowsXP();
                    break;
            }
        }

        static Random rand = new Random();

        static int GetProcessorType()
        {
            int[] cpus = { 8086, 386, 486, 586 };
            return cpus[rand.Next(0, cpus.Length)];
        }

        static void RunWindowsXP()
        {
            Console.WriteLine("XP Running...");
        }
    }
}