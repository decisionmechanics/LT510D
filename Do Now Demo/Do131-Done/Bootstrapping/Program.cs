using System.Runtime.InteropServices;

var data = Enumerable.Range(1, 10).ToArray();

BootstrapMedians(data, (UIntPtr)data.Length, 10000, out double mu, out double sigma);

Console.WriteLine($"Median sampling distribution: mean = {mu:N2}, standard deviation = {sigma:N2}");

[DllImport("bootstrapper.dll", EntryPoint  = "bootstrap_medians", CharSet = CharSet.Auto)] 
static extern void BootstrapMedians([In] int[] data, UIntPtr size, uint iterations, out double mu, out double sigma);