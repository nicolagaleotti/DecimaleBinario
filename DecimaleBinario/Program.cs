using System;
using LibreriaConversioni;

namespace DecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Conversione in Binario/Ottale/Esadecimale ?");
            string risposta = Console.ReadLine();
        }
    }
}
