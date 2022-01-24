namespace ForeachLoop
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            var p = new Program();

            string[] employees = { "Fred Flintstone", "Judy Jetson", "Sponge Bob", "Yogi Bear" };
            
            p.RunPayroll(employees);
        }

        private void RunPayroll(string[] people)
        {
            foreach (string person in people)
            {
                Console.WriteLine("Payroll running for " + person);
                ComputePayroll(person);
            }
        }

        private void ComputePayroll(string p) { }
	}
}