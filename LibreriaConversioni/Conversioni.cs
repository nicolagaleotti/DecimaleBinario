using System;

namespace LibreriaConversioni
{
    public class Conversioni
    {
        public static int Binario(int a)
        {
            Console.WriteLine(Convert.ToString(a, 2));
            return a;
        }
        
        public static int Ottale(int a)
        {
            Console.WriteLine(Convert.ToString(a, 8));
            return a;
        }

        public static int Esadecimale(int a)
        {
            Console.WriteLine(Convert.ToString(a, 16));
            return a;
        }
    }
}
