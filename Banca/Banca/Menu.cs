using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Menu
    {
        internal static void Start()
        { Console.WriteLine("Welcome to your Bank Account.");

            char scelta;

            //•Creare un nuovo conto (non esistente)


            do
            {
                Console.WriteLine("1. Crea un nuovo conto");
                Console.WriteLine("2. Preleva dal tuo conto");
                Console.WriteLine("3. Versa sul tuo conto");
                Console.WriteLine("4. Visualizza saldo");
                Console.WriteLine("5. Elimina conto");

                scelta = Console.ReadKey().KeyChar;


                switch (scelta)
                {
                    case '1':
                         AddNewAcc();
                        Console.WriteLine();
                        break;
                    case '2':
                         PrelievoAcc();
                        Console.WriteLine();
                        break;
                    case '3':
                         VersaAcc();
                        Console.WriteLine();
                        break;

                    case '4':
                        BancaConto.ShowAcc();
                        Console.WriteLine();
                        break;

                    case '5':
                        DelAcc();
                        Console.WriteLine();
                        break;
                    case '6':
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile");
                        break;
                }
            }
            while (!(scelta == '6'));
        }
    }
    // Nuovo Account
    internal static void AddNewAcc()
    {
        string user;


        do
        {
            Console.Write("Inserisci nome: ");
            user = Console.ReadLine();


        }
        while (iban.Length != 20);

        // •Prelevare da un conto


        internal static void PrelievoAcc()
        {
            decimal prelievo;

            {
                do
                {
                    Console.Write("Inserisci importo da prelevare: ");
                    prelievo = Console.ReadLine();

                    if (prelievo <= saldo)
                    {
                        return prelievo = saldo - prelievo;
                        Console.WriteLine($"Hai prelevato {prelievo}");
                    }
                    else "Saldo non sufficiente";

                }
            }
        }
        //•Versare su un conto

        internal static void VersaAcc() { }

        decimal saldo, versamento;


            do
        { Console.Write("Inserisci importo da versare:")
                    versamento == Console.ReadLine();
            return saldo == saldo + versamento;
        }
            return null;
        }
        //•Visualizzare il saldo di un conto

        internal static void ShowAcc(Conto BancaConto)
        {
            Console.Write($"Il saldo disponibile è {saldo}")
    } 

    internal static void DelAcc(iban accToDelete)
    {
        iban.Remove(accToDelete);
    }


}
}
