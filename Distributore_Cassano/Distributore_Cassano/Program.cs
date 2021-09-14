using System;

namespace Distributore_Cassano
{
    class Program
    {
        static void Main(string[] args)
        {
            int Patatine = 1;
            int Taralli = 2;
            int Succo = 3;

            do
            {
 
                Console.WriteLine("Premi il codice della merendina");

                int scelta = int.Parse(Console.ReadLine());
                 int result;
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserisci denaro.");
                        if (Patatine == 0.8)
                        {
                            Console.WriteLine("Erogazione snack");
                            result = Patatine;
                        }
                        else
                        {
                            Console.WriteLine("Denaro non sufficiente.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Inserisci denaro.");
                        if (Taralli == 0.4)
                        {
                            Console.WriteLine("Erogazione snack");
                            result = Taralli;
                        }
                        else
                        {
                            Console.WriteLine("Denaro non sufficiente.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserisci denaro.");
                        if (Succo == 0.8)
                        {
                            Console.WriteLine("Erogazione snack");
                            result = Succo;
                        }
                        else
                        {
                            Console.WriteLine("Denaro non sufficiente.");
                        }
                        break;
                   
                    default:
                        Console.WriteLine("Errore numero");
                        break;
                }
            }
            while (Console.WriteLine("Erogazione resto"));
 
        }


    }
}
