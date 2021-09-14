using System;

namespace Prove
{
    class Prova
    {
        double k = 10.5;
        string TipoGioiello;


        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci tipo Gioiello.");
            string TipoGioiello;
            TipoGioiello = Console.ReadLine();
            Console.WriteLine($"Il tipo di Gioiello è {TipoGioiello}");
            Console.WriteLine("Grazie per aver partecipato!");
        }
    }
}
