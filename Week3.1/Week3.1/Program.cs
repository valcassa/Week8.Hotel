using System;

namespace Week3._1
{
    class Program
    {
        public static Main(string[] args)
        {
            double ImportoVincolato;
            bool ConversioneAvvenuta;
            int AnniVincolo;

            int AnniInteresse;
            int Interesse = 3 %;


            do
            {
                Console.WriteLine("Inserisci importo in euro:");
                ConversioneAvvenuta = double.TryParse(Console.ReadLine(ImportoVincolato), out ImportoVincolato);
            }
            while (!ConversioneAvvenuta || (ImportoVincolato <0));



            do
            {
                Console.WriteLine("Inserisci gli anni del Vincolo");
                ConversioneAvvenuta = int.TryParse(Console.ReadLine(), out AnniVincolo));
            } while (!ConversioneAvvenuta || (AnniVincolo < 0));

            double ImportoFinaleIterazione = CalcolaInteressiIterazione(AnniVincolo, ImportoVincolato, AnniInteresse);
             double ImportoFinaleRicorsione = CalcolaInteressiRicorsione(AnniVincolo, ImportoVincolato, AnniInteresse);


            if (AnniInteresse <= 3; ImportoVincolato + (ImportoVincolato * 3 / 100); ImportoVincolato + 300; ImportoVincolato++){
                return (ImportoVincolato);
            }





            if (AnniInteresse <= 3;  ImportoVincolato = ImportoVincolato - Interesse; ImportoVincolato + 300;
               
            {
                ;
            }
        }
    }
}
