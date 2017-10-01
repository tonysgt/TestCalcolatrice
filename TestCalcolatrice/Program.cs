using System;

namespace TestCalcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sel = 0;
            double a = 0, b = 0;
            double ris = 0;

            Console.WriteLine("Primo numero");
            Console.WriteLine("Secondo numero");
            Console.WriteLine("Scegli l'operazione da effettuare");
            Console.WriteLine("1)Somma");
            Console.WriteLine("2)Differenza");
            switch (sel)
            {
                case 1:
                    ris = a + b;
                    break;
                default:
                    Console.WriteLine("Selezione non valida");
                    break;
                

            }
        }
    }
}
