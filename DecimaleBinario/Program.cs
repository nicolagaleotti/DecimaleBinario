using System;

namespace DecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Il numero binario è {Convert.ToString(n, 2)}.");
            Console.ReadLine();
        }
    }
}
