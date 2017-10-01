using System;

namespace TestCalcolatrice
{
    class Program
    {
        public double InputDouble()
        {
            if (double.TryParse(Console.ReadLine(), out double inputD))
            {
                Console.WriteLine("Numero acquisito.\n");
            }
            else
            {
                Console.WriteLine("Errore nell'aquisizione. IL valore verrà settato a 0\n");
                inputD = 0;
            }
            return inputD;
        }




        static void Main(string[] args)
        {
            Program prog = new Program();
           

            double a = 0, b = 0;
            double ris = 0;
            
            Console.WriteLine("Primo numero");
            a = prog.InputDouble();
            Console.WriteLine("Secondo numero");
            b = prog.InputDouble();
            Console.WriteLine("Scegli l'operazione da effettuare");
            Console.WriteLine("1)Somma");
            Console.WriteLine("2)Differenza");
            if (int.TryParse(Console.ReadLine(), out int sel))
            {
                switch (sel)
                {
                    case 1:
                        ris = a + b;
                        Console.WriteLine("Risultato: " + ris);
                        break;
                    case 2:
                        ris = a - b;
                        Console.WriteLine("Risultato: " + ris);
                        break;
                    default:
                        Console.WriteLine("Selezione non valida");
                        break;
                }
                
                Console.WriteLine("Premere un tasto qualsiasi per terminare");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Si è verificato un errore. L'applicazione è terminata.");
                Console.WriteLine("Premere un tasto qualsiasi per terminare");
                Console.ReadLine();
            }
            

            
           
        }

        

    }
}
