using System;

namespace E_commerce
{
    class Program
    {

        Un utente può:
vedere tutti i prodotti per categoria
vedere tutti i prodotti per categoria con prezzo <= al prezzo inserito
vedere gli alimenti con una data di scadenta >= alla data inserita
vedere l'abbigliamento con taglia uguale alla taglia inserita
vedere gli elettrodomestici della marca inserita.





        static void Main(string[] args)
        {
            AlimentariList al = new AlimentariList();
            ElettronicaList el = new ElettronicaList();
            AbbigliamentoList abl = new AbbigliamentoList();


            Console.WriteLine("*** Programma eseguito ***");
            Console.WriteLine("Scegli tra le seguenti opzioni:");
            Console.WriteLine("1- Visualizza tutti i prodotti per categoria");
            Console.WriteLine("2- Visualizza i prodotti per categoria meno costosi");
            Console.WriteLine("3- Visualizza i prodotti alimentari con scadenza inoltrata");
            Console.WriteLine("4- Visualizza i prodotti d'abbigliamento per taglia");
            Console.WriteLine("5- Visualizza i prodotti elettronici per marca");
            Console.WriteLine("6- Esci");


            while (true)
            {
                int scelta;
                Console.WriteLine("Cosa scegli?");

                while (int.TryParse(Console.ReadLine(), out scelta)) ;



                switch (scelta)
                {
                    case 1:
                        List<Prodotti> Prodotti.ViewCategory();

                        break;
                    case 2:
                        List<AudioLibri> libriAudio = lar.Fetch();
                        break;
                    case 3:

                        List<ListaLibri> libri = lr.Fetch();
                        break;
                    case 4:
                        ListaLibriCarta.AddNew();
                        break;

                    case 5:
                        ListaLibriCarta.ModificaQuantita();
                        break;

                    case 6:
                        ListaLibriAudio.AddNewAudio();
                        break;

                }
            }
        }

    }