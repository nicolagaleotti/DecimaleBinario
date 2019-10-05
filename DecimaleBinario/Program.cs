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
            
            try
            {
                int risultato;
                Console.WriteLine("Conversione in Binario/Ottale/Esadecimale ?");
                string risposta = Console.ReadLine();
                if (risposta == "Binario")
                {
                    risultato = Conversioni.Binario(n);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
